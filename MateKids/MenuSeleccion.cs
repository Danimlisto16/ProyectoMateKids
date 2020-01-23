using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MateKids.Minijuego_1;
using MateKids.Minijuego_6;
using MateKids.Miinijuego_7;
using MateKids.Minijuego_2;

namespace MateKids
{
    public partial class MenuSeleccion : MetroFramework.Forms.MetroForm

    {
        public MenuSeleccion()
        {
            InitializeComponent();
        }

        private void iniciar_minijuego( )
        {

            // Process.Start(minijuego_1);
            Minijuego_1.Minijuego_1 minijuego = new Minijuego_1.Minijuego_1();
            minijuego.ShowDialog();

        }


        private void seleccionar_minijuego(DataGridViewRowDividerDoubleClickEventArgs click, Form MINIJUEO)
        {
            MINIJUEO.ShowDialog(); //ABRE EL FORMULARIOS DEL MINIJUEGO
        }

        private void pbxIcono_multiplicax_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_1.Size = new System.Drawing.Size(170, 148);
        }

        private void pbxIcono_multiplicax_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_1.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_1_Click(object sender, EventArgs e)
        {
            iniciar_minijuego();
        }

        private void icono_minijuego_2_Click(object sender, EventArgs e)
        {
            Minijuego_2.Minijuego_2 minijuego = new Minijuego_2.Minijuego_2();
            minijuego.ShowDialog();
        }

        private void icono_minijuego_6_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_6.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_6_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_6.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_6_Click(object sender, EventArgs e)
        {
            Minijuego_6.Minijuego_6 minijuego = new Minijuego_6.Minijuego_6();
            minijuego.ShowDialog();
        }

        private void icono_minijuego_7_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_7.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_7_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_7.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_7_Click(object sender, EventArgs e)
        {
            Minijuego7 minijuego = new Minijuego7();
            minijuego.ShowDialog();
        }

        private void icono_minijuego_2_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_2.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_2_MouseLeave(object sender, EventArgs e)
        {
            
            icono_minijuego_2.Size = new System.Drawing.Size(155, 133);
        }

        private void MenuSeleccion_Load(object sender, EventArgs e)
        {
            
        }

        private void icono_minijuego_4_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_4.Size = new System.Drawing.Size(170, 148);
            
        }

        private void icono_minijuego_4_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_4.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_4_Click(object sender, EventArgs e)
        {
            Minijuego_4.frmTiempo tiempo = new Minijuego_4.frmTiempo();
            tiempo.Show();
        }

        private void icono_minijuego_3_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_3.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_3_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_3.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_8_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_8.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_8_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_8.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_3_Click(object sender, EventArgs e)
        {
            Minijuego_3.Minijuego_3 mn = new Minijuego_3.Minijuego_3();
            mn.ShowDialog();
        }

        private void icono_minijuego_8_Click(object sender, EventArgs e)
        {
            Minijuego_8.Minijuego_8 mn = new Minijuego_8.Minijuego_8();
            mn.ShowDialog();
        }

        private void icono_minijuego_5_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_5.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_5_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_5.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_5_Click(object sender, EventArgs e)
        {
            Minijuego_5.Minijuego_5 mn = new Minijuego_5.Minijuego_5();
            mn.ShowDialog();
        }

        private void lblContacto_Click(object sender, EventArgs e)
        {
            Contacto c = new Contacto();
            c.ShowDialog();
        }

        private void icono_minijuego_10_Click(object sender, EventArgs e)
        {
            Minijuego_10.Minijuego_10 m = new MateKids.Minijuego_10.Minijuego_10();
            m.ShowDialog();
        }

        private void icono_minijuego_10_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_10.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_10_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_10.Size = new System.Drawing.Size(155, 133);
        }

        private void titulo_minijuego_9_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void titulo_minijuego_9_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void lblContacto_MouseEnter(object sender, EventArgs e)
        {
            lblContacto.FontSize = MetroFramework.MetroLabelSize.Tall;
        }

        private void lblContacto_MouseLeave(object sender, EventArgs e)
        {
            lblContacto.FontSize = MetroFramework.MetroLabelSize.Medium;
        }

        private void icono_minijuego_9_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_9.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_9_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_9.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_9_Click(object sender, EventArgs e)
        {
            Minijuego_9.frmTiempo m = new Minijuego_9.frmTiempo();
            m.ShowDialog();
        }
    }
}
