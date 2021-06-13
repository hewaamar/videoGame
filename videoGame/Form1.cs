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
        // set up keys
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;

        // jumping
        int jumpSpeed = 5;
        int force = 8;




        int playerSpeed = 10;

        int backgroundSpeed = 8;
        int playerScore = 0;



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

            score.Text = $"Score: {playerScore}";
            character.Top += jumpSpeed;


            // advance character left/right while moving background
            if (goLeft == true)
            {
                character.Left -= playerSpeed;
                background.Left += backgroundSpeed;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform")
                    {
                        x.Left += backgroundSpeed;
                    }
                }

                if (goRight == true)
                {
                    character.Left += playerSpeed;
                    background.Left -= backgroundSpeed;

                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox && x.Tag == "platform")
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

                if (character.Top + character.Height >= this.Height)
                {
                    character.Top -= force;
                    force -= 1;
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" && !jumping)
                    {
                        if (character.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            character.Top = x.Top - character.Height;
                        }
                    }
                }
            }

        }
    }

}

