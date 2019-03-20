namespace WindowsFormsApp1
{
    partial class PreloadForm
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
            this.rBtnSideA = new System.Windows.Forms.RadioButton();
            this.rBtnSideB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnSideC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnCargo = new System.Windows.Forms.RadioButton();
            this.rBtnHatch = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnSideA
            // 
            this.rBtnSideA.AutoSize = true;
            this.rBtnSideA.Location = new System.Drawing.Point(50, 19);
            this.rBtnSideA.Name = "rBtnSideA";
            this.rBtnSideA.Size = new System.Drawing.Size(56, 17);
            this.rBtnSideA.TabIndex = 0;
            this.rBtnSideA.TabStop = true;
            this.rBtnSideA.Text = "Side A";
            this.rBtnSideA.UseVisualStyleBackColor = true;
            // 
            // rBtnSideB
            // 
            this.rBtnSideB.AutoSize = true;
            this.rBtnSideB.Location = new System.Drawing.Point(50, 41);
            this.rBtnSideB.Name = "rBtnSideB";
            this.rBtnSideB.Size = new System.Drawing.Size(56, 17);
            this.rBtnSideB.TabIndex = 1;
            this.rBtnSideB.TabStop = true;
            this.rBtnSideB.Text = "Side B";
            this.rBtnSideB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnSideC);
            this.groupBox1.Controls.Add(this.rBtnSideA);
            this.groupBox1.Controls.Add(this.rBtnSideB);
            this.groupBox1.Location = new System.Drawing.Point(239, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rBtnSideC
            // 
            this.rBtnSideC.AutoSize = true;
            this.rBtnSideC.Location = new System.Drawing.Point(50, 63);
            this.rBtnSideC.Name = "rBtnSideC";
            this.rBtnSideC.Size = new System.Drawing.Size(56, 17);
            this.rBtnSideC.TabIndex = 2;
            this.rBtnSideC.TabStop = true;
            this.rBtnSideC.Text = "Side C";
            this.rBtnSideC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(702, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Side A";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(738, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Side B";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(618, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnCargo);
            this.groupBox2.Controls.Add(this.rBtnHatch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargo Or Hatch";
            // 
            // rBtnCargo
            // 
            this.rBtnCargo.AutoSize = true;
            this.rBtnCargo.Location = new System.Drawing.Point(50, 19);
            this.rBtnCargo.Name = "rBtnCargo";
            this.rBtnCargo.Size = new System.Drawing.Size(53, 17);
            this.rBtnCargo.TabIndex = 0;
            this.rBtnCargo.TabStop = true;
            this.rBtnCargo.Text = "Cargo";
            this.rBtnCargo.UseVisualStyleBackColor = true;
            this.rBtnCargo.CheckedChanged += new System.EventHandler(this.rBtnCargo_CheckedChanged);
            // 
            // rBtnHatch
            // 
            this.rBtnHatch.AutoSize = true;
            this.rBtnHatch.Location = new System.Drawing.Point(50, 41);
            this.rBtnHatch.Name = "rBtnHatch";
            this.rBtnHatch.Size = new System.Drawing.Size(54, 17);
            this.rBtnHatch.TabIndex = 1;
            this.rBtnHatch.TabStop = true;
            this.rBtnHatch.Text = "Hatch";
            this.rBtnHatch.UseVisualStyleBackColor = true;
            this.rBtnHatch.CheckedChanged += new System.EventHandler(this.rBtnHatch_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(705, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(34, 23);
            this.btn1.TabIndex = 6;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(665, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(34, 23);
            this.btn2.TabIndex = 7;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(625, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(34, 23);
            this.btn3.TabIndex = 8;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(529, 278);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(34, 23);
            this.btn4.TabIndex = 9;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(529, 314);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(34, 23);
            this.btn5.TabIndex = 10;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(622, 386);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(34, 23);
            this.btn6.TabIndex = 10;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(665, 386);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(34, 23);
            this.btn7.TabIndex = 11;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(705, 386);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(34, 23);
            this.btn8.TabIndex = 12;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(685, 415);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(103, 32);
            this.btnNextPage.TabIndex = 13;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // PreloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FRC_Field;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PreloadForm";
            this.Text = "PreloadForm";
            this.Load += new System.EventHandler(this.PreloadForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnSideA;
        private System.Windows.Forms.RadioButton rBtnSideB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnSideC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnCargo;
        private System.Windows.Forms.RadioButton rBtnHatch;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnNextPage;
    }
}