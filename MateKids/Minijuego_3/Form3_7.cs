using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_3
{
    public partial class Form3_7 : Form
    {
        int intento, nventana, puntaje;
        int[] numeros;
        bool comprobar = false;
        public Form3_7(int[] numeros, int intento, int nventana, int puntaje)
        {
            InitializeComponent();
            this.numeros = numeros;
            this.intento = intento;
            this.nventana = nventana;
            this.puntaje = puntaje;
        }

        private void Opcion1_Click(object sender, EventArgs e)
        {
            lblrespuesta.Visible = true;
            lblrespuesta.BackColor = Color.Red;
            lblrespuesta.Text = "INCORRECTO";
            detener = segundos - 1;
            intento--;
            lblintentos.Text = "" + intento;
            finaliar();
        }

        private void Opcion2_Click(object sender, EventArgs e)
        {
            lblrespuesta.Visible = true;
            lblrespuesta.BackColor = Color.Green;
            lblrespuesta.Text = "CORRECTO";
            puntaje+=2;
            lblpuntaje.Text = "" + puntaje;
            Opcion1.Enabled = false;
            Opcion2.Enabled = false;
            Opcion3.Enabled = false;
            comprobar = true;
            nventana++;
            Siguiente.Visible = true;
            finaliar();
        }

        private void Opcion3_Click(object sender, EventArgs e)
        {
            lblrespuesta.Visible = true;
            lblrespuesta.BackColor = Color.Red;
            lblrespuesta.Text = "INCORRECTO";
            detener = segundos - 1;
            intento--;
            lblintentos.Text = "" + intento;
            finaliar();
        }

        private void finaliar()
        {
            if (nventana == 5 && intento == 3)
            {
                MessageBox.Show("    FELICIDADES\nHaz terminado el juego sin ningún error");
            }
            if (nventana == 5 && (intento == 2 || intento == 1))
            {
                MessageBox.Show("    MUY BIEN\nHaz completado todos los problemas.");
            }
            if (intento == 0)
            {
                Siguiente.Visible = true;
                MessageBox.Show("    Te haz quedado sin intentos\nJuguemos de nuevo");
                Opcion1.Enabled = false;
                Opcion2.Enabled = false;
                Opcion3.Enabled = false;

            }
        }
        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (nventana == 5 || intento == 0)
            {
                Minijuego_3 Ventana = new Minijuego_3();
                this.Hide();
                Ventana.ShowDialog();
                this.Close();
            }
            else
            {

                ventanaSiguiente(nventana);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (detener == segundos)
            {
                lblrespuesta.Visible = false;
            }
            segundos--;
            if (comprobar)
            {
                timer1.Stop();
            }
        }

        private void ventanaSiguiente(int num)
        {
            if (numeros[num] == 1)
            {
                Form3_1 Ventana = new Form3_1(numeros, intento, nventana, puntaje);
                //Ventana.ShowDialog();
                this.Hide();
                Ventana.ShowDialog();
                this.Close();
                //this.Close();

            }
            if (numeros[num] == 2)
            {
                Form3_2 Ventana = new Form3_2(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 3)
            {
                Form3_3 Ventana = new Form3_3(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 4)
            {
                Form3_4 Ventana = new Form3_4(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 5)
            {
                Form3_5 Ventana = new Form3_5(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 6)
            {
                Form3_6 Ventana = new Form3_6(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 7)
            {
                Form3_7 Ventana = new Form3_7(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 8)
            {
                Form3_8 Ventana = new Form3_8(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 9)
            {
                Form3_9 Ventana = new Form3_9(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 10)
            {
                Form3_10 Ventana = new Form3_10(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 11)
            {
                Form3_11 Ventana = new Form3_11(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 12)
            {
                Form3_12 Ventana = new Form3_12(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
        }

        int segundos = 180;
        int detener;
        private void Form3_7Load(object sender, EventArgs e)
        {
            lblintentos.Text = "" + intento;
            lblpuntaje.Text = "" + puntaje;
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
