using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordersystem
{
    public partial class frm_summary : Form
    {
        public frm_summary(double grandTotal, double totalVAT, double change, string name, string address, string number)
        {
            InitializeComponent();
            lbl_grandTotal.Text = grandTotal.ToString("0.00");
            lbl_Vat.Text = totalVAT.ToString("0.00");
            lbl_change.Text = change.ToString("0.00");
            lbl_name.Text = name;
            lbl_num.Text = number;
            lbl_address.Text = address;
        }
        public frm_summary()
        {
            InitializeComponent();
        }

        private void frm_summary_Load(object sender, EventArgs e)
        {

        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cash_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
