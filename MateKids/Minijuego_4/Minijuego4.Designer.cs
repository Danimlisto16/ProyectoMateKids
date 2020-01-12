namespace MateKids.Minijuego_4
{
    partial class Minijuego_4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minijuego_4));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pnlLetrero = new System.Windows.Forms.Panel();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.pnlMarcador = new System.Windows.Forms.Panel();
            this.lblDisparos = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.lblAVG = new System.Windows.Forms.Label();
            this.iniciar_minijuego = new MetroFramework.Controls.MetroButton();
            this.pnlGlobo1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlGlobo2 = new System.Windows.Forms.Panel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbxJuego_nombre = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            this.pnlLetrero.SuspendLayout();
            this.pnlMarcador.SuspendLayout();
            this.pnlGlobo1.SuspendLayout();
            this.pnlGlobo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuego_nombre)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.reducir_tiempo);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pnlLetrero);
            this.metroPanel1.Controls.Add(this.pnlMarcador);
            this.metroPanel1.Controls.Add(this.iniciar_minijuego);
            this.metroPanel1.Controls.Add(this.pnlGlobo1);
            this.metroPanel1.Controls.Add(this.pnlGlobo2);
            this.metroPanel1.Controls.Add(this.fondo);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1466, 686);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pnlLetrero
            // 
            this.pnlLetrero.BackColor = System.Drawing.Color.Transparent;
            this.pnlLetrero.BackgroundImage = global::MateKids.Properties.Resources.letrero1;
            this.pnlLetrero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLetrero.Controls.Add(this.lblEjercicio);
            this.pnlLetrero.Location = new System.Drawing.Point(75, 524);
            this.pnlLetrero.Name = "pnlLetrero";
            this.pnlLetrero.Size = new System.Drawing.Size(204, 140);
            this.pnlLetrero.TabIndex = 98;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.lblEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEjercicio.Location = new System.Drawing.Point(25, 22);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(143, 59);
            this.lblEjercicio.TabIndex = 85;
            this.lblEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMarcador
            // 
            this.pnlMarcador.BackColor = System.Drawing.Color.Transparent;
            this.pnlMarcador.BackgroundImage = global::MateKids.Properties.Resources.panelLetrero_removebg_preview;
            this.pnlMarcador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMarcador.Controls.Add(this.lblDisparos);
            this.pnlMarcador.Controls.Add(this.lblAciertos);
            this.pnlMarcador.Controls.Add(this.lblFallos);
            this.pnlMarcador.Controls.Add(this.lblAVG);
            this.pnlMarcador.Location = new System.Drawing.Point(14, 29);
            this.pnlMarcador.Name = "pnlMarcador";
            this.pnlMarcador.Size = new System.Drawing.Size(274, 362);
            this.pnlMarcador.TabIndex = 97;
            // 
            // lblDisparos
            // 
            this.lblDisparos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisparos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDisparos.Location = new System.Drawing.Point(55, 185);
            this.lblDisparos.Name = "lblDisparos";
            this.lblDisparos.Size = new System.Drawing.Size(191, 41);
            this.lblDisparos.TabIndex = 103;
            this.lblDisparos.Text = "Disparos 0";
            // 
            // lblAciertos
            // 
            this.lblAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAciertos.Location = new System.Drawing.Point(55, 247);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(191, 41);
            this.lblAciertos.TabIndex = 101;
            this.lblAciertos.Text = "Aciertos 0";
            // 
            // lblFallos
            // 
            this.lblFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFallos.Location = new System.Drawing.Point(55, 308);
            this.lblFallos.Name = "lblFallos";
            this.lblFallos.Size = new System.Drawing.Size(191, 41);
            this.lblFallos.TabIndex = 99;
            this.lblFallos.Text = "Fallados 0";
            // 
            // lblAVG
            // 
            this.lblAVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAVG.Location = new System.Drawing.Point(55, 117);
            this.lblAVG.Name = "lblAVG";
            this.lblAVG.Size = new System.Drawing.Size(191, 41);
            this.lblAVG.TabIndex = 97;
            this.lblAVG.Text = "AVG 0%";
            this.lblAVG.Visible = false;
            // 
            // iniciar_minijuego
            // 
            this.iniciar_minijuego.Location = new System.Drawing.Point(90, 435);
            this.iniciar_minijuego.Name = "iniciar_minijuego";
            this.iniciar_minijuego.Size = new System.Drawing.Size(112, 52);
            this.iniciar_minijuego.TabIndex = 84;
            this.iniciar_minijuego.Text = "INICIAR";
            this.iniciar_minijuego.Click += new System.EventHandler(this.iniciar_juego_Click);
            // 
            // pnlGlobo1
            // 
            this.pnlGlobo1.BackColor = System.Drawing.Color.Transparent;
            this.pnlGlobo1.BackgroundImage = global::MateKids.Properties.Resources.GLOB;
            this.pnlGlobo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGlobo1.Controls.Add(this.lblError);
            this.pnlGlobo1.Location = new System.Drawing.Point(577, 256);
            this.pnlGlobo1.Name = "pnlGlobo1";
            this.pnlGlobo1.Size = new System.Drawing.Size(112, 122);
            this.pnlGlobo1.TabIndex = 88;
            this.pnlGlobo1.Click += new System.EventHandler(this.pnlGlobo1_Click_1);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Snow;
            this.lblError.Location = new System.Drawing.Point(18, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(78, 46);
            this.lblError.TabIndex = 0;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Click += new System.EventHandler(this.lblError_Click_1);
            // 
            // pnlGlobo2
            // 
            this.pnlGlobo2.BackColor = System.Drawing.Color.Transparent;
            this.pnlGlobo2.BackgroundImage = global::MateKids.Properties.Resources.GLOB;
            this.pnlGlobo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGlobo2.Controls.Add(this.lblRespuesta);
            this.pnlGlobo2.Location = new System.Drawing.Point(1061, 256);
            this.pnlGlobo2.Name = "pnlGlobo2";
            this.pnlGlobo2.Size = new System.Drawing.Size(112, 122);
            this.pnlGlobo2.TabIndex = 87;
            this.pnlGlobo2.Click += new System.EventHandler(this.pnlGlobo2_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.Color.Snow;
            this.lblRespuesta.Location = new System.Drawing.Point(22, 8);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(73, 57);
            this.lblRespuesta.TabIndex = 0;
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // fondo
            // 
            this.fondo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Image = global::MateKids.Properties.Resources.fondo;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(1466, 686);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 80;
            this.fondo.TabStop = false;
            this.fondo.Click += new System.EventHandler(this.fondo_Click_1);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitulo.BackgroundImage = global::MateKids.Properties.Resources.titulo_removebg_preview;
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitulo.Controls.Add(this.pbxJuego_nombre);
            this.pnlTitulo.Location = new System.Drawing.Point(1156, 6);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(330, 99);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pbxJuego_nombre
            // 
            this.pbxJuego_nombre.Image = global::MateKids.Properties.Resources.titulo;
            this.pbxJuego_nombre.Location = new System.Drawing.Point(50, 22);
            this.pbxJuego_nombre.Name = "pbxJuego_nombre";
            this.pbxJuego_nombre.Size = new System.Drawing.Size(220, 51);
            this.pbxJuego_nombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJuego_nombre.TabIndex = 0;
            this.pbxJuego_nombre.TabStop = false;
            // 
            // Minijuego_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 766);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minijuego_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.pnlLetrero.ResumeLayout(false);
            this.pnlMarcador.ResumeLayout(false);
            this.pnlGlobo1.ResumeLayout(false);
            this.pnlGlobo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuego_nombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private controlPersonalizado.patoControl patoControl1;
        private controlPersonalizado.patoControl patoControl2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton iniciar_minijuego;
        private System.Windows.Forms.Panel pnlGlobo1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlGlobo2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Panel pnlMarcador;
        private System.Windows.Forms.Label lblDisparos;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.Label lblAVG;
        private System.Windows.Forms.Panel pnlLetrero;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxJuego_nombre;
    }
}