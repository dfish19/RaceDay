namespace RaceDay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.r3 = new System.Windows.Forms.PictureBox();
            this.r2 = new System.Windows.Forms.PictureBox();
            this.r1 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.Track = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bomb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.r3);
            this.panel1.Controls.Add(this.r2);
            this.panel1.Controls.Add(this.r1);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.Track);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(133, 575);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(192, 62);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RaceDay.Properties.Resources.Winner;
            this.pictureBox1.Location = new System.Drawing.Point(128, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::RaceDay.Properties.Resources.R;
            this.player.Location = new System.Drawing.Point(235, 363);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 139);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // r3
            // 
            this.r3.Image = global::RaceDay.Properties.Resources.pink_car_top_view_hi;
            this.r3.Location = new System.Drawing.Point(12, 271);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(100, 134);
            this.r3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r3.TabIndex = 4;
            this.r3.TabStop = false;
            // 
            // r2
            // 
            this.r2.Image = global::RaceDay.Properties.Resources.fd57e9449c;
            this.r2.Location = new System.Drawing.Point(355, 148);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(107, 156);
            this.r2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r2.TabIndex = 3;
            this.r2.TabStop = false;
            this.r2.Tag = "carRight";
            this.r2.Click += new System.EventHandler(this.restartGame);
            // 
            // r1
            // 
            this.r1.Image = global::RaceDay.Properties.Resources.fca5fbda9c;
            this.r1.Location = new System.Drawing.Point(98, 0);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(129, 136);
            this.r1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r1.TabIndex = 2;
            this.r1.TabStop = false;
            this.r1.Tag = "carLeft";
            // 
            // award
            // 
            this.award.Image = global::RaceDay.Properties.Resources.seamless_texture_highway_asphalt_road_yellow_white_markings_80496532;
            this.award.Location = new System.Drawing.Point(0, 0);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(475, 519);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 1;
            this.award.TabStop = false;
            // 
            // Track
            // 
            this.Track.Location = new System.Drawing.Point(0, -519);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(475, 519);
            this.Track.TabIndex = 0;
            this.Track.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Image = global::RaceDay.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(355, 39);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(100, 50);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bomb.TabIndex = 7;
            this.bomb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(474, 649);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Racer";
            this.Click += new System.EventHandler(this.restartGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox Track;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox r3;
        private System.Windows.Forms.PictureBox r2;
        private System.Windows.Forms.PictureBox r1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox bomb;
    }
}

