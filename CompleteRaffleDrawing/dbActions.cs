using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            cmd.Parameters.AddWithValue("@name", SqlDbType.Text).Value = buyerName;
            cmd.Parameters.AddWithValue("@bought", SqlDbType.Int).Value = boughtTickets;
            cmd.Parameters.AddWithValue("@bonus", SqlDbType.Int).Value = bonus;
            cmd.Parameters.AddWithValue("@start", SqlDbType.Int).Value = startValue;
            cmd.Parameters.AddWithValue("@end", SqlDbType.Int).Value = endValue;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ClearTicketBuyerTable()
        {
            /*
             * This is to clear the database table after a raffle is run.  This also inserts
             * a blank row after clearing the database to be able to get the starting number of
             * zero when the program starts again.
             */
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            string clearTable = "DELETE FROM dbo.TicketBuyer",
                insertZero = "INSERT INTO dbo.TicketBuyer VALUES (@name, @bought, @bonus, @start, @end)";

            var cmd = new SqlCommand(clearTable, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SqlCommand(insertZero, con);

            cmd.Parameters.AddWithValue("@name", SqlDbType.Text).Value = "blank";
            cmd.Parameters.AddWithValue("@bought", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@bonus", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@start", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@end", SqlDbType.Int).Value = 0;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
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
            int ticketsSold = 0;
            SqlConnection con = new SqlConnection(ReturnConnectionString());
            
            string query = "SELECT MAX(TicketNumberEnd) AS Tickets FROM dbo.TicketBuyer";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            var cmd = new SqlCommand(query, con);

            con.Open();
            da.Fill(ds);
            con.Close();

            DataTable dt = ds.Tables[0];
            ticketsSold = ReturnTicketCount(dt);

            return ticketsSold;
        }

        private int ReturnTicketCount(DataTable dt)
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

        private string ReturnConnectionString()
        {
            // Returns the connection to connect to the database.
            string con = "Server=rthowell89.db.13580181.hostedresource.com;User Id=rthowell89;Password=Mag#tar5;";
            return con;
        }
    }
}
