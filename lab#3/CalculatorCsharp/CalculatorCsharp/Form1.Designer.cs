namespace CalculatorCsharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.CButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.labelCO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DisplayTextBox.Location = new System.Drawing.Point(27, 12);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(287, 32);
            this.DisplayTextBox.TabIndex = 0;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CButton.ForeColor = System.Drawing.Color.Red;
            this.CButton.Location = new System.Drawing.Point(233, 90);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(45, 46);
            this.CButton.TabIndex = 2;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PlusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlusButton.BackgroundImage")));
            this.PlusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.ForeColor = System.Drawing.Color.Blue;
            this.PlusButton.Location = new System.Drawing.Point(235, 142);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(45, 46);
            this.PlusButton.TabIndex = 2;
            this.PlusButton.Tag = "+";
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.MinusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinusButton.BackgroundImage")));
            this.MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.ForeColor = System.Drawing.Color.Blue;
            this.MinusButton.Location = new System.Drawing.Point(286, 142);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(45, 46);
            this.MinusButton.TabIndex = 2;
            this.MinusButton.Tag = "-";
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.MultiplyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MultiplyButton.BackgroundImage")));
            this.MultiplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.ForeColor = System.Drawing.Color.Blue;
            this.MultiplyButton.Location = new System.Drawing.Point(235, 194);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(45, 46);
            this.MultiplyButton.TabIndex = 2;
            this.MultiplyButton.Tag = "*";
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DivideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DivideButton.BackgroundImage")));
            this.DivideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivideButton.ForeColor = System.Drawing.Color.Blue;
            this.DivideButton.Location = new System.Drawing.Point(286, 194);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(45, 46);
            this.DivideButton.TabIndex = 2;
            this.DivideButton.Tag = "/";
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.EqualButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EqualButton.BackgroundImage")));
            this.EqualButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualButton.ForeColor = System.Drawing.Color.Blue;
            this.EqualButton.Location = new System.Drawing.Point(248, 298);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(81, 46);
            this.EqualButton.TabIndex = 2;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PowButton
            // 
            this.PowButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PowButton.BackgroundImage")));
            this.PowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowButton.ForeColor = System.Drawing.Color.Blue;
            this.PowButton.Location = new System.Drawing.Point(286, 246);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(45, 46);
            this.PowButton.TabIndex = 2;
            this.PowButton.Text = "^";
            this.PowButton.UseVisualStyleBackColor = false;
            this.PowButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SqrtButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SqrtButton.BackgroundImage")));
            this.SqrtButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SqrtButton.ForeColor = System.Drawing.Color.Blue;
            this.SqrtButton.Location = new System.Drawing.Point(235, 246);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(45, 46);
            this.SqrtButton.TabIndex = 2;
            this.SqrtButton.UseVisualStyleBackColor = false;
            this.SqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEButton.ForeColor = System.Drawing.Color.Red;
            this.CEButton.Location = new System.Drawing.Point(284, 90);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(45, 46);
            this.CEButton.TabIndex = 2;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SevenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SevenButton.BackgroundImage")));
            this.SevenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SevenButton.ForeColor = System.Drawing.Color.Blue;
            this.SevenButton.Location = new System.Drawing.Point(27, 90);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(49, 46);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Tag = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SixButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SixButton.BackgroundImage")));
            this.SixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SixButton.ForeColor = System.Drawing.Color.Blue;
            this.SixButton.Location = new System.Drawing.Point(27, 142);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(49, 46);
            this.SixButton.TabIndex = 1;
            this.SixButton.Tag = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.OneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OneButton.BackgroundImage")));
            this.OneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OneButton.ForeColor = System.Drawing.Color.Blue;
            this.OneButton.Location = new System.Drawing.Point(27, 194);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(49, 46);
            this.OneButton.TabIndex = 1;
            this.OneButton.Tag = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ZeroButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZeroButton.BackgroundImage")));
            this.ZeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZeroButton.ForeColor = System.Drawing.Color.Blue;
            this.ZeroButton.Location = new System.Drawing.Point(27, 246);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(49, 46);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.EightButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EightButton.BackgroundImage")));
            this.EightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EightButton.ForeColor = System.Drawing.Color.Blue;
            this.EightButton.Location = new System.Drawing.Point(82, 90);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(49, 46);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.FiveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FiveButton.BackgroundImage")));
            this.FiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiveButton.ForeColor = System.Drawing.Color.Blue;
            this.FiveButton.Location = new System.Drawing.Point(82, 142);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(49, 46);
            this.FiveButton.TabIndex = 1;
            this.FiveButton.Tag = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.TwoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TwoButton.BackgroundImage")));
            this.TwoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwoButton.ForeColor = System.Drawing.Color.Blue;
            this.TwoButton.Location = new System.Drawing.Point(82, 194);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(49, 46);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Tag = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PlusMinusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlusMinusButton.BackgroundImage")));
            this.PlusMinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlusMinusButton.ForeColor = System.Drawing.Color.Blue;
            this.PlusMinusButton.Location = new System.Drawing.Point(137, 246);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(49, 46);
            this.PlusMinusButton.TabIndex = 1;
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.NineButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NineButton.BackgroundImage")));
            this.NineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NineButton.ForeColor = System.Drawing.Color.Blue;
            this.NineButton.Location = new System.Drawing.Point(137, 90);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(49, 46);
            this.NineButton.TabIndex = 1;
            this.NineButton.Tag = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.FourButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FourButton.BackgroundImage")));
            this.FourButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FourButton.ForeColor = System.Drawing.Color.Blue;
            this.FourButton.Location = new System.Drawing.Point(137, 142);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(49, 46);
            this.FourButton.TabIndex = 1;
            this.FourButton.Tag = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ThreeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThreeButton.BackgroundImage")));
            this.ThreeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThreeButton.ForeColor = System.Drawing.Color.Blue;
            this.ThreeButton.Location = new System.Drawing.Point(137, 194);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(49, 46);
            this.ThreeButton.TabIndex = 1;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DotButton.BackgroundImage")));
            this.DotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DotButton.ForeColor = System.Drawing.Color.Blue;
            this.DotButton.Location = new System.Drawing.Point(82, 246);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(49, 46);
            this.DotButton.TabIndex = 1;
            this.DotButton.Tag = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // labelCO
            // 
            this.labelCO.AutoSize = true;
            this.labelCO.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCO.Location = new System.Drawing.Point(24, 49);
            this.labelCO.Name = "labelCO";
            this.labelCO.Size = new System.Drawing.Size(0, 25);
            this.labelCO.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 386);
            this.Controls.Add(this.labelCO);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.PowButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.DisplayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button PowButton;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Label labelCO;
    }
}

