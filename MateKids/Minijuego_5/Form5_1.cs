using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_5
{
    public partial class Form5_1 : Form
    {
        int ntabla, intento=3;
        int[] respuestas = new int[10];
        int[] rescorrectas = new int[10];
        public Form5_1(int ntabla)
        {
            InitializeComponent();
            this.ntabla = ntabla;
            //  LlenarTablas(this);
        }

        private void Form5_1_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.PrimaryScreen.Bounds.Location;
            //this.Size = Screen.PrimaryScreen.Bounds.Size;
           // this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            //this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            for (int i = 0; i < 10; i++)
            {
                respuestas[i] = ntabla * (i + 1);
            }


            string str = "image/tabla" + ntabla + ".png";
            titulo_tabla.Image = new Bitmap(str);
            LlenarTablas(this);
        }

        public bool vacio = false; // Variable utilizada para saber si hay algún TextBox vacio.
        private void ValidarCasilleros(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true) MessageBox.Show("No te olvides de llenar todos los casilleros"); // Si nuestra variable es verdadera mostramos un mensaje.
        }

        private void LlenarTablas(Form formulario)
        {
            int i = 1;
            foreach (Control oControls in formulario.Controls) // Buscamos en cada Label de nuestro Formulario.
            {
                if (oControls is Label) // Verificamos que no este vacio.
                {
                    string data = oControls.Name;
                    // Split string on spaces (this will separate all the words).
                    string[] words = data.Split('_');
                    if (words[0] == "n1" || words[0] == "n2")
                    {
                        i = int.Parse(words[1]);
                    }
                    if (oControls.Name == ("n1_" + i))
                    {
                        //MessageBox.Show("er");
                        oControls.Text = "" + ntabla;
                    }

                    if (oControls.Name == ("n2_" + i))
                    {
                        oControls.Text = "" + i;
                    }
                    //i++;
                }

            }
        }

        private void Validar_respuesta(Form formulario)
        {
            int i = 1;
            
            foreach (Control oControls in formulario.Controls) // Buscamos en cada Label de nuestro Formulario.
            {
                if (oControls is TextBox) // Verificamos que no este vacio.
                {
                    string data = oControls.Name;
                    // Split string on spaces (this will separate all the words).
                    string[] words = data.Split('_');
                    if (words[0] == "res")
                    {
                        i = int.Parse(words[1]);
                    }
                    if (oControls.Name == ("res_" + i))
                    {
                        //MessageBox.Show(oControls.Text);

                        if (oControls.Text == ("" + respuestas[i - 1]))
                        {
                            rescorrectas[i - 1] = 1;
                        }
                        else
                        {
                            rescorrectas[i - 1] = 0;
                        }

                    }


                }

            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void res9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            int puntaje = 0, error = 0;
            ValidarCasilleros(this);
            if (!vacio)
            {
                Validar_respuesta(this);
                for (int i = 0; i < 10; i++)
                {
                   
                    if (rescorrectas[i] == 1)
                    {
                        if (i == 0)
                        {
                            lres_1.Text = res_1.Text;
                            lres_1.ForeColor = Color.Green;
                            lres_1.Visible = true;
                            res_1.Visible = false;
                            
                            
                            puntaje++;
                        }
                        if (i == 1)
                        {
                            lres_2.Text = res_2.Text;
                            lres_2.ForeColor = Color.Green;
                            lres_2.Visible = true;
                            res_2.Visible = false;
                            
                            
                            puntaje++;
                        }
                        if (i == 2)
                        {
                            lres_3.Text = res_3.Text;
                            lres_3.ForeColor = Color.Green;
                            lres_3.Visible = true;
                            res_3.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 3)
                        {
                            lres_4.Text = res_4.Text;
                            lres_4.ForeColor = Color.Green;
                            lres_4.Visible = true;
                            res_4.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 4)
                        {
                            lres_5.Text = res_5.Text;
                            lres_5.ForeColor = Color.Green;
                            lres_5.Visible = true;
                            res_5.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 5)
                        {
                            lres_6.Text = res_6.Text;
                            lres_6.ForeColor = Color.Green;
                            lres_6.Visible = true;
                            res_6.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 6)
                        {
                            lres_7.Text = res_7.Text;
                            lres_7.ForeColor = Color.Green;
                            lres_7.Visible = true;
                            res_7.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 7)
                        {
                            lres_8.Text = res_8.Text;
                            lres_8.ForeColor = Color.Green;
                            lres_8.Visible = true;
                            res_8.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 8)
                        {
                            lres_9.Text = res_9.Text;
                            lres_9.ForeColor = Color.Green;
                            lres_9.Visible = true;
                            res_9.Visible = false;
                            
                            
                            puntaje++;
                        }

                        if (i == 9)
                        {
                            lres_10.Text = res_10.Text;
                            lres_10.ForeColor = Color.Green;
                            lres_10.Visible = true;
                            res_10.Visible = false;
                    
                            puntaje++;
                        }

                    }
                    else
                    {
                        //comprobar++;
                        if (i == 0)
                        {

                            res_1.ForeColor = Color.Red;
                            error++;
                        }
                        if (i == 1)
                        {
                            res_2.ForeColor = Color.Red;
                            error++;
                        }
                        if (i == 2)
                        {
                            res_3.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 3)
                        {
                            res_4.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 4)
                        {
                            res_5.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 5)
                        {
                            res_6.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 6)
                        {
                            res_7.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 7)
                        {
                            res_8.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 8)
                        {
                            res_9.ForeColor = Color.Red;
                            error++;
                        }

                        if (i == 9)
                        {
                            res_10.ForeColor = Color.Red;
                            error++;
                        }

                    }
                }
                if (error>0)
                {
                    intento--;
                    lblintentos.Text = "" + intento;
                    if (intento!=0)
                    {
                        if (error == 1)
                        {
                            MessageBox.Show("Intentalo de nuevo \nTienes: " + error + " error");
                        }
                        else
                        {
                            MessageBox.Show("Intentalo de nuevo \nTienes: " + error + " errores");
                        }
                    }
                    

                    if (intento == 0)
                    {
                        MessageBox.Show("Te haz quedado sin intentos :C");
                        Terminar.Enabled = false;
                    }
                }
                lblpuntaje.Text = "" + puntaje;
                if (intento == 3 )
                {
                    
                    MessageBox.Show("FELICITACIONES\nLo haz resuelto a la primera");
                    
                }
                if (error==0)
                {
                    if (intento == 2 || intento == 1)
                    {
                        MessageBox.Show("MUY BIEN\nHaz completado la tabla de multiplicar del " + ntabla);
                    }
                }
                

            }

            
            vacio = false;
            
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Minijuego_5 Ventana = new Minijuego_5();
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void res10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
