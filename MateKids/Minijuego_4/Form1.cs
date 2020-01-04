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


        Random r = new Random();

        int puntaje = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //patoControl1.Parent = pictureBox1;
            
            
            //patoControl2.Parent = pictureBox1;
        }

        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            int valora = r.Next(1, 10);
            int valorb = r.Next(1, 10);
            label1.Text = valora + " x " + valorb;
            int respuesta = valora * valorb;
            int valorc = r.Next(1, respuesta);
            lblRespuesta.Text = respuesta.ToString();
            lblError.Text = valorc.ToString();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y , x1, y1;
            x = r.Next(3,740);
            y = r.Next(3,540);

            x1 = r.Next(3, 740);
            y1 = r.Next(3, 540);

            while (x == x1 && y == y1)
            {
                x1 = r.Next(3, 740);
                y1 = r.Next(3, 540);

            }
            
            
            lblRespuesta.Location = new Point(x,y);
            
            lblError.Location = new Point(x1, y1);

        }
        private void sonidoDisparo()
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer("shot.wav");
            pl.Play();
            
        }

        private void patoControl2_Load(object sender, EventArgs e)
        {
            
        }

        private void patoControl2_Click(object sender, EventArgs e)
        {
            puntaje++;
            
        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {
            sonidoDisparo();
            puntaje++;
            lblMarcador.Text = puntaje.ToString();
            metroButton1_Click(sender, e);
            
        }

        private void lblError_Click(object sender, EventArgs e)
        {
            sonidoDisparo();
            puntaje--;
            lblMarcador.Text = puntaje.ToString();
            metroButton1_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sonidoDisparo();
        }
    }
}
