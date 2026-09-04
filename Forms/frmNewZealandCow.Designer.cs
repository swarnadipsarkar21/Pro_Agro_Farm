namespace Pro_Agro_farm.Forms
{
    partial class frmNewZealandCow
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
            this.lblTop = new System.Windows.Forms.Label();
            this.btnType1 = new System.Windows.Forms.Button();
            this.btnType2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddToCard = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(299, 49);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(210, 27);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "New Zealand Cows ";
            // 
            // btnType1
            // 
            this.btnType1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType1.Location = new System.Drawing.Point(59, 423);
            this.btnType1.Name = "btnType1";
            this.btnType1.Size = new System.Drawing.Size(341, 40);
            this.btnType1.TabIndex = 3;
            this.btnType1.Text = "Type-1 (Price = 18,00,000.00 Taka )";
            this.btnType1.UseVisualStyleBackColor = false;
            this.btnType1.Click += new System.EventHandler(this.btnType1_Click);
            // 
            // btnType2
            // 
            this.btnType2.BackColor = System.Drawing.Color.ForestGreen;
            this.btnType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType2.Location = new System.Drawing.Point(486, 423);
            this.btnType2.Name = "btnType2";
            this.btnType2.Size = new System.Drawing.Size(341, 40);
            this.btnType2.TabIndex = 4;
            this.btnType2.Text = "Type-2 (Price = 6,98,745.00 Taka )";
            this.btnType2.UseVisualStyleBackColor = false;
            this.btnType2.Click += new System.EventHandler(this.btnType2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(235, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddToCard
            // 
            this.btnAddToCard.BackColor = System.Drawing.Color.Gold;
            this.btnAddToCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCard.Location = new System.Drawing.Point(486, 506);
            this.btnAddToCard.Name = "btnAddToCard";
            this.btnAddToCard.Size = new System.Drawing.Size(256, 40);
            this.btnAddToCard.TabIndex = 6;
            this.btnAddToCard.Text = "ADD TO CARD";
            this.btnAddToCard.UseVisualStyleBackColor = false;
            this.btnAddToCard.Click += new System.EventHandler(this.btnAddToCard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Pro_Agro_farm.Properties.Resources.new_type_2_;
            this.pictureBox2.Location = new System.Drawing.Point(486, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnType2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Pro_Agro_farm.Properties.Resources.new_type_1_;
            this.pictureBox1.Location = new System.Drawing.Point(59, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnType1_Click);
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType1.Location = new System.Drawing.Point(44, 142);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(356, 20);
            this.lblType1.TabIndex = 7;
            this.lblType1.Text = "উচ্চ বংশীয় খানদানি গরু (প্রতিদিন 35 লিটার দুধ দেয়)";
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType2.Location = new System.Drawing.Point(482, 142);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(250, 20);
            this.lblType2.TabIndex = 8;
            this.lblType2.Text = "ক্রস বিট (প্রতিদিন 26 লিটার দুধ দেয়)";
            // 
            // frmNewZealandCow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(880, 604);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.btnAddToCard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnType2);
            this.Controls.Add(this.btnType1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTop);
            this.MaximizeBox = false;
            this.Name = "frmNewZealandCow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewZealandCow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnType1;
        private System.Windows.Forms.Button btnType2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddToCard;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblType2;
    }
}