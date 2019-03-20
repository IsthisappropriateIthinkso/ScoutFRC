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
        public class PL
        {
            //I want to capture only the last thing they've checked and send it to Statistics.
        }

        private void PreloadForm_Load(object sender, EventArgs e)
        {
            gBoxSides.Visible = false; //side (a-c) GroupBox
            groupBox2.Visible = true; //Cargo or Hatch Group Box
            rBtn1.Visible = false;
            rBtn2.Visible = false;
            rBtn3.Visible = false;
            rBtn4.Visible = false;
            rBtn5.Visible = false;
            rBtn6.Visible = false;
            rBtn7.Visible = false;
            rBtn8.Visible = false;

            lblCargo1.Visible = false;
            lblCargo2.Visible = false;
            lblCargo3.Visible = false;
            lblCargo4.Visible = false;
            lblCargo5.Visible = false;
            lblCargo6.Visible = false;
            lblCargo7.Visible = false;
            lblCargo8.Visible = false;

            lblHatches1.Visible = false;
            lblHatches2.Visible = false;
            lblHatches3.Visible = false;
            lblHatches4.Visible = false;
            lblHatches5.Visible = false;
            lblHatches6.Visible = false;
            lblHatches7.Visible = false;
            lblHatches8.Visible = false;

        }

        private void rBtnCargo_CheckedChanged(object sender, EventArgs e)
        {
            gBoxSides.Visible = true;

            rBtn1.Visible = false;
            rBtn2.Visible = false;
            rBtn3.Visible = false;
            rBtn4.Visible = false;
            rBtn5.Visible = false;
            rBtn6.Visible = false;
            rBtn7.Visible = false;
            rBtn8.Visible = false;

            lblCargo1.Visible = false;
            lblCargo2.Visible = false;
            lblCargo3.Visible = false;
            lblCargo4.Visible = false;
            lblCargo5.Visible = false;
            lblCargo6.Visible = false;
            lblCargo7.Visible = false;
            lblCargo8.Visible = false;

        }

        private void rBtnHatch_CheckedChanged(object sender, EventArgs e)
        {
            gBoxSides.Visible = true;

            rBtn1.Visible = false;
            rBtn2.Visible = false;
            rBtn3.Visible = false;
            rBtn4.Visible = false;
            rBtn5.Visible = false;
            rBtn6.Visible = false;
            rBtn7.Visible = false;
            rBtn8.Visible = false;

            lblHatches1.Visible = false;
            lblHatches2.Visible = false;
            lblHatches3.Visible = false;
            lblHatches4.Visible = false;
            lblHatches5.Visible = false;
            lblHatches6.Visible = false;
            lblHatches7.Visible = false;
            lblHatches8.Visible = false;

        }

        private void rBtnSideA_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSideA.Checked == true)
            {
                if (rBtnCargo.Checked == true)
                {
                    lblCargo1.Visible = true;
                    lblCargo2.Visible = true;
                    lblCargo3.Visible = true;
                    lblCargo4.Visible = false;
                    lblCargo5.Visible = false;
                    lblCargo6.Visible = false;
                    lblCargo7.Visible = false;
                    lblCargo8.Visible = false;


                    rBtn1.Visible = true;
                    rBtn2.Visible = true;
                    rBtn3.Visible = true;
                    rBtn4.Visible = false;
                    rBtn5.Visible = false;
                    rBtn6.Visible = false;
                    rBtn7.Visible = false;
                    rBtn8.Visible = false;
                }
                if(rBtnHatch.Checked==true)
                {
                    lblHatches1.Visible = true;
                    lblHatches2.Visible = true;
                    lblHatches3.Visible = true;
                    lblHatches4.Visible = false;
                    lblHatches5.Visible = false;
                    lblHatches6.Visible = false;
                    lblHatches7.Visible = false;
                    lblHatches8.Visible = false;

                    rBtn1.Visible = true;
                    rBtn2.Visible = true;
                    rBtn3.Visible = true;
                    rBtn4.Visible = false;
                    rBtn5.Visible = false;
                    rBtn6.Visible = false;
                    rBtn7.Visible = false;
                    rBtn8.Visible = false;
                }
            }          
        }

        private void rBtnSideB_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSideB.Checked == true)
            {
                if (rBtnCargo.Checked == true)
                {
                    lblCargo1.Visible = false;
                    lblCargo2.Visible = false;
                    lblCargo3.Visible = false;
                    lblCargo4.Visible = true;
                    lblCargo5.Visible = true;
                    lblCargo6.Visible = false;
                    lblCargo7.Visible = false;
                    lblCargo8.Visible = false;

                    rBtn1.Visible = false;
                    rBtn2.Visible = false;
                    rBtn3.Visible = false;
                    rBtn4.Visible = true;
                    rBtn5.Visible = true;
                    rBtn6.Visible = false;
                    rBtn7.Visible = false;
                    rBtn8.Visible = false;
                }
                if (rBtnHatch.Checked == true)
                {
                    lblHatches1.Visible = false;
                    lblHatches2.Visible = false;
                    lblHatches3.Visible = false;
                    lblHatches4.Visible = true;
                    lblHatches5.Visible = true;
                    lblHatches6.Visible = false;
                    lblHatches7.Visible = false;
                    lblHatches8.Visible = false;

                    rBtn1.Visible = false;
                    rBtn2.Visible = false;
                    rBtn3.Visible = false;
                    rBtn4.Visible = true;
                    rBtn5.Visible = true;
                    rBtn6.Visible = false;
                    rBtn7.Visible = false;
                    rBtn8.Visible = false;
                }
            }
        }

        private void rBtnSideC_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnSideC.Checked == true)
            {
                if(rBtnCargo.Checked==true)
                {
                    lblCargo1.Visible = false;
                    lblCargo2.Visible = false;
                    lblCargo3.Visible = false;
                    lblCargo4.Visible = false;
                    lblCargo5.Visible = false;
                    lblCargo6.Visible = true;
                    lblCargo7.Visible = true;
                    lblCargo8.Visible = true;

                    rBtn1.Visible = false;
                    rBtn2.Visible = false;
                    rBtn3.Visible = false;
                    rBtn4.Visible = false;
                    rBtn5.Visible = false;
                    rBtn6.Visible = true;
                    rBtn7.Visible = true;
                    rBtn8.Visible = true;
                }
                if (rBtnHatch.Checked == true)
                {
                    lblHatches1.Visible = false;
                    lblHatches2.Visible = false;
                    lblHatches3.Visible = false;
                    lblHatches4.Visible = false;
                    lblHatches5.Visible = false;
                    lblHatches6.Visible = true;
                    lblHatches7.Visible = true;
                    lblHatches8.Visible = true;

                    rBtn1.Visible = false;
                    rBtn2.Visible = false;
                    rBtn3.Visible = false;
                    rBtn4.Visible = false;
                    rBtn5.Visible = false;
                    rBtn6.Visible = true;
                    rBtn7.Visible = true;
                    rBtn8.Visible = true;
                }
            }
        }
    }
}
