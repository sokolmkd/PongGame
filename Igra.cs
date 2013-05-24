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
        private int broj = 0;
        public bool ninja = true;
        private List<PictureBox> lista_ninja;
        int brojac = 0;
        private PictureBox bonus;
        private bool bonus_flag = false;
        private int brojac2 = 0;
        private bool skull = false;
        private bool zgolemuvanje = false;
        private int zivoti = 5;
        private bool izgubi = false;
        Label l;
        public void dodaj_ninja()
        {
           
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                PictureBox p = new PictureBox();
                p.Size = new Size(20, 60);
                p.Location = new Point(r.Next(150, 600), r.Next(0, 400));
                p.BackgroundImage = Properties.Resources.cigli;

                lista_ninja.Add(p);
            }

            for (int i = 0; i < lista_ninja.Count; i++)
                    f.Controls.Remove(lista_ninja.ElementAt(i));

            for (int i = 0; i < lista_ninja.Count; i++)
            {
                f.Controls.Add(lista_ninja.ElementAt(i));
            }

        }
        public Igra(Form1 f,Palka Player1,Palka Player2,Topka Topka1,bool nin=false)
        {
            l = new Label();
            l.Text = "Zivoti:" + zivoti;
            l.BackColor = Color.Transparent;
            f.Controls.Add(l); 
            ninja = nin;
            lista_ninja = new List<PictureBox>();
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
            GameTime.Interval =10;//Set the timer's interval in miliseconds

            GameTime.Tick += new EventHandler(gameTime_Tick);//Creates the Timer's Tick event

            if (!File.Exists("highscore.dat"))
                File.Create("highscore.dat");
            if (ninja)
            {
                dodaj_ninja();   
            }
        }


        public void resetBall()
        {
            zivoti--;
            l.Text = "Zivoti:" + zivoti;
            Topka1.Ball.Location = new Point(700, f.ClientSize.Height / 2 - Topka1.Ball.Height / 2);
            Topka1.SpeedX = -Math.Abs(Topka1.SpeedX);
            if (zivoti == 0)
            {
                izgubi = true;
                GameOver1();
                f.Close();
                
            }
           
        }

        public void GameOver1()
        {
            MessageBox.Show("IZGUBI!! Score:" + Score1.Text);
         
            File.AppendAllText("highscore.dat", Score1.Text+Environment.NewLine);
            f.Close();
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
               // Score2.Text = (int.Parse(Score2.Text) + 10).ToString();
                new System.Media.SoundPlayer(Properties.Resources.bounce).Play();
                brojac++;
            }

            if (Topka1.Ball.Bounds.IntersectsWith(Player1.Pbox.Bounds))
            {
                Topka1.SpeedX = -Topka1.SpeedX;
                Score1.Text = (int.Parse(Score1.Text) + 10).ToString();
                new System.Media.SoundPlayer(Properties.Resources.bounce).Play();
                brojac++;
                
            }
            if (brojac == 4 && Topka1.SpeedX < 12)
            {

                //Score1.Text = Topka1.SpeedX.ToString();
                Topka1.SpeedX = (int)(Topka1.SpeedX * 1.1);
                Topka1.SpeedY = (int)(Topka1.SpeedY * 1.1);
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
           
            if (izgubi)
            { }
            else
            {
                broj++;
                brojac2++;
                if (bonus_flag)
                {
                    bonus.Location = new Point(bonus.Location.X - 7, bonus.Location.Y);
                    if (bonus.Bounds.IntersectsWith(Player1.Pbox.Bounds))
                    {
                        if (skull)
                        {
                            Player1.Pbox.Height = 55;
                        }
                        else if (zgolemuvanje)
                        {
                            Player1.Pbox.Height = 130;
                        }
                        else
                        {
                            for (int i = 0; i < lista_ninja.Count; i++)
                            {
                                f.Controls.Remove(lista_ninja.ElementAt(i));

                            }
                            lista_ninja.Clear();
                        }
                        f.Controls.Remove(bonus);
                        bonus_flag = false;
                    }
                    if (bonus.Location.X < 0)
                    {
                        f.Controls.Remove(bonus);
                        bonus_flag = false;
                    }
                }
                if (broj == 1000 && ninja)
                {
                    bonus_flag = true;
                    bonus = new PictureBox();
                    bonus.Size = new Size(30, 30);
                    bonus.BackgroundImage = Properties.Resources._81412_Claw_Hammer;
                    Random r = new Random();
                    bonus.Location = new Point(r.Next(400, 600), r.Next(50, 500));
                    f.Controls.Add(bonus);
                    broj = 0;
                    dodaj_ninja();
                    skull = false;
                    zgolemuvanje = false;
                }
                if (brojac2 == 500 && ninja)
                {
                    bonus_flag = true;
                    bonus = new PictureBox();
                    bonus.Size = new Size(30, 30);
                    bonus.BackgroundImage = Properties.Resources.Anime_skull;
                    Random r = new Random();
                    bonus.Location = new Point(r.Next(400, 600), r.Next(50, 500));
                    f.Controls.Add(bonus);
                    broj = 0;
                    dodaj_ninja();
                    skull = true;
                    zgolemuvanje = false;
                }
                if (brojac2 == 1700 && ninja)
                {
                    bonus_flag = true;
                    bonus = new PictureBox();
                    bonus.Size = new Size(30, 30);
                    bonus.BackgroundImage = Properties.Resources.heinekens;
                    Random r = new Random();
                    bonus.Location = new Point(r.Next(400, 600), r.Next(50, 500));
                    f.Controls.Add(bonus);
                    broj = 0;
                    dodaj_ninja();
                    zgolemuvanje = true;
                }
                predY = Topka1.Ball.Location.Y;
                Topka1.Ball.Location = new Point(Topka1.Ball.Location.X + Topka1.SpeedX, Topka1.Ball.Location.Y + Topka1.SpeedY);
                gameAreaCollisions();//Checks for collisions with the form's border
                padlleCollision();//Checks for collisions with the padlles
                if (ninja)
                {
                    for (int i = 0; i < lista_ninja.Count; i++)
                    {
                        if (Topka1.Ball.Bounds.IntersectsWith(lista_ninja.ElementAt(i).Bounds))
                        {
                            f.Controls.Remove(lista_ninja.ElementAt(i));
                            Topka1.SpeedX = -Topka1.SpeedX;
                            lista_ninja.RemoveAt(i);
                        }

                    }
                }

                if (Player2.AI)
                {
                    Player1.playerMovement(Cursor.Position);//Updates the player's position
                    Player2.aiMovement(Cursor.Position, Topka1, predY);//Updates the ai's position
                }



            }
        }
        

    }
}
