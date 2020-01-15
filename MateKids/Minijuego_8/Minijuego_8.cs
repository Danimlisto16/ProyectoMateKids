using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_8
{
    public partial class Minijuego_8 : Form
    {
        int intento = 3, nventana = 0, puntaje = 0;
        int[] numeros = new int[5];
        public Minijuego_8()
        {
            InitializeComponent();
        }
        private void iniciar_minijuego_Click(object sender, EventArgs e)
        {
            ventanasAleatorias();
            ventanaSiguiente();
        }

        private void ventanasAleatorias()
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = r.Next(1, 13);

                if (i > 0)    // a partir del segundo numero que genera empezara a comparar que no se repita
                {
                    for (int x = 0; x < 50; x++)  //comprobara que no se repita por 50 veces
                    {

                        for (int j = 0; j < i; j++)
                        {
                            if (numeros[i] == numeros[j])
                            {
                                numeros[i] = r.Next(1, 13);
                            }
                        }
                    }
                }

            }

        }

        private void ventanaSiguiente()
        {
            if (numeros[0] == 1)
            {
                Form8_1 Ventana = new Form8_1(numeros, intento, nventana, puntaje);
                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 2)
            {
                Form8_2 Ventana = new Form8_2(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 3)
            {
                Form8_3 Ventana = new Form8_3(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 4)
            {
                Form8_4 Ventana = new Form8_4(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 5)
            {
                Form8_5 Ventana = new Form8_5(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 6)
            {
                Form8_6 Ventana = new Form8_6(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 7)
            {
                Form8_7 Ventana = new Form8_7(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 8)
            {
                Form8_8 Ventana = new Form8_8(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 9)
            {
                Form8_9 Ventana = new Form8_9(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 10)
            {
                Form8_10 Ventana = new Form8_10(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 11)
            {
                Form8_11 Ventana = new Form8_11(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 12)
            {
                Form8_12 Ventana = new Form8_12(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
        }

    }
}
