using System;
using System.Media;
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
            pictureBox1.Parent = this;
            pictureBox2.Parent = this;
            pictureBox3.Parent = this;
            pictureBox4.Parent = this;
            this.mtTip.SetToolTip(pictureBox4, "Click para iniciar el juego");
            this.mtTip.SetToolTip(pictureBox3, "Click para calcular");
            this.mtTip.UseAnimation = true;
            this.mtTip.UseFading = true;
            mtTip.IsBalloon = true; 
            mtTip.AutoPopDelay = 2000;
            mtTip.InitialDelay = 500;
        }

        Random r = new Random();
        int divisor = 0;
        private void genAleatorio()
        {
            txtDivisor.Text = "";
            int cociente, dividendo;
            cociente = r.Next(1, 10);
            divisor = r.Next(1, 10);
            dividendo = cociente * divisor;
            lblDividendo.Text = dividendo.ToString();
            lblCociente.Text = cociente.ToString();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            genAleatorio();
            pictureBox4.Visible = false;
        }

        private void sonidoCorrecto()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.correcto);
            simpleSound.Play();
        }

        private void sonidoIncorrecto()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.incorrecto);
            simpleSound.Play();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtDivisor.Text == " " || txtDivisor.Text =="" || txtDivisor.Text == "  ")
            {
                MessageBox.Show("Recuerda ingresar una respuesta");
                txtDivisor.BackColor = System.Drawing.Color.Gold;
            }
            else
            {
                int divisor = 0;
                divisor = Int16.Parse(txtDivisor.Text);
                if (divisor == this.divisor)
                {
                    txtDivisor.BackColor = System.Drawing.Color.MediumSpringGreen;
                    genAleatorio();
                    sonidoCorrecto();
                }
                else
                {
                    sonidoIncorrecto();
                    txtDivisor.BackColor = System.Drawing.Color.Pink;

                }
            }
        }

       

        private void txtDivisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
             Regresar.Size = new System.Drawing.Size(60, 66);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Regresar.Size = new System.Drawing.Size(52, 58);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new System.Drawing.Size(176, 156);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new System.Drawing.Size(168, 148);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new System.Drawing.Size(57, 48);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new System.Drawing.Size(67, 58);
        }

        private void Regresar_MouseLeave(object sender, EventArgs e)
        {
            Regresar.Size = new System.Drawing.Size(57, 48);
        }

        private void Regresar_MouseEnter(object sender, EventArgs e)
        {
            Regresar.Size = new System.Drawing.Size(67, 58);
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Cerrar Encuentrax", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
