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

      
     

        private void BtnBackScreenAutonomous_Click(object sender, EventArgs e)
        {
            Preload BackFormPreload = new Preload(); //frmRecord log is the login screen, or form 1
            this.Close();
            BackFormPreload.Show();
        }

        private void rBtnGotHatches_CheckedChanged(object sender, EventArgs e)
        {
            clBoxHatches_1.Visible = true;
            clBoxHatches_2.Visible = true;
            clBoxHatches_3.Visible = true;
            clBoxHatches_4.Visible = true;
            clBoxHatches_5.Visible = true;
            clBoxHatches_6.Visible = true;

            clBoxCargo_1.Visible = false;
            clBoxCargo_2.Visible = false;
            clBoxCargo_3.Visible = false;
            clBoxCargo_4.Visible = false;
            clBoxCargo_5.Visible = false;
            clBoxCargo_6.Visible = false;
        }

        private void Autonomous_Load(object sender, EventArgs e)
        {   
            clBoxHatchOrCargoMiddle1.Visible = false;
            clBoxHatchOrCargoMiddle2.Visible = false;
            clBoxHatchOrCargoMiddle3.Visible = false;
            clBoxHatchOrCargoMiddle4.Visible = false;
            clBoxHatchOrCargoMiddle5.Visible = false;
            clBoxHatchOrCargoMiddle6.Visible = false;
            clBoxHatchOrCargoMiddle7.Visible = false;
            clBoxHatchOrCargoMiddle8.Visible = false;

            clBoxCargo_1.Visible = false;
            clBoxCargo_4.Visible = false;
            clBoxCargo_5.Visible = false;
            clBoxCargo_6.Visible = false;
            clBoxCargo_3.Visible = false;
            clBoxCargo_2.Visible = false;

            clBoxHatches_1.Visible = false;
            clBoxHatches_2.Visible = false;
            clBoxHatches_3.Visible = false;
            clBoxHatches_4.Visible = false;
            clBoxHatches_5.Visible = false;
            clBoxHatches_6.Visible = false;
        }

        private void rBtnGotCargo_CheckedChanged(object sender, EventArgs e)
        {
            clBoxCargo_1.Visible = true;
            clBoxCargo_2.Visible = true;
            clBoxCargo_3.Visible = true;
            clBoxCargo_4.Visible = true;
            clBoxCargo_5.Visible = true;
            clBoxCargo_6.Visible = true;

            clBoxHatches_1.Visible = false;
            clBoxHatches_2.Visible = false;
            clBoxHatches_3.Visible = false;
            clBoxHatches_4.Visible = false;
            clBoxHatches_5.Visible = false;
            clBoxHatches_6.Visible = false;
        }
    }
}