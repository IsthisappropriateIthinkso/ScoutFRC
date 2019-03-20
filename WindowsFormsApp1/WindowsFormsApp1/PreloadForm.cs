using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PreloadForm : Form
    {
        public PreloadForm()
        {
            InitializeComponent();

        }

        private void PreloadForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

        }

        private void rBtnCargo_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnSideA.Checked==true)
            {
                btn1.Text = "cargo";
            }
            if (rBtnSideB.Checked == true)
            {
                btn2.Text = "cargo";
            }
            if (rBtnSideA.Checked == true)
            {
                btn3.Text = "cargo";
            }
            if(rBtnSideC.Checked==true)
            {
                btn4.Text = "cargo";
            }

            if (rBtnSideB.Checked == true)
            {
                btn6.Text = "cargo";
            }

            if (rBtnSideB.Checked == true)
            {
                btn7.Text = "cargo";
            }

            if (rBtnSideB.Checked == true)
            {
                btn8.Text = "cargo";
            }


        }

        private void rBtnHatch_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSideA.Checked == true)
            {
                btn1.Text = "Hatches";
            }
            if (rBtnSideB.Checked == true)
            {
                btn2.Text = "Hatches";
            }
            if (rBtnSideA.Checked == true)
            {
                btn3.Text = "Hatches";
            }
            if (rBtnSideC.Checked == true)
            {
                btn4.Text = "Hatches";
            }

            if (rBtnSideB.Checked == true)
            {
                btn6.Text = "Hatches";
            }

            if (rBtnSideB.Checked == true)
            {
                btn7.Text = "Hatches";
            }

            if (rBtnSideB.Checked == true)
            {
                btn8.Text = "Hatches";
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Autonomous form2 = new Autonomous();
            form2.Show();
            this.Visible = false;
        }
    }
}
