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
    public partial class Form1 : Form
    {
        private bool BOT;
        Palka Player1,Player2;
        Topka topka;
        Igra igra;
       

        const int SCREEN_WIDTH = 800;
        const int SCREEN_HEIGHT = 600;

        Size sizePlayer = new Size(25, 100);
        Size sizeAI = new Size(25, 100);
        Size sizeBall = new Size(20, 20);

        int ballSpeedX = 3;
        int ballSpeedY = 3;
       
       
        public Form1()
        {
            
            
            InitializeComponent();
        }

        public Form1(bool BOT) //konstruktor za povikuvanje od prethodna forma single ili multiplayer
        {
            this.BOT = BOT; 
            InitializeComponent();
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
           Player1.player2Movement(e);
            if(e.KeyCode==Keys.Up||e.KeyCode==Keys.Down)
           Player2.player2Movement(e);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Player1 = new Palka(this,sizePlayer,false);
            Player2 = new Palka(this,sizeAI,BOT); //AI true,false
            
            
          

            this.Width = SCREEN_WIDTH;//sets the Form's Width
            this.Height = SCREEN_HEIGHT;//sets the Form's Height
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen
         

            Player1.Pbox.Location = new Point(Player1.Pbox.Width / 2, ClientSize.Height / 2 - Player1.Pbox.Height / 2);//sets it's location (centered)
            Player1.Pbox.BackColor = Color.Blue;
            this.Controls.Add(Player1.Pbox);



            Player2.Pbox.Location = new Point(ClientSize.Width - (Player2.Pbox.Width + Player2.Pbox.Width / 2), ClientSize.Height / 2 - Player1.Pbox.Height / 2);
            Player2.Pbox.BackColor = Color.Red;
            this.Controls.Add(Player2.Pbox);

            //picBoxBall.Size = sizeBall;
          //  picBoxBall.Location = new Point(ClientSize.Width / 2 - picBoxBall.Width / 2, ClientSize.Height / 2 - picBoxBall.Height / 2);
          //  picBoxBall.BackColor = Color.Green;
          //  this.Controls.Add(picBoxBall);

            topka = new Topka(sizeBall,ballSpeedX,ballSpeedY);
            topka.Ball.Location = new Point(ClientSize.Width / 2 - topka.Ball.Width / 2, ClientSize.Height / 2 - topka.Ball.Height / 2);
            topka.Ball.BackColor = Color.Green;
            this.Controls.Add(topka.Ball);

            igra = new Igra(this, Player1, Player2, topka);
        }
    }
}
