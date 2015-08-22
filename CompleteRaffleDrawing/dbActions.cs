using System;
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
        public void InsertBuyer(string buyerName, int boughtTickets, int bonus, int startValue, int endValue)
        {
            /*
             * Writes the buyers name, number of tickets bought plus bonus tickets to the database.
             * Also writes the "starting" and "ending" number for the buyer of the ticket.
             */
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            string query = "INSERT INTO dbo.TicketBuyer VALUES (@name, @bought, @bonus, @start, @end)";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = buyerName;
            cmd.Parameters.AddWithValue("@bought", SqlDbType.Int).Value = boughtTickets;
            cmd.Parameters.AddWithValue("@bonus", SqlDbType.Int).Value = bonus;
            cmd.Parameters.AddWithValue("@start", SqlDbType.Int).Value = startValue;
            cmd.Parameters.AddWithValue("@end", SqlDbType.Int).Value = endValue;

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
                insertZero = "INSERT INTO dbo.TicketBuyer VALUES (@name, @bought, @bonus, @start, @end)";

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
             * Called when the lblNumTixPurchased needs to be updated.
             * TODO:
             *      Create SQL function to return int versus calling
             *      ReturnTicketCount to get the max ticket number from
             *      the database.
             */
            string query = "SELECT MAX(TicketNumberEnd) AS Tickets FROM dbo.TicketBuyer";
            DataTable dt = ReturnQueryDataTable(query);
            return ReturnTicketCount(dt);
        }

        private static int ReturnTicketCount(DataTable dt)
        {
            /*
             * This is taking the place currently of an SQL funciton
             * to return an int from the database.  Once the SQL function
             * is working, this method will no longer be needed.
             */
            int returnCount = 0;
            var jnkQuery = from jnkDt in dt.AsEnumerable()
                           select new
                           {
                               count = jnkDt.Field<int>("Tickets")
                           };
            foreach (var ticketCount in jnkQuery)
            {
                returnCount = Convert.ToInt32(ticketCount.count);
            }

            return returnCount;
        }

        public string GetWinnerName(int winningNumber)
        {
            /*
             * TODO:
             *      Create SQL function to return string versus calling
             *      ReturnWinnerNameFromDataTable to get the max ticket
             *      number from the database.
             */
            string query = string.Concat("SELECT DISTINCT BuyerName FROM dbo.TicketBuyer WHERE ", winningNumber, " BETWEEN TicketNumberStart AND TicketNumberEnd;");
            DataTable dt = ReturnQueryDataTable(query);
            return ReturnWinnerNameFromDataTable(dt);
        }

        private static string ReturnWinnerNameFromDataTable(DataTable dt)
        {
            string winner = string.Empty;
            var jnkQuery = from jnkDt in dt.AsEnumerable()
                           select new
                           {
                               name = jnkDt.Field<string>("BuyerName")
                           };
            foreach (var jnkWinner in jnkQuery)
            {
                winner = jnkWinner.name;
            }

            return winner;
        }

        public int ReturnBuyerCount()
        {
            /*
             * TODO:
             *      Create SQL function to return int versus calling
             *      ReturnTotalBuyers to get the max ticket
             *      number from the database.
             */
            string query = "SELECT COUNT(DISTINCT BuyerName) AS Buyers FROM dbo.TicketBuyer";
            DataTable dt = ReturnQueryDataTable(query);
            return ReturnTotalBuyers(dt);
        }

        private static int ReturnTotalBuyers(DataTable dt)
        {
            int returnCount = 0;
            var jnkQuery = from jnkDt in dt.AsEnumerable()
                           select new
                           {
                               count = jnkDt.Field<int>("Buyers")
                           };
            foreach (var buyerCount in jnkQuery)
            {
                returnCount = Convert.ToInt32(buyerCount.count);
            }

            return returnCount;
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

        private DataTable ReturnQueryDataTable(string query)
        {
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                da.Fill(ds);
                con.Close();
            }
            catch (Exception e)
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

        private static string ReturnConnectionString()
        {
            // Returns the connection to connect to the database.
            string con = "Server=rthowell89.db.13580181.hostedresource.com;User Id=rthowell89;Password=Mag#tar5;";
            return con;
        }
    }
}
