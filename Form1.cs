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
       public bool flag;

        const int SCREEN_WIDTH = 800;
        const int SCREEN_HEIGHT = 600;

        Size sizePlayer = new Size(10, 100);
        Size sizeAI = new Size(10, 100);
        Size sizeBall = new Size(30, 30);

        int ballSpeedX=6;
        int ballSpeedY=6;
       
       
        public Form1()
        {
                     
            InitializeComponent();
        
           
            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 

        public Form1(bool BOT,int AISpeed,bool f=false) //konstruktor za povikuvanje od prethodna forma single ili multiplayer
        {
            flag = f;
            this.BOT = BOT;
            ballSpeedX = ballSpeedY = AISpeed;
            InitializeComponent();
        }

        public Form1(bool BOT) //konstruktor za povikuvanje od prethodna forma single ili multiplayer
        {
            this.BOT = BOT;
            
            InitializeComponent();
            this.DoubleBuffered = true;
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
           
            Player1 = new Palka(this,sizePlayer,false,flag);
            Player2 = new Palka(this,sizeAI,BOT,flag); //AI true,false



            this.BackgroundImage = Properties.Resources.bg_body;
            this.Width = SCREEN_WIDTH;//sets the Form's Width
            this.Height = SCREEN_HEIGHT;//sets the Form's Height
            this.StartPosition = FormStartPosition.CenterScreen;//opens the form in center of the screen
         

            Player1.Pbox.Location = new Point(Player1.Pbox.Width / 2, ClientSize.Height / 2 - Player1.Pbox.Height / 2);//sets it's location (centered)
            Player1.Pbox.BackColor = Color.Blue;
            this.Controls.Add(Player1.Pbox);



            Player2.Pbox.Location = new Point(ClientSize.Width - (Player2.Pbox.Width + Player2.Pbox.Width / 2), ClientSize.Height / 2 - Player1.Pbox.Height / 2);
            Player2.Pbox.BackColor = Color.Red;
            this.Controls.Add(Player2.Pbox);

          

            topka = new Topka(sizeBall,ballSpeedX,ballSpeedY);
            topka.Ball.Location = new Point(ClientSize.Width / 2 - topka.Ball.Width / 2, ClientSize.Height / 2 - topka.Ball.Height / 2);
           
           //topka.Ball.Image = Properties.Resources.logo;
            this.Controls.Add(topka.Ball);

            igra = new Igra(this, Player1, Player2, topka,flag);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            igra.GameTime.Stop();
        }
    }
}
