using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApplication1
{
    class Palka
    {
        public PictureBox Pbox { get; set; }
        public Size Golemina { get; set; }
        public bool AI { get; set; }  //Dali e bot
        private Form1 f;

        public Palka(Form1 f,Size Golemina,bool AI)
        {
            Pbox =new PictureBox();
            this.Pbox.Size = Golemina;
            this.Golemina = Golemina;
            this.f = f;
            this.AI = AI;
          
        }

        public Palka() { }

        public void playerMovement(Point m)
        {


            if (f.PointToClient(m).Y >= Pbox.Height / 2 && f.PointToClient(m).Y <= f.ClientSize.Height - Pbox.Height / 2)
            {
                int playerX = Pbox.Width / 2;
                int playerY = f.PointToClient(m).Y - Pbox.Height / 2;

                Pbox.Location = new Point(playerX, playerY);
            }
        }

        public void aiMovement(Point m, Topka t, int predY)
        {
            Random r = new Random();

            int g = r.Next(0, 25);
            int raz = t.Ball.Location.Y - predY;
            if (g < 4 && !f.flag)
                raz = 0;
           

  //          Ako g < 5 togash palkata na AI ostanuva vo mesto so shto ne ja sledi dovolno brzo topkata 
            if (t.SpeedX > 0 && !f.flag)
            {

                if (Pbox.Location.Y > 470 && raz > 0)
                {
                    raz = 0;
                }
                else if (Pbox.Location.Y < 10 && raz < 0)
                {
                    raz = 0;
                }
                Pbox.Location = new Point(f.ClientSize.Width - (Pbox.Width + Pbox.Width / 2), Pbox.Location.Y + raz);
            }
            else
            {
                if (Pbox.Location.Y > 470 && raz > 0)
                {
                    raz = 0;
                }
                else if (Pbox.Location.Y < 10 && raz < 0)
                {
                    raz = 0;
                }
                Pbox.Location = new Point(f.ClientSize.Width - (Pbox.Width + Pbox.Width / 2), Pbox.Location.Y + raz);
            }
        }

        public void player2Movement(KeyEventArgs e)  
        {
            if (e.KeyCode == Keys.W)
            {
                if (Pbox.Location.Y >= Pbox.Height / 2 - 35 && Pbox.Location.Y <= f.ClientSize.Height - Pbox.Height / 2 - 40)
                {
                    int playerX = Pbox.Width / 2;
                    int playerY = Pbox.Location.Y - 20;
                    Pbox.Location = new Point(playerX, playerY);
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (Pbox.Location.Y >= Pbox.Height / 2 - 40 && Pbox.Location.Y <= f.ClientSize.Height - Pbox.Height / 2 - 60)
                {
                    int playerX = Pbox.Width / 2;
                    int playerY = Pbox.Location.Y + 20;
                    Pbox.Location = new Point(playerX, playerY);
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (Pbox.Location.Y >= Pbox.Height / 2 - 35 && Pbox.Location.Y <= f.ClientSize.Height - Pbox.Height / 2 - 40)
                {
                    int playerY = Pbox.Location.Y - 20;
                    Pbox.Location = new Point(Pbox.Location.X, playerY);
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Pbox.Location.Y >= Pbox.Height / 2 - 40 && Pbox.Location.Y <= f.ClientSize.Height - Pbox.Height / 2 - 60)
                {

                    int playerY = Pbox.Location.Y + 20;
                    Pbox.Location = new Point(Pbox.Location.X, playerY);
                }
            }
           
        }

    }
}
