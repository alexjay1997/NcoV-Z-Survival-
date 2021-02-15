namespace NCOV_SURVIVAL
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelAmmo = new System.Windows.Forms.Label();
            this.labelKills = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_gameOver = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            this.texthealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmmo
            // 
            this.labelAmmo.AutoSize = true;
            this.labelAmmo.BackColor = System.Drawing.Color.Transparent;
            this.labelAmmo.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmmo.ForeColor = System.Drawing.Color.White;
            this.labelAmmo.Location = new System.Drawing.Point(46, 13);
            this.labelAmmo.Name = "labelAmmo";
            this.labelAmmo.Size = new System.Drawing.Size(97, 34);
            this.labelAmmo.TabIndex = 0;
            this.labelAmmo.Text = "Ammo: 0";
            this.labelAmmo.Click += new System.EventHandler(this.labelAmmo_Click);
            // 
            // labelKills
            // 
            this.labelKills.AutoSize = true;
            this.labelKills.BackColor = System.Drawing.Color.Transparent;
            this.labelKills.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKills.ForeColor = System.Drawing.Color.White;
            this.labelKills.Location = new System.Drawing.Point(256, 13);
            this.labelKills.Name = "labelKills";
            this.labelKills.Size = new System.Drawing.Size(84, 34);
            this.labelKills.TabIndex = 1;
            this.labelKills.Text = "Kills: 0";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.ForeColor = System.Drawing.Color.White;
            this.labelHealth.Location = new System.Drawing.Point(457, 13);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(90, 34);
            this.labelHealth.TabIndex = 2;
            this.labelHealth.Text = "Health:";
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Yellow;
            this.progressBar2.Location = new System.Drawing.Point(547, 14);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(192, 23);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::NCOV_SURVIVAL.Properties.Resources.zdown;
            this.pictureBox2.Location = new System.Drawing.Point(91, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "zombie";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::NCOV_SURVIVAL.Properties.Resources.zdown;
            this.pictureBox3.Location = new System.Drawing.Point(496, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "zombie";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::NCOV_SURVIVAL.Properties.Resources.zup;
            this.pictureBox4.Location = new System.Drawing.Point(342, 447);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 126);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "zombie";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::NCOV_SURVIVAL.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(322, 272);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.gameEngine);
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.Transparent;
            this.label_gameOver.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.label_gameOver.Location = new System.Drawing.Point(247, 171);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(261, 85);
            this.label_gameOver.TabIndex = 8;
            this.label_gameOver.Text = "GameOver";
            this.label_gameOver.Visible = false;
            this.label_gameOver.Click += new System.EventHandler(this.label1_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.Transparent;
            this.playAgain.FlatAppearance.BorderSize = 0;
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playAgain.Location = new System.Drawing.Point(293, 247);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(120, 40);
            this.playAgain.TabIndex = 9;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // texthealth
            // 
            this.texthealth.AutoSize = true;
            this.texthealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texthealth.Location = new System.Drawing.Point(743, 18);
            this.texthealth.Name = "texthealth";
            this.texthealth.Size = new System.Drawing.Size(36, 13);
            this.texthealth.TabIndex = 10;
            this.texthealth.Text = "health";
            this.texthealth.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 523);
            this.Controls.Add(this.texthealth);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelKills);
            this.Controls.Add(this.labelAmmo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ammo;
        private System.Windows.Forms.Label label_Kills;
        private System.Windows.Forms.Label label_health;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAmmo;
        private System.Windows.Forms.Label labelKills;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label texthealth;
    }
}