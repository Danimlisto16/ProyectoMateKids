using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_4
{
    public partial class Minijuego_4 : MetroFramework.Forms.MetroForm
    {
        public Minijuego_4()
        {
            InitializeComponent();
        }

        int puntaje = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //patoControl1.Parent = pictureBox1;
            patoControl1.Parent = pictureBox1;
            //patoControl2.Parent = pictureBox1;
        }

        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender,e);

        }

        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y , x1, y1;
            x = r.Next(3,740);
            y = r.Next(3,540);
            patoControl1.Location = new Point(x,y);

            x1 = r.Next(3, 740);
            y1 = r.Next(3, 540);
           
        }

        private void patoControl2_Load(object sender, EventArgs e)
        {
            
        }

        private void patoControl2_Click(object sender, EventArgs e)
        {
            puntaje++;
            lblMarcador.Text = puntaje.ToString();
        }
        
    }
}
