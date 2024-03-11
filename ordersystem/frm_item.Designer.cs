namespace ordersystem
{
    partial class frm_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_item));
            ExtOsBtn = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txt_tacbur = new TextBox();
            label7 = new Label();
            txt_bigmac = new TextBox();
            txt_quesa = new TextBox();
            txt_Chick = new TextBox();
            BigMacBtn = new CheckBox();
            QuessaBtn = new CheckBox();
            ChickBtn = new CheckBox();
            TacBurBtn = new CheckBox();
            Drinks = new GroupBox();
            label8 = new Label();
            txt_Tea = new TextBox();
            IcedTeaBtn = new CheckBox();
            txt_Peps = new TextBox();
            DrPepBtn = new CheckBox();
            txt_DrPep = new TextBox();
            txt_cola = new TextBox();
            PepsiBtn = new CheckBox();
            CokeBtn = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Name = new TextBox();
            txt_Address = new TextBox();
            txt_Num = new TextBox();
            Confirm_btn = new Button();
            btn_proceed = new Button();
            btn_void = new Button();
            txt_Cash = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            Drinks.SuspendLayout();
            SuspendLayout();
            // 
            // ExtOsBtn
            // 
            ExtOsBtn.BackColor = Color.DarkRed;
            ExtOsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ExtOsBtn.ForeColor = SystemColors.ButtonHighlight;
            ExtOsBtn.Location = new Point(1000, 1);
            ExtOsBtn.Name = "ExtOsBtn";
            ExtOsBtn.Size = new Size(33, 23);
            ExtOsBtn.TabIndex = 0;
            ExtOsBtn.Text = "X";
            ExtOsBtn.UseVisualStyleBackColor = false;
            ExtOsBtn.Click += ExtOsBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_tacbur);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_bigmac);
            groupBox1.Controls.Add(txt_quesa);
            groupBox1.Controls.Add(txt_Chick);
            groupBox1.Controls.Add(BigMacBtn);
            groupBox1.Controls.Add(QuessaBtn);
            groupBox1.Controls.Add(ChickBtn);
            groupBox1.Controls.Add(TacBurBtn);
            groupBox1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkRed;
            groupBox1.Location = new Point(33, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 234);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food and Wrap";
            // 
            // txt_tacbur
            // 
            txt_tacbur.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tacbur.Location = new Point(364, 55);
            txt_tacbur.Name = "txt_tacbur";
            txt_tacbur.Size = new Size(42, 27);
            txt_tacbur.TabIndex = 18;
            txt_tacbur.TextChanged += txt_tacbur_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(353, 26);
            label7.Name = "label7";
            label7.Size = new Size(65, 14);
            label7.TabIndex = 17;
            label7.Text = "Quantity:";
            // 
            // txt_bigmac
            // 
            txt_bigmac.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_bigmac.Location = new Point(364, 180);
            txt_bigmac.Name = "txt_bigmac";
            txt_bigmac.Size = new Size(42, 27);
            txt_bigmac.TabIndex = 11;
            txt_bigmac.TextChanged += txt_bigmac_TextChanged;
            // 
            // txt_quesa
            // 
            txt_quesa.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_quesa.Location = new Point(364, 139);
            txt_quesa.Name = "txt_quesa";
            txt_quesa.Size = new Size(42, 27);
            txt_quesa.TabIndex = 10;
            txt_quesa.TextChanged += txt_quesa_TextChanged;
            // 
            // txt_Chick
            // 
            txt_Chick.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Chick.Location = new Point(364, 96);
            txt_Chick.Name = "txt_Chick";
            txt_Chick.Size = new Size(42, 27);
            txt_Chick.TabIndex = 9;
            txt_Chick.TextChanged += txt_Chick_TextChanged;
            // 
            // BigMacBtn
            // 
            BigMacBtn.AutoSize = true;
            BigMacBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BigMacBtn.Location = new Point(27, 182);
            BigMacBtn.Name = "BigMacBtn";
            BigMacBtn.Size = new Size(91, 23);
            BigMacBtn.TabIndex = 3;
            BigMacBtn.Text = "Big Mac";
            BigMacBtn.UseVisualStyleBackColor = true;
            BigMacBtn.CheckedChanged += BigMacBtn_CheckedChanged;
            // 
            // QuessaBtn
            // 
            QuessaBtn.AutoSize = true;
            QuessaBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuessaBtn.Location = new Point(27, 139);
            QuessaBtn.Name = "QuessaBtn";
            QuessaBtn.Size = new Size(113, 23);
            QuessaBtn.TabIndex = 2;
            QuessaBtn.Text = "Quesadilla";
            QuessaBtn.UseVisualStyleBackColor = true;
            QuessaBtn.CheckedChanged += QuessaBtn_CheckedChanged;
            // 
            // ChickBtn
            // 
            ChickBtn.AutoSize = true;
            ChickBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChickBtn.Location = new Point(27, 100);
            ChickBtn.Name = "ChickBtn";
            ChickBtn.Size = new Size(138, 23);
            ChickBtn.TabIndex = 1;
            ChickBtn.Text = "Fried Chicken";
            ChickBtn.UseVisualStyleBackColor = true;
            ChickBtn.CheckedChanged += ChickBtn_CheckedChanged;
            // 
            // TacBurBtn
            // 
            TacBurBtn.AutoSize = true;
            TacBurBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TacBurBtn.Location = new Point(27, 59);
            TacBurBtn.Name = "TacBurBtn";
            TacBurBtn.Size = new Size(164, 23);
            TacBurBtn.TabIndex = 0;
            TacBurBtn.Text = "Taco and Burrito";
            TacBurBtn.UseVisualStyleBackColor = true;
            TacBurBtn.CheckedChanged += TacBurBtn_CheckedChanged;
            // 
            // Drinks
            // 
            Drinks.Controls.Add(label8);
            Drinks.Controls.Add(txt_Tea);
            Drinks.Controls.Add(IcedTeaBtn);
            Drinks.Controls.Add(txt_Peps);
            Drinks.Controls.Add(DrPepBtn);
            Drinks.Controls.Add(txt_DrPep);
            Drinks.Controls.Add(txt_cola);
            Drinks.Controls.Add(PepsiBtn);
            Drinks.Controls.Add(CokeBtn);
            Drinks.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Drinks.ForeColor = Color.DarkRed;
            Drinks.Location = new Point(610, 256);
            Drinks.Name = "Drinks";
            Drinks.Size = new Size(397, 234);
            Drinks.TabIndex = 3;
            Drinks.TabStop = false;
            Drinks.Text = "Drinks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(208, 25);
            label8.Name = "label8";
            label8.Size = new Size(65, 14);
            label8.TabIndex = 18;
            label8.Text = "Quantity:";
            // 
            // txt_Tea
            // 
            txt_Tea.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Tea.Location = new Point(234, 179);
            txt_Tea.Name = "txt_Tea";
            txt_Tea.Size = new Size(39, 27);
            txt_Tea.TabIndex = 15;
            txt_Tea.TextChanged += txt_Tea_TextChanged;
            // 
            // IcedTeaBtn
            // 
            IcedTeaBtn.AutoSize = true;
            IcedTeaBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IcedTeaBtn.Location = new Point(29, 181);
            IcedTeaBtn.Name = "IcedTeaBtn";
            IcedTeaBtn.Size = new Size(99, 23);
            IcedTeaBtn.TabIndex = 7;
            IcedTeaBtn.Text = "Iced Tea";
            IcedTeaBtn.UseVisualStyleBackColor = true;
            IcedTeaBtn.CheckedChanged += IcedTeaBtn_CheckedChanged;
            // 
            // txt_Peps
            // 
            txt_Peps.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Peps.Location = new Point(234, 140);
            txt_Peps.Name = "txt_Peps";
            txt_Peps.Size = new Size(39, 27);
            txt_Peps.TabIndex = 14;
            txt_Peps.TextChanged += txt_Peps_TextChanged;
            // 
            // DrPepBtn
            // 
            DrPepBtn.AutoSize = true;
            DrPepBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DrPepBtn.Location = new Point(29, 99);
            DrPepBtn.Name = "DrPepBtn";
            DrPepBtn.Size = new Size(110, 23);
            DrPepBtn.TabIndex = 6;
            DrPepBtn.Text = "Dr.Pepper";
            DrPepBtn.UseVisualStyleBackColor = true;
            DrPepBtn.CheckedChanged += DrPepBtn_CheckedChanged;
            // 
            // txt_DrPep
            // 
            txt_DrPep.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_DrPep.Location = new Point(234, 95);
            txt_DrPep.Name = "txt_DrPep";
            txt_DrPep.Size = new Size(39, 27);
            txt_DrPep.TabIndex = 13;
            txt_DrPep.TextChanged += txt_DrPep_TextChanged;
            // 
            // txt_cola
            // 
            txt_cola.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_cola.Location = new Point(234, 54);
            txt_cola.Name = "txt_cola";
            txt_cola.Size = new Size(39, 27);
            txt_cola.TabIndex = 12;
            txt_cola.TextChanged += txt_cola_TextChanged;
            // 
            // PepsiBtn
            // 
            PepsiBtn.AutoSize = true;
            PepsiBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PepsiBtn.Location = new Point(29, 142);
            PepsiBtn.Name = "PepsiBtn";
            PepsiBtn.Size = new Size(72, 23);
            PepsiBtn.TabIndex = 5;
            PepsiBtn.Text = "Pepsi";
            PepsiBtn.UseVisualStyleBackColor = true;
            PepsiBtn.CheckedChanged += PepsiBtn_CheckedChanged;
            // 
            // CokeBtn
            // 
            CokeBtn.AutoSize = true;
            CokeBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CokeBtn.Location = new Point(29, 59);
            CokeBtn.Name = "CokeBtn";
            CokeBtn.Size = new Size(110, 23);
            CokeBtn.TabIndex = 4;
            CokeBtn.Text = "Coca-Cola";
            CokeBtn.UseVisualStyleBackColor = true;
            CokeBtn.CheckedChanged += CokeBtn_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(490, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(476, 110);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 5;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(409, 71);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 6;
            label3.Text = "Contact Number:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(556, 30);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(168, 23);
            txt_Name.TabIndex = 7;
            txt_Name.TextChanged += txt_Name_TextChanged;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(556, 108);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(168, 23);
            txt_Address.TabIndex = 8;
            // 
            // txt_Num
            // 
            txt_Num.Location = new Point(556, 69);
            txt_Num.Name = "txt_Num";
            txt_Num.Size = new Size(168, 23);
            txt_Num.TabIndex = 9;
            txt_Num.TextChanged += txt_Num_TextChanged;
            // 
            // Confirm_btn
            // 
            Confirm_btn.BackColor = Color.DarkGreen;
            Confirm_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirm_btn.ForeColor = SystemColors.ButtonHighlight;
            Confirm_btn.Location = new Point(556, 190);
            Confirm_btn.Name = "Confirm_btn";
            Confirm_btn.Size = new Size(75, 27);
            Confirm_btn.TabIndex = 10;
            Confirm_btn.Text = "Confirm";
            Confirm_btn.UseVisualStyleBackColor = false;
            Confirm_btn.Click += Confirm_btn_Click;
            // 
            // btn_proceed
            // 
            btn_proceed.BackColor = Color.Green;
            btn_proceed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_proceed.ForeColor = SystemColors.ButtonHighlight;
            btn_proceed.Location = new Point(682, 496);
            btn_proceed.Name = "btn_proceed";
            btn_proceed.Size = new Size(141, 25);
            btn_proceed.TabIndex = 19;
            btn_proceed.Text = "Proceed";
            btn_proceed.UseVisualStyleBackColor = false;
            btn_proceed.Click += btn_proceed_Click;
            // 
            // btn_void
            // 
            btn_void.BackColor = Color.DarkRed;
            btn_void.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_void.ForeColor = SystemColors.ButtonHighlight;
            btn_void.Location = new Point(844, 496);
            btn_void.Name = "btn_void";
            btn_void.Size = new Size(163, 25);
            btn_void.TabIndex = 21;
            btn_void.Text = "Void Order(s)";
            btn_void.UseVisualStyleBackColor = false;
            btn_void.Click += btn_void_Click;
            // 
            // txt_Cash
            // 
            txt_Cash.Location = new Point(556, 150);
            txt_Cash.Name = "txt_Cash";
            txt_Cash.Size = new Size(168, 23);
            txt_Cash.TabIndex = 22;
            txt_Cash.TextChanged += txt_Cash_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(500, 148);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 23;
            label4.Text = "Cash:";
            // 
            // frm_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1035, 533);
            Controls.Add(label4);
            Controls.Add(txt_Cash);
            Controls.Add(btn_void);
            Controls.Add(btn_proceed);
            Controls.Add(Confirm_btn);
            Controls.Add(txt_Num);
            Controls.Add(txt_Address);
            Controls.Add(txt_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Drinks);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(ExtOsBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_item";
            Text = "frm_item";
            Load += frm_item_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Drinks.ResumeLayout(false);
            Drinks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExtOsBtn;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private CheckBox BigMacBtn;
        private CheckBox QuessaBtn;
        private CheckBox ChickBtn;
        private CheckBox TacBurBtn;
        private GroupBox Drinks;
        private CheckBox IcedTeaBtn;
        private CheckBox DrPepBtn;
        private CheckBox PepsiBtn;
        private CheckBox CokeBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Name;
        private TextBox txt_Address;
        private TextBox txt_Num;
        private Button Confirm_btn;
        private Label label7;
        private TextBox txt_bigmac;
        private TextBox txt_quesa;
        private TextBox txt_Chick;
        private TextBox txt_Tea;
        private TextBox txt_Peps;
        private TextBox txt_DrPep;
        private TextBox txt_cola;
        private Label label8;
        private TextBox txt_tacbur;
        private Button btn_proceed;
        private Button btn_void;
        private TextBox txt_Cash;
        private Label label4;
    }
}