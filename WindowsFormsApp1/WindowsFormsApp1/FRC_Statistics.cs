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
    public partial class FRC_Statistics : Form
    {
        public FRC_Statistics()
        {
            InitializeComponent();
            int totalHatches = 0;
            int totalHatches2 = 0;

            if (WindowsFormsApp1.gb.valuesDC.sideALowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAMedS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAHighS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBLowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBMedS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBHighS == true)
            {
                totalHatches = totalHatches + 1;
            }

            if (WindowsFormsApp1.gb.valuesDC.sideALowS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAMedS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAHighS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBLowS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBMedS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBHighS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }

            int totalCargo = WindowsFormsApp1.gb.valuesDC.cargoHighS + WindowsFormsApp1.gb.valuesDC.cargoMedS + WindowsFormsApp1.gb.valuesDC.cargoLowS;
            lblCargoTotal.Text = "Rocket 1 cargo: " + totalCargo;
            lblHatchesTotal.Text = "Rocket 1 hatches: " + totalHatches;

            int totalCargo2 = WindowsFormsApp1.gb.valuesDC.cargoHighS2 + WindowsFormsApp1.gb.valuesDC.cargoMedS2 + WindowsFormsApp1.gb.valuesDC.cargoLowS2;
            lblCargoTotal2.Text = "Rocket 2 cargo: " + totalCargo2;
            lblHatchesTotal2.Text = "Rocket 2 hatches: " + totalHatches2;
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            frmRecordLog form1 = new frmRecordLog();
            this.Close();
            form1.Visible=true;
        }

        private void FRC_Statistics_Load(object sender, EventArgs e)
        {

        }

        private void lblCargoHigh_Click(object sender, EventArgs e)
        {

        }
    }
}
