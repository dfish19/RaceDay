﻿namespace RaceDay
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.track = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.track1 = new System.Windows.Forms.PictureBox();
            this.r1 = new System.Windows.Forms.PictureBox();
            this.r2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Crimson;
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(139, 575);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(192, 62);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.BackColor = System.Drawing.Color.Transparent;
            this.textScore.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(172, 524);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(113, 35);
            this.textScore.TabIndex = 3;
            this.textScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // track
            // 
            this.track.BackColor = System.Drawing.Color.Black;
            this.track.Image = global::RaceDay.Properties.Resources.seamless_texture_highway_asphalt_road_yellow_white_markings_80496532;
            this.track.Location = new System.Drawing.Point(0, -519);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(487, 519);
            this.track.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.track.TabIndex = 4;
            this.track.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.bomb);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.r2);
            this.panel1.Controls.Add(this.r1);
            this.panel1.Controls.Add(this.track1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 519);
            this.panel1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // track1
            // 
            this.track1.BackColor = System.Drawing.Color.Black;
            this.track1.Image = global::RaceDay.Properties.Resources.seamless_texture_highway_asphalt_road_yellow_white_markings_80496532;
            this.track1.Location = new System.Drawing.Point(-3, -3);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(487, 519);
            this.track1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.track1.TabIndex = 1;
            this.track1.TabStop = false;
            // 
            // r1
            // 
            this.r1.Image = global::RaceDay.Properties.Resources.fca5fbda9c;
            this.r1.Location = new System.Drawing.Point(21, 15);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(89, 160);
            this.r1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r1.TabIndex = 2;
            this.r1.TabStop = false;
            // 
            // r2
            // 
            this.r2.Image = global::RaceDay.Properties.Resources.fd57e9449c;
            this.r2.Location = new System.Drawing.Point(376, 70);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(89, 160);
            this.r2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r2.TabIndex = 3;
            this.r2.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::RaceDay.Properties.Resources.R;
            this.player.Location = new System.Drawing.Point(259, 342);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(89, 160);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Image = global::RaceDay.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(51, 371);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(100, 50);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb.TabIndex = 5;
            this.bomb.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::RaceDay.Properties.Resources.you_win_congratulations_frame_banner_golden_congratulating_framed_sign_winning_gold_confetti_surprise_achievement_prize_179120853;
            this.award.Location = new System.Drawing.Point(159, 230);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(161, 75);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 6;
            this.award.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(486, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.track);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Racer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.restartGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox track;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox r2;
        private System.Windows.Forms.PictureBox r1;
        private System.Windows.Forms.PictureBox track1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

