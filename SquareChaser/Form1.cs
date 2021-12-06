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
using System.Timers;
using System.Diagnostics;
using System.Media;

namespace SquareChaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(160, 240, 30, 30);
        Rectangle player2 = new Rectangle(140, 170, 30, 30);
        Rectangle pointSquare = new Rectangle(295, 195, 10, 10);
        Rectangle powerUpSquare = new Rectangle(250, 225, 5, 5);
        Rectangle powerDownSquare = new Rectangle(250, 225, 5, 5);
        Rectangle borderRight = new Rectangle(692, 53, 50, 477);
        Rectangle borderLeft = new Rectangle(65, 53, 50, 477);
        Rectangle borderTop = new Rectangle(65, 53, 627, 50);
        Rectangle borderBottom = new Rectangle(65, 530, 677, 50);

        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 4;
        int player2Speed = 4;

        int pointSquarePoints = 1;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        SolidBrush redBrush = new SolidBrush(Color.DarkRed);
        SolidBrush cyanBrush = new SolidBrush(Color.Cyan);
        SolidBrush purpleBrush = new SolidBrush(Color.Purple);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush lightBlueBrush = new SolidBrush(Color.LightSkyBlue);
        SolidBrush crimsonBrush = new SolidBrush(Color.Crimson);

        SoundPlayer ping = new SoundPlayer(Properties.Resources.Ping);
        SoundPlayer woosh = new SoundPlayer(Properties.Resources.Woosh);
        SoundPlayer ughh = new SoundPlayer(Properties.Resources.WallHit);

        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {

            InitializeComponent();
            Random randGen = new Random();
            pointSquare.X = randGen.Next(143, 615);
            pointSquare.Y = randGen.Next(143, 331);
            powerUpSquare.X = randGen.Next(143, 615);
            powerUpSquare.Y = randGen.Next(143, 331);
            powerDownSquare.X = randGen.Next(143, 615);
            powerDownSquare.Y = randGen.Next(143, 331);
            stopwatch.Start();
            x2Label.Text = "";
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
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
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
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int x = player1.X;
            int y = player1.Y;
            int x2 = player2.X;
            int y2 = player2.Y;

            /// move player 1 
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
            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }
            /// move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }
            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }
            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }
            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }
            ///check if player collides with either square. If it does change the direction 
            ///and place the ball in front of the player hit 
            if (player1.IntersectsWith(pointSquare))
            {
                Random randGen = new Random();
                pointSquare.X = randGen.Next(143, 615);
                pointSquare.Y = randGen.Next(143, 331);
                player1Score += pointSquarePoints;
                p1ScoreLabel.Text = $"{player1Score}";
                ping.Play();
            }
            else if (player2.IntersectsWith(pointSquare))
            {
                Random randGen = new Random();
                pointSquare.X = randGen.Next(143, 615);
                pointSquare.Y = randGen.Next(143, 331);
                player2Score += pointSquarePoints;
                p2ScoreLabel.Text = $"{player2Score}";
                ping.Play();
            }
            else if (player1.IntersectsWith(powerUpSquare))
            {
                Random randGen = new Random();
                powerUpSquare.X = randGen.Next(143, 615);
                powerUpSquare.Y = randGen.Next(143, 331);
                player1Speed += 1;
                woosh.Play();
            }
            else if (player2.IntersectsWith(powerUpSquare))
            {
                Random randGen = new Random();
                powerUpSquare.X = randGen.Next(143, 615);
                powerUpSquare.Y = randGen.Next(143, 331);
                player2Speed += 1;
                woosh.Play();
            }
            else if (player1.IntersectsWith(powerDownSquare))
            {
                Random randGen = new Random();
                powerDownSquare.X = randGen.Next(143, 615);
                powerDownSquare.Y = randGen.Next(143, 331);
                player1Speed -= 1;
                ughh.Play();
            }
            else if (player2.IntersectsWith(powerDownSquare))
            {
                Random randGen = new Random();
                powerDownSquare.X = randGen.Next(143, 615);
                powerDownSquare.Y = randGen.Next(143, 331);
                player2Speed -= 1;
                ughh.Play();
            }
            if (player1Speed <= 1)
            {
                player1Speed += 1;
            }
            else if (player2Speed <= 1)
            {
                player2Speed += 1;
            }
            /// makes players unable to go through borders
            if (player1.IntersectsWith(borderTop)|| player1.IntersectsWith(borderLeft)|| player1.IntersectsWith(borderBottom) || player1.IntersectsWith(borderRight))
            {
                player1.X = x;
                player1.Y = y;
            }
            if (player2.IntersectsWith(borderBottom) || player2.IntersectsWith(borderRight) || player2.IntersectsWith(borderLeft) || player2.IntersectsWith(borderTop))
            {
                player2.X = x2;
                player2.Y = y2;
            }
            /// doubles points after 20 seconds pass
            if (stopwatch.ElapsedMilliseconds >= 20000)
            {
                pointSquarePoints = 2;
                x2Label.Text = "2X";
            }
            /// determines the winner
            if (player1Score >= 20)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
                stopwatch.Stop();
                stopwatch.Reset();
            }
            if (player2Score >= 20)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
                stopwatch.Stop();
                stopwatch.Reset();
            }
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(cyanBrush, player1);
            e.Graphics.FillRectangle(purpleBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, pointSquare);
            e.Graphics.FillRectangle(lightBlueBrush, powerUpSquare);
            e.Graphics.FillRectangle(crimsonBrush, powerDownSquare);
            e.Graphics.FillRectangle(redBrush, borderLeft);
            e.Graphics.FillRectangle(redBrush, borderRight);
            e.Graphics.FillRectangle(redBrush, borderTop);
            e.Graphics.FillRectangle(redBrush, borderBottom);
        }
    }
}