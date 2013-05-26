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
    public partial class Izrabotile : Form
    {
        public Izrabotile()
        {
            InitializeComponent();
            this.BackColor = Color.DarkCyan;
            label6.Text = "Single Player :" + Environment.NewLine + 
                "Тука можете да бирате три нивоа на тежина и ninja mode"
                + Environment.NewLine+"Ninja mode :" + Environment.NewLine + 
                "Тука можете да пробате колку време ќе издржите против ботот."
                + Environment.NewLine + "Тој е непобедлив. Можете да земете бонуси за големина на палка и за рушење блокови."
                +Environment.NewLine+"MultiPlayer :" + Environment.NewLine + "Во овој мод можете да играте со друг играч."
                + Environment.NewLine + "Движењата на левата палка се со помош на W и S, а на десната со Up и Down";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Izrabotile_Load(object sender, EventArgs e)
        {

        }

    }
}
