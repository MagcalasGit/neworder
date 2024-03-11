namespace ordersystem
{
    partial class frm_summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_summary));
            lbl_grandTotal = new Label();
            lbl_Vat = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_proceed = new Button();
            lbl_change = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbl_address = new Label();
            lbl_num = new Label();
            lbl_name = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_grandTotal
            // 
            lbl_grandTotal.AutoSize = true;
            lbl_grandTotal.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_grandTotal.Location = new Point(180, 244);
            lbl_grandTotal.Name = "lbl_grandTotal";
            lbl_grandTotal.Size = new Size(38, 24);
            lbl_grandTotal.TabIndex = 0;
            lbl_grandTotal.Text = "----";
            // 
            // lbl_Vat
            // 
            lbl_Vat.AutoSize = true;
            lbl_Vat.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Vat.Location = new Point(180, 284);
            lbl_Vat.Name = "lbl_Vat";
            lbl_Vat.Size = new Size(38, 24);
            lbl_Vat.TabIndex = 1;
            lbl_Vat.Text = "----";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 244);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 3;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 284);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 4;
            label2.Text = "VAT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 325);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 5;
            label3.Text = "Change:";
            // 
            // btn_proceed
            // 
            btn_proceed.BackColor = Color.Green;
            btn_proceed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_proceed.ForeColor = SystemColors.ButtonHighlight;
            btn_proceed.Location = new Point(283, 391);
            btn_proceed.Name = "btn_proceed";
            btn_proceed.Size = new Size(244, 47);
            btn_proceed.TabIndex = 20;
            btn_proceed.Text = "Proceed";
            btn_proceed.UseVisualStyleBackColor = false;
            btn_proceed.Click += btn_proceed_Click;
            // 
            // lbl_change
            // 
            lbl_change.AutoSize = true;
            lbl_change.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_change.Location = new Point(180, 325);
            lbl_change.Name = "lbl_change";
            lbl_change.Size = new Size(38, 24);
            lbl_change.TabIndex = 21;
            lbl_change.Text = "----";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 110);
            label5.Name = "label5";
            label5.Size = new Size(65, 24);
            label5.TabIndex = 22;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 153);
            label6.Name = "label6";
            label6.Size = new Size(153, 24);
            label6.TabIndex = 23;
            label6.Text = "Contact Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(79, 188);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 24;
            label7.Text = "Address:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_address.Location = new Point(180, 188);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(38, 24);
            lbl_address.TabIndex = 25;
            lbl_address.Text = "----";
            // 
            // lbl_num
            // 
            lbl_num.AutoSize = true;
            lbl_num.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_num.Location = new Point(180, 153);
            lbl_num.Name = "lbl_num";
            lbl_num.Size = new Size(38, 24);
            lbl_num.TabIndex = 26;
            lbl_num.Text = "----";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(180, 110);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(38, 24);
            lbl_name.TabIndex = 27;
            lbl_name.Text = "----";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // frm_summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(539, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_name);
            Controls.Add(lbl_num);
            Controls.Add(lbl_address);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbl_change);
            Controls.Add(btn_proceed);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_Vat);
            Controls.Add(lbl_grandTotal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_summary";
            Text = "frm_summary";
            Load += frm_summary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_grandTotal;
        private Label lbl_Vat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_proceed;
        private Label lbl_change;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbl_address;
        private Label lbl_num;
        private Label lbl_name;
        private PictureBox pictureBox1;
    }
}