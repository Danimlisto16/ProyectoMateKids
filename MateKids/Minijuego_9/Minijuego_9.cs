﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_9
{
    public partial class Minijuego_9 : MetroFramework.Forms.MetroForm
    {
        public Minijuego_9(int tiempo)
        {
            InitializeComponent();
            tmp = tiempo;
            aciertos = 0;
            disparos = 0;
            fallados = 0;
        }

        int tmp;
        int aciertos, disparos, fallados;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Random r = new Random();

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrTiempoJuego.Start();
            tmrPosicion.Start();
            genMultiplicacion();
            btnIniciar.Visible = false;

        }

        private void tmrPosicion_Tick(object sender, EventArgs e)
        {
            int posicionPnlMitad1X, posicionPnlMitad2X, posicionPnlMitad1Y, posicionPnlMitad2Y;
            //HACE VISIBLES LOS PANELES CON LOS GLOBOS
            pnlMitad1.Visible = true;
            pnlMitad2.Visible = true;

            //POSICION DE LOS GLOBOS EN LOS PANELES
            posicionPnlMitad1X = r.Next(3, 394);
            posicionPnlMitad1Y = r.Next(3, 378);

            posicionPnlMitad2X = r.Next(3, 378);
            posicionPnlMitad2Y = r.Next(3, 394);

            Console.WriteLine(">>" + posicionPnlMitad1X + "<>" + posicionPnlMitad1Y);
            Console.WriteLine(">>" + posicionPnlMitad2X + "<>" + posicionPnlMitad2Y + "\n\n");


            pnlGlobo1.Location = new Point(posicionPnlMitad1X, posicionPnlMitad1Y);
            pnlGlobo2.Location = new Point(posicionPnlMitad2X, posicionPnlMitad2Y);

        }

        private void tmrTiempoJuego_Tick(object sender, EventArgs e)
        {

        }

        int respuesta = 0;

        private void genMultiplicacion()
        {
            int a, b, opcion, alternativa;
            a = r.Next(1, 10);
            b = r.Next(1, 10);
            respuesta = a * b;
            alternativa = r.Next(1, 100);

            lblProblema.Text = a.ToString() + " x " + b.ToString();
            opcion = r.Next(1, 10);
            if (opcion <= 5)
            {
                lblOpcion2.Text = respuesta.ToString();
                lblOpcion1.Text = alternativa.ToString();
            }
            else
            {
                lblOpcion1.Text = respuesta.ToString();
                lblOpcion2.Text = alternativa.ToString();
            }

        }

        private void actualizarAciertos()
        {
            aciertos++;
            lblAciertos.Text = "Aciertos " + aciertos.ToString();
            actualizarDisparos();
        }
        private void actualizarFallos()
        {
            fallados++;
            lblFallos.Text = "Fallados " + fallados.ToString();
            actualizarDisparos();
        }
        private void actualizarDisparos()
        {
            disparos++;
            lblDisparos.Text = "Disparos" + disparos.ToString();
        }

        private void lblOpcion2_Click(object sender, EventArgs e)
        {
            clickRespuesta(lblOpcion2.Text);
        }

        private void clickRespuesta(string texto)
        {
            if (Int16.Parse(texto) == respuesta)
            {
                genMultiplicacion();
                actualizarAciertos();
                genMultiplicacion();
            }
            else
            {
                actualizarFallos();
            }


        }

        private void lblOpcion1_Click(object sender, EventArgs e)
        {
            clickRespuesta(lblOpcion1.Text);
        }


    }
}
