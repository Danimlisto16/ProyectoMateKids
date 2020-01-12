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

        #region
        Random randomico = new Random();
        int disparos = 0;
        int aciertos = 0;
        int fallados = 0;
        double AVG = 0;
        int tiempo;
        #endregion

        private void inicializar_tiempo()
        {
             tiempo = 30;
        }

        #region
        private void sonidoCorrecto()
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer("correcto.wav");
            pl.Play();
        }
        private void sonidoFail()
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer("fail.wav");
            pl.Play();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTitulo.Parent = fondo;
            pnlLetrero.Parent = fondo;
            pnlMarcador.Parent = fondo;
            pnlGlobo1.Parent = fondo;
            pnlGlobo2.Parent = fondo;
            sonido_ejecucion();
            inicializar_tiempo();
            timer1.Stop();
        }


        private void sonido_ejecucion()
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer("intro.wav");
            pl.Play();
        }
      
        
    


        
        private void reducir_tiempo(object sender, EventArgs e)
        {
            //genera  las posiciones y valores aleatorios de los globos
                int x, y , x1, y1;
                x = randomico.Next(370,1540);
                y = randomico.Next(60,561);
                x1 = randomico.Next(370, 1540);
                y1 = randomico.Next(60, 561);
                while (x == x1 && y == y1)
                {
                    x1 = randomico.Next(331, 1561);
                    y1 = randomico.Next(49, 561);
            }
                pnlGlobo2.Location = new Point(x,y);
                pnlGlobo1.Location = new Point(x1, y1);
                tiempo--;
                if (tiempo == 0)
            {
                timer1.Stop();
                MessageBox.Show("Juego Finalizado!");
                iniciar_minijuego.Enabled = true;
            }
        }

        private void sonido_disparo()
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer("shot.wav");
            pl.Play();
        }

        private void fondo_Click_1(object sender, EventArgs e)
        {
            mostrar_marcador(false, sender, e);
        }

        private void mostrar_marcador(bool respuesta, object sender, EventArgs e)
        {
            sonido_disparo();
            disparos++;
            lblDisparos.Text = "Disparos " + disparos.ToString();
            if (respuesta)
            {
                
                sonidoFail();
                aciertos++;
                lblAciertos.Text = "Aciertos " + aciertos.ToString();
                iniciar_juego_Click(sender,e);
            }
            else
            {
                fallados++;
                lblFallos.Text = "Fallos " + fallados.ToString();
                sonidoCorrecto();
            }
            AVG = (aciertos*100) / disparos;
            lblAVG.Text = "AVG "+ AVG.ToString() + "%" ;
        }



      

        private void lblError_Click_1(object sender, EventArgs e)
        {
            mostrar_marcador(false,sender,e);
        }

       

        private void pnlGlobo1_Click_1(object sender, EventArgs e)
        {
            mostrar_marcador(false, sender, e);
        }

        private void pnlGlobo2_Click(object sender, EventArgs e)
        {
            mostrar_marcador(!false, sender, e); ;
        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {
            mostrar_marcador(!false, sender, e);
        }

       

        private void iniciar_juego_Click(object sender, EventArgs e)
        {
            fallados = 0;
            aciertos = 0;
            AVG = 0;
            disparos = 1;
            timer1.Start();
            this.pnlGlobo2.Visible = true;
            this.pnlGlobo1.Visible = true;
            int valora = randomico.Next(1, 10);
            int valorb = randomico.Next(1, 10);
            lblEjercicio.Text = valora + " x " + valorb;
            int respuesta = valora * valorb;
            int valorc = randomico.Next(1, respuesta);
            lblError.Text = valorc.ToString();
            lblRespuesta.Text = respuesta.ToString();
            iniciar_minijuego.Enabled = false;
        }



        #region
        private void incrementar_marcador()
        {
            aciertos++;
        }

        #endregion

    }


}
