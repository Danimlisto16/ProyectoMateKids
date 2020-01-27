namespace MateKids.Minijuego_6
{
    partial class Minijuego_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minijuego_6));
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.IniciarJuego = new System.Windows.Forms.Button();
            this.btnOpcion4 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.pbxTiempo = new System.Windows.Forms.PictureBox();
            this.tmrTiempoJuego = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Regresar = new System.Windows.Forms.PictureBox();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.White;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(798, 186);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(46, 36);
            this.lblTiempo.TabIndex = 27;
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(240, 337);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(649, 23);
            this.lblInstruccion.TabIndex = 22;
            this.lblInstruccion.Text = "SELECCIONA LA OPCION CORRECTA";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.Reiniciar);
            this.pnlControles.Controls.Add(this.lblPuntaje);
            this.pnlControles.Controls.Add(this.IniciarJuego);
            this.pnlControles.Location = new System.Drawing.Point(19, 147);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(200, 393);
            this.pnlControles.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marcador";
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.Reiniciar.Location = new System.Drawing.Point(45, 284);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(105, 34);
            this.Reiniciar.TabIndex = 2;
            this.Reiniciar.Text = "Jugar Otra Vez";
            this.Reiniciar.UseVisualStyleBackColor = false;
            this.Reiniciar.Visible = false;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuntaje.Location = new System.Drawing.Point(3, 54);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(194, 136);
            this.lblPuntaje.TabIndex = 1;
            this.lblPuntaje.Text = "0";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IniciarJuego
            // 
            this.IniciarJuego.BackColor = System.Drawing.Color.AliceBlue;
            this.IniciarJuego.Location = new System.Drawing.Point(45, 207);
            this.IniciarJuego.Name = "IniciarJuego";
            this.IniciarJuego.Size = new System.Drawing.Size(105, 34);
            this.IniciarJuego.TabIndex = 0;
            this.IniciarJuego.Text = "Iniciar";
            this.IniciarJuego.UseVisualStyleBackColor = false;
            this.IniciarJuego.Click += new System.EventHandler(this.IniciarJuego_Click);
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpcion4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion4.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpcion4.Location = new System.Drawing.Point(751, 370);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(138, 126);
            this.btnOpcion4.TabIndex = 24;
            this.btnOpcion4.UseVisualStyleBackColor = false;
            this.btnOpcion4.Click += new System.EventHandler(this.btnOpcion4_Click);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpcion3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion3.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpcion3.Location = new System.Drawing.Point(582, 370);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(138, 126);
            this.btnOpcion3.TabIndex = 23;
            this.btnOpcion3.UseVisualStyleBackColor = false;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpcion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion2.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpcion2.Location = new System.Drawing.Point(408, 370);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(138, 126);
            this.btnOpcion2.TabIndex = 21;
            this.btnOpcion2.UseVisualStyleBackColor = false;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOpcion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion1.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpcion1.Location = new System.Drawing.Point(240, 370);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(138, 126);
            this.btnOpcion1.TabIndex = 20;
            this.btnOpcion1.UseVisualStyleBackColor = false;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.BackColor = System.Drawing.Color.White;
            this.lblOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(241, 184);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(648, 142);
            this.lblOperacion.TabIndex = 19;
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxTiempo
            // 
            this.pbxTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxTiempo.Image = ((System.Drawing.Image)(resources.GetObject("pbxTiempo.Image")));
            this.pbxTiempo.Location = new System.Drawing.Point(850, 184);
            this.pbxTiempo.Name = "pbxTiempo";
            this.pbxTiempo.Size = new System.Drawing.Size(39, 38);
            this.pbxTiempo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTiempo.TabIndex = 26;
            this.pbxTiempo.TabStop = false;
            // 
            // tmrTiempoJuego
            // 
            this.tmrTiempoJuego.Interval = 1000;
            this.tmrTiempoJuego.Tick += new System.EventHandler(this.tmrTiempoJuego_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MateKids.Properties.Resources.divimax_juego;
            this.pictureBox1.Location = new System.Drawing.Point(244, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.White;
            this.Regresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.Image = global::MateKids.Properties.Resources.back__1_;
            this.Regresar.Location = new System.Drawing.Point(8, 10);
            this.Regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(59, 44);
            this.Regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Regresar.TabIndex = 111;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            this.Regresar.MouseEnter += new System.EventHandler(this.Regresar_MouseEnter);
            this.Regresar.MouseLeave += new System.EventHandler(this.Regresar_MouseLeave);
            // 
            // Minijuego_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateKids.Properties.Resources.dibujos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 557);
            this.ControlBox = false;
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.pbxTiempo);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.btnOpcion4);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.lblOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Minijuego_6";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Minijuego_6_FormClosed);
            this.Load += new System.EventHandler(this.Minijuego1_Load);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pbxTiempo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button IniciarJuego;
        private System.Windows.Forms.Button btnOpcion4;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Timer tmrTiempoJuego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Regresar;
    }
}