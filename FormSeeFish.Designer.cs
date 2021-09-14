namespace CSC470_P2
{
    partial class FormSeeFish
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
            this.fishPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThrownBack = new System.Windows.Forms.Button();
            this.buttonKeepIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fishPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fishPictureBox
            // 
            this.fishPictureBox.Location = new System.Drawing.Point(30, 26);
            this.fishPictureBox.Name = "fishPictureBox";
            this.fishPictureBox.Size = new System.Drawing.Size(585, 362);
            this.fishPictureBox.TabIndex = 0;
            this.fishPictureBox.TabStop = false;
            this.fishPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(30, 412);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 50);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonThrownBack
            // 
            this.buttonThrownBack.Location = new System.Drawing.Point(248, 412);
            this.buttonThrownBack.Name = "buttonThrownBack";
            this.buttonThrownBack.Size = new System.Drawing.Size(150, 50);
            this.buttonThrownBack.TabIndex = 2;
            this.buttonThrownBack.Text = "Throw It Back";
            this.buttonThrownBack.UseVisualStyleBackColor = true;
            this.buttonThrownBack.Click += new System.EventHandler(this.buttonThrowItBack_Click);
            // 
            // buttonKeepIt
            // 
            this.buttonKeepIt.Location = new System.Drawing.Point(465, 412);
            this.buttonKeepIt.Name = "buttonKeepIt";
            this.buttonKeepIt.Size = new System.Drawing.Size(150, 50);
            this.buttonKeepIt.TabIndex = 3;
            this.buttonKeepIt.Text = "Keep It";
            this.buttonKeepIt.UseVisualStyleBackColor = true;
            this.buttonKeepIt.Click += new System.EventHandler(this.buttonKeepIt_Click);
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 486);
            this.Controls.Add(this.buttonKeepIt);
            this.Controls.Add(this.buttonThrownBack);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.fishPictureBox);
            this.Name = "FormSeeFish";
            this.Text = "FormSeeFish";
            this.Load += new System.EventHandler(this.FormSeeFish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fishPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fishPictureBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonThrownBack;
        private System.Windows.Forms.Button buttonKeepIt;
    }
}