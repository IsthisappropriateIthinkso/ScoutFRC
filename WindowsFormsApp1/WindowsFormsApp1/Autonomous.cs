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

        public event EventHandler CheckedChanged;
        
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
            /* main summary
            preload is the screen used for loading up cargo or hatches in the middle part of the field before 
            the autonomous. So from autonomous, there is a back button to go to preload.
            */
            Preload BackFormPreload = new Preload(); //frmRecord log is the login screen, or form 1
            this.Close();
            BackFormPreload.Show();
        }


        
        public void rBtnGotHatches_CheckedChanged(object sender, EventArgs e)
        {
            
            /* main summary
            ..if they clicked the radio button (got hatches) only hatches are visible
            .. same thing for cargo, if they click the cargo button, then only cargo is available.

            cb means it's in the middle in this function, otherwise it's somewhere else.
            */

            cbHatch_1.Visible = true;
            cbHatch_2.Visible = true;
            cbHatch_3.Visible = true;
            cbHatch_4.Visible = true; 
            cbHatch_5.Visible = true;
            cbHatch_6.Visible = true;
            cbHatch_7.Visible = true;
            cbHatch_8.Visible = true;

            clBoxHatches_1.Visible = true;
            clBoxHatches_2.Visible = true;
            clBoxHatches_3.Visible = true;
            clBoxHatches_4.Visible = true;
            clBoxHatches_5.Visible = true;
            clBoxHatches_6.Visible = true;

            cbCargo_1.Visible = false;
            cbCargo_2.Visible = false;
            cbCargo_3.Visible = false;
            cbCargo_4.Visible = false;
            cbCargo_5.Visible = false;
            cbCargo_6.Visible = false;
            cbCargo_7.Visible = false;
            cbCargo_8.Visible = false;

 

            clBoxCargo_1.Visible = false;
            clBoxCargo_2.Visible = false;
            clBoxCargo_3.Visible = false;
            clBoxCargo_4.Visible = false;
            clBoxCargo_5.Visible = false;
            clBoxCargo_6.Visible = false;
        }

        private void Autonomous_Load(object sender, EventArgs e)
        {
            /* main summary
             Everything starts invisible until I know if they got a hatch or cargo
             
            ..this is the loading screen, so this just shows them what I want to show. when the autonomous form loads
             */

            cbCargo_1.Visible = false;
            cbCargo_2.Visible = false;
            cbCargo_3.Visible = false;
            cbCargo_4.Visible = false;
            cbCargo_5.Visible = false;
            cbCargo_6.Visible = false;
            cbCargo_7.Visible = false;
            cbCargo_8.Visible = false;

            cbHatch_1.Visible = false;
            cbHatch_2.Visible = false;
            cbHatch_3.Visible = false;
            cbHatch_4.Visible = false;
            cbHatch_5.Visible = false;
            cbHatch_6.Visible = false;
            cbHatch_7.Visible = false;
            cbHatch_8.Visible = false;

            //Outter Rockets invisible
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

        public void rBtnGotCargo_CheckedChanged(object sender, EventArgs e)
        {


            cbCargo_1.Visible = true;
            cbCargo_2.Visible = true;
            cbCargo_3.Visible = true;
            cbCargo_4.Visible = true;
            cbCargo_5.Visible = true;
            cbCargo_6.Visible = true;
            cbCargo_7.Visible = true;
            cbCargo_8.Visible = true;

            cbHatch_1.Visible = false;
            cbHatch_2.Visible = false;
            cbHatch_3.Visible = false;
            cbHatch_4.Visible = false;
            cbHatch_5.Visible = false;
            cbHatch_6.Visible = false;
            cbHatch_7.Visible = false;
            cbHatch_8.Visible = false;


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

        private void MyCheckedChanged(object sender, EventArgs e)
        {
            /* main summary
          Everytime the check is changed I want a method of adding all the amount of checkboxes checked.
           */

            cbCargo_1.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_2.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_3.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_4.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_5.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_6.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_7.CheckedChanged += new EventHandler(MyCheckedChanged);
            cbCargo_8.CheckedChanged += new EventHandler(MyCheckedChanged);

            /* main summary
           Num Cargo is supposed to be translating the cargo into a number, so that I can get it to 
           not accumulate anymore after two. It needs to be a number, so I can do logic with it. 
           Same with hatches
           */

            var NumCargo1 = cbCargo_1.Checked ? 1 : 0;
            var NumCargo2 = cbCargo_2.Checked ? 1 : 0;
            var NumCargo3 = cbCargo_3.Checked ? 1 : 0;
            var NumCargo4 = cbCargo_4.Checked ? 1 : 0;
            var NumCargo5 = cbCargo_5.Checked ? 1 : 0;
            var NumCargo6 = cbCargo_6.Checked ? 1 : 0;
            var NumCargo7 = cbCargo_7.Checked ? 1 : 0;
            var NumCargo8 = cbCargo_8.Checked ? 1 : 0;

            var NumHatch1 = cbHatch_1.Checked ? 1 : 0;
            var NumHatch2 = cbHatch_2.Checked ? 1 : 0;
            var NumHatch3 = cbHatch_3.Checked ? 1 : 0;
            var NumHatch4 = cbHatch_4.Checked ? 1 : 0;
            var NumHatch5 = cbHatch_5.Checked ? 1 : 0;
            var NumHatch6 = cbHatch_6.Checked ? 1 : 0;
            var NumHatch7 = cbHatch_7.Checked ? 1 : 0;
            var NumHatch8 = cbHatch_8.Checked ? 1 : 0;


            CheckBox checkBox = sender as CheckBox;
        }
    }
}