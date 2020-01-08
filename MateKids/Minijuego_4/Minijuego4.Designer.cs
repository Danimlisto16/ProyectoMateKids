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
            this.lblMarcador = new System.Windows.Forms.Label();
            this.iniciar_juego = new MetroFramework.Controls.MetroButton();
            this.lblMarcador_titulo = new System.Windows.Forms.Label();
            this.problema = new System.Windows.Forms.Label();
            this.pbxLetreroPanel = new System.Windows.Forms.PictureBox();
            this.pnlGlobo1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlGlobo2 = new System.Windows.Forms.Panel();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.letrero = new System.Windows.Forms.PictureBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLetreroPanel)).BeginInit();
            this.pnlGlobo1.SuspendLayout();
            this.pnlGlobo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letrero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pbxLetreroPanel);
            this.metroPanel1.Controls.Add(this.lblMarcador);
            this.metroPanel1.Controls.Add(this.iniciar_juego);
            this.metroPanel1.Controls.Add(this.lblMarcador_titulo);
            this.metroPanel1.Controls.Add(this.pnlGlobo1);
            this.metroPanel1.Controls.Add(this.pnlGlobo2);
            this.metroPanel1.Controls.Add(this.problema);
            this.metroPanel1.Controls.Add(this.letrero);
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
            // lblMarcador
            // 
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(729, 186);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(35, 41);
            this.lblMarcador.TabIndex = 83;
            this.lblMarcador.Text = "0";
            this.lblMarcador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iniciar_juego
            // 
            this.iniciar_juego.Location = new System.Drawing.Point(627, 328);
            this.iniciar_juego.Name = "iniciar_juego";
            this.iniciar_juego.Size = new System.Drawing.Size(96, 30);
            this.iniciar_juego.TabIndex = 84;
            this.iniciar_juego.Text = "INICIAR";
            // 
            // lblMarcador_titulo
            // 
            this.lblMarcador_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador_titulo.Location = new System.Drawing.Point(542, 186);
            this.lblMarcador_titulo.Name = "lblMarcador_titulo";
            this.lblMarcador_titulo.Size = new System.Drawing.Size(158, 41);
            this.lblMarcador_titulo.TabIndex = 82;
            this.lblMarcador_titulo.Text = "Marcador:";
            // 
            // problema
            // 
            this.problema.BackColor = System.Drawing.Color.Transparent;
            this.problema.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problema.ForeColor = System.Drawing.Color.Black;
            this.problema.Location = new System.Drawing.Point(53, 546);
            this.problema.Name = "problema";
            this.problema.Size = new System.Drawing.Size(143, 59);
            this.problema.TabIndex = 85;
            this.problema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLetreroPanel
            // 
            this.pbxLetreroPanel.Image = global::MateKids.Properties.Resources.panelLetrero;
            this.pbxLetreroPanel.Location = new System.Drawing.Point(3, 20);
            this.pbxLetreroPanel.Name = "pbxLetreroPanel";
            this.pbxLetreroPanel.Size = new System.Drawing.Size(319, 338);
            this.pbxLetreroPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLetreroPanel.TabIndex = 90;
            this.pbxLetreroPanel.TabStop = false;
            // 
            // pnlGlobo1
            // 
            this.pnlGlobo1.BackColor = System.Drawing.Color.Transparent;
            this.pnlGlobo1.BackgroundImage = global::MateKids.Properties.Resources.GLOB;
            this.pnlGlobo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGlobo1.Controls.Add(this.lblError);
            this.pnlGlobo1.Location = new System.Drawing.Point(1039, 328);
            this.pnlGlobo1.Name = "pnlGlobo1";
            this.pnlGlobo1.Size = new System.Drawing.Size(112, 122);
            this.pnlGlobo1.TabIndex = 88;
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
            // 
            // pnlGlobo2
            // 
            this.pnlGlobo2.BackColor = System.Drawing.Color.Transparent;
            this.pnlGlobo2.BackgroundImage = global::MateKids.Properties.Resources.GLOB;
            this.pnlGlobo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGlobo2.Controls.Add(this.lblRespuesta);
            this.pnlGlobo2.Location = new System.Drawing.Point(1168, 328);
            this.pnlGlobo2.Name = "pnlGlobo2";
            this.pnlGlobo2.Size = new System.Drawing.Size(112, 122);
            this.pnlGlobo2.TabIndex = 87;
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
            // 
            // letrero
            // 
            this.letrero.BackColor = System.Drawing.Color.Transparent;
            this.letrero.Image = global::MateKids.Properties.Resources.letrero1;
            this.letrero.Location = new System.Drawing.Point(23, 520);
            this.letrero.Name = "letrero";
            this.letrero.Size = new System.Drawing.Size(210, 140);
            this.letrero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.letrero.TabIndex = 89;
            this.letrero.TabStop = false;
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
            // 
            // Minijuego_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 766);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minijuego_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLetreroPanel)).EndInit();
            this.pnlGlobo1.ResumeLayout(false);
            this.pnlGlobo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.letrero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private controlPersonalizado.patoControl patoControl1;
        private controlPersonalizado.patoControl patoControl2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox letrero;
        private System.Windows.Forms.Label lblMarcador;
        private MetroFramework.Controls.MetroButton iniciar_juego;
        private System.Windows.Forms.Label lblMarcador_titulo;
        private System.Windows.Forms.Panel pnlGlobo1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlGlobo2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label problema;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.PictureBox pbxLetreroPanel;
    }
}