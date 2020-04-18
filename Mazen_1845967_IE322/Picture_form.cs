using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mazen_1845967_IE322
{
    public partial class Picture_form : Form
    {
        public Picture_form()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:/Users/0001/Desktop/AGFY-Sonic.Mania/KAU_logo.png"); 

            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
