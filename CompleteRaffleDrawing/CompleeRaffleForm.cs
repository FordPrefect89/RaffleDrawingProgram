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
            CheckXMLFileExists();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool bGood = BGoodCheck();
            if (bGood)
                WriteTicketPurchase(string.Concat(ReturnFilePath(), @"RaffleData.xml"));
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

        private void CheckXMLFileExists()
        {
            /*
             * Checks to see if there is a RaffleData.xml file in the 
             * user home/Documents directory.  If it does not exist, creates
             * the file.
             */
            string filePath = string.Concat(ReturnFilePath(), @"RaffleData.xml");

            if (File.Exists(filePath) == false)
            {
                WriteBlankXML(filePath);
            }
        }

        private void WriteBlankXML(string filePath)
        {
            /*
             * This is the generic XML file with just the ticket element
             * and the sold/bouns tickets listed.
             * 
             * Elements for people who have bought tickets will be added on 
             * under the tickets element.
             */
            new XDocument(
                new XElement("raffle",
                    new XElement("tickets",
                        new XElement("sold", "0"),
                        new XElement("bouns", "0")
                    )
                )
            )
            .Save(filePath);
        }

        private void WriteTicketPurchase(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            XmlElement ticketsale = xmlDoc.CreateElement("ticketsale");
            XmlElement buyer = xmlDoc.CreateElement("buyer");
            XmlElement tickets = xmlDoc.CreateElement("bought");
            XmlElement bouns = xmlDoc.CreateElement("bonus");
            XmlText txtBuyer = xmlDoc.CreateTextNode(txtBuyerName.Text);
            XmlText txtTixBought = xmlDoc.CreateTextNode(txtBoughtTix.Value.ToString());

            xmlDoc.DocumentElement.AppendChild(ticketsale);
            xmlDoc.DocumentElement.LastChild.AppendChild(buyer);
            xmlDoc.DocumentElement.LastChild.AppendChild(txtBuyer);
            xmlDoc.DocumentElement.LastChild.AppendChild(tickets);
            xmlDoc.DocumentElement.LastChild.AppendChild(txtTixBought);
            xmlDoc.Save(filePath);
        }

        private string ReturnFilePath()
        {
            // Returns a string for the filepath to the My Documents directory
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return string.Concat(filePath, @"\");
        }
    }
}
