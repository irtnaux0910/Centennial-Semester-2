namespace Calculator
{
    partial class formCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCal));
            tab = new TabControl();
            tabCal = new TabPage();
            btn2SquareX = new Button();
            btnAb = new Button();
            btnSquare = new Button();
            btnCube = new Button();
            btnLog = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnE = new Button();
            btnPi = new Button();
            btnSQRT = new Button();
            btnFact = new Button();
            btnPlus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnCos = new Button();
            btnMinus = new Button();
            btnSin = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiple = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDivide = new Button();
            btnClearEntry = new Button();
            btn1over = new Button();
            btnPercent = new Button();
            btnClear = new Button();
            radScientific = new RadioButton();
            radStandard = new RadioButton();
            txtDisplay = new TextBox();
            chkDark = new CheckBox();
            tabAbout = new TabPage();
            lblToday = new Label();
            Date = new DateTimePicker();
            lblIntro = new Label();
            lblName = new Label();
            pictLogo = new PictureBox();
            pictProfile = new PictureBox();
            tab.SuspendLayout();
            tabCal.SuspendLayout();
            tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictProfile).BeginInit();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabCal);
            tab.Controls.Add(tabAbout);
            tab.Location = new Point(-1, 1);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(1680, 1306);
            tab.TabIndex = 0;
            // 
            // tabCal
            // 
            tabCal.Controls.Add(btn2SquareX);
            tabCal.Controls.Add(btnAb);
            tabCal.Controls.Add(btnSquare);
            tabCal.Controls.Add(btnCube);
            tabCal.Controls.Add(btnLog);
            tabCal.Controls.Add(btnEqual);
            tabCal.Controls.Add(btnDot);
            tabCal.Controls.Add(btn0);
            tabCal.Controls.Add(btnE);
            tabCal.Controls.Add(btnPi);
            tabCal.Controls.Add(btnSQRT);
            tabCal.Controls.Add(btnFact);
            tabCal.Controls.Add(btnPlus);
            tabCal.Controls.Add(btn3);
            tabCal.Controls.Add(btn2);
            tabCal.Controls.Add(btn1);
            tabCal.Controls.Add(btnCos);
            tabCal.Controls.Add(btnMinus);
            tabCal.Controls.Add(btnSin);
            tabCal.Controls.Add(btn6);
            tabCal.Controls.Add(btn5);
            tabCal.Controls.Add(btn4);
            tabCal.Controls.Add(btnMultiple);
            tabCal.Controls.Add(btn9);
            tabCal.Controls.Add(btn8);
            tabCal.Controls.Add(btn7);
            tabCal.Controls.Add(btnDivide);
            tabCal.Controls.Add(btnClearEntry);
            tabCal.Controls.Add(btn1over);
            tabCal.Controls.Add(btnPercent);
            tabCal.Controls.Add(btnClear);
            tabCal.Controls.Add(radScientific);
            tabCal.Controls.Add(radStandard);
            tabCal.Controls.Add(txtDisplay);
            tabCal.Controls.Add(chkDark);
            tabCal.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabCal.ForeColor = SystemColors.ControlText;
            tabCal.Location = new Point(12, 69);
            tabCal.Margin = new Padding(0);
            tabCal.Name = "tabCal";
            tabCal.Padding = new Padding(3);
            tabCal.Size = new Size(1656, 1225);
            tabCal.TabIndex = 0;
            tabCal.Text = "Calculator";
            tabCal.UseVisualStyleBackColor = true;
            tabCal.Click += tabCal_Click;
            // 
            // btn2SquareX
            // 
            btn2SquareX.BackColor = Color.White;
            btn2SquareX.Location = new Point(1374, 590);
            btn2SquareX.Name = "btn2SquareX";
            btn2SquareX.Size = new Size(272, 157);
            btn2SquareX.TabIndex = 31;
            btn2SquareX.Text = "2^x";
            btn2SquareX.UseVisualStyleBackColor = false;
            btn2SquareX.Click += btn2SquareX_Click;
            // 
            // btnAb
            // 
            btnAb.BackColor = Color.White;
            btnAb.Location = new Point(1374, 748);
            btnAb.Name = "btnAb";
            btnAb.Size = new Size(272, 157);
            btnAb.TabIndex = 32;
            btnAb.Text = "|x|";
            btnAb.UseVisualStyleBackColor = false;
            btnAb.Click += btnAb_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.White;
            btnSquare.Location = new Point(1374, 274);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(272, 157);
            btnSquare.TabIndex = 29;
            btnSquare.Text = "x^2";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnCube
            // 
            btnCube.BackColor = Color.White;
            btnCube.Location = new Point(1374, 432);
            btnCube.Name = "btnCube";
            btnCube.Size = new Size(272, 157);
            btnCube.TabIndex = 30;
            btnCube.Text = "x^3";
            btnCube.UseVisualStyleBackColor = false;
            btnCube.Click += btnCube_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.White;
            btnLog.Location = new Point(1105, 590);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(272, 157);
            btnLog.TabIndex = 33;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.White;
            btnEqual.Location = new Point(17, 1064);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(1088, 157);
            btnEqual.TabIndex = 27;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.Location = new Point(561, 906);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(272, 157);
            btnDot.TabIndex = 26;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += Number;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.Location = new Point(289, 906);
            btn0.Name = "btn0";
            btn0.Size = new Size(272, 157);
            btn0.TabIndex = 25;
            btn0.Text = "     0   ";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Number;
            // 
            // btnE
            // 
            btnE.BackColor = Color.White;
            btnE.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnE.Location = new Point(1374, 906);
            btnE.Name = "btnE";
            btnE.Size = new Size(272, 157);
            btnE.TabIndex = 26;
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.White;
            btnPi.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPi.Location = new Point(1105, 906);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(272, 157);
            btnPi.TabIndex = 28;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += btnPi_Click;
            // 
            // btnSQRT
            // 
            btnSQRT.BackColor = Color.White;
            btnSQRT.Location = new Point(17, 906);
            btnSQRT.Name = "btnSQRT";
            btnSQRT.Size = new Size(272, 157);
            btnSQRT.TabIndex = 24;
            btnSQRT.Text = "√x";
            btnSQRT.UseVisualStyleBackColor = false;
            btnSQRT.Click += btnSQRT_Click;
            // 
            // btnFact
            // 
            btnFact.BackColor = Color.White;
            btnFact.Location = new Point(1105, 748);
            btnFact.Name = "btnFact";
            btnFact.Size = new Size(272, 157);
            btnFact.TabIndex = 27;
            btnFact.Text = "!";
            btnFact.UseVisualStyleBackColor = false;
            btnFact.Click += btnFact_Click_1;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.White;
            btnPlus.Location = new Point(833, 906);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(272, 157);
            btnPlus.TabIndex = 23;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += Operator;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.Location = new Point(561, 748);
            btn3.Name = "btn3";
            btn3.Size = new Size(272, 157);
            btn3.TabIndex = 22;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Number;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.Location = new Point(289, 748);
            btn2.Name = "btn2";
            btn2.Size = new Size(272, 157);
            btn2.TabIndex = 21;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Number;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.Location = new Point(17, 748);
            btn1.Name = "btn1";
            btn1.Size = new Size(272, 157);
            btn1.TabIndex = 20;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Number;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.White;
            btnCos.Location = new Point(1105, 432);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(272, 157);
            btnCos.TabIndex = 25;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += btnCos_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.White;
            btnMinus.Location = new Point(833, 748);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(272, 157);
            btnMinus.TabIndex = 19;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += Operator;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.White;
            btnSin.Location = new Point(1105, 274);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(272, 157);
            btnSin.TabIndex = 24;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += btnSin_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.Location = new Point(561, 590);
            btn6.Name = "btn6";
            btn6.Size = new Size(272, 157);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Number;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.Location = new Point(289, 590);
            btn5.Name = "btn5";
            btn5.Size = new Size(272, 157);
            btn5.TabIndex = 17;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Number;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.Location = new Point(17, 590);
            btn4.Name = "btn4";
            btn4.Size = new Size(272, 157);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Number;
            // 
            // btnMultiple
            // 
            btnMultiple.BackColor = Color.White;
            btnMultiple.Location = new Point(833, 590);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(272, 157);
            btnMultiple.TabIndex = 15;
            btnMultiple.Text = "×";
            btnMultiple.UseVisualStyleBackColor = false;
            btnMultiple.Click += Operator;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.Location = new Point(561, 432);
            btn9.Name = "btn9";
            btn9.Size = new Size(272, 157);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Number;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.Location = new Point(289, 432);
            btn8.Name = "btn8";
            btn8.Size = new Size(272, 157);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Number;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.Location = new Point(17, 433);
            btn7.Name = "btn7";
            btn7.Size = new Size(272, 157);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Number;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.White;
            btnDivide.Location = new Point(833, 432);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(272, 157);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.White;
            btnClearEntry.Location = new Point(289, 274);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(272, 157);
            btnClearEntry.TabIndex = 10;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btn1over
            // 
            btn1over.BackColor = Color.White;
            btn1over.Font = new Font("Wingdings", 12F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btn1over.Location = new Point(833, 274);
            btn1over.Name = "btn1over";
            btn1over.Size = new Size(272, 157);
            btn1over.TabIndex = 9;
            btn1over.Text = "";
            btn1over.UseVisualStyleBackColor = false;
            btn1over.Click += btn1over_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.White;
            btnPercent.Location = new Point(17, 274);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(272, 157);
            btnPercent.TabIndex = 8;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Location = new Point(561, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(272, 157);
            btnClear.TabIndex = 7;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // radScientific
            // 
            radScientific.AutoSize = true;
            radScientific.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radScientific.Location = new Point(312, 216);
            radScientific.Name = "radScientific";
            radScientific.Size = new Size(233, 51);
            radScientific.TabIndex = 3;
            radScientific.Text = "Scientific ";
            radScientific.UseVisualStyleBackColor = true;
            radScientific.CheckedChanged += radScientific_CheckedChanged;
            // 
            // radStandard
            // 
            radStandard.AutoSize = true;
            radStandard.Checked = true;
            radStandard.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radStandard.Location = new Point(31, 216);
            radStandard.Name = "radStandard";
            radStandard.Size = new Size(224, 51);
            radStandard.TabIndex = 2;
            radStandard.TabStop = true;
            radStandard.Text = "Standard";
            radStandard.UseVisualStyleBackColor = true;
            radStandard.CheckedChanged += radStandard_CheckedChanged;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.White;
            txtDisplay.Font = new Font("Gadugi", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(3, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(1102, 194);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // chkDark
            // 
            chkDark.AutoSize = true;
            chkDark.Font = new Font("Gadugi", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDark.Location = new Point(570, 216);
            chkDark.Name = "chkDark";
            chkDark.Size = new Size(263, 51);
            chkDark.TabIndex = 0;
            chkDark.Text = "Dark Mode";
            chkDark.UseVisualStyleBackColor = true;
            chkDark.CheckedChanged += chkDark_CheckedChanged;
            // 
            // tabAbout
            // 
            tabAbout.Controls.Add(lblToday);
            tabAbout.Controls.Add(Date);
            tabAbout.Controls.Add(lblIntro);
            tabAbout.Controls.Add(lblName);
            tabAbout.Controls.Add(pictLogo);
            tabAbout.Controls.Add(pictProfile);
            tabAbout.Location = new Point(12, 69);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(3);
            tabAbout.Size = new Size(1656, 1225);
            tabAbout.TabIndex = 1;
            tabAbout.Text = "About us";
            tabAbout.UseVisualStyleBackColor = true;
            tabAbout.Click += tabAbout_Click;
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Gadugi", 9F);
            lblToday.Location = new Point(349, 1163);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(149, 43);
            lblToday.TabIndex = 7;
            lblToday.Text = "Today is";
            lblToday.Click += lblToday_Click;
            // 
            // Date
            // 
            Date.Font = new Font("Gadugi", 9F);
            Date.Location = new Point(504, 1155);
            Date.Name = "Date";
            Date.Size = new Size(600, 55);
            Date.TabIndex = 6;
            // 
            // lblIntro
            // 
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Gadugi", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntro.Location = new Point(12, 777);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(1083, 48);
            lblIntro.TabIndex = 4;
            lblIntro.Text = "I'm studying Software Engineering in Centennial College";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Gadugi", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(301, 675);
            lblName.Name = "lblName";
            lblName.Size = new Size(484, 48);
            lblName.TabIndex = 3;
            lblName.Text = "Hi I am Xuan Tri Nguyen";
            // 
            // pictLogo
            // 
            pictLogo.Image = (Image)resources.GetObject("pictLogo.Image");
            pictLogo.Location = new Point(6, 3);
            pictLogo.Name = "pictLogo";
            pictLogo.Size = new Size(175, 543);
            pictLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictLogo.TabIndex = 2;
            pictLogo.TabStop = false;
            // 
            // pictProfile
            // 
            pictProfile.Anchor = AnchorStyles.None;
            pictProfile.BackColor = Color.Transparent;
            pictProfile.Image = (Image)resources.GetObject("pictProfile.Image");
            pictProfile.Location = new Point(301, 6);
            pictProfile.Name = "pictProfile";
            pictProfile.Size = new Size(500, 500);
            pictProfile.SizeMode = PictureBoxSizeMode.AutoSize;
            pictProfile.TabIndex = 1;
            pictProfile.TabStop = false;
            pictProfile.Click += pictureBox1_Click_1;
            // 
            // formCal
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 1308);
            Controls.Add(tab);
            Name = "formCal";
            Text = "Calculator";
            Load += formCal_Load;
            tab.ResumeLayout(false);
            tabCal.ResumeLayout(false);
            tabCal.PerformLayout();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage tabCal;
        private CheckBox chkDark;
        private TextBox txtDisplay;
        private RadioButton radScientific;
        private RadioButton radStandard;
        private Button btnClearEntry;
        private Button btnEqual;
        private Button btnDot;
        private Button btn0;
        private Button btnSQRT;
        private Button btnPlus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMinus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMultiple;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDivide;
        private Button btn1over;
        private Button btnPercent;
        private Button btnClear;
        private Button btnPi;
        private Button btnFact;
        private Button btnE;
        private Button btnCos;
        private Button btnSin;
        private Button btnLog;
        private Button btnAb;
        private Button btn2SquareX;
        private Button btnCube;
        private Button btnSquare;
        private TabPage tabAbout;
        private PictureBox pictProfile;
        private Label lblIntro;
        private Label lblName;
        private PictureBox pictLogo;
        private DateTimePicker Date;
        private Label lblToday;
    }
}
