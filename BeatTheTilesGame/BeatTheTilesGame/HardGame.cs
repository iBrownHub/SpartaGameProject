using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheTilesGame
{
    public partial class HardGame : Form
    {
        bool isLeft = false;
        bool isRight = false;
        bool isJumping = false;
        bool isCrouching = false;
        bool hasShot = false;
        bool hasDamaged = false;
        int jumpSpeed = 10;
        int jumpForce = 10;
        int speed = 5;
        int projSpeed = 8;
        public int playerHealth = 3;
        int enemyHealth = 30;

        

        public HardGame()
        {
            InitializeComponent();
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            player.Refresh();
            if (isJumping && jumpForce < 0)
            {
                isJumping = false;
            }
            if (isJumping)
            {
                jumpSpeed = -10;
                jumpForce -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }
            if (isLeft)
            {
                player.Left -= speed;
            }
            if (isRight)
            {
                player.Left += speed;
            }
            if (isCrouching)
            {
                Size size = new Size(50, 25);
                player.Size = size;
            }
            else
            {
                Size size = new Size(50, 50);
                player.Size = size;
            }
            if (enemyHealth <= 0)
            {
                WinGame wg = new WinGame();
                wg.Show();
                this.Close();
            }


            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && (string)i.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        jumpForce = 10;
                        player.Top = i.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }
                if (i is PictureBox && (string)i.Tag == "edge")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        player.Left = 0;
                    }
                }
                if (i is PictureBox && (string)i.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds) && hasDamaged == false)
                    {
                        hasDamaged = true;
                        --playerHealth;
                        switch (playerHealth)
                        {
                            case 0:
                                GameOver go = new GameOver();
                                go.Show();
                                this.Hide();
                                break;
                            case 1:
                                health2.BackColor = Color.Black;
                                break;
                            case 2:
                                health3.BackColor = Color.Black;
                                break;
                            default:
                                break;
                        }
                    }
                    if (!(player.Bounds.IntersectsWith(i.Bounds)))                    
                    {
                        hasDamaged = false;
                    }
                }
                if (i is PictureBox && (string)i.Tag == "projectile")
                {
                    i.Left += projSpeed;
                    if (((PictureBox)i).Left > 782)
                    {
                        this.Controls.Remove((PictureBox)i);
                        ((PictureBox)i).Dispose();
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && (string)j.Tag == "projectile") && (i is PictureBox && (string)i.Tag == "enemyHitbox"))
                    {
                        if (i.Bounds.IntersectsWith(j.Bounds))
                        {
                            --enemyHealth;
                            this.Controls.Remove(j);
                            j.Dispose();
                            
                        }
                    }
                }
                
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                isRight = true;
            }
            if (e.KeyCode == Keys.W && !isJumping)
            {
                isJumping = true;
            }
            if (e.KeyCode == Keys.S)
            {
                isCrouching = true;
            }
            if (e.KeyCode == Keys.P)
            {
                enemyHealth = 0;
            }
            if (e.KeyCode == Keys.Space && !hasShot)
            {
                MkProjectile();
                hasShot = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                isLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                isRight = false;
            }
            if (e.KeyCode == Keys.W && isJumping)
            {
                isJumping = false;
            }
            if (e.KeyCode == Keys.S)
            {
                isCrouching = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                hasShot = false;
            }
        }
        public void MkProjectile()
        {
            Trace.WriteLine("MkProjectile Method");
            Trace.WriteLine(enemyHealth);
            PictureBox proj = new PictureBox();
            proj.BackColor = Color.DarkOrange;
            proj.Height = 10;
            proj.Width = 15;
            proj.Tag = "projectile";
            proj.Left = player.Left + player.Width;
            proj.Top = player.Top + (player.Height / 2);
            this.Controls.Add(proj);
            proj.BringToFront();
        }
    }
}
