namespace RandomRaffleDrawing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTixNum = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblSix = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.lblResult6 = new System.Windows.Forms.Label();
            this.lblResult5 = new System.Windows.Forms.Label();
            this.lblResult4 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTixNum
            // 
            this.lblTixNum.AutoSize = true;
            this.lblTixNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTixNum.Location = new System.Drawing.Point(13, 13);
            this.lblTixNum.Name = "lblTixNum";
            this.lblTixNum.Size = new System.Drawing.Size(177, 18);
            this.lblTixNum.TabIndex = 0;
            this.lblTixNum.Text = "Number of Raffle Tickets";
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(13, 34);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(100, 26);
            this.txtTickets.TabIndex = 1;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(10, 95);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(79, 18);
            this.lblOne.TabIndex = 2;
            this.lblOne.Text = "First Prize";
            this.lblOne.Visible = false;
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwo.Location = new System.Drawing.Point(10, 113);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(102, 18);
            this.lblTwo.TabIndex = 3;
            this.lblTwo.Text = "Second Prize";
            this.lblTwo.Visible = false;
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(10, 149);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(92, 18);
            this.lblFour.TabIndex = 5;
            this.lblFour.Text = "Fourth Prize";
            this.lblFour.Visible = false;
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThree.Location = new System.Drawing.Point(10, 131);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(83, 18);
            this.lblThree.TabIndex = 4;
            this.lblThree.Text = "Third Prize";
            this.lblThree.Visible = false;
            // 
            // lblSix
            // 
            this.lblSix.AutoSize = true;
            this.lblSix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSix.Location = new System.Drawing.Point(10, 185);
            this.lblSix.Name = "lblSix";
            this.lblSix.Size = new System.Drawing.Size(82, 18);
            this.lblSix.TabIndex = 7;
            this.lblSix.Text = "Sixth Prize";
            this.lblSix.Visible = false;
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(10, 167);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(78, 18);
            this.lblFive.TabIndex = 6;
            this.lblFive.Text = "Fifth Prize";
            this.lblFive.Visible = false;
            // 
            // btnDrawing
            // 
            this.btnDrawing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDrawing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawing.Location = new System.Drawing.Point(119, 34);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(115, 26);
            this.btnDrawing.TabIndex = 8;
            this.btnDrawing.Text = "Draw Winners";
            this.btnDrawing.UseVisualStyleBackColor = false;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // lblResult6
            // 
            this.lblResult6.AutoSize = true;
            this.lblResult6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult6.Location = new System.Drawing.Point(116, 185);
            this.lblResult6.Name = "lblResult6";
            this.lblResult6.Size = new System.Drawing.Size(17, 18);
            this.lblResult6.TabIndex = 14;
            this.lblResult6.Text = "6";
            this.lblResult6.Visible = false;
            // 
            // lblResult5
            // 
            this.lblResult5.AutoSize = true;
            this.lblResult5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult5.Location = new System.Drawing.Point(116, 167);
            this.lblResult5.Name = "lblResult5";
            this.lblResult5.Size = new System.Drawing.Size(17, 18);
            this.lblResult5.TabIndex = 13;
            this.lblResult5.Text = "5";
            this.lblResult5.Visible = false;
            // 
            // lblResult4
            // 
            this.lblResult4.AutoSize = true;
            this.lblResult4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult4.Location = new System.Drawing.Point(116, 149);
            this.lblResult4.Name = "lblResult4";
            this.lblResult4.Size = new System.Drawing.Size(17, 18);
            this.lblResult4.TabIndex = 12;
            this.lblResult4.Text = "4";
            this.lblResult4.Visible = false;
            // 
            // lblResult3
            // 
            this.lblResult3.AutoSize = true;
            this.lblResult3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult3.Location = new System.Drawing.Point(116, 131);
            this.lblResult3.Name = "lblResult3";
            this.lblResult3.Size = new System.Drawing.Size(17, 18);
            this.lblResult3.TabIndex = 11;
            this.lblResult3.Text = "3";
            this.lblResult3.Visible = false;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult2.Location = new System.Drawing.Point(116, 113);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(17, 18);
            this.lblResult2.TabIndex = 10;
            this.lblResult2.Text = "2";
            this.lblResult2.Visible = false;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult1.Location = new System.Drawing.Point(116, 95);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(17, 18);
            this.lblResult1.TabIndex = 9;
            this.lblResult1.Text = "1";
            this.lblResult1.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(13, 66);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(221, 26);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(239, 209);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResult6);
            this.Controls.Add(this.lblResult5);
            this.Controls.Add(this.lblResult4);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.btnDrawing);
            this.Controls.Add(this.lblSix);
            this.Controls.Add(this.lblFive);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.lblTixNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inquis Raffle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTixNum;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblSix;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Button btnDrawing;
        private System.Windows.Forms.Label lblResult6;
        private System.Windows.Forms.Label lblResult5;
        private System.Windows.Forms.Label lblResult4;
        private System.Windows.Forms.Label lblResult3;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Button btnReset;
    }
}

