using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BeatTheTilesGame
{
    public partial class MainGame : Form
    {
        int gameSelect;
        string tileSwitch;
        public MainGame()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            gameSelect = DiceRoll();
            switch (gameSelect)
            {
                case 1:
                    player.Left += 60;
                    mainGameTimer.Start();
                    break;
                case 2:
                    player.Left += 120;
                    mainGameTimer.Start();
                    break;
                case 3:
                    player.Left += 180;
                    mainGameTimer.Start();
                    break;
                default:
                    break;
            }            
        }
        private int DiceRoll()
        {
            Random rand = new Random();
            return rand.Next(1, 4);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {            
            foreach (Control i in this.Controls)
            {

                if (i is Label && (string)i.Tag == "frontLabel")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        tileSwitch = i.Text;
                        switch (tileSwitch)
                        {
                            case "Play Top Down":
                                TopDown td = new TopDown();
                                td.Show();
                                this.Hide();
                                mainGameTimer.Stop();
                                break;
                            case "Play Scroller":
                                SideScroller ss = new SideScroller();
                                ss.Show();
                                this.Hide();
                                mainGameTimer.Stop();
                                break;
                            case "Forward One Space":
                                player.Left += 60;
                                break;
                            case "Back One Space":
                                player.Left -= 60;
                                break;
                            case "Back To Start...":
                                player.Left -= 360;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (i is Label && (string)i.Tag == "bossLabel")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        BossLevel bl = new BossLevel();
                        bl.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
