namespace Pro_Agro_farm.Forms
{
    partial class frmBrahama
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
            this.btnAddToCard = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToCard
            // 
            this.btnAddToCard.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddToCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCard.Location = new System.Drawing.Point(499, 412);
            this.btnAddToCard.Name = "btnAddToCard";
            this.btnAddToCard.Size = new System.Drawing.Size(212, 48);
            this.btnAddToCard.TabIndex = 49;
            this.btnAddToCard.Text = "ADD to CARD";
            this.btnAddToCard.UseVisualStyleBackColor = false;
            this.btnAddToCard.Click += new System.EventHandler(this.btnAddToCard_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(625, 334);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(224, 25);
            this.lblTotalPrice.TabIndex = 48;
            this.lblTotalPrice.Text = "Total Price : 0.00 taka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 47;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(559, 243);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(169, 25);
            this.lblQuantity.TabIndex = 46;
            this.lblQuantity.Text = "Enter Quantity  :";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(625, 176);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(183, 25);
            this.lblAvailable.TabIndex = 45;
            this.lblAvailable.Text = "Available stock: 0";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.Location = new System.Drawing.Point(605, 118);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(244, 25);
            this.lblPricePerUnit.TabIndex = 44;
            this.lblPricePerUnit.Text = "Price per Unit: 0.00 taka";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(818, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 47);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(155, 77);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(330, 27);
            this.lblTop.TabIndex = 41;
            this.lblTop.Text = "PRODUCT :  Brahama Baby cow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pro_Agro_farm.Properties.Resources.brahama;
            this.pictureBox1.Location = new System.Drawing.Point(62, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // frmBrahama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1003, 568);
            this.Controls.Add(this.btnAddToCard);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblPricePerUnit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmBrahama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrahama";
            this.Load += new System.EventHandler(this.frmBrahama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToCard;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}