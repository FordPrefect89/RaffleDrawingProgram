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
        private string ReturnConnectionString()
        {
            string con = "Server=rthowell89.db.13580181.hostedresource.com;User Id=rthowell89;Password=Mag#tar5;";
            return con;
        }

        private void DatabaseWrite(SqlCommand cmd, string query)
        {

        }

        public void InsertBuyer(string buyerName, int boughtTickets, int bonus, int startValue, int endValue)
        {
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

        public int GetTicketAmount()
        {
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
    }
}
