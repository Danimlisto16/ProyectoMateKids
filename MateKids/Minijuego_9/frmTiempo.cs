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
    public partial class frmTiempo : MetroFramework.Forms.MetroForm
    {
        public frmTiempo()
        {
            InitializeComponent();
        }

        private void frmTiempo_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int tiempo = 0;
            if (rdb30s.Checked)
            {
                tiempo = 30;
            }
            else
            {
                if (rdb1m.Checked)
                {
                    tiempo = 60;
                }
                else
                {
                    tiempo = 90;
                }
            }

            Minijuego_9 m = new Minijuego_9 (tiempo);
            m.Show();
            this.Close();
        }
    }
}
