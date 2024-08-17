namespace GUI
{
    public partial class formCal : Form
    {
        public formCal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDarkLight_Click(object sender, EventArgs e)
        {
            if (btnDarkLight.Text != "Switch to Light")
            {
                btnDarkLight.Text = "Switch to Light";
                this.BackColor = SystemColors.ActiveCaptionText;
                lblFirst.ForeColor = SystemColors.ButtonHighlight;
                lblSecond.ForeColor = SystemColors.ButtonHighlight;
                lblResult.ForeColor = SystemColors.ButtonHighlight;
            }
            else
            {
                btnDarkLight.Text = "Switch to Dark";
                this.BackColor = SystemColors.Control;
                lblFirst.ForeColor = SystemColors.ControlText;
                lblSecond.ForeColor = SystemColors.ControlText;
                lblResult.ForeColor = SystemColors.ControlText;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtSecond.Text = "";
            txtResult.Text = "";
        }



        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtFirst.Text) + Convert.ToDouble(txtSecond.Text)).ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtFirst.Text) - Convert.ToDouble(txtSecond.Text)).ToString();

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtFirst.Text) * Convert.ToDouble(txtSecond.Text)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtFirst.Text) / Convert.ToDouble(txtSecond.Text)).ToString();

        }
    }
}
