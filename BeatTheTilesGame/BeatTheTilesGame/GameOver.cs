﻿using System;
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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StartGame sg = new StartGame();
            sg.Show();
            this.Hide();
        }
    }
}