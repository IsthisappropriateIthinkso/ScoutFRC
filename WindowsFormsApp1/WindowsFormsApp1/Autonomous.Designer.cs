namespace WindowsFormsApp1
{
    partial class Autonomous
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
            this.components = new System.ComponentModel.Container();
            this.BtnNextScreenAutonomous = new System.Windows.Forms.Button();
            this.cBoxAutonomousPlatform = new System.Windows.Forms.CheckBox();
            this.rBtnGotHatches = new System.Windows.Forms.RadioButton();
            this.rBtnGotCargo = new System.Windows.Forms.RadioButton();
            this.gBoxGotHatchesOrCargo = new System.Windows.Forms.GroupBox();
            this.BtnBackScreenAutonomous = new System.Windows.Forms.Button();
            this.WaitTimer = new System.Windows.Forms.Timer(this.components);
            this.clBoxHatches_1 = new System.Windows.Forms.CheckedListBox();
            this.clBoxHatches_2 = new System.Windows.Forms.CheckedListBox();
            this.clBoxHatches_3 = new System.Windows.Forms.CheckedListBox();
            this.clBoxCargo_1 = new System.Windows.Forms.CheckedListBox();
            this.clBoxCargo_2 = new System.Windows.Forms.CheckedListBox();
            this.clBoxCargo_3 = new System.Windows.Forms.CheckedListBox();
            this.clBoxCargo_4 = new System.Windows.Forms.CheckedListBox();
            this.clBoxCargo_5 = new System.Windows.Forms.CheckedListBox();
            this.clBoxCargo_6 = new System.Windows.Forms.CheckedListBox();
            this.clBoxHatches_4 = new System.Windows.Forms.CheckedListBox();
            this.clBoxHatches_5 = new System.Windows.Forms.CheckedListBox();
            this.clBoxHatches_6 = new System.Windows.Forms.CheckedListBox();
            this.lblTimerCountdownToNextPick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHatch_1 = new System.Windows.Forms.CheckBox();
            this.cbHatch_2 = new System.Windows.Forms.CheckBox();
            this.cbHatch_3 = new System.Windows.Forms.CheckBox();
            this.cbHatch_5 = new System.Windows.Forms.CheckBox();
            this.cbHatch_4 = new System.Windows.Forms.CheckBox();
            this.cbHatch_6 = new System.Windows.Forms.CheckBox();
            this.cbHatch_7 = new System.Windows.Forms.CheckBox();
            this.cbHatch_8 = new System.Windows.Forms.CheckBox();
            this.cbCargo_1 = new System.Windows.Forms.CheckBox();
            this.cbCargo_2 = new System.Windows.Forms.CheckBox();
            this.cbCargo_3 = new System.Windows.Forms.CheckBox();
            this.cbCargo_4 = new System.Windows.Forms.CheckBox();
            this.cbCargo_5 = new System.Windows.Forms.CheckBox();
            this.cbCargo_6 = new System.Windows.Forms.CheckBox();
            this.cbCargo_7 = new System.Windows.Forms.CheckBox();
            this.cbCargo_8 = new System.Windows.Forms.CheckBox();
            this.gBoxGotHatchesOrCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNextScreenAutonomous
            // 
            this.BtnNextScreenAutonomous.Location = new System.Drawing.Point(114, 545);
            this.BtnNextScreenAutonomous.Name = "BtnNextScreenAutonomous";
            this.BtnNextScreenAutonomous.Size = new System.Drawing.Size(68, 49);
            this.BtnNextScreenAutonomous.TabIndex = 16;
            this.BtnNextScreenAutonomous.Text = "Next Screen";
            this.BtnNextScreenAutonomous.UseVisualStyleBackColor = true;
            this.BtnNextScreenAutonomous.Click += new System.EventHandler(this.BtnNextScreenAutonomous_Click);
            // 
            // cBoxAutonomousPlatform
            // 
            this.cBoxAutonomousPlatform.Location = new System.Drawing.Point(232, 278);
            this.cBoxAutonomousPlatform.Name = "cBoxAutonomousPlatform";
            this.cBoxAutonomousPlatform.Size = new System.Drawing.Size(116, 49);
            this.cBoxAutonomousPlatform.TabIndex = 19;
            this.cBoxAutonomousPlatform.Text = "Autonomous Got Off Platform";
            this.cBoxAutonomousPlatform.UseVisualStyleBackColor = true;
            // 
            // rBtnGotHatches
            // 
            this.rBtnGotHatches.AutoSize = true;
            this.rBtnGotHatches.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rBtnGotHatches.Location = new System.Drawing.Point(42, 28);
            this.rBtnGotHatches.Name = "rBtnGotHatches";
            this.rBtnGotHatches.Size = new System.Drawing.Size(85, 17);
            this.rBtnGotHatches.TabIndex = 21;
            this.rBtnGotHatches.TabStop = true;
            this.rBtnGotHatches.Text = "Got Hatches";
            this.rBtnGotHatches.UseVisualStyleBackColor = false;
            this.rBtnGotHatches.CheckedChanged += new System.EventHandler(this.rBtnGotHatches_CheckedChanged);
            // 
            // rBtnGotCargo
            // 
            this.rBtnGotCargo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rBtnGotCargo.Location = new System.Drawing.Point(42, 62);
            this.rBtnGotCargo.Name = "rBtnGotCargo";
            this.rBtnGotCargo.Size = new System.Drawing.Size(85, 17);
            this.rBtnGotCargo.TabIndex = 40;
            this.rBtnGotCargo.TabStop = true;
            this.rBtnGotCargo.Text = "Got Cargo";
            this.rBtnGotCargo.UseVisualStyleBackColor = false;
            this.rBtnGotCargo.CheckedChanged += new System.EventHandler(this.rBtnGotCargo_CheckedChanged);
            // 
            // gBoxGotHatchesOrCargo
            // 
            this.gBoxGotHatchesOrCargo.Controls.Add(this.rBtnGotHatches);
            this.gBoxGotHatchesOrCargo.Controls.Add(this.rBtnGotCargo);
            this.gBoxGotHatchesOrCargo.Location = new System.Drawing.Point(20, 241);
            this.gBoxGotHatchesOrCargo.Name = "gBoxGotHatchesOrCargo";
            this.gBoxGotHatchesOrCargo.Size = new System.Drawing.Size(162, 100);
            this.gBoxGotHatchesOrCargo.TabIndex = 86;
            this.gBoxGotHatchesOrCargo.TabStop = false;
            // 
            // BtnBackScreenAutonomous
            // 
            this.BtnBackScreenAutonomous.Location = new System.Drawing.Point(39, 545);
            this.BtnBackScreenAutonomous.Name = "BtnBackScreenAutonomous";
            this.BtnBackScreenAutonomous.Size = new System.Drawing.Size(68, 49);
            this.BtnBackScreenAutonomous.TabIndex = 103;
            this.BtnBackScreenAutonomous.Text = "Back Screen";
            this.BtnBackScreenAutonomous.UseVisualStyleBackColor = true;
            this.BtnBackScreenAutonomous.Click += new System.EventHandler(this.BtnBackScreenAutonomous_Click);
            // 
            // WaitTimer
            // 
            this.WaitTimer.Interval = 5000;
            // 
            // clBoxHatches_1
            // 
            this.clBoxHatches_1.FormattingEnabled = true;
            this.clBoxHatches_1.Items.AddRange(new object[] {
            "Low Hatch",
            "Medium Hatch",
            "High Hatch"});
            this.clBoxHatches_1.Location = new System.Drawing.Point(441, 48);
            this.clBoxHatches_1.Name = "clBoxHatches_1";
            this.clBoxHatches_1.Size = new System.Drawing.Size(95, 49);
            this.clBoxHatches_1.TabIndex = 104;
            // 
            // clBoxHatches_2
            // 
            this.clBoxHatches_2.FormattingEnabled = true;
            this.clBoxHatches_2.Items.AddRange(new object[] {
            "Low Hatch",
            "Medium Hatch",
            "High Hatch"});
            this.clBoxHatches_2.Location = new System.Drawing.Point(544, 117);
            this.clBoxHatches_2.Name = "clBoxHatches_2";
            this.clBoxHatches_2.Size = new System.Drawing.Size(95, 49);
            this.clBoxHatches_2.TabIndex = 105;
            // 
            // clBoxHatches_3
            // 
            this.clBoxHatches_3.FormattingEnabled = true;
            this.clBoxHatches_3.Items.AddRange(new object[] {
            "Low Hatch",
            "Medium Hatch",
            "High Hatch"});
            this.clBoxHatches_3.Location = new System.Drawing.Point(644, 48);
            this.clBoxHatches_3.Name = "clBoxHatches_3";
            this.clBoxHatches_3.Size = new System.Drawing.Size(95, 49);
            this.clBoxHatches_3.TabIndex = 106;
            // 
            // clBoxCargo_1
            // 
            this.clBoxCargo_1.FormattingEnabled = true;
            this.clBoxCargo_1.Items.AddRange(new object[] {
            "Low Cargo",
            "Medium Cargo",
            "High Cargo"});
            this.clBoxCargo_1.Location = new System.Drawing.Point(441, 48);
            this.clBoxCargo_1.Name = "clBoxCargo_1";
            this.clBoxCargo_1.Size = new System.Drawing.Size(95, 49);
            this.clBoxCargo_1.TabIndex = 107;
            // 
            // clBoxCargo_2
            // 
            this.clBoxCargo_2.FormattingEnabled = true;
            this.clBoxCargo_2.Items.AddRange(new object[] {
            "Low Cargo",
            "Medium Cargo",
            "High Cargo"});
            this.clBoxCargo_2.Location = new System.Drawing.Point(544, 117);
            this.clBoxCargo_2.Name = "clBoxCargo_2";
            this.clBoxCargo_2.Size = new System.Drawing.Size(95, 49);
            this.clBoxCargo_2.TabIndex = 108;
            // 
            // clBoxCargo_3
            // 
            this.clBoxCargo_3.FormattingEnabled = true;
            this.clBoxCargo_3.Items.AddRange(new object[] {
            "Low Cargo",
            "Medium Cargo",
            "High Cargo"});
            this.clBoxCargo_3.Location = new System.Drawing.Point(644, 48);
            this.clBoxCargo_3.Name = "clBoxCargo_3";
            this.clBoxCargo_3.Size = new System.Drawing.Size(95, 49);
            this.clBoxCargo_3.TabIndex = 109;
            // 
            // clBoxCargo_4
            // 
            this.clBoxCargo_4.FormattingEnabled = true;
            this.clBoxCargo_4.Items.AddRange(new object[] {
            "Low Cargo",
            "Medium Cargo",
            "High Cargo"});
            this.clBoxCargo_4.Location = new System.Drawing.Point(441, 519);
            this.clBoxCargo_4.Name = "clBoxCargo_4";
            this.clBoxCargo_4.Size = new System.Drawing.Size(95, 49);
            this.clBoxCargo_4.TabIndex = 110;
            // 
            // clBoxCargo_5
            // 
            this.clBoxCargo_5.FormattingEnabled = true;
            this.clBoxCargo_5.Items.AddRange(new object[] {
            "Low Cargo",
            "Medium Cargo",
            "High Cargo"});
            this.clBoxCargo_5.Location = new System.Drawing.Point(544, 438);
            this.clBoxCargo_5.Name = "clBoxCargo_5";
            this.clBoxCargo_5.Size = new System.Drawing.Size(95, 49);
            this.clBoxCargo_5.TabIndex = 111;
            // 
            // clBoxCargo_6
            // 
            this.clBoxCargo_6.FormattingEnabled = true;
            this.clBoxCargo_6.Items.AddRange(new object[] {
            "Low Cargo",
            "Medium Cargo",
            "High Cargo"});
            this.clBoxCargo_6.Location = new System.Drawing.Point(650, 524);
            this.clBoxCargo_6.Name = "clBoxCargo_6";
            this.clBoxCargo_6.Size = new System.Drawing.Size(95, 49);
            this.clBoxCargo_6.TabIndex = 112;
            // 
            // clBoxHatches_4
            // 
            this.clBoxHatches_4.FormattingEnabled = true;
            this.clBoxHatches_4.Items.AddRange(new object[] {
            "Low Hatch",
            "Medium Hatch",
            "High Hatch"});
            this.clBoxHatches_4.Location = new System.Drawing.Point(440, 519);
            this.clBoxHatches_4.Name = "clBoxHatches_4";
            this.clBoxHatches_4.Size = new System.Drawing.Size(95, 49);
            this.clBoxHatches_4.TabIndex = 113;
            // 
            // clBoxHatches_5
            // 
            this.clBoxHatches_5.FormattingEnabled = true;
            this.clBoxHatches_5.Items.AddRange(new object[] {
            "Low Hatch",
            "Medium Hatch",
            "High Hatch"});
            this.clBoxHatches_5.Location = new System.Drawing.Point(544, 438);
            this.clBoxHatches_5.Name = "clBoxHatches_5";
            this.clBoxHatches_5.Size = new System.Drawing.Size(95, 49);
            this.clBoxHatches_5.TabIndex = 114;
            // 
            // clBoxHatches_6
            // 
            this.clBoxHatches_6.FormattingEnabled = true;
            this.clBoxHatches_6.Items.AddRange(new object[] {
            "Low Hatch",
            "Medium Hatch",
            "High Hatch"});
            this.clBoxHatches_6.Location = new System.Drawing.Point(650, 524);
            this.clBoxHatches_6.Name = "clBoxHatches_6";
            this.clBoxHatches_6.Size = new System.Drawing.Size(95, 49);
            this.clBoxHatches_6.TabIndex = 115;
            // 
            // lblTimerCountdownToNextPick
            // 
            this.lblTimerCountdownToNextPick.Location = new System.Drawing.Point(59, 60);
            this.lblTimerCountdownToNextPick.Name = "lblTimerCountdownToNextPick";
            this.lblTimerCountdownToNextPick.Size = new System.Drawing.Size(100, 23);
            this.lblTimerCountdownToNextPick.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Wait Timer";
            // 
            // cbHatch_1
            // 
            this.cbHatch_1.Location = new System.Drawing.Point(716, 202);
            this.cbHatch_1.Name = "cbHatch_1";
            this.cbHatch_1.Size = new System.Drawing.Size(60, 17);
            this.cbHatch_1.TabIndex = 126;
            this.cbHatch_1.Text = "Hatch ";
            this.cbHatch_1.UseVisualStyleBackColor = true;
            // 
            // cbHatch_2
            // 
            this.cbHatch_2.AutoSize = true;
            this.cbHatch_2.Location = new System.Drawing.Point(652, 202);
            this.cbHatch_2.Name = "cbHatch_2";
            this.cbHatch_2.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_2.TabIndex = 127;
            this.cbHatch_2.Text = "Hatch";
            this.cbHatch_2.UseVisualStyleBackColor = true;
            // 
            // cbHatch_3
            // 
            this.cbHatch_3.AutoSize = true;
            this.cbHatch_3.Location = new System.Drawing.Point(585, 202);
            this.cbHatch_3.Name = "cbHatch_3";
            this.cbHatch_3.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_3.TabIndex = 128;
            this.cbHatch_3.Text = "Hatch";
            this.cbHatch_3.UseVisualStyleBackColor = true;
            // 
            // cbHatch_5
            // 
            this.cbHatch_5.AutoSize = true;
            this.cbHatch_5.Location = new System.Drawing.Point(487, 316);
            this.cbHatch_5.Name = "cbHatch_5";
            this.cbHatch_5.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_5.TabIndex = 129;
            this.cbHatch_5.Text = "Hatch";
            this.cbHatch_5.UseVisualStyleBackColor = true;
            // 
            // cbHatch_4
            // 
            this.cbHatch_4.AutoSize = true;
            this.cbHatch_4.Location = new System.Drawing.Point(486, 280);
            this.cbHatch_4.Name = "cbHatch_4";
            this.cbHatch_4.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_4.TabIndex = 129;
            this.cbHatch_4.Text = "Hatch";
            this.cbHatch_4.UseVisualStyleBackColor = true;
            // 
            // cbHatch_6
            // 
            this.cbHatch_6.AutoSize = true;
            this.cbHatch_6.Location = new System.Drawing.Point(585, 388);
            this.cbHatch_6.Name = "cbHatch_6";
            this.cbHatch_6.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_6.TabIndex = 130;
            this.cbHatch_6.Text = "Hatch";
            this.cbHatch_6.UseVisualStyleBackColor = true;
            // 
            // cbHatch_7
            // 
            this.cbHatch_7.AutoSize = true;
            this.cbHatch_7.Location = new System.Drawing.Point(657, 388);
            this.cbHatch_7.Name = "cbHatch_7";
            this.cbHatch_7.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_7.TabIndex = 131;
            this.cbHatch_7.Text = "Hatch";
            this.cbHatch_7.UseVisualStyleBackColor = true;
            // 
            // cbHatch_8
            // 
            this.cbHatch_8.AutoSize = true;
            this.cbHatch_8.Location = new System.Drawing.Point(730, 388);
            this.cbHatch_8.Name = "cbHatch_8";
            this.cbHatch_8.Size = new System.Drawing.Size(55, 17);
            this.cbHatch_8.TabIndex = 132;
            this.cbHatch_8.Text = "Hatch";
            this.cbHatch_8.UseVisualStyleBackColor = true;
            // 
            // cbCargo_1
            // 
            this.cbCargo_1.Location = new System.Drawing.Point(716, 202);
            this.cbCargo_1.Name = "cbCargo_1";
            this.cbCargo_1.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_1.TabIndex = 133;
            this.cbCargo_1.Text = "Cargo";
            this.cbCargo_1.UseVisualStyleBackColor = true;
            // 
            // cbCargo_2
            // 
            this.cbCargo_2.Location = new System.Drawing.Point(651, 202);
            this.cbCargo_2.Name = "cbCargo_2";
            this.cbCargo_2.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_2.TabIndex = 134;
            this.cbCargo_2.Text = "Cargo";
            this.cbCargo_2.UseVisualStyleBackColor = true;
            // 
            // cbCargo_3
            // 
            this.cbCargo_3.Location = new System.Drawing.Point(585, 202);
            this.cbCargo_3.Name = "cbCargo_3";
            this.cbCargo_3.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_3.TabIndex = 135;
            this.cbCargo_3.Text = "Cargo";
            this.cbCargo_3.UseVisualStyleBackColor = true;
            // 
            // cbCargo_4
            // 
            this.cbCargo_4.Location = new System.Drawing.Point(487, 280);
            this.cbCargo_4.Name = "cbCargo_4";
            this.cbCargo_4.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_4.TabIndex = 136;
            this.cbCargo_4.Text = "Cargo";
            this.cbCargo_4.UseVisualStyleBackColor = true;
            // 
            // cbCargo_5
            // 
            this.cbCargo_5.Location = new System.Drawing.Point(486, 316);
            this.cbCargo_5.Name = "cbCargo_5";
            this.cbCargo_5.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_5.TabIndex = 137;
            this.cbCargo_5.Text = "Cargo";
            this.cbCargo_5.UseVisualStyleBackColor = true;
            // 
            // cbCargo_6
            // 
            this.cbCargo_6.Location = new System.Drawing.Point(580, 388);
            this.cbCargo_6.Name = "cbCargo_6";
            this.cbCargo_6.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_6.TabIndex = 138;
            this.cbCargo_6.Text = "Cargo";
            this.cbCargo_6.UseVisualStyleBackColor = true;
            // 
            // cbCargo_7
            // 
            this.cbCargo_7.Location = new System.Drawing.Point(657, 388);
            this.cbCargo_7.Name = "cbCargo_7";
            this.cbCargo_7.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_7.TabIndex = 139;
            this.cbCargo_7.Text = "Cargo";
            this.cbCargo_7.UseVisualStyleBackColor = true;
            // 
            // cbCargo_8
            // 
            this.cbCargo_8.Location = new System.Drawing.Point(730, 388);
            this.cbCargo_8.Name = "cbCargo_8";
            this.cbCargo_8.Size = new System.Drawing.Size(60, 17);
            this.cbCargo_8.TabIndex = 140;
            this.cbCargo_8.Text = "Cargo";
            this.cbCargo_8.UseVisualStyleBackColor = true;
            // 
            // Autonomous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FRC_Field;
            this.ClientSize = new System.Drawing.Size(828, 606);
            this.Controls.Add(this.cbCargo_8);
            this.Controls.Add(this.cbCargo_7);
            this.Controls.Add(this.cbCargo_6);
            this.Controls.Add(this.cbCargo_5);
            this.Controls.Add(this.cbCargo_4);
            this.Controls.Add(this.cbCargo_3);
            this.Controls.Add(this.cbCargo_2);
            this.Controls.Add(this.cbCargo_1);
            this.Controls.Add(this.cbHatch_8);
            this.Controls.Add(this.cbHatch_7);
            this.Controls.Add(this.cbHatch_6);
            this.Controls.Add(this.cbHatch_4);
            this.Controls.Add(this.cbHatch_5);
            this.Controls.Add(this.cbHatch_3);
            this.Controls.Add(this.cbHatch_2);
            this.Controls.Add(this.cbHatch_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimerCountdownToNextPick);
            this.Controls.Add(this.clBoxCargo_5);
            this.Controls.Add(this.clBoxCargo_4);
            this.Controls.Add(this.clBoxHatches_6);
            this.Controls.Add(this.clBoxHatches_5);
            this.Controls.Add(this.clBoxHatches_4);
            this.Controls.Add(this.clBoxCargo_6);
            this.Controls.Add(this.clBoxCargo_3);
            this.Controls.Add(this.clBoxCargo_2);
            this.Controls.Add(this.clBoxCargo_1);
            this.Controls.Add(this.clBoxHatches_3);
            this.Controls.Add(this.clBoxHatches_2);
            this.Controls.Add(this.clBoxHatches_1);
            this.Controls.Add(this.BtnBackScreenAutonomous);
            this.Controls.Add(this.gBoxGotHatchesOrCargo);
            this.Controls.Add(this.cBoxAutonomousPlatform);
            this.Controls.Add(this.BtnNextScreenAutonomous);
            this.Name = "Autonomous";
            this.Text = "Autonomous";
            this.Load += new System.EventHandler(this.Autonomous_Load);
            this.gBoxGotHatchesOrCargo.ResumeLayout(false);
            this.gBoxGotHatchesOrCargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnNextScreenAutonomous;
        private System.Windows.Forms.CheckBox cBoxAutonomousPlatform;
        private System.Windows.Forms.RadioButton rBtnGotHatches;
        private System.Windows.Forms.RadioButton rBtnGotCargo;
        private System.Windows.Forms.GroupBox gBoxGotHatchesOrCargo;
        private System.Windows.Forms.Button BtnBackScreenAutonomous;
        private System.Windows.Forms.Timer WaitTimer;
        private System.Windows.Forms.CheckedListBox clBoxHatches_1;
        private System.Windows.Forms.CheckedListBox clBoxHatches_2;
        private System.Windows.Forms.CheckedListBox clBoxHatches_3;
        private System.Windows.Forms.CheckedListBox clBoxCargo_1;
        private System.Windows.Forms.CheckedListBox clBoxCargo_2;
        private System.Windows.Forms.CheckedListBox clBoxCargo_3;
        private System.Windows.Forms.CheckedListBox clBoxCargo_4;
        private System.Windows.Forms.CheckedListBox clBoxCargo_5;
        private System.Windows.Forms.CheckedListBox clBoxCargo_6;
        private System.Windows.Forms.CheckedListBox clBoxHatches_4;
        private System.Windows.Forms.CheckedListBox clBoxHatches_5;
        private System.Windows.Forms.CheckedListBox clBoxHatches_6;
        private System.Windows.Forms.Label lblTimerCountdownToNextPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHatch_1;
        private System.Windows.Forms.CheckBox cbHatch_2;
        private System.Windows.Forms.CheckBox cbHatch_3;
        private System.Windows.Forms.CheckBox cbHatch_5;
        private System.Windows.Forms.CheckBox cbHatch_4;
        private System.Windows.Forms.CheckBox cbHatch_6;
        private System.Windows.Forms.CheckBox cbHatch_7;
        private System.Windows.Forms.CheckBox cbHatch_8;
        private System.Windows.Forms.CheckBox cbCargo_1;
        private System.Windows.Forms.CheckBox cbCargo_2;
        private System.Windows.Forms.CheckBox cbCargo_3;
        private System.Windows.Forms.CheckBox cbCargo_4;
        private System.Windows.Forms.CheckBox cbCargo_5;
        private System.Windows.Forms.CheckBox cbCargo_6;
        private System.Windows.Forms.CheckBox cbCargo_7;
        private System.Windows.Forms.CheckBox cbCargo_8;
    }
}