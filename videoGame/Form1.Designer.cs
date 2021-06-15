
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
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
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
            this.score.Paint += new System.Windows.Forms.PaintEventHandler(this.score_Paint);
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Transparent;
            this.coin4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin4.BackgroundImage")));
            this.coin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin4.Location = new System.Drawing.Point(994, 189);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(54, 62);
            this.coin4.TabIndex = 11;
            this.coin4.TabStop = false;
            this.coin4.Tag = "coin";
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin3.BackgroundImage")));
            this.coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin3.Location = new System.Drawing.Point(806, 125);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(54, 62);
            this.coin3.TabIndex = 10;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin2.BackgroundImage")));
            this.coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin2.Location = new System.Drawing.Point(634, 165);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(54, 62);
            this.coin2.TabIndex = 9;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coin1.Location = new System.Drawing.Point(385, 125);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(54, 62);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(509, 504);
            this.Controls.Add(this.score);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
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
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
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
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.Label score;
    }
}

