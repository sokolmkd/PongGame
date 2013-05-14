using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
  
    class Igra
    {
        public Timer GameTime { get; set; }
        public Palka Player1 { get; set; }
        public Palka Player2 { get; set; }
        public Topka Topka1 { get; set; }
        private Form1 f;
        public Label Score1 { get; set; }
        public Label Score2 { get; set; }
        public int predY;
        int brojac = 0;

        public Igra(Form1 f,Palka Player1,Palka Player2,Topka Topka1)
        {
            this.f = f;
            this.Topka1 = Topka1;
            this.Player1 = Player1;
            this.Player2 = Player2;
            Score1 = new Label();
            Score2 = new Label();
            Score1.Text = "0";
            Score2.Text = "0";
            Score1.Location=new Point(100, 500);
            Score2.Location = new Point(700, 500);
            Score1.Font = new Font(Score1.Font.FontFamily, Score1.Font.Size + 5, Score1.Font.Style);
            Score2.Font = new Font(Score2.Font.FontFamily, Score2.Font.Size + 5, Score2.Font.Style);
            this.f.Controls.Add(Score1);
            if (!Player2.AI)
            {
                this.f.Controls.Add(Score2);
                f.KeyDown += new KeyEventHandler(f.Form1_KeyDown);
            }
            GameTime = new Timer();//Initializes the Timer

            GameTime.Enabled = true;//Enables the Timer
            GameTime.Interval = 1;//Set the timer's interval in miliseconds

            GameTime.Tick += new EventHandler(gameTime_Tick);//Creates the Timer's Tick event

            if (!File.Exists("highscore.dat"))
                File.Create("highscore.dat");
            
        }


        public void resetBall()
        {
            Topka1.Ball.Location = new Point(700, f.ClientSize.Height / 2 - Topka1.Ball.Height / 2);
            Topka1.SpeedX = -Math.Abs(Topka1.SpeedX);

        }

        public void GameOver1()
        {
 
            File.AppendAllText("highscore.dat", Score1.Text+Environment.NewLine);
        }


        public void GameOver2()
        {
            File.AppendAllText("highscore.dat", Score2.Text + Environment.NewLine);
        }

       public void padlleCollision()
        {
          
            if (Topka1.Ball.Bounds.IntersectsWith(Player2.Pbox.Bounds))
            {
                Topka1.SpeedX = -Topka1.SpeedX;
                Score2.Text = (int.Parse(Score2.Text) + 10).ToString();
                new System.Media.SoundPlayer(Properties.Resources.bounce).Play();
                brojac++;
            }

            if (Topka1.Ball.Bounds.IntersectsWith(Player1.Pbox.Bounds))
            {
                Topka1.SpeedX = -Topka1.SpeedX;
                //Score1.Text = (int.Parse(Score1.Text) + 10).ToString();
                new System.Media.SoundPlayer(Properties.Resources.bounce).Play();
                brojac++;
            }
            if (brojac == 3 && Topka1.SpeedX < 16)
            {

                Score1.Text = Topka1.SpeedX.ToString();
                Topka1.SpeedX = (int)(Topka1.SpeedX * 1.2);
                Topka1.SpeedY = (int)(Topka1.SpeedY * 1.2);
                brojac = 0;
            }
        }

       public void gameAreaCollisions()
       {
           if (Topka1.Ball.Location.Y > f.ClientSize.Height - Topka1.Ball.Height || Topka1.Ball.Location.Y < 0)
           {
               Topka1.SpeedY = -Topka1.SpeedY;
               new System.Media.SoundPlayer(Properties.Resources.bounce_wall).Play();
           }
           else if (Topka1.Ball.Location.X > f.ClientSize.Width)
           {
               resetBall();
               //GameOver2();
           }
           else if (Topka1.Ball.Location.X < 0)
           {
               resetBall();
               //GameOver1();
           }
       }
      
        void gameTime_Tick(object sender, EventArgs e)
        {
            predY = Topka1.Ball.Location.Y;
            Topka1.Ball.Location = new Point(Topka1.Ball.Location.X + Topka1.SpeedX, Topka1.Ball.Location.Y + Topka1.SpeedY);
            gameAreaCollisions();//Checks for collisions with the form's border
            padlleCollision();//Checks for collisions with the padlles

            if (Player2.AI)
            {
                Player1.playerMovement(Cursor.Position);//Updates the player's position
                Player2.aiMovement(Cursor.Position, Topka1,predY);//Updates the ai's position
            }

            
            
            
        }
        

    }
}
