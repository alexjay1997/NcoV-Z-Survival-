using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace NCOV_SURVIVAL
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            player.URL = "gone-apocalypse.mp3";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Form2 f2 = new Form2();
            this.Hide();
           
            f2.ShowDialog();
           
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Options_Click(object sender, EventArgs e)
        {

            Form_options form_options = new Form_options();
            this.Hide();

            form_options.ShowDialog();

            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
       
            

        }
    }
}
