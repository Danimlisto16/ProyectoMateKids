using System;
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
            pictureBox5.Parent = this;
        }

        Random r = new Random();
        int divisor = 0;
        private void genAleatorio()
        {
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
                }
                else
                {
                    txtDivisor.BackColor = System.Drawing.Color.Pink;
                }
            }
        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {

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
             pictureBox5.Size = new System.Drawing.Size(60, 66);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new System.Drawing.Size(52, 58);
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
            pictureBox4.Size = new System.Drawing.Size(138, 130);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new System.Drawing.Size(130, 122);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
