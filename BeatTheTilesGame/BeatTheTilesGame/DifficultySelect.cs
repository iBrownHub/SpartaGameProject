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
    public partial class DifficultySelect : Form
    {
        public string difficulty;
        public DifficultySelect()
        {
            InitializeComponent();
        }
        private void DifficultyButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            difficulty = btn.Text;
            switch (difficulty)
            {
                case "Instructions":
                    EasyGame eg = new EasyGame();
                    eg.Show();
                    this.Close();
                    break;
                case "Hard":
                    MainGame mg = new MainGame();
                    mg.Show();
                    this.Close();
                    break;
            }
        }
    }
}
