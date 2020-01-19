using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_10
{
    public partial class Minijuego_10 : Form
    {
        public Minijuego_10()
        {
            InitializeComponent();
        }

        private void Minijuego_10_Load(object sender, EventArgs e)
        {

        }

        Random r = new Random();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int valora, valorb,respuesta;
            
            do
            {
                txtRespuesta.BackColor = Color.White;
                valora = r.Next(1, 10);
                respuesta = r.Next(1, 10);
                valorb = valora * respuesta;
                lblValor1.Text = valora.ToString();
                lblvalor2.Text = respuesta.ToString();
                if (!txtRespuesta.Equals(" "))
                {
                    if (int.Parse(txtRespuesta.Text) == respuesta)
                    {
                        txtRespuesta.BackColor = Color.Green;
                        continue;
                    }
                    else
                    {
                        txtRespuesta.BackColor = Color.Red;
                    }

                }
                else
                {
                    MessageBox.Show("Ingresa una respuesta");
                }

            } while (true);
        }
    }
}
