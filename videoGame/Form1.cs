using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoGame
{
    public partial class Form1 : Form
    {

        List<Rectangle> obstacle = new List<Rectangle>();
        int obstacleHeight = 50;
        int obstacleWidth = 15;
        int obstacleX = 50;
        int obstacleSpeed = 5;
        SolidBrush obstacleBrush = new SolidBrush(Color.HotPink);
        int obstacleCounter = 0;

        // set up movement directions
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        // set up speeds/forces
        int characterSpeed = 0;
        int jumpSpeed = 12;
        int force = 8;
        int backgroundSpeed = 5;


        int playerSpeed = 10;

  
        int playerScore = 0;
        int coinValue = 5;

        List<Rectangle> leftRectangle = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            coin1.Image = Properties.Resources.movingCoin;
            score.Text = $"Score: {playerScore}";

            character.Top += jumpSpeed;

            // move rectangles
            for (int i = 0; i < obstacle.Count(); i++)
            {
                int y = obstacle[i].Y + obstacleSpeed;

                obstacle[i] = new Rectangle(obstacle[i].X, y, obstacleWidth, obstacleHeight);
            }

            // add more obstacles
            obstacleCounter++;

            if (obstacleCounter% 32 == 0)
            {
                obstacle.Add(new Rectangle(obstacle[1].X, 0 - this.Height, obstacleWidth, obstacleHeight));
            }
            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (goLeft)
            {
                character.Left -= characterSpeed;
                background.Left += backgroundSpeed;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform")
                    {
                        x.Left += backgroundSpeed;
                    }
                }

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "coin")
                    {
                        x.Left += backgroundSpeed;
                    }
                }
            }

            if (goRight)
            {
                character.Left += characterSpeed;
                background.Left -= backgroundSpeed;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform")
                    {
                        x.Left -= backgroundSpeed;
                    }
                }

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "coin")
                    {
                        x.Left -= backgroundSpeed;
                    }
                }
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (character.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        character.Top = x.Top - character.Height;
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (character.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                        playerScore = playerScore + coinValue;
                        score.Text = $"Score: {playerScore}";
                    }
                }
            }
            Refresh();


        }

        private void score_Paint(object sender, PaintEventArgs e)
        {
            // paint obstacles
            for (int i = 0; i < obstacle.Count(); i++)
            {
                e.Graphics.FillRectangle(obstacleBrush, obstacle[i]);
            }

        }
    }
    }


