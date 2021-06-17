﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace videoGame
{
    public partial class Form1 : Form
    {
        // SET UP OBSTACLES
        List<Rectangle> obstacle = new List<Rectangle>();
        List<PictureBox> leftPic = new List<PictureBox>();
        int obstacleHeight = 20;
        int obstacleWidth = 10;
        int obstacle1X = 200;
        int obstacle2X = 500;
        int obstacle3X = 740;
        int obstacleSpeed = 5;
        int obstacleCounter = 0;
        SolidBrush obstacleBrush = new SolidBrush(Color.HotPink);

        // set up character movements
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        // set up speeds/forces for character + game layout
        int characterSpeed = 0;
        int jumpSpeed = 12;
        int force = 8;
        int backgroundSpeed = 5;
        int playerSpeed = 10;

        // score
        int playerScore = 0;
        int coinValue = 5;

        // set up graphics
        Graphics bgGraphics;

        // Set up soundplayer
         SoundPlayer musicPlayer;
        SoundPlayer coinPlayer;

        public Form1()
        {
            InitializeComponent();
            // set up graphics
            bgGraphics = background.CreateGraphics();

            //musicPlayer = new SoundPlayer(Properties.Resources.mainSong);

            // make door visible
            door.Visible = true;

           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // key down event
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

        private void Form1_KeyUp(object sender, KeyEventArgs e) // key yp event
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


        public void GameStart()
        {
            gameTimer.Enabled = true; // enable game timer
            winLoseBox.Visible = false;
            background.Image = null;
            background.BackgroundImage = null;
            character.Parent = background;
        }

        public void GameWin() // screen layout for win game
        {
            gameTimer.Enabled = false;
            winLoseBox.Visible = true;
            winLoseBox.BackgroundImage = Properties.Resources.winner;
            winLoseBox.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Parent = winLoseBox;
            playAgainButton.Parent = winLoseBox;
            exitButton.Visible = true;
            playAgainButton.Visible = true;



        }

        public void GameLose() // screen layout for win game
        {
            gameTimer.Enabled = false;
            winLoseBox.Visible = true;
            winLoseBox.BackgroundImage = Properties.Resources.loser;
            winLoseBox.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Parent = winLoseBox;
            playAgainButton.Parent = winLoseBox;
            exitButton.Visible = true;
            playAgainButton.Visible = true;

        }

        //private void GameLose()
        //{
        //    winl
        //}
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            // score label
            score.Text = $"Score: {playerScore}";

            // move character
            character.Top += jumpSpeed;

            // move character left, and game components in the opposite direction
            if (goLeft)
            {
                character.Left -= characterSpeed;
                background.Left += backgroundSpeed;
                door.Left += backgroundSpeed;

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

            // move character right, and game components in the opposite direction
            if (goRight)
            {
                character.Left += characterSpeed;
                background.Left -= backgroundSpeed;
                door.Left -= backgroundSpeed;
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

            // make character jump
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            // create "gravity" so character goes back down after jumping 
            if (jumping && force < 0)
            {
                jumping = false;
            }



            // move obstacles
            for (int i = 0; i < leftPic.Count(); i++)
            {
                int y = leftPic[i].Location.Y + obstacleSpeed;
                
                leftPic[i].Location = new Point(leftPic[i].Location.X, y);
              
            }

            // add more obstacles
            obstacleCounter++;

            if (obstacleCounter% 60 == 0)
            {
                
              //  obstacle.Add(new Rectangle(obstacle1X, 0 - this.Height, obstacleWidth, obstacleHeight)); // first obstacle
                PictureBox newObs = new PictureBox();
                newObs.Location = new Point(obstacle1X, 0 - this.Height);
                newObs.Size = new Size(obstacleWidth, obstacleHeight);
                newObs.BackgroundImage = Properties.Resources.obstaclePic;
                 newObs.Parent = background;
                newObs.BringToFront();
                newObs.Tag = "obstacle";
                leftPic.Add(newObs);



                obstacle.Add(new Rectangle(obstacle2X, 0 - this.Height, obstacleWidth, obstacleHeight)); // second obstacle
                PictureBox newObs2 = new PictureBox();
                newObs2.Location = new Point(obstacle2X, 0 - this.Height);
                newObs2.Size = new Size(obstacleWidth, obstacleHeight);
                newObs2.BackgroundImage = Properties.Resources.obstaclePic;
                newObs2.Parent = background;
                leftPic.Add(newObs2);

                obstacle.Add(new Rectangle(obstacle3X, 0 - this.Height, obstacleWidth, obstacleHeight)); // third obstacle
                PictureBox newObs3 = new PictureBox();
                newObs3.Location = new Point(obstacle3X, 0 - this.Height);
                newObs3.Size = new Size(obstacleWidth, obstacleHeight);
                newObs3.BackgroundImage = Properties.Resources.obstaclePic;
                newObs3.Parent = background;
                leftPic.Add(newObs3);

            }

            // remove obstacles offscreen
            for (int i = 0; i < leftPic.Count(); i++)
            {
                if (leftPic[i].Location.Y > this.Height)
                {
                    leftPic.RemoveAt(i);
                }
            }


            // platform collision
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

            // coin collision
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (character.Bounds.IntersectsWith(x.Bounds))
                    {
                       

                        x.Visible = false;
                        playerScore = playerScore + coinValue;
                        score.Text = $"Score: {playerScore}";
                        Refresh();
                    }
                }
            }

            // door collision (win)
            if (character.Bounds.IntersectsWith(door.Bounds))
            {

                GameWin();

            }

            // obstacle collision (lose)
            for (int i = 0; i < leftPic.Count(); i++)
            {
                if (character.Bounds.IntersectsWith(leftPic[i].Bounds))
                {
                    gameTimer.Enabled = false;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    if (character.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Enabled = false;
                    }
                }
            }
 

            if (character.Location.Y > this.Height)
            {
                GameLose();
            }


           Refresh();
        }

       

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {

            winLoseBox.Visible = false;
            GameStart();

            
            
          

        }

        
    }
    }


