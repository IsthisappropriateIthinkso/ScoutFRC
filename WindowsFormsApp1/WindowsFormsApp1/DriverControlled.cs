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
        public DriverControlled()
        {
            InitializeComponent();
        }

        private void BtnNextScreenDriverStation_Click(object sender, EventArgs e)
        {
            EndGame form4 = new EndGame();
            this.Close();
            form4.Show();
        }
    }
}
