using System;
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

            winLoseBox.Visible = false;

           
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

        public void GameWin() // screen layout for win game
        {
            gameTimer.Enabled = false;
            winLoseBox.Visible = true;
            winLoseBox.BackgroundImage = Properties.Resources.winner;
            winLoseBox.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Parent = winLoseBox;
            exitButton.Visible = true;
        }

        public void GameLose() // screen layout for win game
        {
            gameTimer.Enabled = false;
            winLoseBox.Visible = true;
            winLoseBox.BackgroundImage = Properties.Resources.loser;
            winLoseBox.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.Parent = winLoseBox;
            exitButton.Visible = true;
        }

      
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

    }
    }


