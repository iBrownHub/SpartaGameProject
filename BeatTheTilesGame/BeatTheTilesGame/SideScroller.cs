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
    public partial class SideScroller : Form
    {
        bool isLeft = false;
        bool isRight = false;
        bool isJumping = false;
        bool isCrouching = false;
        bool hasDamaged = false;
        int scrollerHealth = 3;
        int jumpSpeed = 10;
        int jumpForce = 10;
        int speed = 5;
        int backSpeed = 8;
        public SideScroller()
        {
            InitializeComponent();            
        }

        private void sideScrollerTick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            player.Refresh();
            HardGame hg = new HardGame();

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
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && (string)i.Tag == "background")
                {
                    i.Left -= 8;
                }
                if (i is PictureBox && (string)i.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        jumpForce = 10;
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
                    i.Left -= 5;
                    if (player.Bounds.IntersectsWith(i.Bounds) && hasDamaged == false)
                    {
                        hasDamaged = true;                        
                        --scrollerHealth;                        
                        switch (scrollerHealth)
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
                    if (!player.Bounds.IntersectsWith(i.Bounds))
                    {
                        hasDamaged = false;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && (string)j.Tag == "background") && (i is PictureBox && (string)i.Tag == "rightEdge"))
                    {
                        if (!(i.Bounds.IntersectsWith(j.Bounds)))
                        {
                            MainGame mg = new MainGame();
                            mg.Show();
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
