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
    public partial class SideScroller : Form, IMkEnemy
    {   
        public static List<PictureBox> enemies = new List<PictureBox>();
        bool isLeft = false;
        bool isRight = false;
        bool isJumping = false;
        bool isCrouching = false;
        bool hasDamaged = false;
        int scrollerHealth = 3;
        int jumpSpeed = 10;
        int jumpForce = 10;
        int speed = 5;
        int backSpeed = 5;
        public SideScroller()
        {
            InitializeComponent();
            MkEnemy(17,1);
        }

        public void MkEnemy(int x, int y)
        {
            int oldX = initEnemy.Left;
                        
            for (int i = 1; i < x; ++i)
            {
                if ((i % 2) == 0)
                {                    
                    PictureBox enemy = new PictureBox();
                    enemy.BackColor = Color.Gold;
                    enemy.Height = 28;
                    enemy.Width = 12;
                    enemy.Tag = "enemy";
                    enemy.Name = ("enemy" + i);
                    enemy.Left = oldX + 200;
                    enemy.Top = initEnemy.Top;
                    this.Controls.Add(enemy);
                    enemy.BringToFront();
                    oldX = enemy.Left;
                    enemies.Add(enemy);
                }
                else
                {                    
                    PictureBox enemy = new PictureBox();
                    enemy.BackColor = Color.Gold;
                    enemy.Height = 28;
                    enemy.Width = 12;
                    enemy.Tag = "enemy";
                    enemy.Name = ("enemy" + i);
                    enemy.Left = oldX + 200;
                    enemy.Top = initEnemy.Top - 25;
                    this.Controls.Add(enemy);
                    enemy.BringToFront();
                    oldX = enemy.Left;
                    enemies.Add(enemy);
                }
            }            
        }

        private void sideScrollerTick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            player.Refresh();            

            if (isJumping && jumpForce < 0)
            {
                isJumping = false;
            }

            if (isJumping)
            {
                jumpSpeed = -12;
                jumpForce -= 1;
            }
            else
            {
                jumpSpeed = 12;
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

            foreach (Control i in this.Controls)
            {                
                if (i is PictureBox && (string)i.Tag == "background")
                {
                    i.Left -= backSpeed;
                }
                if (i is PictureBox && (string)i.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        jumpForce = 8;
                        player.Top = i.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }

                if (i is PictureBox && (string)i.Tag == "leftEdge")
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
                    i.Left -= backSpeed;

                    if (player.Bounds.IntersectsWith(i.Bounds) && hasDamaged == false)
                    {
                        hasDamaged = true;                        
                        scrollerHealth--;
                        i.Left = player.Left - i.Width;                        
                        switch (scrollerHealth)
                        {
                            case 0:
                                GameOver go = new GameOver();
                                go.Show();
                                Application.OpenForms["MainGame"].Close();
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
                    if (!player.Bounds.IntersectsWith(i.Bounds))
                    {
                        hasDamaged = false;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && (string)j.Tag == "background") && (i is PictureBox && (string)i.Tag == "rightFinish"))
                    {
                        if (!(i.Bounds.IntersectsWith(j.Bounds)))
                        {
                            Application.OpenForms["MainGame"].Show();
                            this.Close();
                        }
                    }                    
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                isRight = true;
            }
            if (e.KeyCode == Keys.A)
            {
                isLeft = true;
            }
            if (e.KeyCode == Keys.W && !isJumping)
            {
                isJumping = true;
            }
            if (e.KeyCode == Keys.S)
            {
                isCrouching = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                isRight = false;
            }
            if (e.KeyCode == Keys.A)
            {
                isLeft = false;
            }
            if (e.KeyCode == Keys.W && isJumping)
            {
                isJumping = false;
            }
            if (e.KeyCode == Keys.S)
            {
                isCrouching = false;
            }
        }
    }
}
