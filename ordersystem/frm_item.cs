using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordersystem
{
    public partial class frm_item : Form
    {
        const double price_TaconBurr = 30.00;
        const double price_FriedChicken = 40.00;
        const double price_Quesadilla = 15.00;
        const double price_BigMac = 25.00;
        const double price_Coca = 18.00;
        const double price_DrPep = 20.00;
        const double price_IcedTea = 23.00;
        const double price_Pepsi = 19.00;
        double grandTotal;
        double totalVAT;

        public frm_item()
        {
            InitializeComponent();
            btn_proceed.Enabled = false;
        }
        private double cash;
        private void ExtOsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_item_Load(object sender, EventArgs e)
        {

        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void TacBurBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TacBurBtn.Checked == true)
            {
                txt_tacbur.Enabled = true;
                txt_tacbur.Text = "";
                txt_tacbur.Focus();
            }
            else
            {
                txt_tacbur.Enabled = false;
                txt_tacbur.Text = "0";
            }
        }

        private void txt_Chick_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bigmac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cola_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DrPep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Peps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tacbur_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChickBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickBtn.Checked == true)
            {
                txt_Chick.Enabled = true;
                txt_Chick.Text = "0";
                txt_Chick.Focus();
            }
            else
            {
                txt_Chick.Enabled = false;
                txt_Chick.Text = "0";
            }
        }

        private void QuessaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (QuessaBtn.Checked == true)
            {
                txt_quesa.Enabled = true;
                txt_quesa.Text = "0";
                txt_quesa.Focus();
            }
            else
            {
                txt_quesa.Enabled = false;
                txt_quesa.Text = "0";
            }
        }

        private void BigMacBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BigMacBtn.Checked == true)
            {
                txt_bigmac.Enabled = true;
                txt_bigmac.Text = "0";
                txt_bigmac.Focus();
            }
            else
            {
                txt_bigmac.Enabled = false;
                txt_bigmac.Text = "0";
            }
        }

        private void CokeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CokeBtn.Checked == true)
            {
                txt_cola.Enabled = true;
                txt_cola.Text = "0";
                txt_cola.Focus();
            }
            else
            {
                txt_cola.Enabled = false;
                txt_cola.Text = "0";
            }
        }

        private void DrPepBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DrPepBtn.Checked == true)
            {
                txt_DrPep.Enabled = true;
                txt_DrPep.Text = "0";
                txt_DrPep.Focus();
            }
            else
            {
                txt_DrPep.Enabled = false;
                txt_DrPep.Text = "0";
            }
        }

        private void PepsiBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PepsiBtn.Checked == true)
            {
                txt_Peps.Enabled = true;
                txt_Peps.Text = "0";
                txt_Peps.Focus();
            }
            else
            {
                txt_Peps.Enabled = false;
                txt_Peps.Text = "0";
            }
        }

        private void IcedTeaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PepsiBtn.Checked == true)
            {
                txt_Peps.Enabled = true;
                txt_Peps.Text = "0";
                txt_Peps.Focus();
            }
            else
            {
                txt_Peps.Enabled = false;
                txt_Peps.Text = "0";
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bx_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_proceed_Click(object sender, EventArgs e)
        {
            // Calculate the grand total and total VAT
            double totalTaconBurr = price_TaconBurr * (TacBurBtn.Checked ? Convert.ToDouble(txt_tacbur.Text) : 0);
            double totalFriedChicken = price_FriedChicken * (ChickBtn.Checked ? Convert.ToDouble(txt_Chick.Text) : 0);
            double totalQuesadilla = price_Quesadilla * (QuessaBtn.Checked ? Convert.ToDouble(txt_quesa.Text) : 0);
            double totalBigMac = price_BigMac * (BigMacBtn.Checked ? Convert.ToDouble(txt_bigmac.Text) : 0);
            double totalCoca = price_Coca * (CokeBtn.Checked ? Convert.ToDouble(txt_cola.Text) : 0);
            double totalDrPep = price_DrPep * (DrPepBtn.Checked ? Convert.ToDouble(txt_DrPep.Text) : 0);
            double totalIcedTea = price_IcedTea * (IcedTeaBtn.Checked ? Convert.ToDouble(txt_Tea.Text) : 0);
            double totalPepsi = price_Pepsi * (PepsiBtn.Checked ? Convert.ToDouble(txt_Peps.Text) : 0);

            double grandTotal = totalTaconBurr + totalFriedChicken + totalQuesadilla +
                                totalBigMac + totalCoca + totalDrPep + totalIcedTea + totalPepsi;


            double change = cash - grandTotal;
            double totalVAT = grandTotal * 0.12;

            // Check if all items have quantities
            if ((TacBurBtn.Checked && string.IsNullOrWhiteSpace(txt_tacbur.Text)) ||
                (ChickBtn.Checked && string.IsNullOrWhiteSpace(txt_Chick.Text)) ||
                (QuessaBtn.Checked && string.IsNullOrWhiteSpace(txt_quesa.Text)) ||
                (BigMacBtn.Checked && string.IsNullOrWhiteSpace(txt_bigmac.Text)) ||
                (CokeBtn.Checked && string.IsNullOrWhiteSpace(txt_cola.Text)) ||
                (DrPepBtn.Checked && string.IsNullOrWhiteSpace(txt_DrPep.Text)) ||
                (PepsiBtn.Checked && string.IsNullOrWhiteSpace(txt_Peps.Text)) ||
                (IcedTeaBtn.Checked && string.IsNullOrWhiteSpace(txt_Tea.Text)))
            {
                MessageBox.Show("Please enter a quantity for all selected items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Open the summary form and pass the grand total and total VAT
            frm_summary summary = new frm_summary(grandTotal, totalVAT, change, txt_Name.Text, txt_Address.Text, txt_Num.Text);
            summary.Show();
        }

        private void txt_Cash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_void_Click(object sender, EventArgs e)
        {
            ChickBtn.Checked = false;
            QuessaBtn.Checked = false;
            BigMacBtn.Checked = false;
            CokeBtn.Checked = false;
            DrPepBtn.Checked = false;
            PepsiBtn.Checked = false;
            IcedTeaBtn.Checked = false;
            TacBurBtn.Checked = false;
        }


        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
                   string.IsNullOrWhiteSpace(txt_Num.Text) ||
                        string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                MessageBox.Show("Please fill up all fields (Name, Number, Address) before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Calculate the grand total and total VAT
            double totalTaconBurr = price_TaconBurr * (TacBurBtn.Checked ? Convert.ToDouble(txt_tacbur.Text) : 0);
            double totalFriedChicken = price_FriedChicken * (ChickBtn.Checked ? Convert.ToDouble(txt_Chick.Text) : 0);
            double totalQuesadilla = price_Quesadilla * (QuessaBtn.Checked ? Convert.ToDouble(txt_quesa.Text) : 0);
            double totalBigMac = price_BigMac * (BigMacBtn.Checked ? Convert.ToDouble(txt_bigmac.Text) : 0);
            double totalCoca = price_Coca * (CokeBtn.Checked ? Convert.ToDouble(txt_cola.Text) : 0);
            double totalDrPep = price_DrPep * (DrPepBtn.Checked ? Convert.ToDouble(txt_DrPep.Text) : 0);
            double totalIcedTea = price_IcedTea * (IcedTeaBtn.Checked ? Convert.ToDouble(txt_Tea.Text) : 0);
            double totalPepsi = price_Pepsi * (PepsiBtn.Checked ? Convert.ToDouble(txt_Peps.Text) : 0);

            double grandTotal = totalTaconBurr + totalFriedChicken + totalQuesadilla +
                                totalBigMac + totalCoca + totalDrPep + totalIcedTea + totalPepsi;



            double totalVAT = grandTotal * 0.12;

            double cash;

            if (!double.TryParse(txt_Cash.Text, out cash))
            {
                MessageBox.Show("Please enter a valid amount for cash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cash < grandTotal)
            {
                btn_proceed.Enabled = false;
            }
            else
            {
                btn_proceed.Enabled = true;
                double change = cash - grandTotal;
            }




        }

        private void txt_Cash_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                cash = double.Parse(txt_Cash.Text);
            }
            catch
            {
                cash = 0;
            }
        }

        private void txt_Num_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_Num.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer for Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Num.Text = "0";
            }
        }
    }
}
