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
    public partial class BossLevel : Form, IMkProjectile, IMkEnemy
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
        int enemyHealth = 50;

        

        public BossLevel()
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
                if (i is PictureBox && (string)i.Tag == "rightEdge")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        player.Left = rightEdge.Left - player.Width;
                    }
                }
                if (i is PictureBox && (string)i.Tag == "enemy")
                {
                    i.Left -= 2;
                    if (player.Bounds.IntersectsWith(i.Bounds) && hasDamaged == false)
                    {
                        this.Controls.Remove((PictureBox)i);
                        ((PictureBox)i).Dispose();
                        hasDamaged = true;
                        --playerHealth;
                        switch (playerHealth)
                        {
                            case 0:
                                GameOver go = new GameOver();
                                go.Show();
                                this.Close();
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
                if (i is PictureBox && (string)i.Tag == "enemyTop")
                {
                    i.Top += 2;
                    if (player.Bounds.IntersectsWith(i.Bounds) && hasDamaged == false)
                    {
                        this.Controls.Remove((PictureBox)i);
                        ((PictureBox)i).Dispose();
                        hasDamaged = true;
                        --playerHealth;
                        switch (playerHealth)
                        {
                            case 0:
                                GameOver go = new GameOver();
                                go.Show();
                                this.Close();
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
        public void MkEnemy(int x, int y)
        {            
            Random rand = new Random();
            switch (rand.Next(1,4))
            {
                case 1:
                    PictureBox enemy = new PictureBox();
                    enemy.BackColor = Color.Gold;
                    enemy.Size = new Size(20, 20);
                    //enemy.Height = 30;
                    //enemy.Width = 30;
                    enemy.Tag = "enemy";
                    enemy.Left = 800;
                    enemy.Top = platform.Top - enemy.Height;
                    this.Controls.Add(enemy);
                    enemy.BringToFront();                    
                    break;
                case 2:
                    PictureBox enemy2 = new PictureBox();
                    enemy2.BackColor = Color.Gold;
                    enemy2.Size = new Size(20, 20);
                    //enemy.Height = 30;
                    //enemy.Width = 30;
                    enemy2.Tag = "enemy";
                    enemy2.Left = 800;
                    enemy2.Top = platform.Top - enemy2.Height - 30;
                    this.Controls.Add(enemy2);
                    enemy2.BringToFront();
                    break;
                case 3:
                    PictureBox enemy3 = new PictureBox();
                    enemy3.BackColor = Color.Gold;
                    enemy3.Size = new Size(20, 20);
                    //enemy.Height = 30;
                    //enemy.Width = 30;
                    enemy3.Tag = "enemyTop";
                    enemy3.Left = player.Left;
                    enemy3.Top = 0;
                    this.Controls.Add(enemy3);
                    enemy3.BringToFront();
                    break;
                default:
                    break;
            }
        }

        private void enemyGameTimer(object sender, EventArgs e)
        {
            MkEnemy(1, 1);

        }
    }
}
