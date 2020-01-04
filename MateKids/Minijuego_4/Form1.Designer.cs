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
            this.patoControl2 = new controlPersonalizado.patoControl();
            this.patoControl1 = new controlPersonalizado.patoControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_minijuego_4)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.patoControl2);
            this.splitContainer1.Panel2.Controls.Add(this.patoControl1);
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
            // patoControl2
            // 
            this.patoControl2.BackColor = System.Drawing.Color.Transparent;
            this.patoControl2.Location = new System.Drawing.Point(53, 314);
            this.patoControl2.Name = "patoControl2";
            this.patoControl2.Size = new System.Drawing.Size(99, 142);
            this.patoControl2.TabIndex = 2;
            this.patoControl2.Load += new System.EventHandler(this.patoControl2_Load);
            this.patoControl2.Click += new System.EventHandler(this.patoControl2_Click);
            // 
            // patoControl1
            // 
            this.patoControl1.BackColor = System.Drawing.Color.Transparent;
            this.patoControl1.Location = new System.Drawing.Point(53, 314);
            this.patoControl1.Name = "patoControl1";
            this.patoControl1.Size = new System.Drawing.Size(99, 142);
            this.patoControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MateKids.Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 47);
            this.label1.TabIndex = 73;
            // 
            // Minijuego_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 766);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minijuego_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titulo_minijuego_4)).EndInit();
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
    }
}