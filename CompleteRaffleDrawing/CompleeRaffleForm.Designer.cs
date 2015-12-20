namespace CompleteRaffleDrawing
{
    partial class frmInquisRaffleEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInquisRaffleEntry));
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblNumTix = new System.Windows.Forms.Label();
            this.txtBoughtTix = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRunRaffle = new System.Windows.Forms.Button();
            this.lblTitleTixPur = new System.Windows.Forms.Label();
            this.lblNumTixPurchased = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.getCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGoldFromSales = new System.Windows.Forms.Label();
            this.chkFreeTickets = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoughtTix)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyerName.Location = new System.Drawing.Point(5, 53);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(197, 26);
            this.txtBuyerName.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(5, 32);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(197, 18);
            this.lblEnterName.TabIndex = 998;
            this.lblEnterName.Text = "Enter Name of Ticket Buyer";
            // 
            // lblNumTix
            // 
            this.lblNumTix.AutoSize = true;
            this.lblNumTix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTix.Location = new System.Drawing.Point(5, 91);
            this.lblNumTix.Name = "lblNumTix";
            this.lblNumTix.Size = new System.Drawing.Size(244, 18);
            this.lblNumTix.TabIndex = 999;
            this.lblNumTix.Text = "Enter number of purchased tickets";
            // 
            // txtBoughtTix
            // 
            this.txtBoughtTix.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoughtTix.Location = new System.Drawing.Point(5, 144);
            this.txtBoughtTix.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtBoughtTix.Name = "txtBoughtTix";
            this.txtBoughtTix.Size = new System.Drawing.Size(120, 32);
            this.txtBoughtTix.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(133, 121);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 55);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit Purchase";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(133, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 55);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel Purchase";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRunRaffle
            // 
            this.btnRunRaffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRunRaffle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunRaffle.Location = new System.Drawing.Point(5, 244);
            this.btnRunRaffle.Name = "btnRunRaffle";
            this.btnRunRaffle.Size = new System.Drawing.Size(244, 33);
            this.btnRunRaffle.TabIndex = 4;
            this.btnRunRaffle.Text = "Run Drawing";
            this.btnRunRaffle.UseVisualStyleBackColor = false;
            this.btnRunRaffle.Click += new System.EventHandler(this.btnRunRaffle_Click);
            // 
            // lblTitleTixPur
            // 
            this.lblTitleTixPur.AutoSize = true;
            this.lblTitleTixPur.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTixPur.Location = new System.Drawing.Point(5, 284);
            this.lblTitleTixPur.Name = "lblTitleTixPur";
            this.lblTitleTixPur.Size = new System.Drawing.Size(60, 22);
            this.lblTitleTixPur.TabIndex = 997;
            this.lblTitleTixPur.Text = "Totals";
            // 
            // lblNumTixPurchased
            // 
            this.lblNumTixPurchased.AutoSize = true;
            this.lblNumTixPurchased.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTixPurchased.Location = new System.Drawing.Point(156, 306);
            this.lblNumTixPurchased.Name = "lblNumTixPurchased";
            this.lblNumTixPurchased.Size = new System.Drawing.Size(21, 22);
            this.lblNumTixPurchased.TabIndex = 996;
            this.lblNumTixPurchased.Text = "0";
            this.lblNumTixPurchased.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(255, 24);
            this.menuStrip1.TabIndex = 1000;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCountsToolStripMenuItem,
            this.tsmClearDatabase,
            this.MenuSeperator,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "&File";
            // 
            // getCountsToolStripMenuItem
            // 
            this.getCountsToolStripMenuItem.Name = "getCountsToolStripMenuItem";
            this.getCountsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getCountsToolStripMenuItem.Text = "&Get Counts";
            this.getCountsToolStripMenuItem.Click += new System.EventHandler(this.getCountsToolStripMenuItem_Click);
            // 
            // tsmClearDatabase
            // 
            this.tsmClearDatabase.Name = "tsmClearDatabase";
            this.tsmClearDatabase.Size = new System.Drawing.Size(152, 22);
            this.tsmClearDatabase.Text = "&Clear Database";
            this.tsmClearDatabase.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // MenuSeperator
            // 
            this.MenuSeperator.Name = "MenuSeperator";
            this.MenuSeperator.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(152, 22);
            this.tsmExit.Text = "E&xit";
            this.tsmExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHelp});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(142, 22);
            this.tsmHelp.Text = "&General Help";
            this.tsmHelp.Click += new System.EventHandler(this.tsmHelp_Click);
            // 
            // lblGoldFromSales
            // 
            this.lblGoldFromSales.AutoSize = true;
            this.lblGoldFromSales.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldFromSales.Location = new System.Drawing.Point(156, 328);
            this.lblGoldFromSales.Name = "lblGoldFromSales";
            this.lblGoldFromSales.Size = new System.Drawing.Size(21, 22);
            this.lblGoldFromSales.TabIndex = 1002;
            this.lblGoldFromSales.Text = "0";
            this.lblGoldFromSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkFreeTickets
            // 
            this.chkFreeTickets.AutoSize = true;
            this.chkFreeTickets.Location = new System.Drawing.Point(5, 197);
            this.chkFreeTickets.Name = "chkFreeTickets";
            this.chkFreeTickets.Size = new System.Drawing.Size(85, 17);
            this.chkFreeTickets.TabIndex = 1003;
            this.chkFreeTickets.Text = "Free Tickets";
            this.chkFreeTickets.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 1005;
            this.label1.Text = "Gold Collected: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 1004;
            this.label2.Text = "Tickets Sold:      ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInquisRaffleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(255, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkFreeTickets);
            this.Controls.Add(this.lblGoldFromSales);
            this.Controls.Add(this.lblNumTixPurchased);
            this.Controls.Add(this.lblTitleTixPur);
            this.Controls.Add(this.btnRunRaffle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoughtTix);
            this.Controls.Add(this.lblNumTix);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmInquisRaffleEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warmart Raffle";
            ((System.ComponentModel.ISupportInitialize)(this.txtBoughtTix)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblNumTix;
        private System.Windows.Forms.NumericUpDown txtBoughtTix;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRunRaffle;
        private System.Windows.Forms.Label lblTitleTixPur;
        private System.Windows.Forms.Label lblNumTixPurchased;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmClearDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripSeparator MenuSeperator;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem getCountsToolStripMenuItem;
        private System.Windows.Forms.Label lblGoldFromSales;
        private System.Windows.Forms.CheckBox chkFreeTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

