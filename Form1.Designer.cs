namespace Hunt_Mortgage
{
    partial class MorgageCalculator
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
            this.PrincipalLab = new System.Windows.Forms.Label();
            this.dobPncTxtBx = new System.Windows.Forms.TextBox();
            this.TIYLab = new System.Windows.Forms.Label();
            this.RB15 = new System.Windows.Forms.RadioButton();
            this.RB30 = new System.Windows.Forms.RadioButton();
            this.RBO = new System.Windows.Forms.RadioButton();
            this.dobOTxtBx = new System.Windows.Forms.TextBox();
            this.InterestLab = new System.Windows.Forms.Label();
            this.dobIntrCombo = new System.Windows.Forms.ComboBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.RstBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.monpatLab = new System.Windows.Forms.Label();
            this.FinNumLab = new System.Windows.Forms.Label();
            this.sBadNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrincipalLab
            // 
            this.PrincipalLab.AutoSize = true;
            this.PrincipalLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrincipalLab.Location = new System.Drawing.Point(27, 9);
            this.PrincipalLab.Name = "PrincipalLab";
            this.PrincipalLab.Size = new System.Drawing.Size(82, 20);
            this.PrincipalLab.TabIndex = 0;
            this.PrincipalLab.Text = "Principal:";
            // 
            // dobPncTxtBx
            // 
            this.dobPncTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dobPncTxtBx.Location = new System.Drawing.Point(115, 9);
            this.dobPncTxtBx.Name = "dobPncTxtBx";
            this.dobPncTxtBx.Size = new System.Drawing.Size(100, 20);
            this.dobPncTxtBx.TabIndex = 1;
            // 
            // TIYLab
            // 
            this.TIYLab.AutoSize = true;
            this.TIYLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIYLab.Location = new System.Drawing.Point(27, 48);
            this.TIYLab.Name = "TIYLab";
            this.TIYLab.Size = new System.Drawing.Size(122, 20);
            this.TIYLab.TabIndex = 2;
            this.TIYLab.Text = "Term In Years";
            // 
            // RB15
            // 
            this.RB15.AutoSize = true;
            this.RB15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB15.Location = new System.Drawing.Point(31, 71);
            this.RB15.Name = "RB15";
            this.RB15.Size = new System.Drawing.Size(99, 24);
            this.RB15.TabIndex = 3;
            this.RB15.TabStop = true;
            this.RB15.Text = "15 Years";
            this.RB15.UseVisualStyleBackColor = true;
            // 
            // RB30
            // 
            this.RB30.AutoSize = true;
            this.RB30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB30.Location = new System.Drawing.Point(31, 101);
            this.RB30.Name = "RB30";
            this.RB30.Size = new System.Drawing.Size(99, 24);
            this.RB30.TabIndex = 4;
            this.RB30.TabStop = true;
            this.RB30.Text = "30 Years";
            this.RB30.UseVisualStyleBackColor = true;
            // 
            // RBO
            // 
            this.RBO.AutoSize = true;
            this.RBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBO.Location = new System.Drawing.Point(31, 131);
            this.RBO.Name = "RBO";
            this.RBO.Size = new System.Drawing.Size(87, 24);
            this.RBO.TabIndex = 5;
            this.RBO.TabStop = true;
            this.RBO.Text = "Other...";
            this.RBO.UseVisualStyleBackColor = true;
            this.RBO.CheckedChanged += new System.EventHandler(this.RBO_CheckedChanged);
            // 
            // dobOTxtBx
            // 
            this.dobOTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dobOTxtBx.Location = new System.Drawing.Point(110, 134);
            this.dobOTxtBx.Name = "dobOTxtBx";
            this.dobOTxtBx.Size = new System.Drawing.Size(76, 20);
            this.dobOTxtBx.TabIndex = 6;
            // 
            // InterestLab
            // 
            this.InterestLab.AutoSize = true;
            this.InterestLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestLab.Location = new System.Drawing.Point(27, 169);
            this.InterestLab.Name = "InterestLab";
            this.InterestLab.Size = new System.Drawing.Size(72, 20);
            this.InterestLab.TabIndex = 7;
            this.InterestLab.Text = "Interest";
            // 
            // dobIntrCombo
            // 
            this.dobIntrCombo.DropDownHeight = 75;
            this.dobIntrCombo.FormattingEnabled = true;
            this.dobIntrCombo.IntegralHeight = false;
            this.dobIntrCombo.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.dobIntrCombo.Location = new System.Drawing.Point(110, 168);
            this.dobIntrCombo.MaxDropDownItems = 15;
            this.dobIntrCombo.Name = "dobIntrCombo";
            this.dobIntrCombo.Size = new System.Drawing.Size(39, 21);
            this.dobIntrCombo.TabIndex = 8;
            // 
            // CalcBtn
            // 
            this.CalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtn.Location = new System.Drawing.Point(31, 207);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(184, 50);
            this.CalcBtn.TabIndex = 9;
            this.CalcBtn.Text = "Calculate Payment";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // RstBtn
            // 
            this.RstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RstBtn.Location = new System.Drawing.Point(31, 263);
            this.RstBtn.Name = "RstBtn";
            this.RstBtn.Size = new System.Drawing.Size(88, 50);
            this.RstBtn.TabIndex = 10;
            this.RstBtn.Text = "Reset";
            this.RstBtn.UseVisualStyleBackColor = true;
            this.RstBtn.Click += new System.EventHandler(this.RstBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(127, 263);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(88, 50);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // monpatLab
            // 
            this.monpatLab.AutoSize = true;
            this.monpatLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monpatLab.Location = new System.Drawing.Point(38, 316);
            this.monpatLab.Name = "monpatLab";
            this.monpatLab.Size = new System.Drawing.Size(167, 20);
            this.monpatLab.TabIndex = 12;
            this.monpatLab.Text = "Monthly payment is:";
            // 
            // FinNumLab
            // 
            this.FinNumLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FinNumLab.AutoSize = true;
            this.FinNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinNumLab.Location = new System.Drawing.Point(97, 336);
            this.FinNumLab.Name = "FinNumLab";
            this.FinNumLab.Size = new System.Drawing.Size(43, 20);
            this.FinNumLab.TabIndex = 13;
            this.FinNumLab.Text = "num";
            // 
            // sBadNum
            // 
            this.sBadNum.AutoSize = true;
            this.sBadNum.Location = new System.Drawing.Point(92, 35);
            this.sBadNum.Name = "sBadNum";
            this.sBadNum.Size = new System.Drawing.Size(143, 13);
            this.sBadNum.TabIndex = 14;
            this.sBadNum.Text = "Please input a numeric value";
            this.sBadNum.Visible = false;
            // 
            // MorgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(247, 360);
            this.Controls.Add(this.sBadNum);
            this.Controls.Add(this.FinNumLab);
            this.Controls.Add(this.monpatLab);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RstBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.dobIntrCombo);
            this.Controls.Add(this.InterestLab);
            this.Controls.Add(this.dobOTxtBx);
            this.Controls.Add(this.RBO);
            this.Controls.Add(this.RB30);
            this.Controls.Add(this.RB15);
            this.Controls.Add(this.TIYLab);
            this.Controls.Add(this.dobPncTxtBx);
            this.Controls.Add(this.PrincipalLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MorgageCalculator";
            this.Text = "Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrincipalLab;
        private System.Windows.Forms.TextBox dobPncTxtBx;
        private System.Windows.Forms.Label TIYLab;
        private System.Windows.Forms.RadioButton RB15;
        private System.Windows.Forms.RadioButton RB30;
        private System.Windows.Forms.RadioButton RBO;
        private System.Windows.Forms.TextBox dobOTxtBx;
        private System.Windows.Forms.Label InterestLab;
        private System.Windows.Forms.ComboBox dobIntrCombo;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button RstBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label monpatLab;
        private System.Windows.Forms.Label FinNumLab;
        private System.Windows.Forms.Label sBadNum;
    }
}

