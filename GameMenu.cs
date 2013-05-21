using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameMenu : Form
    {
       private PictureBox picbEasy, picbMedium, picbHard, picbNinja, picbBack;
       private bool menuCh;
        
        public GameMenu()
        {
            InitializeComponent();
            
            picbEasy = new PictureBox();
            picbMedium = new PictureBox();
            picbHard = new PictureBox();
            picbNinja = new PictureBox();
            picbBack = new PictureBox();
            picbEasy.Image = Properties.Resources.Easy_01691;
            picbEasy.Size = picbSinglePlayer.Size;
            picbMedium.Size = picbSinglePlayer.Size;
            picbHard.Size = picbSinglePlayer.Size;
            picbNinja.Size = picbSinglePlayer.Size;
            picbBack.Size = picbSinglePlayer.Size; 
            picbMedium.Image = Properties.Resources.Medium_01793;
            picbHard.Image = Properties.Resources.Hard_02014;
            picbNinja.Image = Properties.Resources.Ninja_02111;
            picbBack.Image = Properties.Resources.Back_02202;
            picbEasy.Location = picbSinglePlayer.Location;
            picbMedium.Location = picbTwoPlayers.Location;
            picbHard.Location = picbHighScore.Location;
            picbNinja.Location = picbAbout.Location;
            picbBack.Location = picbExit.Location;
            picbEasy.BorderStyle = picbMedium.BorderStyle = picbHard.BorderStyle = picbNinja.BorderStyle = picbBack.BorderStyle = BorderStyle.FixedSingle;
            picbEasy.Visible = false;
            picbMedium.Visible = false;
            picbNinja.Visible = false;
            picbHard.Visible = false;
            picbBack.Visible = false;
            menuCh = true;
            this.Controls.Add(picbEasy);
            this.Controls.Add(picbMedium);
            this.Controls.Add(picbHard);
            this.Controls.Add(picbNinja);
            this.Controls.Add(picbBack);
            picbEasy.MouseClick += picbEasy_MouseClick;
            picbMedium.MouseClick += picbMedium_MouseClick;
            picbHard.MouseClick += picbHard_MouseClick;
            picbNinja.MouseClick += picbNinja_MouseClick;
            picbBack.MouseClick += picbBack_MouseClick;

           
        }

        void picbBack_MouseClick(object sender, MouseEventArgs e)
        {
            
                menuCh = !menuCh;
                MenuChange();
            
        }

        void picbNinja_MouseClick(object sender, MouseEventArgs e)
        {

            Form1 forma = new Form1(true, 8,true);
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        void picbHard_MouseClick(object sender, MouseEventArgs e)
        {

            Form1 forma = new Form1(true,8);
            this.Hide();
            forma.ShowDialog();
            this.Show();
           
        }

        void picbMedium_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 forma = new Form1(true,6);
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

     

        void picbEasy_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 forma = new Form1(true,4);
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }


        private void MenuChange()
        {
            picbSinglePlayer.Visible = menuCh;
            picbTwoPlayers.Visible = menuCh;
            picbHighScore.Visible = menuCh;
            picbExit.Visible = menuCh;
            picbAbout.Visible = menuCh;

            picbEasy.Visible = !menuCh;
            picbMedium.Visible = !menuCh;
            picbNinja.Visible = !menuCh;
            picbHard.Visible = !menuCh;
            picbBack.Visible = !menuCh;
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menuCh = !menuCh;
            MenuChange();
            
            
        }

        private void picb3_Click(object sender, EventArgs e)
        {
        
            Form1 forma = new Form1();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
      
        //dekoracija na kopcinjata
        private void picb2_MouseDown(object sender, MouseEventArgs e)
        {
                picbSinglePlayer.BorderStyle = BorderStyle.Fixed3D;  
        }

        private void picb2_MouseUp(object sender, MouseEventArgs e)
        {
            picbSinglePlayer.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb2_MouseLeave(object sender, EventArgs e)
        {
           
            picbSinglePlayer.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb3_MouseDown(object sender, MouseEventArgs e)
        {
            picbTwoPlayers.BorderStyle = BorderStyle.Fixed3D;  
        }

        private void picb3_MouseLeave(object sender, EventArgs e)
        {
            picbTwoPlayers.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb3_MouseUp(object sender, MouseEventArgs e)
        {
            picbTwoPlayers.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb5_Click(object sender, EventArgs e)
        {

        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }

        
        private void picbExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void picbExit_MouseDown(object sender, MouseEventArgs e)
        {
            picbExit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picbExit_MouseUp(object sender, MouseEventArgs e)
        {
            picbExit.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picbExit_MouseLeave(object sender, EventArgs e)
        {
            picbExit.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
