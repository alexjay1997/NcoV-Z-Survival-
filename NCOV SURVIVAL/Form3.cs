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
    public partial class Form3 : Form
    {
        


        WindowsMediaPlayer playerSound = new WindowsMediaPlayer();
        public Form3()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            playerSound.URL = "gone-apocalypse.mp3";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            playerSound.controls.play();
        }


        // ------------ start variables -------

        bool goUp; //player go up
        bool goDown; //player go up
        bool goLeft; //player go up
        bool goRight; //player go up

        string facing = "up"; //used to guide the bullets

        int playerHealth = 100;

        int speed = 20;
        int ammo = 20;
        int zombieSpeed = 5;

        int score = 0;

        bool gameOver = false;
        Random rnd = new Random();

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            texthealth.Text = "health";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void playAgain_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            this.Hide();

            f1.ShowDialog();

            this.Close();
        }

        // end variables



        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;

            }


            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;

            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;

            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;

            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                shoot(facing);

            }

            if (ammo == 5 || ammo ==8)
            {
                DropAmmo();

            }

            


        }

        private void gameEngine(object sender, EventArgs e)
        {

            //health
            if (playerHealth > 1)
            {
                progressBar2.Value = Convert.ToInt32(playerHealth);

            }

            

            else
            {
                player.Image = Properties.Resources.dead;
                timer1.Stop();
                gameOver = true;
                label_gameOver.Visible = true;
                playAgain.Visible = true;//play again button

            }

            // end health

            labelAmmo.Text = "Ammo:" + ammo;
            labelKills.Text = "Kills: " + score;
            texthealth.Text = Convert.ToString(playerHealth);//text or health label here!!


            

            if (goLeft && player.Left > 0)

            {
                player.Left -= speed;

            }

            if (goRight && player.Left + player.Width < 930)
            {

                player.Left += speed;

            }

            if (goUp && player.Top > 60)
            {
                player.Top -= speed;

            
            }

            if (goDown && player.Top + player.Height < 700)
            {
                player.Top += speed;

                
            }

            foreach (Control x in this.Controls)
            {


                if (x is PictureBox && x.Tag == "medikit")

                {



                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));

                        ((PictureBox)x).Dispose();
                        playerHealth += 30;

                        if (playerHealth > 100) {
                         //   this.Controls.Remove(((PictureBox)x));
                            playerHealth = 100;
                            ((PictureBox)x).Dispose();



                        }

                        
                    }



                }

                if (x is PictureBox && x.Tag == "ammo")

                {

                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));

                        ((PictureBox)x).Dispose();
                        ammo += 7;


                    }

                }

                if (x is PictureBox && x.Tag == "bullet")
                {


                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)

                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }


                }

                if (x is PictureBox && x.Tag == "zombie")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealth -= 1; // if zombie hits the player then minus the health by 1
                    }

                    if (playerHealth == 70)
                    {
                        DropMedikit();

                    }

                    // move zombie towards  the player picturebox

                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }

                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }


                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }

                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }

                    
                    
                    
                }


                foreach (Control j in this.Controls)
                { 
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                        {

                        if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                            score++;
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            makeZombies();

                            }
                    
                         }
                
                }
            }

        }
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, 890);
            ammo.Top = rnd.Next(50, 600);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();

            return;

        }
        private void DropMedikit()
        {
            PictureBox medikit = new PictureBox();
            medikit.Image = Properties.Resources.medikit;
            medikit.SizeMode = PictureBoxSizeMode.AutoSize;
            medikit.Left = rnd.Next(10, 890);
            medikit.Top = rnd.Next(50, 600);
            medikit.Tag = "medikit";
            this.Controls.Add(medikit);
            medikit.BringToFront();
            player.BringToFront();

        }

        private void shoot(string direct)
        { 
         bullet shoot =  new bullet();
            shoot.direction = direct;

            shoot.bulletLeft = player.Left + (player.Width / 2);
            shoot.bulletTop = player.Top + (player.Height / 2);
            shoot.mkBullet(this);


        }
        private void makeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            //zombie left

            zombie.Top = rnd.Next(0, 800);

            //zombie top

            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(zombie);
            player.BringToFront();




        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void labelAmmo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
