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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void BtnNextScreen_Click(object sender, EventArgs e)
        {
            FRC_Statistics form5 = new FRC_Statistics();
            this.Close();
            form5.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBoxDidGetBackOnPlatform_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxDidGetBackOnPlatform.Checked = true) {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
            }
        }
    }
}
