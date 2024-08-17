namespace GUI
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
            btnMultiple = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btnDarkLight = new Button();
            lblFirst = new Label();
            lblSecond = new Label();
            lblResult = new Label();
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnMultiple
            // 
            btnMultiple.BackColor = Color.White;
            btnMultiple.Font = new Font("Segoe UI", 24F);
            btnMultiple.Location = new Point(1008, 200);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(140, 140);
            btnMultiple.TabIndex = 4;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = false;
            btnMultiple.Click += btnMultiple_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.White;
            btnMinus.Font = new Font("Segoe UI", 24F);
            btnMinus.Location = new Point(1180, 21);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(140, 140);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.White;
            btnPlus.Font = new Font("Segoe UI", 24F);
            btnPlus.Location = new Point(1008, 21);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(140, 140);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.White;
            btnDivide.Font = new Font("Segoe UI", 24F);
            btnDivide.Location = new Point(1180, 200);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(140, 140);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1008, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(312, 132);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDarkLight
            // 
            btnDarkLight.BackColor = Color.White;
            btnDarkLight.Font = new Font("Segoe UI", 20F);
            btnDarkLight.Location = new Point(108, 35);
            btnDarkLight.Name = "btnDarkLight";
            btnDarkLight.Size = new Size(820, 126);
            btnDarkLight.TabIndex = 1;
            btnDarkLight.Text = "Switch to Dark";
            btnDarkLight.UseVisualStyleBackColor = false;
            btnDarkLight.Click += btnDarkLight_Click;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Microsoft Sans Serif", 18F);
            lblFirst.Location = new Point(47, 184);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(471, 82);
            lblFirst.TabIndex = 6;
            lblFirst.Text = "First Number:";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Microsoft Sans Serif", 18F);
            lblSecond.Location = new Point(47, 280);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(574, 82);
            lblSecond.TabIndex = 7;
            lblSecond.Text = "Second Number:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 18F);
            lblResult.Location = new Point(47, 380);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(240, 82);
            lblResult.TabIndex = 8;
            lblResult.Text = "Result";
            // 
            // txtFirst
            // 
            txtFirst.Cursor = Cursors.IBeam;
            txtFirst.Font = new Font("Microsoft Sans Serif", 16F);
            txtFirst.ForeColor = Color.Red;
            txtFirst.Location = new Point(630, 196);
            txtFirst.Multiline = true;
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(298, 70);
            txtFirst.TabIndex = 9;
            txtFirst.TextChanged += txtFirst_TextChanged;
            // 
            // txtSecond
            // 
            txtSecond.Cursor = Cursors.IBeam;
            txtSecond.Font = new Font("Microsoft Sans Serif", 16F);
            txtSecond.ForeColor = Color.Red;
            txtSecond.Location = new Point(630, 292);
            txtSecond.Multiline = true;
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(298, 70);
            txtSecond.TabIndex = 10;
            // 
            // txtResult
            // 
            txtResult.Cursor = Cursors.IBeam;
            txtResult.Font = new Font("Microsoft Sans Serif", 16F);
            txtResult.ForeColor = Color.Red;
            txtResult.Location = new Point(630, 392);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(298, 70);
            txtResult.TabIndex = 11;
            // 
            // formCal
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1364, 597);
            Controls.Add(txtResult);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Controls.Add(lblResult);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            Controls.Add(btnDarkLight);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiple);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formCal";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMultiple;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnClear;
        private Button btnDarkLight;
        private Label lblFirst;
        private Label lblSecond;
        private Label lblResult;
        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
    }
}
