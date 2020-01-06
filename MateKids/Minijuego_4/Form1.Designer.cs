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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReiniciar = new MetroFramework.Controls.MetroButton();
            this.btnIniciar = new MetroFramework.Controls.MetroButton();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblMarcador_titulo = new System.Windows.Forms.Label();
            this.titulo_minijuego_4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControl11 = new globoControl.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_minijuego_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReiniciar);
            this.splitContainer1.Panel1.Controls.Add(this.btnIniciar);
            this.splitContainer1.Panel1.Controls.Add(this.lblMarcador);
            this.splitContainer1.Panel1.Controls.Add(this.lblMarcador_titulo);
            this.splitContainer1.Panel1.Controls.Add(this.titulo_minijuego_4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userControl11);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.lblError);
            this.splitContainer1.Panel2.Controls.Add(this.lblRespuesta);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1266, 686);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(97, 504);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(120, 49);
            this.btnReiniciar.TabIndex = 72;
            this.btnReiniciar.Text = "REINICIAR";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(97, 428);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 49);
            this.btnIniciar.TabIndex = 71;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lblMarcador
            // 
            this.lblMarcador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(54, 189);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(224, 178);
            this.lblMarcador.TabIndex = 70;
            this.lblMarcador.Text = "0";
            this.lblMarcador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarcador_titulo
            // 
            this.lblMarcador_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador_titulo.Location = new System.Drawing.Point(74, 121);
            this.lblMarcador_titulo.Name = "lblMarcador_titulo";
            this.lblMarcador_titulo.Size = new System.Drawing.Size(179, 56);
            this.lblMarcador_titulo.TabIndex = 69;
            this.lblMarcador_titulo.Text = "Marcador";
            // 
            // titulo_minijuego_4
            // 
            this.titulo_minijuego_4.Image = global::MateKids.Properties.Resources.shooterex;
            this.titulo_minijuego_4.Location = new System.Drawing.Point(3, 3);
            this.titulo_minijuego_4.Name = "titulo_minijuego_4";
            this.titulo_minijuego_4.Size = new System.Drawing.Size(350, 104);
            this.titulo_minijuego_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titulo_minijuego_4.TabIndex = 67;
            this.titulo_minijuego_4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(385, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 46);
            this.label1.TabIndex = 73;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MateKids.Properties.Resources.letrero;
            this.pictureBox2.Location = new System.Drawing.Point(364, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblError.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(3, 120);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(69, 47);
            this.lblError.TabIndex = 75;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRespuesta.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(3, 60);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(69, 47);
            this.lblRespuesta.TabIndex = 74;
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRespuesta.Visible = false;
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MateKids.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControl11.Location = new System.Drawing.Point(43, 223);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(136, 144);
            this.userControl11.TabIndex = 78;
            this.userControl11.Click += new System.EventHandler(this.userControl11_Click);
            // 
            // Minijuego_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 766);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minijuego_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titulo_minijuego_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox titulo_minijuego_4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnReiniciar;
        private MetroFramework.Controls.MetroButton btnIniciar;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblMarcador_titulo;
        private System.Windows.Forms.Timer timer1;
        private controlPersonalizado.patoControl patoControl1;
        private controlPersonalizado.patoControl patoControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private globoControl.UserControl1 userControl11;
    }
}