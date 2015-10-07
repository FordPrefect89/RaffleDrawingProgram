using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteRaffleDrawing
{
    class GenerateSingleWinners
    {
        public List<string> ReturnWinners()
        {
            List<string> tmpNames = new List<string>();
            DataTable dt = GetDataFromDatabase();
            int ticketTotal = GetTotalTickets();
            string jnkName = ReturnWinnerName(dt, ticketTotal);
            tmpNames.Add(jnkName);

            //for (int count = 0; count < 8; count++ )
            while (tmpNames.Count <= 7)
            {
                jnkName = ReturnWinnerName(dt, ticketTotal);
                if (tmpNames.Contains(jnkName))
                {
                    jnkName = ReturnWinnerName(dt, ticketTotal);
                }
                else
                {
                    tmpNames.Add(jnkName);
                }
            }
                return tmpNames;
        }

        private string ReturnWinnerName(DataTable dt, int ticketTotal)
        {
            int rndNumber = ReturnRandomNumber(ticketTotal);
            string tmpName = string.Empty;
            
            var winner = from jnkDt in dt.AsEnumerable()
                         where
                         jnkDt.Field<int>("TicketNumberEnd") >= rndNumber &&
                         jnkDt.Field<int>("TicketNumberStart") <= rndNumber
                         select new
                         {
                             name = jnkDt.Field<string>("BuyerName")
                         };
            foreach (var jnk in winner)
                tmpName = jnk.name.ToString();
            return tmpName;
        }

        private int ReturnRandomNumber(int ticketTotal)
        {
            Random randomNumber = new Random(),
                randomTimer = new Random();
            // Sleep thread a random time to attempt to randomize thread
            System.Threading.Thread.Sleep(randomTimer.Next(1, 500));
            // Get random number from total number of tickets sold
            int rand = randomNumber.Next(1, ticketTotal);
            return rand;
        }

        private DataTable GetDataFromDatabase()
        {
            string query = "SELECT * from dbo.TicketBuyer WHERE BuyerName NOT LIKE '%blank%';";
            dbActions dbase = new dbActions();
            DataTable dt = dbase.ReturnQueryDataTable(query);
            return dt;
        }

        private int GetTotalTickets()
        {
            dbActions dBase = new dbActions();
            return dBase.GetTicketAmount();
        }
    }
}
