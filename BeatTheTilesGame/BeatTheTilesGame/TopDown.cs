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
    public partial class TopDown : Form, IMkProjectile, IMkEnemy
    {
        List<PictureBox> enemies = new List<PictureBox>();
        bool isLeft;
        bool isRight;
        bool isFired;
        int speed = 1;
        int playerSpeed = 5;
        int projSpeed = 7;
        public TopDown()
        {
            InitializeComponent();
            MkEnemy(3, 13);
        }

        private void TopDownTimer_Tick(object sender, EventArgs e)
        {
            if (isLeft)
            {
                player.Left -= playerSpeed;
            }
            if (isRight)
            {
                player.Left += playerSpeed;
            }
            if (enemies.Count <= 0)
            {
                Application.OpenForms["MainGame"].Show();
                this.Close();
            }
            
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && (string)i.Tag == "enemy")
                {                    
                    i.Left += speed;
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        GameOver go = new GameOver();
                        go.Show();
                        Application.OpenForms["MainGame"].Close();
                        this.Close();
                    }
                    if (i.Left == 0)
                    {
                        speed = 1;
                        foreach (Control j in this.Controls)
                        {
                            if (j is PictureBox && (string)j.Tag == "enemy")
                            {
                                j.Top += 10;
                            }
                        }
                    }
                    if (i.Left + i.Width == background.Left + background.Width)
                    {
                        speed = -1;
                        foreach (Control j in this.Controls)
                        {
                            if (j is PictureBox && (string)j.Tag == "enemy")
                            {
                                j.Top += 10;
                            }
                        }
                    }
                }
                if (i is PictureBox && (string)i.Tag == "projectile")
                {
                    i.Top -= projSpeed;
                    if (i.Top > 402)
                    {
                        this.Controls.Remove(i);
                        i.Dispose();
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
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && (string)j.Tag == "projectile") && (i is PictureBox && (string)i.Tag == "enemy"))
                    {
                        if (i.Bounds.IntersectsWith(j.Bounds))
                        {
                            enemies.Remove((PictureBox)i);
                            this.Controls.Remove(i);
                            i.Dispose();                            
                            this.Controls.Remove(j);
                            j.Dispose();

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
            if (e.KeyCode == Keys.Space && !isFired)
            {
                MkProjectile();
                isFired = true;
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
            if (e.KeyCode == Keys.Space)
            {
                isFired = false;
            }
        }
        public void MkProjectile()
        {            
            PictureBox proj = new PictureBox();
            proj.BackColor = Color.DarkOrange;
            proj.Height = 15;
            proj.Width = 10;
            proj.Tag = "projectile";
            proj.Left = player.Left + (player.Width / 2) - (proj.Width / 2);
            proj.Top = player.Top;
            this.Controls.Add(proj);
            proj.BringToFront();
        }
        public void MkEnemy(int rows, int columns)
        {
            int oldX = initEnemy.Left;
            int oldY = initEnemy.Top;
            initEnemy.Hide();
            int drop = 50;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    PictureBox enemy = new PictureBox();
                    enemy.BackColor = Color.Gold;
                    enemy.Size = new Size(30, 30);
                    //enemy.Height = 30;
                    //enemy.Width = 30;
                    enemy.Tag = "enemy";
                    enemy.Name = ("enemy" + i + j);
                    enemy.Left = oldX + 40;
                    enemy.Top = oldY;
                    this.Controls.Add(enemy);
                    enemy.BringToFront();
                    oldX = enemy.Left;
                    enemies.Add(enemy);
                }
                oldY = oldY + drop;
                oldX = initEnemy.Left;
            }
        }
    }

}
