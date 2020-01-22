namespace MateKids.Minijuego_4
{
    partial class Minijuego_4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minijuego_4_1));
            this.pnlLetrero = new System.Windows.Forms.Panel();
            this.lblProblema = new System.Windows.Forms.Label();
            this.pnlMarcador = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pbxTiempo = new System.Windows.Forms.PictureBox();
            this.lblDisparos = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.pnlMitad2 = new System.Windows.Forms.Panel();
            this.pnlGlobo2 = new System.Windows.Forms.Panel();
            this.lblOpcion2 = new System.Windows.Forms.Label();
            this.pnlMitad1 = new System.Windows.Forms.Panel();
            this.pnlGlobo1 = new System.Windows.Forms.Panel();
            this.lblOpcion1 = new System.Windows.Forms.Label();
            this.pbxFondo = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbxJuego_nombre = new System.Windows.Forms.PictureBox();
            this.tmrPosicion = new System.Windows.Forms.Timer(this.components);
            this.tmrTiempoJuego = new System.Windows.Forms.Timer(this.components);
            this.pnlLetrero.SuspendLayout();
            this.pnlMarcador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiempo)).BeginInit();
            this.pnlMitad2.SuspendLayout();
            this.pnlGlobo2.SuspendLayout();
            this.pnlMitad1.SuspendLayout();
            this.pnlGlobo1.SuspendLayout();
            this.pbxFondo.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuego_nombre)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLetrero
            // 
            this.pnlLetrero.BackColor = System.Drawing.Color.Transparent;
            this.pnlLetrero.BackgroundImage = global::MateKids.Properties.Resources.letrero1;
            this.pnlLetrero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLetrero.Controls.Add(this.lblProblema);
            this.pnlLetrero.Location = new System.Drawing.Point(25, 438);
            this.pnlLetrero.Name = "pnlLetrero";
            this.pnlLetrero.Size = new System.Drawing.Size(180, 140);
            this.pnlLetrero.TabIndex = 99;
            // 
            // lblProblema
            // 
            this.lblProblema.BackColor = System.Drawing.Color.Transparent;
            this.lblProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProblema.Location = new System.Drawing.Point(25, 22);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(143, 59);
            this.lblProblema.TabIndex = 85;
            this.lblProblema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMarcador
            // 
            this.pnlMarcador.BackColor = System.Drawing.Color.Transparent;
            this.pnlMarcador.BackgroundImage = global::MateKids.Properties.Resources.panelLetrero_removebg_preview;
            this.pnlMarcador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMarcador.Controls.Add(this.lblTiempo);
            this.pnlMarcador.Controls.Add(this.pbxTiempo);
            this.pnlMarcador.Controls.Add(this.lblDisparos);
            this.pnlMarcador.Controls.Add(this.lblAciertos);
            this.pnlMarcador.Controls.Add(this.lblFallos);
            this.pnlMarcador.Location = new System.Drawing.Point(3, 45);
            this.pnlMarcador.Name = "pnlMarcador";
            this.pnlMarcador.Size = new System.Drawing.Size(262, 358);
            this.pnlMarcador.TabIndex = 98;
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(72, 117);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(63, 38);
            this.lblTiempo.TabIndex = 99;
            this.lblTiempo.Text = "000";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxTiempo
            // 
            this.pbxTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxTiempo.Image = ((System.Drawing.Image)(resources.GetObject("pbxTiempo.Image")));
            this.pbxTiempo.Location = new System.Drawing.Point(141, 117);
            this.pbxTiempo.Name = "pbxTiempo";
            this.pbxTiempo.Size = new System.Drawing.Size(39, 38);
            this.pbxTiempo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTiempo.TabIndex = 18;
            this.pbxTiempo.TabStop = false;
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
            // pnlMitad2
            // 
            this.pnlMitad2.BackColor = System.Drawing.Color.Transparent;
            this.pnlMitad2.BackgroundImage = global::MateKids.Properties.Resources.fondo1;
            this.pnlMitad2.Controls.Add(this.pnlGlobo2);
            this.pnlMitad2.Location = new System.Drawing.Point(817, 12);
            this.pnlMitad2.Name = "pnlMitad2";
            this.pnlMitad2.Size = new System.Drawing.Size(515, 505);
            this.pnlMitad2.TabIndex = 2;
            this.pnlMitad2.Visible = false;
            // 
            // pnlGlobo2
            // 
            this.pnlGlobo2.BackgroundImage = global::MateKids.Properties.Resources.GLOB;
            this.pnlGlobo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGlobo2.Controls.Add(this.lblOpcion2);
            this.pnlGlobo2.Location = new System.Drawing.Point(390, 378);
            this.pnlGlobo2.Name = "pnlGlobo2";
            this.pnlGlobo2.Size = new System.Drawing.Size(122, 124);
            this.pnlGlobo2.TabIndex = 1;
            // 
            // lblOpcion2
            // 
            this.lblOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion2.ForeColor = System.Drawing.Color.White;
            this.lblOpcion2.Location = new System.Drawing.Point(31, 17);
            this.lblOpcion2.Name = "lblOpcion2";
            this.lblOpcion2.Size = new System.Drawing.Size(59, 38);
            this.lblOpcion2.TabIndex = 0;
            this.lblOpcion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpcion2.Click += new System.EventHandler(this.lblOpcion2_Click);
            // 
            // pnlMitad1
            // 
            this.pnlMitad1.BackColor = System.Drawing.Color.Transparent;
            this.pnlMitad1.BackgroundImage = global::MateKids.Properties.Resources.fondo1;
            this.pnlMitad1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMitad1.Controls.Add(this.pnlGlobo1);
            this.pnlMitad1.Location = new System.Drawing.Point(292, 12);
            this.pnlMitad1.Name = "pnlMitad1";
            this.pnlMitad1.Size = new System.Drawing.Size(519, 505);
            this.pnlMitad1.TabIndex = 1;
            this.pnlMitad1.Visible = false;
            // 
            // pnlGlobo1
            // 
            this.pnlGlobo1.BackgroundImage = global::MateKids.Properties.Resources.GLOB;
            this.pnlGlobo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGlobo1.Controls.Add(this.lblOpcion1);
            this.pnlGlobo1.Location = new System.Drawing.Point(394, 378);
            this.pnlGlobo1.Name = "pnlGlobo1";
            this.pnlGlobo1.Size = new System.Drawing.Size(122, 124);
            this.pnlGlobo1.TabIndex = 0;
            // 
            // lblOpcion1
            // 
            this.lblOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion1.ForeColor = System.Drawing.Color.White;
            this.lblOpcion1.Location = new System.Drawing.Point(31, 17);
            this.lblOpcion1.Name = "lblOpcion1";
            this.lblOpcion1.Size = new System.Drawing.Size(59, 38);
            this.lblOpcion1.TabIndex = 0;
            this.lblOpcion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpcion1.Click += new System.EventHandler(this.lblOpcion1_Click);
            // 
            // pbxFondo
            // 
            this.pbxFondo.BackgroundImage = global::MateKids.Properties.Resources.fondo;
            this.pbxFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFondo.Controls.Add(this.btnIniciar);
            this.pbxFondo.Controls.Add(this.pnlLetrero);
            this.pbxFondo.Controls.Add(this.pnlMitad1);
            this.pbxFondo.Controls.Add(this.pnlMarcador);
            this.pbxFondo.Controls.Add(this.pnlMitad2);
            this.pbxFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxFondo.Location = new System.Drawing.Point(20, 60);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(1348, 592);
            this.pbxFondo.TabIndex = 100;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciar.Location = new System.Drawing.Point(755, 532);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(184, 46);
            this.btnIniciar.TabIndex = 100;
            this.btnIniciar.Text = "JUGAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitulo.BackgroundImage = global::MateKids.Properties.Resources.titulo_removebg_preview;
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitulo.Controls.Add(this.pbxJuego_nombre);
            this.pnlTitulo.Location = new System.Drawing.Point(26, 60);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(283, 99);
            this.pnlTitulo.TabIndex = 101;
            // 
            // pbxJuego_nombre
            // 
            this.pbxJuego_nombre.Image = global::MateKids.Properties.Resources.titulo;
            this.pbxJuego_nombre.Location = new System.Drawing.Point(26, 21);
            this.pbxJuego_nombre.Name = "pbxJuego_nombre";
            this.pbxJuego_nombre.Size = new System.Drawing.Size(220, 51);
            this.pbxJuego_nombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJuego_nombre.TabIndex = 0;
            this.pbxJuego_nombre.TabStop = false;
            // 
            // tmrPosicion
            // 
            this.tmrPosicion.Interval = 2000;
            this.tmrPosicion.Tick += new System.EventHandler(this.tmrPosicion_Tick);
            // 
            // tmrTiempoJuego
            // 
            this.tmrTiempoJuego.Interval = 1000;
            this.tmrTiempoJuego.Tick += new System.EventHandler(this.tmrTiempoJuego_Tick);
            // 
            // Minijuego_4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 672);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pbxFondo);
            this.MinimizeBox = false;
            this.Name = "Minijuego_4_1";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Minijuego_4_1_Load);
            this.pnlLetrero.ResumeLayout(false);
            this.pnlMarcador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiempo)).EndInit();
            this.pnlMitad2.ResumeLayout(false);
            this.pnlGlobo2.ResumeLayout(false);
            this.pnlMitad1.ResumeLayout(false);
            this.pnlGlobo1.ResumeLayout(false);
            this.pbxFondo.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuego_nombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMitad1;
        private System.Windows.Forms.Panel pnlGlobo1;
        private System.Windows.Forms.Label lblOpcion1;
        private System.Windows.Forms.Panel pnlMitad2;
        private System.Windows.Forms.Panel pnlMarcador;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pbxTiempo;
        private System.Windows.Forms.Label lblDisparos;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.Panel pnlLetrero;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Panel pnlGlobo2;
        private System.Windows.Forms.Label lblOpcion2;
        private System.Windows.Forms.Panel pbxFondo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxJuego_nombre;
        private System.Windows.Forms.Timer tmrPosicion;
        private System.Windows.Forms.Timer tmrTiempoJuego;
    }
}