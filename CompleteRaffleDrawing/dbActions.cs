﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteRaffleDrawing
{
    class dbActions
    {
        public void InsertBuyer(string buyerName, int boughtTickets, int bonus, int startValue, int endValue, int freeTickets)
        {
            /*
             * Writes the buyers name, number of tickets bought plus bonus tickets to the database.
             * Also writes the "starting" and "ending" number for the buyer of the ticket.
             */
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            string query = "INSERT INTO dbo.TicketBuyer VALUES (@name, @bought, @bonus, @start, @end, @freebies)";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = buyerName;
            cmd.Parameters.AddWithValue("@bought", SqlDbType.Int).Value = boughtTickets;
            cmd.Parameters.AddWithValue("@bonus", SqlDbType.Int).Value = bonus;
            cmd.Parameters.AddWithValue("@start", SqlDbType.Int).Value = startValue;
            cmd.Parameters.AddWithValue("@end", SqlDbType.Int).Value = endValue;
            cmd.Parameters.AddWithValue("@freebies", SqlDbType.Bit).Value = freeTickets;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Unable to connecto to database\nPlease check Internet connection\nand try again", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApplication();
            }
        }

        public void ClearTicketBuyerTable()
        {
            /*
             * This is to clear the database table after a raffle is run.  This also inserts
             * a blank row after clearing the database to be able to get the starting number of
             * zero when the program starts again.
             * 
             * TODO:
             *      Clean up code.  Too many calls to the same code could be put into seperate method.
             */
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            string clearTable = "DELETE FROM dbo.TicketBuyer",
                insertZero = "INSERT INTO dbo.TicketBuyer VALUES (@name, @bought, @bonus, @start, @end, @freebies)";

            var cmd = new SqlCommand(clearTable, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Unable to connecto to database\nPlease check Internet connection\nand try again", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApplication();
            }
            cmd = new SqlCommand(insertZero, con);

            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = "blank";
            cmd.Parameters.AddWithValue("@bought", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@bonus", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@start", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@end", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@freebies", SqlDbType.Int).Value = 0;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Unable to connecto to database\nPlease check Internet connection\nand try again", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApplication();
            }
        }

        public int GetTicketAmount()
        {
            /*
             * This calls the stored function to retrieve the int32
             * for the total number of tickets sold.  
             */
            string query = "SELECT dbo.GetTicketTotal();";
            int ticketCount = 0;

            SqlConnection con = new SqlConnection(ReturnConnectionString());
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                ticketCount = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to connecto to database\nPlease check Internet connection\nand try again", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApplication();
            }
            return ticketCount;
        }

        public static int GoldAmountForTicketSales()
        {
            /*
             * Returns the value of the total tickets sold.
             * SQL Funciton will get the total number of tickets sold and not the ones given
             * for free through the auction.
             * Results in more accurate gold total returned.
             */
            string query = "SELECT dbo.GetTotalSoldTickets()";
            const int TICKETCOST = 997;
            int soldGoldTotal = 0;

            SqlConnection con = new SqlConnection(ReturnConnectionString());
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                soldGoldTotal = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch
            {
                MessageBox.Show("Unable to connecto to database\nPlease check Internet connection\nand try again", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApplication();
               
            }

            return TICKETCOST * soldGoldTotal;
        }

        public List<string> ReturnDistinctBuyers(string[] winnerNames)
        {
            /*
             * This will return a list of buyer names that did NOT
             * win one of the eight prizes.  This list creates is
             * the basis for the bonus prize winners.
             */
            string query = "SELECT DISTINCT BuyerName from dbo.TicketBuyer";
            DataTable dt = ReturnQueryDataTable(query);
            return ReturnTotalDistinctBuyers(dt, winnerNames);
        }

        private static List<string> ReturnTotalDistinctBuyers(DataTable dt, string[] winnerNames)
        {
            /*
             * This takes the array of winners and removes them from the data table
             * then adds the name, if it is not a winner to the List<string> to return
             * it so that the bonus winners can then be drawn.
             */
            List<string> buyerNames = new List<string>();

            var jnkQuery = from jnkDt in dt.AsEnumerable()
                           select new
                           {
                               buyer = jnkDt.Field<string>("BuyerName")
                           };
            foreach (var jnkBuyer in jnkQuery)
            {
                if (Array.Exists(winnerNames, element => element == jnkBuyer.buyer) == false)
                {
                    buyerNames.Add(jnkBuyer.buyer);
                }
            }

            return buyerNames;
        }

        public DataTable ReturnQueryDataTable(string query)
        {
            /*
             * This method is called when a data table is needed to be returned from the database
             * All that needs to be passed to this is a T-SQL query string.  
             */
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                da.Fill(ds);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Unable to connecto to database\nPlease check Internet connection\nand try again", "Unable to Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApplication();
            }

            DataTable dt = ds.Tables[0];
            return dt;
        }

        private static void ExitApplication()
        {
            // Exits the program if unable to connect to the database after message box is displayed.
            System.Environment.Exit(0);
        }

        public static string ReturnConnectionString()
        {
            // Returns the connection to connect to the database.  PRIOR TO COMMIT TO GIT REMOVE PASSWORD!
            string con = "Server=rthowell89.db.13580181.hostedresource.com;User Id=rthowell89;Password=Mag#tar5;";
            return con;
        }
    }
}
