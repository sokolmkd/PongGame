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
        public GameMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            Form1 forma = new Form1(true);
            this.Hide();
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.ShowDialog();
            this.Show();
        }

        private void picb3_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1(false);
            this.Hide();
            forma.StartPosition = FormStartPosition.CenterScreen;
            forma.ShowDialog();
            this.Show();
        }
      
        //dekoracija na kopcinjata
        private void picb2_MouseDown(object sender, MouseEventArgs e)
        {
                picb2.BorderStyle = BorderStyle.Fixed3D;  
        }

        private void picb2_MouseUp(object sender, MouseEventArgs e)
        {
            picb2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb2_MouseLeave(object sender, EventArgs e)
        {
            picb2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb3_MouseDown(object sender, MouseEventArgs e)
        {
            picb3.BorderStyle = BorderStyle.Fixed3D;  
        }

        private void picb3_MouseLeave(object sender, EventArgs e)
        {
            picb3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb3_MouseUp(object sender, MouseEventArgs e)
        {
            picb3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picb5_Click(object sender, EventArgs e)
        {

        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

        }

       
    }
}
