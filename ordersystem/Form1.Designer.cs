namespace ordersystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OrdrBtn = new Button();
            ExtBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OrdrBtn
            // 
            OrdrBtn.BackColor = Color.LimeGreen;
            OrdrBtn.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdrBtn.ForeColor = SystemColors.ButtonHighlight;
            OrdrBtn.Location = new Point(43, 225);
            OrdrBtn.Name = "OrdrBtn";
            OrdrBtn.Size = new Size(259, 64);
            OrdrBtn.TabIndex = 0;
            OrdrBtn.Text = "Order Now";
            OrdrBtn.UseVisualStyleBackColor = false;
            OrdrBtn.Click += OrdrBtn_Click;
            // 
            // ExtBtn
            // 
            ExtBtn.BackColor = Color.DarkRed;
            ExtBtn.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExtBtn.ForeColor = SystemColors.ButtonHighlight;
            ExtBtn.Location = new Point(43, 314);
            ExtBtn.Name = "ExtBtn";
            ExtBtn.Size = new Size(259, 64);
            ExtBtn.TabIndex = 1;
            ExtBtn.Text = "Exit";
            ExtBtn.UseVisualStyleBackColor = false;
            ExtBtn.Click += ExtBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(346, 450);
            Controls.Add(pictureBox1);
            Controls.Add(ExtBtn);
            Controls.Add(OrdrBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Los Pollos Ordering System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OrdrBtn;
        private Button ExtBtn;
        private PictureBox pictureBox1;
    }
}
