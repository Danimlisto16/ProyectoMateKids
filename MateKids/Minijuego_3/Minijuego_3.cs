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
    public partial class Minijuego_3 : Form
    {
        int intento = 3, nventana = 0, puntaje = 0;
        int[] numeros = new int[5];

        public Minijuego_3()
        {
            InitializeComponent();
        }

        private void iniciar_minijuego_Click(object sender, EventArgs e)
        {
            ventanasAleatorias();
            ventanaSiguiente();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Form3_1 Ventana = new Form3_1(numeros, intento, nventana, puntaje);
                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 2)
            {
                Form3_2 Ventana = new Form3_2(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 3)
            {
                Form3_3 Ventana = new Form3_3(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 4)
            {
                Form3_4 Ventana = new Form3_4(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 5)
            {
                Form3_5 Ventana = new Form3_5(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 6)
            {
                Form3_6 Ventana = new Form3_6(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 7)
            {
                Form3_7 Ventana = new Form3_7(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 8)
            {
                Form3_8 Ventana = new Form3_8(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 9)
            {
                Form3_9 Ventana = new Form3_9(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 10)
            {
                Form3_10 Ventana = new Form3_10(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 11)
            {
                Form3_11 Ventana = new Form3_11(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[0] == 12)
            {
                Form3_12 Ventana = new Form3_12(numeros, intento, nventana, puntaje);

                this.Hide();
                Ventana.ShowDialog();
                this.Close();

            }
        }
    }
}
