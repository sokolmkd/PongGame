using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Topka
    {
       public int SpeedX { get; set; }
       public int SpeedY { get; set; }
       public PictureBox Ball { get; set; }
       

       public Topka(Size golemina,int X,int Y)
       {
           SpeedX = X;
           SpeedY = Y;
           Ball = new OvalPictureBox();
           Ball.Size = golemina;
       }

     
       
    }
}
