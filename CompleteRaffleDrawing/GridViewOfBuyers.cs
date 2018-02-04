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
            dvgTicketQuantityInfo_CellContentClick(null, null);
        }

        private void dvgTicketQuantityInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dbActions jnk = new dbActions();
            string query = @"SELECT BuyerName, TicketsBought, BonusTickets from dbo.Ticketbuyer WHERE BuyerName <> 'blank' ORDER BY BuyerName, TicketsBought;";
            DataTable dt = jnk.ReturnQueryDataTable(query);
            dgvTicketQuantityInfo.DataSource = dt;
            
        }
    }
}
