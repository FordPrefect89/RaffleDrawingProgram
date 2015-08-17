using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CompleteRaffleDrawing
{
    public partial class frmInquisRaffleEntry : Form
    {
        public frmInquisRaffleEntry()
        {
            InitializeComponent();
            lblNumTix.Text = "Enter number of purchased tickets\r\n(No Bonus)";
            dbActions tmpCount = new dbActions();
            int ticketCount = tmpCount.GetTicketAmount();
            lblNumTixPurchased.Text = ticketCount.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool bGood = BGoodCheck();
            if (bGood)
            {
                dbActions dbWrite = new dbActions();
                int bonusTix = CalculateBonusTickets(),
                    startValue = Convert.ToInt32(lblNumTixPurchased.Text) + 1,
                    endValue = CalculateEndValue(bonusTix);

                dbWrite.InsertBuyer(txtBuyerName.Text, Convert.ToInt32(txtBoughtTix.Value), bonusTix, startValue, endValue);
                lblNumTixPurchased.Text = dbWrite.GetTicketAmount().ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Clears the form and sets the name to focus.
            txtBuyerName.Text = string.Empty;
            txtBoughtTix.Value = 0;
            txtBuyerName.Focus();
        }

        private void btnRunRaffle_Click(object sender, EventArgs e)
        {
            /*
             * TODO:
             *      This will implement the raffle drawing.  The raffle
             *      drawing will consist of the following:
             *      1) Drawing eight (8) winners, no duplicates. ** DONE **
             *      2) Get the winners name from the database based on the drawn number. ** DONE **
             *      3) Next to winners name, place a random number label 1-6, d6 simumlator ** DONE **
             *      4) Draw (8) number of "boobie" prize winners.  None of these winners can match the first eight (8).
             *      5) Once drawing is complete, give option to clear database(?).
             */
            var resultsForm = new frmRaffleDrawing();
            resultsForm.Show();
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbActions clearDB = new dbActions();

            if (MessageBox.Show("Clear data from database?\nThis will wipe the data from the database\nwith **NO** recovery possible.", "Clear Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearDB.ClearTicketBuyerTable();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {
            /*
             * Opens the main help dialog screen
             */
            var helpDialog = new Help();
            helpDialog.ShowDialog();
        }

        private bool BGoodCheck()
        {
            /* 
             * User input checker.  Verifies a buyer name is entered 
             * and a value of > 1 has been entered where the ticket
             * quantity is.
             * 
             * Calls CheckName and CheckTix to perform the verify.
             */
            bool bGood = false,
                bName = CheckName(),
                bTix = CheckTix();

            if (bName && bTix)
                bGood = true;
            
            return bGood;
        }

        private bool CheckName()
        {
            bool bGood = false;

            if (txtBuyerName.Text != string.Empty)
            {
                bGood = true;
            }
            else
            {
                MessageBox.Show("Please Enter buyer name", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuyerName.Focus();
                bGood = false;
            }
            return bGood;
        }

        private bool CheckTix()
        {
            bool bGood = false;
            
            if (txtBoughtTix.Value <= 0)
            {
                MessageBox.Show("Please enter a number greater than one (1)", "Invlaid Ticket Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bGood = false;
            }
            else
            {
                bGood = true;
            }
            
            return bGood;
        }

        private int CalculateBonusTickets()
        {
            /*
             * Calculates buyer bonus tickets based on buying a quantity of five (5)
             * or more.  When the division is done, rounds the number down to convert
             * the double to an int.
             */
            int tmpBonus = Convert.ToInt32(txtBoughtTix.Value);
            double bonusTix = 0;

            if (tmpBonus >= 5)
            {
                bonusTix = tmpBonus / 5;
            }

            int retBonusTix = Convert.ToInt32(Math.Floor(bonusTix));
            return retBonusTix;
        }

        private int CalculateEndValue(int bonusTickets)
        {
            /*
             * This takes the current number of tickets purchased and calculates a 
             * new end value to insert into the database for the current buyer.
             */
            int tickets = Convert.ToInt32(txtBoughtTix.Value),
                currentCount = Convert.ToInt32(lblNumTixPurchased.Text),
                newEndNumber = currentCount + tickets + bonusTickets;
            return newEndNumber;
        }
    }
}
