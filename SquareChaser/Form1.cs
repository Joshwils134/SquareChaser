using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SquareChaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(165, 120, 40, 40);
        Rectangle player2 = new Rectangle(360, 120, 40, 40);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle speedOrb = new Rectangle(195, 295, 10, 10);
        Random ballMvmt = new Random();
        Random speedMvmt = new Random();

        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 2;
        int player2Speed = 2;
        int ballSpot;
        int speedSpot;

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool rightDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        Pen borderPen = new Pen(Color.White, 3);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }

            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < this.Height - player1.Height)
            {
                player1.X += player1Speed;
            }

            //move  player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (leftDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }

            if (rightDown == true && player2.X < this.Height - player2.Height)
            {
                player2.X += player2Speed;
            }

            //Check if player has intersected with white square, if so add a point and move ball location.
            if (player1.IntersectsWith(ball))
            {
                ballSpot = ballMvmt.Next(1, 11);
                p1ScoreLabel.Text = $"{player1Score++}";
                //Play Sound FX
                SoundPlayer collectNoise = new SoundPlayer(Properties.Resources.orbCollect);
                collectNoise.Play();
                //Move ball to random location
                if (ballSpot == 1)
                {
                    ball.X = 180;
                    ball.Y = 265;
                }
                else if (ballSpot == 2)
                {
                    ball.X = 129;
                    ball.Y = 170;
                }
                else if (ballSpot == 3)
                {
                    ball.X = 92;
                    ball.Y = 350;
                }
                else if (ballSpot == 4)
                {
                    ball.X = 35;
                    ball.Y = 105;
                }
                else if (ballSpot == 5)
                {
                    ball.X = 159;
                    ball.Y = 95;
                }
                else if (ballSpot == 6)
                {
                    ball.X = 295;
                    ball.Y = 321;
                }
                else if (ballSpot == 7)
                {
                    ball.X = 299;
                    ball.Y = 299;
                }
                else if (ballSpot == 8)
                {
                    ball.X = 21;
                    ball.Y = 420;
                }
                else if (ballSpot == 9)
                {
                    ball.X = 12;
                    ball.Y = 198;
                }
                else if (ballSpot == 10)
                {
                    ball.X = 10;
                    ball.Y = 23;
                }
            }
            if (player2.IntersectsWith(ball))
            {
                ballSpot = ballMvmt.Next(1, 11);
                p2ScoreLabel.Text = $"{player2Score++}";
                //Play Sound FX
                SoundPlayer collectNoise = new SoundPlayer(Properties.Resources.orbCollect);
                collectNoise.Play();
                //Move ball to random location
                if (ballSpot == 1)
                {
                    ball.X = 180;
                    ball.Y = 265;
                }
                else if (ballSpot == 2)
                {
                    ball.X = 129;
                    ball.Y = 170;
                }
                else if (ballSpot == 3)
                {
                    ball.X = 92;
                    ball.Y = 350;
                }
                else if (ballSpot == 4)
                {
                    ball.X = 35;
                    ball.Y = 105;
                }
                else if (ballSpot == 5)
                {
                    ball.X = 159;
                    ball.Y = 95;
                }
                else if (ballSpot == 6)
                {
                    ball.X = 295;
                    ball.Y = 321;
                }
                else if (ballSpot == 7)
                {
                    ball.X = 299;
                    ball.Y = 299;
                }
                else if (ballSpot == 8)
                {
                    ball.X = 21;
                    ball.Y = 420;
                }
                else if (ballSpot == 9)
                {
                    ball.X = 12;
                    ball.Y = 198;
                }
                else if (ballSpot == 10)
                {
                    ball.X = 10;
                    ball.Y = 23;
                }

            }
            if (player1.IntersectsWith(speedOrb))
            {
                player1Speed++;
                SoundPlayer collectNoise = new SoundPlayer(Properties.Resources.orbCollect);
                collectNoise.Play();
                speedSpot = speedMvmt.Next(1, 11);

                if (speedSpot == 1)
                {
                    speedOrb.X = 120;
                    speedOrb.Y = 215;
                }
                else if (speedSpot == 2)
                {
                    speedOrb.X = 62;
                    speedOrb.Y = 234;
                }
                else if (speedSpot == 3)
                {
                    speedOrb.X = 292;
                    speedOrb.Y = 150;
                }
                else if (speedSpot == 4)
                {
                    speedOrb.X = 76;
                    speedOrb.Y = 203;
                }
                else if (speedSpot == 5)
                {
                    speedOrb.X = 100;
                    speedOrb.Y = 265;
                }
                else if (speedSpot == 6)
                {
                    speedOrb.X = 154;
                    speedOrb.Y = 213;
                }
                else if (speedSpot == 7)
                {
                    speedOrb.X = 199;
                    speedOrb.Y = 199;
                }
                else if (speedSpot == 8)
                {
                    speedOrb.X = 34;
                    speedOrb.Y = 342;
                }
                else if (speedSpot == 9)
                {
                    speedOrb.X = 345;
                    speedOrb.Y = 355;
                }
                else if (speedSpot == 10)
                {
                    speedOrb.X = 23;
                    speedOrb.Y = 27;
                }
            }

            if (player2.IntersectsWith(speedOrb))
            {
                player2Speed++;
                SoundPlayer collectNoise = new SoundPlayer(Properties.Resources.orbCollect);
                collectNoise.Play();
                speedSpot = speedMvmt.Next(1, 11);

                if (speedSpot == 1)
                {
                    speedOrb.X = 120;
                    speedOrb.Y = 215;
                }
                else if (speedSpot == 2)
                {
                    speedOrb.X = 62;
                    speedOrb.Y = 234;
                }
                else if (speedSpot == 3)
                {
                    speedOrb.X = 292;
                    speedOrb.Y = 150;
                }
                else if (speedSpot == 4)
                {
                    speedOrb.X = 76;
                    speedOrb.Y = 203;
                }
                else if (speedSpot == 5)
                {
                    speedOrb.X = 100;
                    speedOrb.Y = 265;
                }
                else if (speedSpot == 6)
                {
                    speedOrb.X = 154;
                    speedOrb.Y = 213;
                }
                else if (speedSpot == 7)
                {
                    speedOrb.X = 199;
                    speedOrb.Y = 199;
                }
                else if (speedSpot == 8)
                {
                    speedOrb.X = 34;
                    speedOrb.Y = 342;
                }
                else if (speedSpot == 9)
                {
                    speedOrb.X = 345;
                    speedOrb.Y = 355;
                }
                else if (speedSpot == 10)
                {
                    speedOrb.X = 23;
                    speedOrb.Y = 27;
                }
            }
            //Check player score and determine the winner
            if (player1Score == 8)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                SoundPlayer victoryPlayer = new SoundPlayer(Properties.Resources.victoryNoise);
                victoryPlayer.Play();
                winLabel.Text = "Player 1  Wins!!";
            }
            else if (player2Score == 8)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                SoundPlayer victoryPlayer = new SoundPlayer(Properties.Resources.victoryNoise);
                victoryPlayer.Play();
                winLabel.Text = "Player 2  Wins!!";
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(orangeBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, ball);
            e.Graphics.FillRectangle(yellowBrush, speedOrb);
        }
    }
}
