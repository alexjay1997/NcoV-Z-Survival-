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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.timer1.Start();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //progressBar1_Loading.Increment(1);
            progressBar1_Loading.Increment(1+2+1);
            label1.Text ="Loading " + (progressBar1_Loading.Value).ToString() + "%";
            if (progressBar1_Loading.Value==100)
            {

                timer1.Enabled = false;

                Form3 f3 = new Form3();
                this.Hide();
               
                f3.ShowDialog();
              

                this.Close();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Loading_Click(object sender, EventArgs e)
        {

        }
    }
}
