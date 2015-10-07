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
            //dbActions dBase = new dbActions();
            GenerateSingleWinners winners = new GenerateSingleWinners();
            List<string> winnerList = winners.ReturnWinners();
            lblWinner1.Text = winnerList[0];
            lblWinner2.Text = winnerList[1];
            lblWinner3.Text = winnerList[2];
            lblWinner4.Text = winnerList[3];
            lblWinner5.Text = winnerList[4];
            lblWinner6.Text = winnerList[5];
            lblWinner7.Text = winnerList[6];
            lblWinner8.Text = winnerList[7];
        }

        private void GenerateBonusPrizeWinners()
        {
            /*
             * Populates the bonus winner text fields.  Winners chosen from the remainder 
             * of names in the database after removing the main winners from the List<string>.
             * This also removes the "blank" string from the list so that will not come up as 
             * a winner.
             */
            dbActions db = new dbActions();
            string[] winners = WinnersArray();
            List<string> nonWinners = db.ReturnDistinctBuyers(winners);
            nonWinners.Remove("blank");         // Remove the blank string from the list.  Added to prevent database errors after clearing database.
            List<string> selectedBonusWinners = BonusListWinners(nonWinners);


            lblBonus1.Text = selectedBonusWinners[0];
            lblBonus2.Text = selectedBonusWinners[1];
            lblBonus3.Text = selectedBonusWinners[2];
            lblBonus4.Text = selectedBonusWinners[3];
            lblBonus5.Text = selectedBonusWinners[4];
            lblBonus6.Text = selectedBonusWinners[5];
            lblBonus7.Text = selectedBonusWinners[6];
            lblBonus8.Text = selectedBonusWinners[7];

            
        }

        private List<string> BonusListWinners(List<string> nonWinners)
        {
            /*
             * This generates the list of bonus winners from the remaining names 
             * in the database that HAVE NOT been drawn as main winners.
             */
            List<string> bonusWinners = new List<string>();

            for (int cnt = 0; cnt <= nonWinners.Count() - 1; cnt++)
            {
                string tmpName = DrawWinnerName(nonWinners);

                if (bonusWinners.Contains(tmpName))
                {
                    DrawWinnerName(nonWinners);
                }
                else
                {
                    bonusWinners.Add(tmpName);
                }
            }

            return bonusWinners;
        }

        private string DrawWinnerName(List<string> tmpList)
        {
            string tmpName = string.Empty;
            Random randomNumber = new Random(),
                   randomTimer = new Random();
            System.Threading.Thread.Sleep(randomTimer.Next(1, 500));
            return tmpName = tmpList[randomNumber.Next(1, tmpList.Count())];
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
            int[] winnerArray = {
                                    0, 0, 0, 0, 0, 0, 0, 0
                                };

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
