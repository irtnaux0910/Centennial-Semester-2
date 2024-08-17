namespace Gui
{
    public partial class formCal : Form
    {
        double num;
        public formCal()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDark.Checked)
            {
                this.BackColor = SystemColors.ControlDarkDark;
                txtResult.BackColor = SystemColors.ActiveCaption;
                btnSin.BackColor = SystemColors.ButtonShadow;
                btnCos.BackColor = SystemColors.ButtonShadow;
                btnOddEven.BackColor = SystemColors.ButtonShadow;
                btnClear.BackColor = SystemColors.ButtonShadow;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                txtResult.BackColor = SystemColors.Window;
                btnSin.BackColor = SystemColors.Control;
                btnCos.BackColor = SystemColors.Control;
                btnOddEven.BackColor = SystemColors.Control;
                btnClear.BackColor = SystemColors.Control;
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            num = Math.Sin(Convert.ToDouble(txtResult.Text));
            MessageBox.Show(Convert.ToString(num), "Result");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            num = Math.Cos(Convert.ToDouble(txtResult.Text));
            MessageBox.Show(Convert.ToString(num), "Result");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtResult.Text);
            if (num % 2 == 1)
            {
                MessageBox.Show("The number is Odd", "Result");
            }
            MessageBox.Show("The number is Even", "Result");


        }
    }
}
