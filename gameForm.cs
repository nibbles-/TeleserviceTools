using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeleserviceTools
{
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();
        }
        
        //Score
        private int GameScore = 0;
        //Ball settings
        private const int BallWidth = 20;
        private const int BallHeight = 20;
        private int BallX, BallY; //Position
        private int BallVx, BallVy; // Speed
        
        //Paddle settings
        private const int PaddleWidth = 10;
        private const int PaddleHeight = 100;
        private int PaddleX, PaddleY; //Position
        //private int PaddleVy = 0; //Speed
        private bool movePaddleUP=false, movePaddleDOWN=false;

        private void gameForm_Load(object sender, EventArgs e)
        {
            //Random startposition for ball
            Random rnd = new Random();
            BallVx = rnd.Next(2, 2);
            BallVy = rnd.Next(2, 2);
            BallX = rnd.Next(0 + BallWidth, this.ClientSize.Width - BallWidth);
            BallY = rnd.Next(0 + BallHeight, this.ClientSize.Height - BallHeight);

            //Create Paddle
            PaddleX = 10;
            PaddleY = 40;
            
            //Double buffering to reduce flicker
            this.SetStyle(
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }

        private void gameForm_Paint(object sender, PaintEventArgs e)
        {
            //Draw ball
            //e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(System.Drawing.Brushes.Blue, BallX, BallY, BallWidth, BallHeight);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Blue, BallX, BallY, BallWidth, BallHeight);
            //Draw paddle
            e.Graphics.FillRectangle(System.Drawing.Brushes.Black, PaddleX, PaddleY, PaddleWidth, PaddleHeight);
            e.Graphics.DrawRectangle(System.Drawing.Pens.Black, PaddleX, PaddleY, PaddleWidth, PaddleHeight);
            
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //Move the paddle
            if (movePaddleUP)
            {
                if (PaddleY <= 0)
                    PaddleY = 0;
                else
                    PaddleY = PaddleY - 15;
                movePaddleUP = false;
            }
            if(movePaddleDOWN)
            {
                if (PaddleY + PaddleHeight >= this.ClientSize.Height)
                    PaddleY = this.ClientSize.Height - PaddleHeight;
                else
                    PaddleY = PaddleY + 15;
                movePaddleDOWN=false;
            }
            //Move the ball
            BallX += BallVx;
            if (BallX <= PaddleX+PaddleWidth)
            {
                if (BallY >= PaddleY && BallY <= PaddleY + PaddleHeight)
                    BallVx = -BallVx;
                else if (BallX + BallWidth < 0)
                {
                    BallX = this.ClientSize.Width - BallWidth;
                    GameScore -= 1;
                }
                    
            }
            else if (BallX + BallWidth > this.ClientSize.Width)
            {
                BallVx = -BallVx;
            }

            BallY += BallVy;
            if (BallY < 0)
            {
                BallVy = -BallVy;
            }
            else if (BallY + BallHeight > this.ClientSize.Height)
            {
                BallVy = -BallVy;
            }

            //Keep Score
            scoreLabel.Text = GameScore.ToString();

            //Force the form to repaint
            this.Invalidate();
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                movePaddleDOWN = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                movePaddleUP =true;
            }
        }
    }
}
