namespace WindowsFormsApp1
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.tbMatchNum = new System.Windows.Forms.TextBox();
            this.tbTeamNum = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(71, 107);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 0;
            // 
            // tbEvent
            // 
            this.tbEvent.Location = new System.Drawing.Point(201, 107);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(100, 20);
            this.tbEvent.TabIndex = 1;
            // 
            // tbMatchNum
            // 
            this.tbMatchNum.Location = new System.Drawing.Point(336, 107);
            this.tbMatchNum.Name = "tbMatchNum";
            this.tbMatchNum.Size = new System.Drawing.Size(100, 20);
            this.tbMatchNum.TabIndex = 2;
            // 
            // tbTeamNum
            // 
            this.tbTeamNum.Location = new System.Drawing.Point(472, 107);
            this.tbTeamNum.Name = "tbTeamNum";
            this.tbTeamNum.Size = new System.Drawing.Size(100, 20);
            this.tbTeamNum.TabIndex = 3;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(596, 107);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Record ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Team ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alliance ID";
            // 
            // BtnContinue
            // 
            this.BtnContinue.Location = new System.Drawing.Point(657, 379);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(107, 60);
            this.BtnContinue.TabIndex = 10;
            this.BtnContinue.Text = "CONTINUE";
            this.BtnContinue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 584);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbTeamNum);
            this.Controls.Add(this.tbMatchNum);
            this.Controls.Add(this.tbEvent);
            this.Controls.Add(this.tbID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbEvent;
        private System.Windows.Forms.TextBox tbMatchNum;
        private System.Windows.Forms.TextBox tbTeamNum;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnContinue;
    }
}

