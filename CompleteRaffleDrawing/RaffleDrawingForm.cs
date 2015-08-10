using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteRaffleDrawing
{
    public partial class frmRaffleDrawing : Form
    {
        public frmRaffleDrawing()
        {
            InitializeComponent();
            dbActions dBase = new dbActions();
            int ticketTotal = dBase.GetTicketAmount();
            int[] winningNumbers = ReturnDrawingNumber(ticketTotal);
            int[] bonusPrizes = ReturnDrawingNumber(ticketTotal);
        }

        private int[] ReturnDrawingNumber(int ticketTotal)
        {
            int[] winnerArray = { 0, 0, 0, 0, 0, 0, 0, 0};

            for (int count = 0; count <= winnerArray.Length - 1; count++)
            {
                int winner = RandomNumberGenerator(ticketTotal, winnerArray);
                winnerArray[count] = winner;
            }

            return winnerArray;
        }

        private int RandomNumberGenerator(int ticketTotal, int[] winnerArray)
        {
            Random randomNumber = new Random();

            System.Threading.Thread.Sleep(30);
            string rand = randomNumber.Next(1, ticketTotal).ToString();

            if (winnerArray.Contains(Convert.ToInt32(rand)))
            {
                RandomNumberGenerator(ticketTotal, winnerArray);
            }

            return Convert.ToInt32(rand);
        }
    }
}
