﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_1
{
    public partial class Minijuego_1 : Form
    {
        public Minijuego_1()
        {
            InitializeComponent();
        }
        #region
        int tiempo = 60;
        #endregion

        int respuesta;
        int marcador = 0;
        int posicion;
        int[] vectorSolucion = new int[5];

        //inicializar tiemo

        private void Inicializar_tiempo()
        {
            int tiempo = 60;
        }

        private void IniciarJuego_Click(object sender, EventArgs e)
        {
            tmrTiempoJuego.Start();
            pbxTiempo.Visible = true;
            lblTiempo.Visible = true;
            actBotones(true);
            IniciarJuego.Visible = false;
            encerarVector(vectorSolucion);
            Random r = new Random();
            int num1 = r.Next(1, 10);
            int num2 = r.Next(1, 10);
            lblOperacion.Text = num1.ToString() + " x " + num2.ToString();
            int resultado = num1 * num2;
            vectorSolucion[4] = resultado;
            Random pos = new Random();
            arregloSinNumRep(vectorSolucion);
            posicion = pos.Next(0, 4);
            vectorSolucion[posicion] = resultado;
            respuesta = resultado;
            btnOpcion1.Text = vectorSolucion[0].ToString();
            btnOpcion2.Text = vectorSolucion[1].ToString();
            btnOpcion3.Text = vectorSolucion[2].ToString();
            btnOpcion4.Text = vectorSolucion[3].ToString();
        }

        private void Minijuego1_Load(object sender, EventArgs e)
        {
            actBotones(false);
        }

        private void actBotones(bool control)
        {
            btnOpcion1.Enabled = control;
            btnOpcion2.Enabled = control;
            btnOpcion3.Enabled = control;
            btnOpcion4.Enabled = control;
            pbxTiempo.Visible = control;
            lblTiempo.Visible = control;
        }
        private void encerarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = 0;
            }
        }

        private void arregloSinNumRep(int[] vector)
        {
            int n;
            Random num = new Random();

            for (int i = 0; i < vector.Length - 1; i++)
            {
                n = num.Next(1, 101);//genera valores entre el 1-100
                if (!existe(n, vector))
                {
                    vector[i] = n;
                }
            }
        }

        private bool existe(int num, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (num == vector[i])
                {
                    return true;
                }

            }
            return false;

        }
        //INGRESAR RESPUESTA

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            Validar_respuesta(btnOpcion1, sender, e);

        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            Validar_respuesta(btnOpcion2, sender, e);
        }

        private void btnOpcion3_Click(object sender, EventArgs e)
        {
            Validar_respuesta(btnOpcion3, sender, e);
        }

        private void btnOpcion4_Click(object sender, EventArgs e)
        {
            Validar_respuesta(btnOpcion4, sender, e);
        }

        private void Incrementar_marcador()
        {
            marcador++;
        }

        private void Validar_respuesta(Button btn, object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(btn.Text);
            if (opcion == respuesta)
            {
                Incrementar_marcador();
                lblPuntaje.Text = marcador.ToString();
                IniciarJuego_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Intentalo otra vez", "Respuesta Incorrecta");
            }
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            actBotones(true);
            marcador = 0;
            lblPuntaje.Text = marcador.ToString();
            IniciarJuego_Click(sender, e);
            Reiniciar.Visible = false;
            tiempo = 60;
            lblTiempo.Text = tiempo.ToString();
        }

        private void tmrTiempoJuego_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblTiempo.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                tmrTiempoJuego.Stop();
                MessageBox.Show("Juego terminado... tu marcador es: " + marcador.ToString());
                actBotones(false);
                Reiniciar.Visible = true;
            }
        }

        #region
        private void Ingresar_respuesta()
        {
            this.btnOpcion1.Select();
            this.btnOpcion2.Select();
            this.btnOpcion3.Select();
            this.btnOpcion4.Select();
        }

        private void Reducir_tiempo()
        {
            tiempo--;
        }

        #endregion
    }
}
