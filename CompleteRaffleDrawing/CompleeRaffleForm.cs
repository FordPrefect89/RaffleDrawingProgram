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
            lblNumTix.Text = "Enter number of purchased tickets\r\n(No Bonus Tickets)";
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
                dbWrite.InsertBuyer(txtBuyerName.Text, Convert.ToInt32(txtBoughtTix.Value), 0);
            }
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
            bool bGood = false;

            if (txtBuyerName.Text != string.Empty)
            {
                bGood = true;
            }
            else 
            {
                MessageBox.Show("Please Enter buyer name", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBuyerName.Focus();
            }

            if (txtBoughtTix.Value <= 0)
            {
                MessageBox.Show("Please enter a number greater than one (1)", "Invlaid Ticket Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bGood = true;
            }

            return bGood;
        }
    }
}
