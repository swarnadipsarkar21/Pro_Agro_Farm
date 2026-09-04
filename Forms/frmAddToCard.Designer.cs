namespace Pro_Agro_farm.Forms
{
    partial class frmAddToCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblPaymentNote = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnBuyMore = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanks For Purchasing From Us ";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(40, 95);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(99, 48);
            this.lblCustomerInfo.TabIndex = 2;
            this.lblCustomerInfo.Text = "Name: \r\nAddress: ";
            // 
            // lstItems
            // 
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(40, 165);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(860, 164);
            this.lstItems.TabIndex = 3;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(40, 360);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(243, 25);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Total Amount: 0.00 taka";
            // 
            // lblPaymentNote
            // 
            this.lblPaymentNote.AutoSize = true;
            this.lblPaymentNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentNote.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPaymentNote.Location = new System.Drawing.Point(40, 405);
            this.lblPaymentNote.Name = "lblPaymentNote";
            this.lblPaymentNote.Size = new System.Drawing.Size(660, 20);
            this.lblPaymentNote.TabIndex = 5;
            this.lblPaymentNote.Text = "At this moment we only take cash , so please pay on cash when your product delive" +
    "red ";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(700, 440);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(193, 48);
            this.lblFooter.TabIndex = 6;
            this.lblFooter.Text = "pro group of industry\r\nBorn to destroy";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuyMore
            // 
            this.btnBuyMore.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuyMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMore.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMore.Location = new System.Drawing.Point(40, 480);
            this.btnBuyMore.Name = "btnBuyMore";
            this.btnBuyMore.Size = new System.Drawing.Size(150, 47);
            this.btnBuyMore.TabIndex = 7;
            this.btnBuyMore.Text = "BUY MORE";
            this.btnBuyMore.UseVisualStyleBackColor = false;
            this.btnBuyMore.Click += new System.EventHandler(this.btnBuyMore_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Yellow;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(220, 480);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(150, 47);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmAddToCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(940, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblPaymentNote);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnBuyMore);
            this.Controls.Add(this.btnDone);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "frmAddToCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddToCard";
            this.Load += new System.EventHandler(this.frmAddToCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblPaymentNote;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnBuyMore;
        private System.Windows.Forms.Button btnDone;
    }
}