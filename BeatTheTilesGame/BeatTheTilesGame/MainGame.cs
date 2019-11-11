using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheTilesGame
{
    public partial class MainGame : Form
    {
        string gameSelect;
        public MainGame()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            gameSelect = (string)btn.Text;
            switch (gameSelect)
            {
                case "Top Down":
                    break;
                case "Side Scroller":
                    SideScroller ss = new SideScroller();
                    ss.Show();
                    this.Hide();
                    break;
                case "Boss Level":
                    HardGame hg = new HardGame();
                    hg.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
