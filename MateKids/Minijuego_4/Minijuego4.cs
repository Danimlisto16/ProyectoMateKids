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


        Random randomico = new Random();

        int puntaje = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            letrero.Parent = fondo;
            pbxLetreroPanel.Parent = fondo;
            pnlGlobo1.Parent = fondo;
            pnlGlobo2.Parent = fondo;   
        }
      
        
    

        private void iniciar_juego_Click(object sender, EventArgs e)
        {
            this.pnlGlobo2.Visible = true;
            this.pnlGlobo1.Visible = true;

            int valora = randomico.Next(1, 10);
            int valorb = randomico.Next(1, 10);
            problema.Text = valora + " x " + valorb;
            int respuesta = valora * valorb;
            int valorc = randomico.Next(1, respuesta);
            lblError.Text = valorc.ToString();
            lblRespuesta.Text = respuesta.ToString();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //genera  las posiciones y valores aleatorios de los globos
            int x, y , x1, y1;
            x = randomico.Next(3,740);
            y = randomico.Next(3,540);

            x1 = randomico.Next(3, 740);
            y1 = randomico.Next(107, 540);

            while (x == x1 && y == y1)
            {
                x1 = randomico.Next(3, 740);
                y1 = randomico.Next(107, 540);
            }
            pnlGlobo2.Location = new Point(x,y);
            pnlGlobo1.Location = new Point(x1, y1);
        }

        private void sonido_disparo()
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer("shot.wav");
            pl.Play();
            
        }

        

        private void fondo_Click(object sender, EventArgs e)
        {
            sonido_disparo();
        }

      

     
        #region

        private void incrementar_marcador()
        {
            puntaje++;
        }
        private void decrementar_marcador()
        {
            if(puntaje!=0)
                puntaje--;
        }

        private void mostrar_marcador()
        {
            lblMarcador.Text = puntaje.ToString();
        }

        #endregion

      
        

        private void pnlGlobo1_Click(object sender, EventArgs e)
        {
            decrementar_marcador();
            mostrar_marcador();
            sonido_disparo();
            iniciar_juego_Click(sender, e);

        }

        private void pnlGlobo2_Click(object sender, EventArgs e)
        {
            incrementar_marcador();
            mostrar_marcador();
            sonido_disparo();
            iniciar_juego_Click(sender, e);

        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {
            pnlGlobo2_Click(sender,e);
        }

        private void lblError_Click(object sender, EventArgs e)
        {
            pnlGlobo1_Click(sender, e);
        }

        
    }


}
