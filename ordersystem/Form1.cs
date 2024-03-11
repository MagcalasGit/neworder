namespace ordersystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OrdrBtn_Click(object sender, EventArgs e)
        {
            Form item = new frm_item();
            item.Show(); 
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
