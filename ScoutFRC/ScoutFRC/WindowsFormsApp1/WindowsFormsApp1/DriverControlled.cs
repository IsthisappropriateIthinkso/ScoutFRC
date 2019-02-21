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
    public partial class DriverControlled : Form
    {
        int sideALow = 0;
        int sideAMed = 0;
        int sideAHigh = 0;
        int sideBLow = 0;
        int sideBMed = 0;
        int sideBHigh = 0;
        int sideCLow = 0;
        int sideCMed = 0;
        int sideCHigh = 0;

        int sideALow2 = 0;
        int sideAMed2 = 0;
        int sideAHigh2 = 0;
        int sideBLow2 = 0;
        int sideBMed2 = 0;
        int sideBHigh2 = 0;
        int sideCLow2 = 0;
        int sideCMed2 = 0;
        int sideCHigh2 = 0;

        public DriverControlled()
        {
            InitializeComponent();
          
        }

        private void DriverControlled_Load(object sender, EventArgs e)
        {

        }

        private void BtnAttempted_1_Click(object sender, EventArgs e)
        {
            lblAttempted.Text = "0";
            if (rBtnA.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    sideALow = sideALow + 1;
                    lblAttempted.Text = "" + sideALow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    sideAMed = sideAMed + 1;
                    lblAttempted.Text = "" + sideAMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    sideAHigh = sideAHigh + 1;
                    lblAttempted.Text = "" + sideAHigh;
                }
            }
            if (rBtnB.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    sideBLow = sideBLow + 1;
                    lblAttempted.Text = "" + sideBLow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    sideBMed = sideBMed + 1;
                    lblAttempted.Text = "" + sideBMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    sideBHigh = sideBHigh + 1;
                    lblAttempted.Text = "" + sideBHigh;
                }
            }
            if (rBtnC.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    sideCLow = sideCLow + 1;
                    lblAttempted.Text = "" + sideCLow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    sideCMed = sideCMed + 1;
                    lblAttempted.Text = "" + sideCMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    sideCHigh = sideCHigh + 1;
                    lblAttempted.Text = "" + sideCHigh;
                }
            }
        }

        private void lblAttempted_Click(object sender, EventArgs e)
        {

        }

        private void rBtnLow_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA.Checked == true)
            {
                lblAttempted.Text = "" + sideALow;
            }
            else if (rBtnB.Checked == true)
            {
                lblAttempted.Text = "" + sideBLow;
            }
            else if (rBtnC.Checked == true)
            {
                lblAttempted.Text = "" + sideCLow;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    lblAttempted.Text = "" + sideALow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    lblAttempted.Text = "" + sideAMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    lblAttempted.Text = "" + sideAHigh;
                }
            }
            rBtnLow.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHigh.Checked = false;
        }

        private void rBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA.Checked == true)
            {
                lblAttempted.Text = "" + sideAMed;
            }
            else if (rBtnB.Checked == true)
            {
                lblAttempted.Text = "" + sideBMed;
            }
            else if (rBtnC.Checked == true)
            {
                lblAttempted.Text = "" + sideCMed;
            }

        }

        private void rBtnHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA.Checked == true)
            {
                lblAttempted.Text = "" + sideAHigh;
            }
            else if (rBtnB.Checked == true)
            {
                lblAttempted.Text = "" + sideBHigh;
            }
            else if (rBtnC.Checked == true)
            {
                lblAttempted.Text = "" + sideCHigh;
            }
        }

        private void rBtnB_CheckedChanged(object sender, EventArgs e)
        {
            rBtnLow.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHigh.Checked = false;
        }

        private void rBtnC_CheckedChanged(object sender, EventArgs e)
        {
            rBtnLow.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHigh.Checked = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMinus_1_Click(object sender, EventArgs e)
        {
            if (rBtnA.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    sideALow = sideALow - 1;
                    lblAttempted.Text = "" + sideALow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    sideAMed = sideAMed - 1;
                    lblAttempted.Text = "" + sideAMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    sideAHigh = sideAHigh - 1;
                    lblAttempted.Text = "" + sideAHigh;
                }
            }
            if (rBtnB.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    sideBLow = sideBLow - 1;
                    lblAttempted.Text = "" + sideBLow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    sideBMed = sideBMed - 1;
                    lblAttempted.Text = "" + sideBMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    sideBHigh = sideBHigh - 1;
                    lblAttempted.Text = "" + sideBHigh;
                }
            }
            if (rBtnC.Checked == true)
            {
                if (rBtnLow.Checked == true)
                {
                    sideCLow = sideCLow - 1;
                    lblAttempted.Text = "" + sideCLow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    sideCMed = sideCMed - 1;
                    lblAttempted.Text = "" + sideCMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    sideCHigh = sideCHigh - 1;
                    lblAttempted.Text = "" + sideCHigh;
                }
            }
        }

        private void BtnAttempted_2_Click(object sender, EventArgs e)
        {
            lblAttempted2.Text = "0";
            if (rBtnA2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    sideALow2 = sideALow2 + 1;
                    lblAttempted2.Text = "" + sideALow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    sideAMed2 = sideAMed2 + 1;
                    lblAttempted2.Text = "" + sideAMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    sideAHigh2 = sideAHigh2 + 1;
                    lblAttempted2.Text = "" + sideAHigh2;
                }
            }
            if (rBtnB2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    sideBLow2 = sideBLow2 + 1;
                    lblAttempted2.Text = "" + sideBLow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    sideBMed2 = sideBMed2 + 1;
                    lblAttempted2.Text = "" + sideBMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    sideBHigh2 = sideBHigh2 + 1;
                    lblAttempted2.Text = "" + sideBHigh2;
                }
            }
            if (rBtnC2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    sideCLow2 = sideCLow2 + 1;
                    lblAttempted2.Text = "" + sideCLow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    sideCMed2 = sideCMed2 + 1;
                    lblAttempted2.Text = "" + sideCMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    sideCHigh2 = sideCHigh2 + 1;
                    lblAttempted2.Text = "" + sideCHigh2;
                }
            }
        }

        private void rBtnLow2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA2.Checked == true)
            {
                lblAttempted2.Text = "" + sideALow2;
            }
            else if (rBtnB2.Checked == true)
            {
                lblAttempted2.Text = "" + sideBLow2;
            }
            else if (rBtnC2.Checked == true)
            {
                lblAttempted2.Text = "" + sideCLow2;
            }
        }

        private void rBtnA2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    lblAttempted2.Text = "" + sideALow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    lblAttempted2.Text = "" + sideAMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    lblAttempted2.Text = "" + sideAHigh2;
                }
            }
            rBtnLow.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHigh.Checked = false;
        }

        private void rBtnMedium2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA2.Checked == true)
            {
                lblAttempted2.Text = "" + sideAMed2;
            }
            else if (rBtnB2.Checked == true)
            {
                lblAttempted2.Text = "" + sideBMed2;
            }
            else if (rBtnC2.Checked == true)
            {
                lblAttempted2.Text = "" + sideCMed2;
            }
        }

        private void rBtnHigh2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnA2.Checked == true)
            {
                lblAttempted2.Text = "" + sideAHigh2;
            }
            else if (rBtnB2.Checked == true)
            {
                lblAttempted2.Text = "" + sideBHigh2;
            }
            else if (rBtnC2.Checked == true)
            {
                lblAttempted2.Text = "" + sideCHigh2;
            }
        }

        private void rBtnB2_CheckedChanged(object sender, EventArgs e)
        {
            rBtnLow.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHigh.Checked = false;
        }

        private void rBtnC2_CheckedChanged(object sender, EventArgs e)
        {
            rBtnLow.Checked = false;
            rBtnMedium.Checked = false;
            rBtnHigh.Checked = false;
        }

        private void btnMinus_2_Click(object sender, EventArgs e)
        {
            if (rBtnA2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    sideALow2 = sideALow - 1;
                    lblAttempted2.Text = "" + sideALow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    sideAMed2 = sideAMed2 - 1;
                    lblAttempted2.Text = "" + sideAMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    sideAHigh2 = sideAHigh2 - 1;
                    lblAttempted2.Text = "" + sideAHigh2;
                }
            }
            if (rBtnB2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    sideBLow2 = sideBLow2 - 1;
                    lblAttempted2.Text = "" + sideBLow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    sideBMed2 = sideBMed2 - 1;
                    lblAttempted2.Text = "" + sideBMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    sideBHigh2 = sideBHigh2 - 1;
                    lblAttempted2.Text = "" + sideBHigh2;
                }
            }
            if (rBtnC2.Checked == true)
            {
                if (rBtnLow2.Checked == true)
                {
                    sideCLow2 = sideCLow2 - 1;
                    lblAttempted2.Text = "" + sideCLow2;
                }
                else if (rBtnMedium2.Checked == true)
                {
                    sideCMed2 = sideCMed2 - 1;
                    lblAttempted2.Text = "" + sideCMed2;
                }
                else if (rBtnHigh2.Checked == true)
                {
                    sideCHigh2 = sideCHigh2 - 1;
                    lblAttempted2.Text = "" + sideCHigh2;
                }
            }
        }
    }
}
