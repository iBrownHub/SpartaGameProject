using System.Windows.Forms;

namespace BeatTheTilesGame
{
    partial class BossLevel
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.background = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.enemyHitbox = new System.Windows.Forms.PictureBox();
            this.edge = new System.Windows.Forms.PictureBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.health1 = new System.Windows.Forms.PictureBox();
            this.health3 = new System.Windows.Forms.PictureBox();
            this.health2 = new System.Windows.Forms.PictureBox();
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.rightEdge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHitbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEdge)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Maroon;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(782, 403);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "background";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Purple;
            this.player.Location = new System.Drawing.Point(12, 297);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform.Location = new System.Drawing.Point(0, 353);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(782, 50);
            this.platform.TabIndex = 2;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Gold;
            this.enemy.Location = new System.Drawing.Point(658, 147);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(200, 200);
            this.enemy.TabIndex = 3;
            this.enemy.TabStop = false;
            this.enemy.Tag = "";
            // 
            // enemyHitbox
            // 
            this.enemyHitbox.BackColor = System.Drawing.Color.MediumBlue;
            this.enemyHitbox.Location = new System.Drawing.Point(695, 303);
            this.enemyHitbox.Name = "enemyHitbox";
            this.enemyHitbox.Size = new System.Drawing.Size(30, 30);
            this.enemyHitbox.TabIndex = 4;
            this.enemyHitbox.TabStop = false;
            this.enemyHitbox.Tag = "enemyHitbox";
            // 
            // edge
            // 
            this.edge.Location = new System.Drawing.Point(0, 0);
            this.edge.Name = "edge";
            this.edge.Size = new System.Drawing.Size(0, 402);
            this.edge.TabIndex = 5;
            this.edge.TabStop = false;
            this.edge.Tag = "edge";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Maroon;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(13, 13);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(58, 20);
            this.healthLabel.TabIndex = 6;
            this.healthLabel.Text = "Health";
            // 
            // health1
            // 
            this.health1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health1.Location = new System.Drawing.Point(78, 13);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(20, 20);
            this.health1.TabIndex = 7;
            this.health1.TabStop = false;
            this.health1.Tag = "health1";
            // 
            // health3
            // 
            this.health3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health3.Location = new System.Drawing.Point(130, 13);
            this.health3.Name = "health3";
            this.health3.Size = new System.Drawing.Size(20, 20);
            this.health3.TabIndex = 8;
            this.health3.TabStop = false;
            this.health3.Tag = "health3";
            // 
            // health2
            // 
            this.health2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health2.Location = new System.Drawing.Point(104, 13);
            this.health2.Name = "health2";
            this.health2.Size = new System.Drawing.Size(20, 20);
            this.health2.TabIndex = 9;
            this.health2.TabStop = false;
            this.health2.Tag = "health2";
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 1000;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyGameTimer);
            // 
            // rightEdge
            // 
            this.rightEdge.Location = new System.Drawing.Point(782, 0);
            this.rightEdge.Name = "rightEdge";
            this.rightEdge.Size = new System.Drawing.Size(0, 402);
            this.rightEdge.TabIndex = 28;
            this.rightEdge.TabStop = false;
            this.rightEdge.Tag = "rightEdge";
            // 
            // BossLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.rightEdge);
            this.Controls.Add(this.health2);
            this.Controls.Add(this.health3);
            this.Controls.Add(this.health1);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.edge);
            this.Controls.Add(this.enemyHitbox);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.player);
            this.Controls.Add(this.background);
            this.Name = "BossLevel";
            this.Text = "Boss Level";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHitbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEdge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox enemyHitbox;
        private System.Windows.Forms.PictureBox edge;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox health1;
        private System.Windows.Forms.PictureBox health3;
        private System.Windows.Forms.PictureBox health2;
        private Timer enemyTimer;
        private PictureBox rightEdge;
    }
}