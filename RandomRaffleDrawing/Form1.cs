using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomRaffleDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnReset_Click(null, null);
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            int jnkInt = 0,
                totalTickets = 0;
            bool readText = int.TryParse(txtTickets.Text, out jnkInt);

            if (readText)
            {
                totalTickets = int.Parse(txtTickets.Text);
                GenerateWinners(totalTickets);
                LabelVisibility(true);
            }
            else
            {
                MessageBox.Show("Please enter numbers only.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTickets.Text = "";
                txtTickets.Focus();
            }
        }

        private void GenerateWinners(int totalTickets)
        {
            lblResult1.Text = RandomNumberGenerator(totalTickets);
            lblResult2.Text = RandomNumberGenerator(totalTickets);
            lblResult3.Text = RandomNumberGenerator(totalTickets);
            lblResult4.Text = RandomNumberGenerator(totalTickets);
            lblResult5.Text = RandomNumberGenerator(totalTickets);
            lblResult6.Text = RandomNumberGenerator(totalTickets);
        }

        private void CheckResults(int totalTickets)
        {
            if (lblResult2.Text == lblResult1.Text)
                lblResult2.Text = RandomNumberGenerator(totalTickets);

            if (lblResult3.Text == lblResult2.Text || lblResult3.Text == lblResult1.Text)
                lblResult3.Text = RandomNumberGenerator(totalTickets);

            if (lblResult4.Text == lblResult3.Text || lblResult4.Text == lblResult2.Text || lblResult4.Text == lblResult1.Text)
                lblResult4.Text = RandomNumberGenerator(totalTickets);

            if (lblResult5.Text == lblResult4.Text || lblResult5.Text == lblResult3.Text || lblResult5.Text == lblResult2.Text || lblResult5.Text == lblResult1.Text)
                lblResult5.Text = RandomNumberGenerator(totalTickets);

            if (lblResult6.Text == lblResult5.Text || lblResult6.Text == lblResult4.Text || lblResult6.Text == lblResult3.Text || lblResult6.Text == lblResult2.Text || lblResult6.Text == lblResult1.Text)
                lblResult6.Text = RandomNumberGenerator(totalTickets);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LabelVisibility(false);
            lblResult1.Text = "0";
            lblResult2.Text = "0";
            lblResult3.Text = "0";
            lblResult4.Text = "0";
            lblResult5.Text = "0";
            lblResult6.Text = "0";
        }

        private string RandomNumberGenerator(int maxTickets)
        {
            Random randomNumber = new Random();

            System.Threading.Thread.Sleep(30);
            string rand = randomNumber.Next(1, maxTickets).ToString();

            return rand;
        }

        private void LabelVisibility(bool visible)
        {
            lblOne.Visible = visible;
            lblTwo.Visible = visible;
            lblThree.Visible = visible;
            lblFour.Visible = visible;
            lblFive.Visible = visible;
            lblSix.Visible = visible;

            lblResult1.Visible = visible;
            lblResult2.Visible = visible;
            lblResult3.Visible = visible;
            lblResult4.Visible = visible;
            lblResult5.Visible = visible;
            lblResult6.Visible = visible;
        }
    }
}
