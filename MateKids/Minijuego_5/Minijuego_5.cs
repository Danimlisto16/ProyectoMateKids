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
    public partial class Minijuego_5 : Form
    {
        public Minijuego_5()
        {
            InitializeComponent();
        }

        private void tabla_2_MouseLeave(object sender, EventArgs e)
        {
            tabla_2.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_2_MouseEnter(object sender, EventArgs e)
        {
            tabla_2.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_3_MouseEnter(object sender, EventArgs e)
        {
            tabla_3.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_3_MouseLeave(object sender, EventArgs e)
        {
            tabla_3.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_4_MouseEnter(object sender, EventArgs e)
        {
            tabla_4.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_4_MouseLeave(object sender, EventArgs e)
        {
            tabla_4.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_5_MouseLeave(object sender, EventArgs e)
        {
            tabla_5.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_5_MouseEnter(object sender, EventArgs e)
        {
            tabla_5.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_6_MouseLeave(object sender, EventArgs e)
        {
            tabla_6.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_6_MouseEnter(object sender, EventArgs e)
        {
            tabla_6.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_7_MouseLeave(object sender, EventArgs e)
        {
            tabla_7.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_7_MouseEnter(object sender, EventArgs e)
        {
            tabla_7.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_8_MouseEnter(object sender, EventArgs e)
        {
            tabla_8.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_8_MouseLeave(object sender, EventArgs e)
        {
            tabla_8.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_9_MouseEnter(object sender, EventArgs e)
        {
            tabla_9.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_9_MouseLeave(object sender, EventArgs e)
        {
            tabla_9.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_10_MouseLeave(object sender, EventArgs e)
        {
            tabla_10.Size = new System.Drawing.Size(159, 112);
        }

        private void tabla_10_MouseEnter(object sender, EventArgs e)
        {
            tabla_10.Size = new System.Drawing.Size(155, 133);
        }

        private void tabla_2_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(2);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_3_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(3);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_4_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(4);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_5_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(5);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_6_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(6);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_7_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(7);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_8_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(8);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_9_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(9);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void tabla_10_Click(object sender, EventArgs e)
        {
            Form5_1 Ventana = new Form5_1(10);
            this.Hide();
            Ventana.ShowDialog();
            this.Close();
        }

        private void Minijuego_5_Load(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
