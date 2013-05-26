namespace WindowsFormsApplication1
{
    partial class GameMenu
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
            this.picbAbout = new System.Windows.Forms.PictureBox();
            this.picbHighScore = new System.Windows.Forms.PictureBox();
            this.picbTwoPlayers = new System.Windows.Forms.PictureBox();
            this.picbSinglePlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbHighScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbTwoPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbSinglePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picbAbout
            // 
            this.picbAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbAbout.Image = global::WindowsFormsApplication1.Properties.Resources.About_22939;
            this.picbAbout.Location = new System.Drawing.Point(63, 365);
            this.picbAbout.Name = "picbAbout";
            this.picbAbout.Size = new System.Drawing.Size(302, 52);
            this.picbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbAbout.TabIndex = 4;
            this.picbAbout.TabStop = false;
            this.picbAbout.Click += new System.EventHandler(this.picb5_Click);
            // 
            // picbHighScore
            // 
            this.picbHighScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbHighScore.Image = global::WindowsFormsApplication1.Properties.Resources.High_Score_22913;
            this.picbHighScore.Location = new System.Drawing.Point(63, 287);
            this.picbHighScore.Name = "picbHighScore";
            this.picbHighScore.Size = new System.Drawing.Size(302, 52);
            this.picbHighScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbHighScore.TabIndex = 3;
            this.picbHighScore.TabStop = false;
            this.picbHighScore.Click += new System.EventHandler(this.picbHighScore_Click);
            // 
            // picbTwoPlayers
            // 
            this.picbTwoPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbTwoPlayers.Image = global::WindowsFormsApplication1.Properties.Resources.Two_Players_22802;
            this.picbTwoPlayers.Location = new System.Drawing.Point(63, 209);
            this.picbTwoPlayers.Name = "picbTwoPlayers";
            this.picbTwoPlayers.Size = new System.Drawing.Size(302, 52);
            this.picbTwoPlayers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbTwoPlayers.TabIndex = 2;
            this.picbTwoPlayers.TabStop = false;
            this.picbTwoPlayers.Click += new System.EventHandler(this.picb3_Click);
            this.picbTwoPlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picb3_MouseDown);
            this.picbTwoPlayers.MouseLeave += new System.EventHandler(this.picb3_MouseLeave);
            this.picbTwoPlayers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picb3_MouseUp);
            // 
            // picbSinglePlayer
            // 
            this.picbSinglePlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbSinglePlayer.Image = global::WindowsFormsApplication1.Properties.Resources.Single_Playe_22667;
            this.picbSinglePlayer.Location = new System.Drawing.Point(63, 131);
            this.picbSinglePlayer.Name = "picbSinglePlayer";
            this.picbSinglePlayer.Size = new System.Drawing.Size(302, 52);
            this.picbSinglePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbSinglePlayer.TabIndex = 1;
            this.picbSinglePlayer.TabStop = false;
            this.picbSinglePlayer.Click += new System.EventHandler(this.pictureBox2_Click);
            this.picbSinglePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picb2_MouseDown);
            this.picbSinglePlayer.MouseLeave += new System.EventHandler(this.picb2_MouseLeave);
            this.picbSinglePlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picb2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.PONG_20563;
            this.pictureBox1.Location = new System.Drawing.Point(107, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picbExit
            // 
            this.picbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbExit.Image = global::WindowsFormsApplication1.Properties.Resources.Exit_02228;
            this.picbExit.Location = new System.Drawing.Point(63, 443);
            this.picbExit.Name = "picbExit";
            this.picbExit.Size = new System.Drawing.Size(302, 52);
            this.picbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbExit.TabIndex = 5;
            this.picbExit.TabStop = false;
            this.picbExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbExit_MouseClick);
            this.picbExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbExit_MouseDown);
            this.picbExit.MouseLeave += new System.EventHandler(this.picbExit_MouseLeave);
            this.picbExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbExit_MouseUp);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 519);
            this.Controls.Add(this.picbExit);
            this.Controls.Add(this.picbAbout);
            this.Controls.Add(this.picbHighScore);
            this.Controls.Add(this.picbTwoPlayers);
            this.Controls.Add(this.picbSinglePlayer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameMenu";
            this.Text = "Pong Game";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbHighScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbTwoPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbSinglePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbSinglePlayer;
        private System.Windows.Forms.PictureBox picbTwoPlayers;
        private System.Windows.Forms.PictureBox picbHighScore;
        private System.Windows.Forms.PictureBox picbAbout;
        private System.Windows.Forms.PictureBox picbExit;
    }
}