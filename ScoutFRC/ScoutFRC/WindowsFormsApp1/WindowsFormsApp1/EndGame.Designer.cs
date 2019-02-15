namespace WindowsFormsApp1
{
    partial class EndGame
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
            this.cBoxDidGetBackOnPlatform = new System.Windows.Forms.CheckBox();
            this.BtnNextScreen = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cBoxDidGetBackOnPlatform
            // 
            this.cBoxDidGetBackOnPlatform.Location = new System.Drawing.Point(208, 262);
            this.cBoxDidGetBackOnPlatform.Name = "cBoxDidGetBackOnPlatform";
            this.cBoxDidGetBackOnPlatform.Size = new System.Drawing.Size(143, 93);
            this.cBoxDidGetBackOnPlatform.TabIndex = 0;
            this.cBoxDidGetBackOnPlatform.Text = "Robot reached the habitat";
            this.cBoxDidGetBackOnPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBoxDidGetBackOnPlatform.UseVisualStyleBackColor = true;
            this.cBoxDidGetBackOnPlatform.CheckedChanged += new System.EventHandler(this.cBoxDidGetBackOnPlatform_CheckedChanged);
            // 
            // BtnNextScreen
            // 
            this.BtnNextScreen.Location = new System.Drawing.Point(679, 382);
            this.BtnNextScreen.Name = "BtnNextScreen";
            this.BtnNextScreen.Size = new System.Drawing.Size(115, 56);
            this.BtnNextScreen.TabIndex = 1;
            this.BtnNextScreen.Text = "Next Screen";
            this.BtnNextScreen.UseVisualStyleBackColor = true;
            this.BtnNextScreen.Click += new System.EventHandler(this.BtnNextScreen_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(391, 276);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "High Stage";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(391, 299);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Low Stage";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(403, 322);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Floor";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FRC_Field;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnNextScreen);
            this.Controls.Add(this.cBoxDidGetBackOnPlatform);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxDidGetBackOnPlatform;
        private System.Windows.Forms.Button BtnNextScreen;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}