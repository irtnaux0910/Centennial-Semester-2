namespace Gui
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
            btnSin = new Button();
            btnCos = new Button();
            btnOddEven = new Button();
            btnClear = new Button();
            chkDark = new CheckBox();
            lblNumber = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Segoe UI", 10F);
            btnSin.Location = new Point(979, 52);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(140, 140);
            btnSin.TabIndex = 0;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Segoe UI", 10F);
            btnCos.Location = new Point(1165, 52);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(140, 140);
            btnCos.TabIndex = 1;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnOddEven
            // 
            btnOddEven.Font = new Font("Segoe UI", 10F);
            btnOddEven.Location = new Point(979, 223);
            btnOddEven.Name = "btnOddEven";
            btnOddEven.Size = new Size(326, 140);
            btnOddEven.TabIndex = 2;
            btnOddEven.Text = "Odd/Even";
            btnOddEven.UseVisualStyleBackColor = true;
            btnOddEven.Click += btnOddEven_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(979, 391);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(326, 140);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chkDark
            // 
            chkDark.AutoSize = true;
            chkDark.Font = new Font("Segoe UI", 10F);
            chkDark.Location = new Point(168, 188);
            chkDark.Name = "chkDark";
            chkDark.Size = new Size(266, 58);
            chkDark.TabIndex = 4;
            chkDark.Text = "Dark Mode";
            chkDark.UseVisualStyleBackColor = true;
            chkDark.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 10F);
            lblNumber.Location = new Point(168, 290);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(178, 54);
            lblNumber.TabIndex = 5;
            lblNumber.Text = "Number:";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 10F);
            txtResult.ForeColor = Color.Red;
            txtResult.Location = new Point(465, 290);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(360, 61);
            txtResult.TabIndex = 6;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // formCal
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 597);
            Controls.Add(txtResult);
            Controls.Add(lblNumber);
            Controls.Add(chkDark);
            Controls.Add(btnClear);
            Controls.Add(btnOddEven);
            Controls.Add(btnCos);
            Controls.Add(btnSin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formCal";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSin;
        private Button btnCos;
        private Button btnOddEven;
        private Button btnClear;
        private CheckBox chkDark;
        private Label lblNumber;
        private TextBox txtResult;
    }
}
