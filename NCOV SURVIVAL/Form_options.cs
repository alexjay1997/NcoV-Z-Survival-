using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOV_SURVIVAL
{
    public partial class Form_options : Form
    {
        public Form_options()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();

            f1.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
