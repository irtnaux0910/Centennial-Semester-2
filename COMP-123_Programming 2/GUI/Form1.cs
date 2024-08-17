using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.Button;
using System;

namespace Calculator
{
    public partial class formCal : Form
    {
        double firstValue, secondValue;
        String op;
        public formCal()
        {
            InitializeComponent();
        }

        private void chkDark_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDark.Checked)
            {
                tabCal.ForeColor = Color.FromArgb(245, 246, 250);
                tabCal.BackColor = Color.FromArgb(32, 32, 32);
                tabAbout.ForeColor = Color.FromArgb(245, 246, 250);
                tabAbout.BackColor = Color.FromArgb(32, 32, 32);
                txtDisplay.ForeColor = Color.FromArgb(245, 246, 250);
                txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
                btnPercent.ForeColor = Color.FromArgb(245, 246, 250);
                btnPercent.BackColor = Color.FromArgb(32, 32, 32);
                btn1over.ForeColor = Color.FromArgb(245, 246, 250);
                btn1over.BackColor = Color.FromArgb(32, 32, 32);
                btnClearEntry.ForeColor = Color.FromArgb(245, 246, 250);
                btnClearEntry.BackColor = Color.FromArgb(32, 32, 32);
                btnClear.ForeColor = Color.FromArgb(245, 246, 250);
                btnClear.BackColor = Color.FromArgb(32, 32, 32);
                btn0.ForeColor = Color.FromArgb(245, 246, 250);
                btn0.BackColor = Color.FromArgb(32, 32, 32);
                btn1.ForeColor = Color.FromArgb(245, 246, 250);
                btn1.BackColor = Color.FromArgb(32, 32, 32);
                btn2.ForeColor = Color.FromArgb(245, 246, 250);
                btn2.BackColor = Color.FromArgb(32, 32, 32);
                btn3.ForeColor = Color.FromArgb(245, 246, 250);
                btn3.BackColor = Color.FromArgb(32, 32, 32);
                btn4.ForeColor = Color.FromArgb(245, 246, 250);
                btn4.BackColor = Color.FromArgb(32, 32, 32);
                btn5.ForeColor = Color.FromArgb(245, 246, 250);
                btn5.BackColor = Color.FromArgb(32, 32, 32);
                btn6.ForeColor = Color.FromArgb(245, 246, 250);
                btn6.BackColor = Color.FromArgb(32, 32, 32);
                btn7.ForeColor = Color.FromArgb(245, 246, 250);
                btn7.BackColor = Color.FromArgb(32, 32, 32);
                btn8.ForeColor = Color.FromArgb(245, 246, 250);
                btn8.BackColor = Color.FromArgb(32, 32, 32);
                btn9.ForeColor = Color.FromArgb(245, 246, 250);
                btn9.BackColor = Color.FromArgb(32, 32, 32);
                btnEqual.ForeColor = Color.FromArgb(245, 246, 250);
                btnEqual.BackColor = Color.FromArgb(32, 32, 32);
                btnPlus.ForeColor = Color.FromArgb(245, 246, 250);
                btnPlus.BackColor = Color.FromArgb(32, 32, 32);
                btnMinus.ForeColor = Color.FromArgb(245, 246, 250);
                btnMinus.BackColor = Color.FromArgb(32, 32, 32);
                btnMultiple.ForeColor = Color.FromArgb(245, 246, 250);
                btnMultiple.BackColor = Color.FromArgb(32, 32, 32);
                btnDivide.ForeColor = Color.FromArgb(245, 246, 250);
                btnDivide.BackColor = Color.FromArgb(32, 32, 32);
                btnSQRT.BackColor = Color.FromArgb(32, 32, 32);
                btnSQRT.ForeColor = Color.FromArgb(245, 246, 250);
                btnDot.ForeColor = Color.FromArgb(245, 246, 250);
                btnDot.BackColor = Color.FromArgb(32, 32, 32);
                btnSin.ForeColor = Color.FromArgb(245, 246, 250);
                btnSin.BackColor = Color.FromArgb(32, 32, 32);
                btnCos.ForeColor = Color.FromArgb(245, 246, 250);
                btnCos.BackColor = Color.FromArgb(32, 32, 32);
                btnLog.BackColor = Color.FromArgb(32, 32, 32);
                btnLog.ForeColor = Color.FromArgb(245, 246, 250);
                btnFact.ForeColor = Color.FromArgb(245, 246, 250);
                btnFact.BackColor = Color.FromArgb(32, 32, 32);
                btnPi.ForeColor = Color.FromArgb(245, 246, 250);
                btnPi.BackColor = Color.FromArgb(32, 32, 32);
                btnE.ForeColor = Color.FromArgb(245, 246, 250);
                btnE.BackColor = Color.FromArgb(32, 32, 32);
                btnAb.BackColor = Color.FromArgb(32, 32, 32);
                btnAb.ForeColor = Color.FromArgb(245, 246, 250);
                btn2SquareX.ForeColor = Color.FromArgb(245, 246, 250);
                btn2SquareX.BackColor = Color.FromArgb(32, 32, 32);
                btnCube.ForeColor = Color.FromArgb(245, 246, 250);
                btnCube.BackColor = Color.FromArgb(32, 32, 32);
                btnSquare.ForeColor = Color.FromArgb(245, 246, 250);
                btnSquare.BackColor = Color.FromArgb(32, 32, 32);
            }
            else
            {
                tabCal.ForeColor = Color.FromArgb(32, 32, 32);
                tabCal.BackColor = Color.FromArgb(245, 246, 250);
                tabAbout.ForeColor = Color.FromArgb(32, 32, 32);
                tabAbout.BackColor = Color.FromArgb(245, 246, 250);
                txtDisplay.ForeColor = Color.FromArgb(32, 32, 32);
                txtDisplay.BackColor = Color.FromArgb(245, 246, 250);
                btnPercent.ForeColor = Color.FromArgb(32, 32, 32);
                btnPercent.BackColor = Color.FromArgb(245, 246, 250);
                btn1over.ForeColor = Color.FromArgb(32, 32, 32);
                btn1over.BackColor = Color.FromArgb(245, 246, 250);
                btnClearEntry.ForeColor = Color.FromArgb(32, 32, 32);
                btnClearEntry.BackColor = Color.FromArgb(245, 246, 250);
                btnClear.ForeColor = Color.FromArgb(32, 32, 32);
                btnClear.BackColor = Color.FromArgb(245, 246, 250);
                btn0.ForeColor = Color.FromArgb(32, 32, 32);
                btn0.BackColor = Color.FromArgb(245, 246, 250);
                btn1.ForeColor = Color.FromArgb(32, 32, 32);
                btn1.BackColor = Color.FromArgb(245, 246, 250);
                btn2.ForeColor = Color.FromArgb(32, 32, 32);
                btn2.BackColor = Color.FromArgb(245, 246, 250);
                btn3.ForeColor = Color.FromArgb(32, 32, 32);
                btn3.BackColor = Color.FromArgb(245, 246, 250);
                btn4.ForeColor = Color.FromArgb(32, 32, 32);
                btn4.BackColor = Color.FromArgb(245, 246, 250);
                btn5.ForeColor = Color.FromArgb(32, 32, 32);
                btn5.BackColor = Color.FromArgb(245, 246, 250);
                btn6.ForeColor = Color.FromArgb(32, 32, 32);
                btn6.BackColor = Color.FromArgb(245, 246, 250);
                btn7.ForeColor = Color.FromArgb(32, 32, 32);
                btn7.BackColor = Color.FromArgb(245, 246, 250);
                btn8.ForeColor = Color.FromArgb(32, 32, 32);
                btn8.BackColor = Color.FromArgb(245, 246, 250);
                btn9.ForeColor = Color.FromArgb(32, 32, 32);
                btn9.BackColor = Color.FromArgb(245, 246, 250);
                btnEqual.ForeColor = Color.FromArgb(32, 32, 32);
                btnEqual.BackColor = Color.FromArgb(245, 246, 250);
                btnPlus.ForeColor = Color.FromArgb(32, 32, 32);
                btnPlus.BackColor = Color.FromArgb(245, 246, 250);
                btnMinus.ForeColor = Color.FromArgb(32, 32, 32);
                btnMinus.BackColor = Color.FromArgb(245, 246, 250);
                btnMultiple.ForeColor = Color.FromArgb(32, 32, 32);
                btnMultiple.BackColor = Color.FromArgb(245, 246, 250);
                btnDivide.ForeColor = Color.FromArgb(32, 32, 32);
                btnDivide.BackColor = Color.FromArgb(245, 246, 250);
                btnSQRT.BackColor = Color.FromArgb(245, 246, 250);
                btnSQRT.ForeColor = Color.FromArgb(32, 32, 32);
                btnDot.ForeColor = Color.FromArgb(32, 32, 32);
                btnDot.BackColor = Color.FromArgb(245, 246, 250);
                btnSin.ForeColor = Color.FromArgb(32, 32, 32);
                btnSin.BackColor = Color.FromArgb(245, 246, 250);
                btnCos.ForeColor = Color.FromArgb(32, 32, 32);
                btnCos.BackColor = Color.FromArgb(245, 246, 250);
                btnLog.BackColor = Color.FromArgb(245, 246, 250);
                btnLog.ForeColor = Color.FromArgb(32, 32, 32);
                btnFact.ForeColor = Color.FromArgb(32, 32, 32);
                btnFact.BackColor = Color.FromArgb(245, 246, 250);
                btnPi.ForeColor = Color.FromArgb(32, 32, 32);
                btnPi.BackColor = Color.FromArgb(245, 246, 250);
                btnE.ForeColor = Color.FromArgb(32, 32, 32);
                btnE.BackColor = Color.FromArgb(245, 246, 250);
                btnAb.BackColor = Color.FromArgb(245, 246, 250);
                btnAb.ForeColor = Color.FromArgb(32, 32, 32);
                btn2SquareX.ForeColor = Color.FromArgb(32, 32, 32);
                btn2SquareX.BackColor = Color.FromArgb(245, 246, 250);
                btnCube.ForeColor = Color.FromArgb(32, 32, 32);
                btnCube.BackColor = Color.FromArgb(245, 246, 250);
                btnSquare.ForeColor = Color.FromArgb(32, 32, 32);
                btnSquare.BackColor = Color.FromArgb(245, 246, 250);
            }
        }

        private void radScientific_CheckedChanged(object sender, EventArgs e)
        {
            if (radScientific.Checked)
            {
                this.Size = new Size(1712, 1411);
                txtDisplay.Size = new Size(1643, 194);
                btnEqual.Size = new Size(1629, 157);
                pictProfile.Location = new Point(564, 27);
                lblToday.Location = new Point(904, 1171);
                Date.Location = new Point(1056, 1164);
                lblName.Location = new Point(593, 672);
                lblName.Font = new Font("Gadugi", 12, FontStyle.Bold);
                lblIntro.Location = new Point(267, 789);
                lblIntro.Font = new Font("Gadugi", 12, FontStyle.Bold);
            }
        }
        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radStandard.Checked)
            {
                this.Size = new Size(1154, 1411);
                txtDisplay.Size = new Size(1102, 194);
                btnEqual.Size = new Size(1088, 157);
                pictProfile.Location = new Point(301, 6);
                lblToday.Location = new Point(349, 1163);
                Date.Location = new Point(504, 1155);
                lblName.Location = new Point(301, 675);
                lblName.Font = new Font("Gadugi", 10, FontStyle.Bold);
                lblIntro.Location = new Point(12, 777);
                lblIntro.Font = new Font("Gadugi", 10, FontStyle.Bold);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {


        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtDisplay.Text) / 100;
            txtDisplay.Text = Convert.ToString(num);
        }

        private void tabCal_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtDisplay.Text);
            cos = Math.Cos(cos);
            txtDisplay.Text = Convert.ToString(cos);
        }

        private void btnSquareY_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtDisplay.Text);
            double y = Convert.ToDouble(txtDisplay.Text);
            double result = Math.Pow(x, y);
            txtDisplay.Text = Convert.ToString(result);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabAbout_Click(object sender, EventArgs e)
        {

        }

        private void lblToday_Click(object sender, EventArgs e)
        {

        }

        private void Number(object sender, EventArgs e)
        {
            System.Windows.Forms.Button number = (System.Windows.Forms.Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";
            {
                if (number.Text == ".")
                {
                    if (!txtDisplay.Text.Contains("."))
                        txtDisplay.Text = txtDisplay.Text + number.Text;
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text + number.Text;
                }
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
        }

        private void Operator(object sender, EventArgs e)
        {
            System.Windows.Forms.Button number = (System.Windows.Forms.Button)sender;
            firstValue = Convert.ToDouble(txtDisplay.Text);
            op = number.Text;
            txtDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondValue = Convert.ToDouble(txtDisplay.Text);

            switch (op)
            {
                case "+":
                    txtDisplay.Text = (firstValue + secondValue).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstValue - secondValue).ToString();
                    break;
                case "×":
                    txtDisplay.Text = (firstValue * secondValue).ToString();
                    break;
                case "÷":
                    txtDisplay.Text = (firstValue / secondValue).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            String first, second;
            first = Convert.ToString(firstValue);
            second = Convert.ToString(secondValue);

            first = "";
            second = "";
        }

        private void btn1over_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = $"{(Math.PI):F4}";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(txtDisplay.Text);
            log = Math.Log10(log);
            txtDisplay.Text = Convert.ToString(log);
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtDisplay.Text);
            sqrt = Math.Sqrt(sqrt);
            txtDisplay.Text = Convert.ToString(sqrt);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(num);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtDisplay.Text);
            sin = Math.Sin(sin);
            txtDisplay.Text = Convert.ToString(sin);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = $"{(Math.E):F4}";
        }

        private void btn2SquareX_Click(object sender, EventArgs e)
        {
            double num;
            num = Math.Pow(2, Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = Convert.ToString(num);
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtDisplay.Text) < 0)
            {
                txtDisplay.Text = Convert.ToString(-Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
        }

        private void btnFact_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtDisplay.Text) < 0)
            {
                MessageBox.Show("Factorial cannot be negative");
            }
            int num = 1;
            for (int i = 2; i <= Convert.ToDouble(txtDisplay.Text); i++)
            {
                num *= i;
            }
            txtDisplay.Text = Convert.ToString(num);
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(num);
        }

        private void formCal_Load(object sender, EventArgs e)
        {

        }
    }
}
