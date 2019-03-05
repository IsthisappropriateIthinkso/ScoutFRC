using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Autonomous : Form
    {
        int i = 0;

    
    public Autonomous()
        {
            InitializeComponent();
            
        }

        private void BtnNextScreenAutonomous_Click(object sender, EventArgs e)
        {
            DriverControlled form3 = new DriverControlled();
            this.Close();
            form3.Show();
        }

      

        private void rBtnGotHatches_CheckedChanged(object sender, EventArgs e)
        {
            rBtnDidGetLowLeftDownHatch_1.Visible = true;
            rBtnDidGetLowLeftUpHatch_1.Visible = true;
            rBtnDidGetLowMiddleDownHatch_1.Visible = true;
            rBtnDidGetLowMiddleUpHatch_1.Visible = true;
            rBtnDidGetLowRightDownHatch_1.Visible = true;
            rBtnDidGetLowRightUpHatch_1.Visible = true;
            rBtnDidGetLowLeftUpHatch_1.Visible = true;
            rBtnDidGetMediumLeftDownHatch_1.Visible = true;
            rBtnDidGetMediumLeftUpHatch_1.Visible = true;
            rBtnDidGetMediumMiddleDownHatch_1.Visible = true;
            rBtnDidGetMediumRightDownHatch_1.Visible = true;
            rBtnDidGetMediumMiddleUpHatch_1.Visible = true;
            rBtnDidGetMediumRightUpHatch_1.Visible = true;
            rBtnDidGetHighMiddleUpHatch_1.Visible = true;
            rBtnDidGetHighRightDownHatch_1.Visible = true;
            rBtnDidGetHighRightUpHatch_1.Visible = true;
            rBtnDidGetHighLeftDownHatch_1.Visible = true;
            rBtnDidGetHighLeftUpHatch_1.Visible = true;
            rBtnDidGetHighMiddleDownHatch_1.Visible = true;


            rBtnDidGetLowLeftDownCargo_1.Visible = false;
            rBtnDidGetLowLeftUpCargo_1.Visible = false;
            rBtnDidGetLowMiddleDownCargo_1.Visible = false;
            rBtnDidGetLowMiddleUpCargo_1.Visible = false;
            rBtnDidGetLowRightDownCargo_1.Visible = false;
            rBtnDidGetLowRightUpCargo_1.Visible = false;
            rBtnDidGetMediumLeftDownCargo_1.Visible = false;
            rBtnDidGetMediumLeftUpCargo_1.Visible = false;
            rBtnDidGetMediumMiddleDownCargo_1.Visible = false;
            rBtnDidGetMediumMiddleUpCargo_1.Visible = false;
            rBtnDidGetMediumRightDownCargo_1.Visible = false;
            rBtnDidGetMediumRightUpCargo_1.Visible = false;
            rBtnDidGetHighMiddleDownCargo_1.Visible = false;
            rBtnDidGetHighLeftDownCargo_1.Visible = false;
            rBtnDidGetHighLeftUpCargo_1.Visible = false;
            rBtnDidGetHighMiddleUpCargo_1.Visible = false;
            rBtnDidGetHighRightDownCargo_1.Visible = false;
            rBtnDidGetHighRightUpCargo_1.Visible = false;

            rBtnCargo1.Visible = false;// middle part
            rBtnCargo2.Visible = false;
            rBtnCargo3.Visible = false;
            rBtnCargo4.Visible = false;
            rBtnCargo5.Visible = false;
            rBtnCargo6.Visible = false;
            rBtnCargo7.Visible = false;
            rBtnCargo8.Visible = false;

            rBtnHatch1.Visible = true;
            rBtnHatch2.Visible = true;
            rBtnHatch3.Visible = true;
            rBtnHatch4.Visible = true;
            rBtnHatch5.Visible = true;
            rBtnHatch6.Visible = true;
            rBtnHatch7.Visible = true;
            rBtnHatch8.Visible = true;

        }

        private void rBtnGotCargo_CheckedChanged(object sender, EventArgs e)
        {
            rBtnDidGetLowLeftDownCargo_1.Visible = true;
            rBtnDidGetLowLeftUpCargo_1.Visible = true;
            rBtnDidGetLowMiddleDownCargo_1.Visible = true;
            rBtnDidGetLowMiddleUpCargo_1.Visible = true;
            rBtnDidGetLowRightDownCargo_1.Visible = true;
            rBtnDidGetLowRightUpCargo_1.Visible = true;
            rBtnDidGetMediumLeftDownCargo_1.Visible = true;
            rBtnDidGetMediumLeftUpCargo_1.Visible = true;
            rBtnDidGetMediumMiddleDownCargo_1.Visible = true;
            rBtnDidGetMediumMiddleUpCargo_1.Visible = true;
            rBtnDidGetMediumRightDownCargo_1.Visible = true;
            rBtnDidGetMediumRightUpCargo_1.Visible = true;
            rBtnDidGetHighMiddleDownCargo_1.Visible = true;
            rBtnDidGetHighLeftDownCargo_1.Visible = true;
            rBtnDidGetHighLeftUpCargo_1.Visible = true;
            rBtnDidGetHighMiddleUpCargo_1.Visible = true;
            rBtnDidGetHighRightDownCargo_1.Visible = true;
            rBtnDidGetHighRightUpCargo_1.Visible = true;

            rBtnDidGetLowLeftDownHatch_1.Visible = false;
            rBtnDidGetLowLeftUpHatch_1.Visible = false;
            rBtnDidGetLowMiddleDownHatch_1.Visible = false;
            rBtnDidGetLowMiddleUpHatch_1.Visible = false;
            rBtnDidGetLowRightDownHatch_1.Visible = false;
            rBtnDidGetLowRightUpHatch_1.Visible = false;
            rBtnDidGetLowLeftUpHatch_1.Visible = false;
            rBtnDidGetMediumLeftDownHatch_1.Visible = false;
            rBtnDidGetMediumLeftUpHatch_1.Visible = false;
            rBtnDidGetMediumMiddleDownHatch_1.Visible = false;
            rBtnDidGetMediumRightDownHatch_1.Visible = false;
            rBtnDidGetMediumMiddleUpHatch_1.Visible = false;
            rBtnDidGetMediumRightUpHatch_1.Visible = false;
            rBtnDidGetHighMiddleUpHatch_1.Visible = false;
            rBtnDidGetHighRightDownHatch_1.Visible = false;
            rBtnDidGetHighRightUpHatch_1.Visible = false;
            rBtnDidGetHighLeftDownHatch_1.Visible = false;
            rBtnDidGetHighLeftUpHatch_1.Visible = false;
            rBtnDidGetHighMiddleDownHatch_1.Visible = false;

            rBtnCargo1.Visible = true;// middle part
            rBtnCargo2.Visible = true;
            rBtnCargo3.Visible = true;
            rBtnCargo4.Visible = true;
            rBtnCargo5.Visible = true;
            rBtnCargo6.Visible = true;
            rBtnCargo7.Visible = true;
            rBtnCargo8.Visible = true;

            rBtnHatch1.Visible = false;
            rBtnHatch2.Visible = false;
            rBtnHatch3.Visible = false;
            rBtnHatch4.Visible = false;
            rBtnHatch5.Visible = false;
            rBtnHatch6.Visible = false;
            rBtnHatch7.Visible = false;
            rBtnHatch8.Visible = false;


        }

        private void Autonomous_Load(object sender, EventArgs e)
        {
            //did get low, medium, high/ left,middle, right/Up,Down 
            

            rBtnDidGetLowLeftDownHatch_1.Visible = false;
            rBtnDidGetLowLeftUpHatch_1.Visible = false;
            rBtnDidGetLowMiddleDownHatch_1.Visible = false;
            rBtnDidGetLowMiddleUpHatch_1.Visible = false;
            rBtnDidGetLowRightDownHatch_1.Visible = false;
            rBtnDidGetLowRightUpHatch_1.Visible = false;
            rBtnDidGetLowLeftUpHatch_1.Visible = false;
            rBtnDidGetMediumLeftDownHatch_1.Visible = false;
            rBtnDidGetMediumLeftUpHatch_1.Visible = false;
            rBtnDidGetMediumMiddleDownHatch_1.Visible = false;
            rBtnDidGetMediumRightDownHatch_1.Visible = false;
            rBtnDidGetMediumMiddleUpHatch_1.Visible = false;
            rBtnDidGetMediumRightUpHatch_1.Visible = false;
            rBtnDidGetHighMiddleUpHatch_1.Visible = false;
            rBtnDidGetHighRightDownHatch_1.Visible = false;
            rBtnDidGetHighRightUpHatch_1.Visible = false;
            rBtnDidGetHighLeftDownHatch_1.Visible = false;
            rBtnDidGetHighLeftUpHatch_1.Visible = false;
            rBtnDidGetHighMiddleDownHatch_1.Visible = false;




            rBtnDidGetLowLeftDownCargo_1.Visible = false;
            rBtnDidGetLowLeftUpCargo_1.Visible = false;
            rBtnDidGetLowMiddleDownCargo_1.Visible = false;
            rBtnDidGetLowMiddleUpCargo_1.Visible = false;
            rBtnDidGetLowRightDownCargo_1.Visible = false;     
            rBtnDidGetLowRightUpCargo_1.Visible = false;
            rBtnDidGetMediumLeftDownCargo_1.Visible = false;
            rBtnDidGetMediumLeftUpCargo_1.Visible = false;
            rBtnDidGetMediumMiddleDownCargo_1.Visible = false;
            rBtnDidGetMediumMiddleUpCargo_1.Visible = false;
            rBtnDidGetMediumRightDownCargo_1.Visible = false;
            rBtnDidGetMediumRightUpCargo_1.Visible = false;
            rBtnDidGetHighMiddleDownCargo_1.Visible = false;
            rBtnDidGetHighLeftDownCargo_1.Visible = false;
            rBtnDidGetHighLeftUpCargo_1.Visible = false;
            rBtnDidGetHighMiddleUpCargo_1.Visible = false;
            rBtnDidGetHighRightDownCargo_1.Visible = false;
            rBtnDidGetHighRightUpCargo_1.Visible = false;


            rBtnHatch1.Visible = false;
            rBtnHatch2.Visible = false;
            rBtnHatch3.Visible = false;
            rBtnHatch4.Visible = false;
            rBtnHatch5.Visible = false;
            rBtnHatch6.Visible = false;
            rBtnHatch7.Visible = false;
            rBtnHatch8.Visible = false;

            rBtnCargo1.Visible = false;
            rBtnCargo2.Visible = false;
            rBtnCargo3.Visible = false;
            rBtnCargo4.Visible = false;
            rBtnCargo5.Visible = false;
            rBtnCargo6.Visible = false;
            rBtnCargo7.Visible = false;
            rBtnCargo8.Visible = false;

        }

        private void BtnBackScreenAutonomous_Click(object sender, EventArgs e)
        {
            frmRecordLog BackForm = new frmRecordLog(); //frmRecord log is the login screen, or form 1
            this.Close();
            BackForm.Show();
        }
    }
}

