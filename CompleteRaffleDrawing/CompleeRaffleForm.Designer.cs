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
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblNumTix = new System.Windows.Forms.Label();
            this.txtBoughtTix = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRunRaffle = new System.Windows.Forms.Button();
            this.lblTitleTixPur = new System.Windows.Forms.Label();
            this.lblNumTixPurchased = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoughtTix)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyerName.Location = new System.Drawing.Point(9, 30);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(197, 26);
            this.txtBuyerName.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(9, 9);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(197, 18);
            this.lblEnterName.TabIndex = 998;
            this.lblEnterName.Text = "Enter Name of Ticket Buyer";
            // 
            // lblNumTix
            // 
            this.lblNumTix.AutoSize = true;
            this.lblNumTix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTix.Location = new System.Drawing.Point(9, 68);
            this.lblNumTix.Name = "lblNumTix";
            this.lblNumTix.Size = new System.Drawing.Size(244, 18);
            this.lblNumTix.TabIndex = 999;
            this.lblNumTix.Text = "Enter number of purchased tickets";
            // 
            // txtBoughtTix
            // 
            this.txtBoughtTix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoughtTix.Location = new System.Drawing.Point(9, 127);
            this.txtBoughtTix.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtBoughtTix.Name = "txtBoughtTix";
            this.txtBoughtTix.Size = new System.Drawing.Size(120, 26);
            this.txtBoughtTix.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(137, 98);
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
            this.btnCancel.Location = new System.Drawing.Point(137, 159);
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
            this.btnRunRaffle.Location = new System.Drawing.Point(9, 221);
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
            this.lblTitleTixPur.Location = new System.Drawing.Point(42, 261);
            this.lblTitleTixPur.Name = "lblTitleTixPur";
            this.lblTitleTixPur.Size = new System.Drawing.Size(179, 22);
            this.lblTitleTixPur.TabIndex = 997;
            this.lblTitleTixPur.Text = "Running Ticket Total";
            // 
            // lblNumTixPurchased
            // 
            this.lblNumTixPurchased.AutoSize = true;
            this.lblNumTixPurchased.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTixPurchased.Location = new System.Drawing.Point(121, 287);
            this.lblNumTixPurchased.Name = "lblNumTixPurchased";
            this.lblNumTixPurchased.Size = new System.Drawing.Size(21, 22);
            this.lblNumTixPurchased.TabIndex = 996;
            this.lblNumTixPurchased.Text = "0";
            // 
            // frmInquisRaffleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(261, 318);
            this.Controls.Add(this.lblNumTixPurchased);
            this.Controls.Add(this.lblTitleTixPur);
            this.Controls.Add(this.btnRunRaffle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoughtTix);
            this.Controls.Add(this.lblNumTix);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtBuyerName);
            this.Name = "frmInquisRaffleEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inquis Raffle";
            ((System.ComponentModel.ISupportInitialize)(this.txtBoughtTix)).EndInit();
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
    }
}

