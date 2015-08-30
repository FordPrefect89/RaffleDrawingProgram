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
    public partial class GridViewOfBuyers : Form
    {
        public GridViewOfBuyers()
        {
            InitializeComponent();
        }

        private void GridViewOfBuyers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketBuyerInfo.TicketBuyer' table. You can move, or remove it, as needed.
            this.ticketBuyerTableAdapter.Fill(this.ticketBuyerInfo.TicketBuyer);

        }
    }
}
