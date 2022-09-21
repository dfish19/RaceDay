using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDay
{
    public partial class Form1 : Form
    {
        int roadSpeed = 15;
        int trafficSpeed = 15;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random random = new Random();
        Random carPosition = new Random();
        bool goLeft, goRight;
        public Form1()
        {
            InitializeComponent();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            bomb.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false; ;
            score = 0;
            award.Image = Properties.Resources.tryAgain;
            roadSpeed = 12;
            trafficSpeed = 15;
            r1.Top = carPosition.Next(200, 500) * -1;
            r1.Left = carPosition.Next(5, 200);
            r2.Top = carPosition.Next(200, 500) * -1;
            r2.Left = carPosition.Next(245, 422);
            gameTimer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            textScore.Text = "Score: " + score;
            score++;

            if(goLeft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            Track.Top += roadSpeed;
            award.Top += roadSpeed;

            if (award.Top > 519)
            {
                award.Top = -519;
            }
            if (Track.Top > 519)
            {
                Track.Top = -519;
            }

            r1.Top = trafficSpeed;
            r2.Top = trafficSpeed;

            if (r1.Top > 530)
            {
                ChangeACars(r1);
            }
            if (r2.Top > 530)
            {
                ChangeACars(r2);
            }
            if (player.Bounds.IntersectsWith(r1.Bounds) ||
                player.Bounds.IntersectsWith(r2.Bounds))
            {
                gameOver();
            }
            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.tryAgain;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.Loser;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (score > 2000)
            {
                award.Image = Properties.Resources.Winner;
                roadSpeed = 27;
                trafficSpeed = 25;
            }
        }

        private void gameOver()
        {
            gameTimer.Stop();
            bomb.Visible = true;
            player.Controls.Add(bomb);
            bomb.Location = new Point(-8, 5);
            bomb.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;
        }
        
        private void ChangeACars(PictureBox tempCar)
        {
            carImage = random.Next(1, 7);
            switch(carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.R;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.fd57e9449c;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.fca5fbda9c;
                    break;
            }
            tempCar.Top = carPosition.Next(100 , 400) * -1;
            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245 , 200);
            }
        }


        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
    }
}
