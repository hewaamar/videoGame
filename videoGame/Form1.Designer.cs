
namespace videoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.winLoseBox = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.winLoseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Enabled = false;
            this.score.Font = new System.Drawing.Font("Consolas", 12F);
            this.score.ForeColor = System.Drawing.Color.MidnightBlue;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(146, 37);
            this.score.TabIndex = 12;
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLoseBox
            // 
            this.winLoseBox.Location = new System.Drawing.Point(-3, -1);
            this.winLoseBox.Name = "winLoseBox";
            this.winLoseBox.Size = new System.Drawing.Size(473, 513);
            this.winLoseBox.TabIndex = 17;
            this.winLoseBox.TabStop = false;
            this.winLoseBox.Visible = false;
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door.BackgroundImage")));
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.door.Location = new System.Drawing.Point(1309, 45);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(69, 98);
            this.door.TabIndex = 16;
            this.door.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1004, 197);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 35);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(822, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(649, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin1.BackgroundImage")));
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin1.Location = new System.Drawing.Point(395, 136);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(33, 35);
            this.coin1.TabIndex = 8;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // platform4
            // 
            this.platform4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform4.BackgroundImage")));
            this.platform4.Location = new System.Drawing.Point(970, 238);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(100, 50);
            this.platform4.TabIndex = 7;
            this.platform4.TabStop = false;
            this.platform4.Tag = "platform";
            // 
            // platform3
            // 
            this.platform3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform3.BackgroundImage")));
            this.platform3.Location = new System.Drawing.Point(784, 177);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(100, 50);
            this.platform3.TabIndex = 6;
            this.platform3.TabStop = false;
            this.platform3.Tag = "platform";
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("character.BackgroundImage")));
            this.character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.character.Location = new System.Drawing.Point(165, 106);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(54, 53);
            this.character.TabIndex = 5;
            this.character.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(1163, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(215, 50);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // platform2
            // 
            this.platform2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform2.BackgroundImage")));
            this.platform2.Location = new System.Drawing.Point(617, 222);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(100, 50);
            this.platform2.TabIndex = 3;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // platform1
            // 
            this.platform1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform1.BackgroundImage")));
            this.platform1.Location = new System.Drawing.Point(359, 177);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(100, 50);
            this.platform1.TabIndex = 2;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // platform
            // 
            this.platform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform.BackgroundImage")));
            this.platform.Location = new System.Drawing.Point(143, 222);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(100, 50);
            this.platform.TabIndex = 1;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // background
            // 
            this.background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background.BackgroundImage")));
            this.background.Location = new System.Drawing.Point(-3, -1);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1385, 346);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightCoral;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.exitButton.Location = new System.Drawing.Point(60, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.playAgainButton.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.PowderBlue;
            this.playAgainButton.Location = new System.Drawing.Point(254, 383);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(151, 50);
            this.playAgainButton.TabIndex = 19;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1379, 504);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.winLoseBox);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.character);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.winLoseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox winLoseBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;
    }
}

