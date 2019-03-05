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
    public partial class gb : Form
    {
        // All ints below are for the misses
        int sideALow = 0;
        int sideAMed = 0;
        int sideAHigh = 0;
        int sideBLow = 0;
        int sideBMed = 0;
        int sideBHigh = 0;
        int cargoHigh = 0;
        int cargoMed = 0;
        int cargoLow = 0;

        int sideALow2 = 0;
        int sideAMed2 = 0;
        int sideAHigh2 = 0;
        int sideBLow2 = 0;
        int sideBMed2 = 0;
        int sideBHigh2 = 0;
        int cargoHigh2 = 0;
        int cargoMed2 = 0;
        int cargoLow2 = 0;

        // Below are for successful
        Boolean sideALowS = false;
        Boolean sideAMedS = false;
        Boolean sideAHighS = false;
        Boolean sideBLowS = false;
        Boolean sideBMedS = false;
        Boolean sideBHighS = false;
        int cargoHighS = 0;
        int cargoMedS = 0;
        int cargoLowS = 0;



        public gb()
        {
            InitializeComponent();
          
        }

        private void DriverControlled_Load(object sender, EventArgs e)
        {

        }

        private void BtnAttempted_1_Click(object sender, EventArgs e)
        {
                if (rBtnLow.Checked == true)
                {
                    lblAttempted.Text = "" + sideALow;
                    sideALow = sideALow + 1;
                }
                else if (rBtnMedium.Checked == true)
                {
                    lblAttempted.Text = "" + sideAMed;
                    sideAMed = sideAMed + 1;
                }
                else if (rBtnHigh.Checked == true)
                {
                    lblAttempted.Text = "" + sideAHigh;
                    sideAHigh = sideAHigh + 1;
                }
            
        }
        

        private void lblAttempted_Click(object sender, EventArgs e)
        {

        }

        private void rBtnLow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + sideALow;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                lblAttempted.Text = "";
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

        private void BtnNextScreenDriverStation_Click(object sender, EventArgs e)
        {
            EndGame form4 = new EndGame();
            this.Close();
            form4.Show();
        }

        private void BtnMinus_1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowTop.Checked == true)
                {
                    lblAttempted.Text = "" + cargoLow;
                    cargoLow = cargoLow - 1;
                }
                else if (rBtnMediumTop.Checked == true)
                {
                     lblAttempted.Text = "" + cargoMed;
                    cargoMed = cargoMed - 1;
                }
                else if (rBtnHighTop.Checked == true)
                {
                    lblAttempted.Text = "" + cargoHigh;
                    cargoHigh = cargoHigh - 1;                    
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        lblAttempted.Text = "" + sideALow;
                        sideALow = sideALow - 1;
                        
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideAMed;
                        sideAMed = sideAMed - 1;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideAHigh;
                        sideAHigh = sideAHigh - 1;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBLow;
                        sideBLow = sideBLow - 1;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBMed;
                        sideBMed = sideBMed - 1;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBHigh;
                        sideBHigh = sideBHigh - 1;
                    }
                }
            }
        }

        private void rBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + sideAMed;
        }

        private void rBtnHigh_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + sideAHigh;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowTop.Checked == true)
                {                  
                    cargoLow = cargoLow + 1;
                    lblAttempted.Text = "" + cargoLow;
                }
                else if (rBtnMediumTop.Checked == true)
                {                    
                    cargoMed = cargoMed + 1;
                    lblAttempted.Text = "" + cargoMed;
                }
                else if (rBtnHighTop.Checked == true)
                {                   
                    cargoHigh = cargoHigh + 1;
                    lblAttempted.Text = "" + cargoHigh;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        
                        sideALow = sideALow + 1;
                        lblAttempted.Text = "" + sideALow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        
                        sideAMed = sideAMed + 1;
                        lblAttempted.Text = "" + sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        
                        sideAHigh = sideAHigh + 1;
                        lblAttempted.Text = "" + sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBLow;
                        sideBLow = sideBLow + 1;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBMed;
                        sideBMed = sideBMed + 1;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBHigh;
                        sideBHigh = sideBHigh + 1;
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            rBtnHighTop.Checked = false;
            rBtnMediumTop.Checked = false;
            rBtnLowTop.Checked = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rBtnRocket.Checked == true)
            {
                gbSideTop.Visible = true;
                groupBox4.Visible = true;
                groupBox2.Visible = true;
                gbHeightTop.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                lblAttempted.Visible = true;
                lblAttempted2.Visible = true;
                BtnMinus1.Visible = true;
                btnMinus2.Visible = true;
                btnAdd1.Visible = true;
                btnAdd2.Visible = true;
                cBoxSuccessfulCargo.Visible = false;
                cBoxHatchesSuccessful.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRocket.Checked == true)
            {
                gbSideTop.Visible = false;
                groupBox4.Visible = false;
                gbHeightTop.Visible = true;
                groupBox2.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                lblAttempted.Visible = true;
                lblAttempted2.Visible = true;
                BtnMinus1.Visible = true;
                btnMinus2.Visible = true;
                btnAdd1.Visible = true;
                btnAdd2.Visible = true;
                cBoxSuccessfulCargo.Visible = true;
                cBoxHatchesSuccessful.Visible = false;
                lblAttempted2.Text = "";
                lblAttempted.Text = "";
            }
        }

        private void rBtnLowTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + cargoLow;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + sideALow;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + sideBLow;
                }
            }
        }

        private void rBtnMediumTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + cargoMed;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + sideAMed;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + sideBMed;
                }
            }
        }

        private void rBtnHighTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + cargoHigh;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + sideAHigh;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + sideBHigh;
                }
            }
        }

        private void lblAttempted2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowLow.Checked == true)
                {
                    cargoLow2 = cargoLow2 + 1;
                    lblAttempted2.Text = "" + cargoLow2;
                }
                else if (rBtnMediumLow.Checked == true)
                {
                    cargoMed2 = cargoMed2 + 1;
                    lblAttempted2.Text = "" + cargoMed2;
                }
                else if (rBtnHighLow.Checked == true)
                {
                    cargoHigh2 = cargoHigh2 + 1;
                    lblAttempted2.Text = "" + cargoHigh2;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {

                        sideALow2 = sideALow2 + 1;
                        lblAttempted2.Text = "" + sideALow2;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {

                        sideAMed2 = sideAMed2 + 1;
                        lblAttempted2.Text = "" + sideAMed2;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {

                        sideAHigh2 = sideAHigh2 + 1;
                        lblAttempted2.Text = "" + sideAHigh2;
                    }
                }
                else if (btnBLow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideBLow2;
                        sideBLow2 = sideBLow2 + 1;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideBMed2;
                        sideBMed2 = sideBMed2 + 1;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideBHigh2;
                        sideBHigh2 = sideBHigh2 + 1;
                    }
                }
            }
        }

        private void btnBTop_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            rBtnHighTop.Checked = false;
            rBtnMediumTop.Checked = false;
            rBtnLowTop.Checked = false;
        }

        private void btnALow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted2.Text = "";
            rBtnHighLow.Checked = false;
            rBtnMediumLow.Checked = false;
            rBtnLowLow.Checked = false;
        }

        private void btnBLow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted2.Text = "";
            rBtnHighLow.Checked = false;
            rBtnMediumLow.Checked = false;
            rBtnLowLow.Checked = false;
        }

        private void rBtnLowLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + cargoLow2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + sideALow2;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted2.Text = "" + sideBLow2;
                }
            }
        }

        private void rBtnMediumLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + cargoMed2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + sideAMed2;
                }
                if (btnBLow.Checked == true)
                {
                    lblAttempted2.Text = "" + sideBMed2;
                }
            }
        }

        private void rBtnHighLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + cargoHigh2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + sideAHigh2;
                }
                if (btnBLow.Checked == true)
                {
                    lblAttempted2.Text = "" + sideBHigh2;
                }
            }
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowLow.Checked == true)
                {
                    lblAttempted2.Text = "" + cargoLow2;
                    cargoLow2 = cargoLow2 - 1;
                }
                else if (rBtnMediumLow.Checked == true)
                {
                    lblAttempted2.Text = "" + cargoMed2;
                    cargoMed2 = cargoMed2 - 1;
                }
                else if (rBtnHighLow.Checked == true)
                {
                    lblAttempted2.Text = "" + cargoHigh2;
                    cargoHigh2 = cargoHigh2 - 1;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {

                        lblAttempted2.Text = "" + sideALow2;
                        sideALow2 = sideALow2 - 1;

                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideAMed2;
                        sideAMed2 = sideAMed2 - 1;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        lblAttempted.Text = "" + sideAHigh2;
                        sideAHigh2 = sideAHigh2 - 1;
                    }
                }
                else if (btnBLow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideBLow2;
                        sideBLow2 = sideBLow2 - 1;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideBMed2;
                        sideBMed2 = sideBMed2 - 1;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        lblAttempted2.Text = "" + sideBHigh2;
                        sideBHigh2 = sideBHigh2 - 1;
                    }
                }
            }
        }

        private void rBtnRocket_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void rBtnShuttle_CheckedChanged(object sender, EventArgs e)
        {
            gbSideTop.Visible = false;
            groupBox4.Visible = false;
            gbHeightTop.Visible = false;
            groupBox2.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            lblAttempted.Visible = false;
            lblAttempted2.Visible = false;
            BtnMinus1.Visible = false;
            btnMinus2.Visible = false;
            btnAdd1.Visible = false;
            btnAdd2.Visible = false;
            lblAttempted2.Text = "";
            lblAttempted.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cBoxHatchesSuccessful.Visible = false;
            cBoxSuccessfulCargo.Visible = false;
        }

        private void cBoxHatch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        sideALow = sideALow + 1;
                        lblAttempted.Text = "" + sideALow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {

                        sideAMed = sideAMed + 1;
                        lblAttempted.Text = "" + sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {

                        sideAHigh = sideAHigh + 1;
                        lblAttempted.Text = "" + sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBLow;
                        sideBLow = sideBLow + 1;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBMed;
                        sideBMed = sideBMed + 1;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        lblAttempted.Text = "" + sideBHigh;
                        sideBHigh = sideBHigh + 1;
                    }
                }
            }
        }

        private void cBoxSuccessfulCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
