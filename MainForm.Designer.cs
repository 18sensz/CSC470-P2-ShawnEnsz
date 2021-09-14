namespace CSC470_P2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.walleyeRadioButton = new System.Windows.Forms.RadioButton();
            this.perchRadioButton = new System.Windows.Forms.RadioButton();
            this.crappieRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.walleyeRadioButton);
            this.groupBox1.Controls.Add(this.perchRadioButton);
            this.groupBox1.Controls.Add(this.crappieRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a fish to see";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.walleyeRadioButton.AutoSize = true;
            this.walleyeRadioButton.Location = new System.Drawing.Point(3, 62);
            this.walleyeRadioButton.Name = "radioButton3";
            this.walleyeRadioButton.Size = new System.Drawing.Size(63, 17);
            this.walleyeRadioButton.TabIndex = 2;
            this.walleyeRadioButton.TabStop = true;
            this.walleyeRadioButton.Text = "Walleye";
            this.walleyeRadioButton.UseVisualStyleBackColor = true;
            this.walleyeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.perchRadioButton.AutoSize = true;
            this.perchRadioButton.Location = new System.Drawing.Point(3, 39);
            this.perchRadioButton.Name = "radioButton2";
            this.perchRadioButton.Size = new System.Drawing.Size(53, 17);
            this.perchRadioButton.TabIndex = 1;
            this.perchRadioButton.TabStop = true;
            this.perchRadioButton.Text = "Perch";
            this.perchRadioButton.UseVisualStyleBackColor = true;
            this.perchRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.crappieRadioButton.AutoSize = true;
            this.crappieRadioButton.Location = new System.Drawing.Point(3, 16);
            this.crappieRadioButton.Name = "radioButton1";
            this.crappieRadioButton.Size = new System.Drawing.Size(61, 17);
            this.crappieRadioButton.TabIndex = 0;
            this.crappieRadioButton.TabStop = true;
            this.crappieRadioButton.Text = "Crappie";
            this.crappieRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "See Fish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton walleyeRadioButton;
        private System.Windows.Forms.RadioButton perchRadioButton;
        private System.Windows.Forms.RadioButton crappieRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}