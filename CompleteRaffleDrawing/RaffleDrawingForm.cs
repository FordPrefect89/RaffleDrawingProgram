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
            PlaceWinnerNames(winningNumbers);
            PlaceD6Roll();
            GenerateBonusPrizeWinners();
        }

        private void PlaceWinnerNames(int[] winNumber)
        {
            dbActions dBase = new dbActions();
            lblWinner1.Text = dBase.GetWinnerName(winNumber[0]);
            lblWinner2.Text = dBase.GetWinnerName(winNumber[1]);
            lblWinner3.Text = dBase.GetWinnerName(winNumber[2]);
            lblWinner4.Text = dBase.GetWinnerName(winNumber[3]);
            lblWinner5.Text = dBase.GetWinnerName(winNumber[4]);
            lblWinner6.Text = dBase.GetWinnerName(winNumber[5]);
            lblWinner7.Text = dBase.GetWinnerName(winNumber[6]);
            lblWinner8.Text = dBase.GetWinnerName(winNumber[7]);
        }

        private void GenerateBonusPrizeWinners()
        {
            dbActions db = new dbActions();
            string[] winners = WinnersArray();
            List<string> nonWinners = db.ReturnDistinctBuyers(winners);

            lblBonus1.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus2.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus3.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus4.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus5.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus6.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus7.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
            lblBonus8.Text = nonWinners[BonusRandomNumberGenerator(nonWinners)];
        }

        private int BonusRandomNumberGenerator(List<string> nonWinners)
        {
            Random randomNumber = new Random(),
                   randomTimer = new Random();

            System.Threading.Thread.Sleep(randomTimer.Next(1, 500));
            return randomNumber.Next(1, nonWinners.Count());
        }

        private void PlaceD6Roll()
        {
            lbld6Roll1.Text = D6RollGenerator();
            lbld6Roll2.Text = D6RollGenerator();
            lbld6Roll3.Text = D6RollGenerator();
            lbld6Roll4.Text = D6RollGenerator();
            lbld6Roll5.Text = D6RollGenerator();
            lbld6Roll6.Text = D6RollGenerator();
            lbld6Roll7.Text = D6RollGenerator();
            lbld6Roll8.Text = D6RollGenerator();
        }

        private string[] WinnersArray()
        {
            string[] winners = {
                                   lblWinner1.Text, lblWinner2.Text, lblWinner3.Text, lblWinner4.Text,
                                   lblWinner5.Text, lblWinner6.Text, lblWinner7.Text, lblWinner8.Text
                               };
            return winners;
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
            Random randomNumber = new Random(),
                randomTimer = new Random();

            // Sleep thread a random time to attempt to randomize thread
            System.Threading.Thread.Sleep(randomTimer.Next(1, 500));
            // Get random number from total number of tickets sold
            int  rand = randomNumber.Next(1, ticketTotal);

            // Check to see if random number is already in array.  If it is, call method again.
            if (winnerArray.Contains(rand))
            {
                RandomNumberGenerator(ticketTotal, winnerArray);
            }

            return rand;
        }

        private string D6RollGenerator()
        {
            Random d6 = new Random(),
                timerSeed = new Random();

            System.Threading.Thread.Sleep(timerSeed.Next(1, 500));
            string d6Roll = d6.Next(1, 6).ToString();
            return d6Roll;
        }
    }
}
