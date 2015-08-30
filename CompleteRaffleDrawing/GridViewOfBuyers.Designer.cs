namespace CompleteRaffleDrawing
{
    partial class GridViewOfBuyers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewOfBuyers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketBuyerInfo = new CompleteRaffleDrawing.TicketBuyerInfo();
            this.ticketBuyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketBuyerTableAdapter = new CompleteRaffleDrawing.TicketBuyerInfoTableAdapters.TicketBuyerTableAdapter();
            this.buyerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBoughtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusTicketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBuyerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBuyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerNameDataGridViewTextBoxColumn,
            this.ticketsBoughtDataGridViewTextBoxColumn,
            this.bonusTicketsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBuyerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // ticketBuyerInfo
            // 
            this.ticketBuyerInfo.DataSetName = "TicketBuyerInfo";
            this.ticketBuyerInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBuyerBindingSource
            // 
            this.ticketBuyerBindingSource.DataMember = "TicketBuyer";
            this.ticketBuyerBindingSource.DataSource = this.ticketBuyerInfo;
            // 
            // ticketBuyerTableAdapter
            // 
            this.ticketBuyerTableAdapter.ClearBeforeFill = true;
            // 
            // buyerNameDataGridViewTextBoxColumn
            // 
            this.buyerNameDataGridViewTextBoxColumn.DataPropertyName = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.HeaderText = "BuyerName";
            this.buyerNameDataGridViewTextBoxColumn.Name = "buyerNameDataGridViewTextBoxColumn";
            // 
            // ticketsBoughtDataGridViewTextBoxColumn
            // 
            this.ticketsBoughtDataGridViewTextBoxColumn.DataPropertyName = "TicketsBought";
            this.ticketsBoughtDataGridViewTextBoxColumn.HeaderText = "TicketsBought";
            this.ticketsBoughtDataGridViewTextBoxColumn.Name = "ticketsBoughtDataGridViewTextBoxColumn";
            // 
            // bonusTicketsDataGridViewTextBoxColumn
            // 
            this.bonusTicketsDataGridViewTextBoxColumn.DataPropertyName = "BonusTickets";
            this.bonusTicketsDataGridViewTextBoxColumn.HeaderText = "BonusTickets";
            this.bonusTicketsDataGridViewTextBoxColumn.Name = "bonusTicketsDataGridViewTextBoxColumn";
            // 
            // GridViewOfBuyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 262);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GridViewOfBuyers";
            this.Text = "Buyer Data";
            this.Load += new System.EventHandler(this.GridViewOfBuyers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBuyerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBuyerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketBuyerInfo ticketBuyerInfo;
        private System.Windows.Forms.BindingSource ticketBuyerBindingSource;
        private TicketBuyerInfoTableAdapters.TicketBuyerTableAdapter ticketBuyerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsBoughtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusTicketsDataGridViewTextBoxColumn;
    }
}