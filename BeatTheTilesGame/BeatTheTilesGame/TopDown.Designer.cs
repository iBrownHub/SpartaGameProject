namespace BeatTheTilesGame
{
    partial class TopDown
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
            this.background = new System.Windows.Forms.PictureBox();
            this.health2 = new System.Windows.Forms.PictureBox();
            this.health3 = new System.Windows.Forms.PictureBox();
            this.health1 = new System.Windows.Forms.PictureBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.rightEdge = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topDownTimer = new System.Windows.Forms.Timer(this.components);
            this.initEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Brown;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(782, 402);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "background";
            // 
            // health2
            // 
            this.health2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health2.Location = new System.Drawing.Point(103, 9);
            this.health2.Name = "health2";
            this.health2.Size = new System.Drawing.Size(20, 20);
            this.health2.TabIndex = 22;
            this.health2.TabStop = false;
            this.health2.Tag = "health2";
            // 
            // health3
            // 
            this.health3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health3.Location = new System.Drawing.Point(129, 9);
            this.health3.Name = "health3";
            this.health3.Size = new System.Drawing.Size(20, 20);
            this.health3.TabIndex = 21;
            this.health3.TabStop = false;
            this.health3.Tag = "health3";
            // 
            // health1
            // 
            this.health1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health1.Location = new System.Drawing.Point(77, 9);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(20, 20);
            this.health1.TabIndex = 20;
            this.health1.TabStop = false;
            this.health1.Tag = "health1";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Firebrick;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(12, 9);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(58, 20);
            this.healthLabel.TabIndex = 19;
            this.healthLabel.Text = "Health";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Purple;
            this.player.Location = new System.Drawing.Point(356, 296);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 18;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform.Location = new System.Drawing.Point(0, 352);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(782, 50);
            this.platform.TabIndex = 17;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // rightEdge
            // 
            this.rightEdge.Location = new System.Drawing.Point(782, 0);
            this.rightEdge.Name = "rightEdge";
            this.rightEdge.Size = new System.Drawing.Size(0, 402);
            this.rightEdge.TabIndex = 24;
            this.rightEdge.TabStop = false;
            this.rightEdge.Tag = "rightEdge";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 402);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "leftEdge";
            // 
            // topDownTimer
            // 
            this.topDownTimer.Enabled = true;
            this.topDownTimer.Interval = 1;
            this.topDownTimer.Tag = "topDownTimer";
            this.topDownTimer.Tick += new System.EventHandler(this.TopDownTimer_Tick);
            // 
            // initEnemy
            // 
            this.initEnemy.BackColor = System.Drawing.Color.Gold;
            this.initEnemy.Location = new System.Drawing.Point(20, 60);
            this.initEnemy.Margin = new System.Windows.Forms.Padding(0);
            this.initEnemy.Name = "initEnemy";
            this.initEnemy.Size = new System.Drawing.Size(30, 30);
            this.initEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.initEnemy.TabIndex = 25;
            this.initEnemy.TabStop = false;
            this.initEnemy.Tag = "initEnemy";
       
            // 
            // TopDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.initEnemy);
            this.Controls.Add(this.health2);
            this.Controls.Add(this.health3);
            this.Controls.Add(this.health1);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.rightEdge);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.background);
            this.Name = "TopDown";
            this.Text = "TopDown";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox health2;
        private System.Windows.Forms.PictureBox health3;
        private System.Windows.Forms.PictureBox health1;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox rightEdge;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer topDownTimer;
        private System.Windows.Forms.PictureBox initEnemy;
    }
}