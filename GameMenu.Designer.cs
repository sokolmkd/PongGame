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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picb2 = new System.Windows.Forms.PictureBox();
            this.picb3 = new System.Windows.Forms.PictureBox();
            this.picb4 = new System.Windows.Forms.PictureBox();
            this.picb5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picb2
            // 
            this.picb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb2.Image = ((System.Drawing.Image)(resources.GetObject("picb2.Image")));
            this.picb2.Location = new System.Drawing.Point(63, 131);
            this.picb2.Name = "picb2";
            this.picb2.Size = new System.Drawing.Size(302, 52);
            this.picb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picb2.TabIndex = 1;
            this.picb2.TabStop = false;
            this.picb2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.picb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picb2_MouseDown);
            this.picb2.MouseLeave += new System.EventHandler(this.picb2_MouseLeave);
            this.picb2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picb2_MouseUp);
            // 
            // picb3
            // 
            this.picb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb3.Image = ((System.Drawing.Image)(resources.GetObject("picb3.Image")));
            this.picb3.Location = new System.Drawing.Point(63, 211);
            this.picb3.Name = "picb3";
            this.picb3.Size = new System.Drawing.Size(302, 52);
            this.picb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picb3.TabIndex = 2;
            this.picb3.TabStop = false;
            this.picb3.Click += new System.EventHandler(this.picb3_Click);
            this.picb3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picb3_MouseDown);
            this.picb3.MouseLeave += new System.EventHandler(this.picb3_MouseLeave);
            this.picb3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picb3_MouseUp);
            // 
            // picb4
            // 
            this.picb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb4.Image = ((System.Drawing.Image)(resources.GetObject("picb4.Image")));
            this.picb4.Location = new System.Drawing.Point(63, 291);
            this.picb4.Name = "picb4";
            this.picb4.Size = new System.Drawing.Size(302, 52);
            this.picb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picb4.TabIndex = 3;
            this.picb4.TabStop = false;
            // 
            // picb5
            // 
            this.picb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb5.Image = ((System.Drawing.Image)(resources.GetObject("picb5.Image")));
            this.picb5.Location = new System.Drawing.Point(63, 371);
            this.picb5.Name = "picb5";
            this.picb5.Size = new System.Drawing.Size(302, 52);
            this.picb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picb5.TabIndex = 4;
            this.picb5.TabStop = false;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 453);
            this.Controls.Add(this.picb5);
            this.Controls.Add(this.picb4);
            this.Controls.Add(this.picb3);
            this.Controls.Add(this.picb2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picb2;
        private System.Windows.Forms.PictureBox picb3;
        private System.Windows.Forms.PictureBox picb4;
        private System.Windows.Forms.PictureBox picb5;
    }
}