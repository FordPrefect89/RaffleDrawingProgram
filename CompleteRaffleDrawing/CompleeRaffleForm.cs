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
                    startValue = Convert.ToInt32(lblNumTixPurchased.Text),
                    endValue = CalculateEndValue(bonusTix);

                //MessageBox.Show(String.Concat("Bonus Tickets ", bonusTix, "\nNew Start Value ", startValue, "\nNew End Value ", endValue));

                dbWrite.InsertBuyer(txtBuyerName.Text, Convert.ToInt32(txtBoughtTix.Value), bonusTix, startValue, endValue);
                lblNumTixPurchased.Text = dbWrite.GetTicketAmount().ToString();
            }
        }

        private int CalculateBonusTickets()
        {
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
            int tickets = Convert.ToInt32(txtBoughtTix.Value),
                currentCount = Convert.ToInt32(lblNumTixPurchased.Text),
                newEndNumber = currentCount + tickets + bonusTickets;
            return newEndNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBuyerName.Text = string.Empty;
            txtBoughtTix.Value = 0;
            txtBuyerName.Focus();
        }

        private void btnRunRaffle_Click(object sender, EventArgs e)
        {
            
        }

        private bool BGoodCheck()
        {
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
    }
}
