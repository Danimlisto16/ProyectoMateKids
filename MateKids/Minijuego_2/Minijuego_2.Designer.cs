namespace MateKids.Minijuego_2
{
    partial class Minijuego_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minijuego_2));
            this.iniciar_minijuego = new System.Windows.Forms.Button();
            this.texto_descripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Regresar = new System.Windows.Forms.PictureBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // iniciar_minijuego
            // 
            this.iniciar_minijuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_minijuego.Location = new System.Drawing.Point(277, 477);
            this.iniciar_minijuego.Margin = new System.Windows.Forms.Padding(2);
            this.iniciar_minijuego.Name = "iniciar_minijuego";
            this.iniciar_minijuego.Size = new System.Drawing.Size(138, 34);
            this.iniciar_minijuego.TabIndex = 8;
            this.iniciar_minijuego.Text = "INICIAR";
            this.iniciar_minijuego.UseVisualStyleBackColor = true;
            this.iniciar_minijuego.Click += new System.EventHandler(this.iniciar_minijuego_Click);
            // 
            // texto_descripcion
            // 
            this.texto_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_descripcion.ForeColor = System.Drawing.Color.Blue;
            this.texto_descripcion.Location = new System.Drawing.Point(22, 148);
            this.texto_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texto_descripcion.Name = "texto_descripcion";
            this.texto_descripcion.Size = new System.Drawing.Size(664, 310);
            this.texto_descripcion.TabIndex = 7;
            this.texto_descripcion.Text = resources.GetString("texto_descripcion.Text");
            this.texto_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MateKids.Properties.Resources.multipractis_juego;
            this.pictureBox1.Location = new System.Drawing.Point(131, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.Image = global::MateKids.Properties.Resources.back__1_;
            this.Regresar.Location = new System.Drawing.Point(11, 11);
            this.Regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(65, 48);
            this.Regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Regresar.TabIndex = 112;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // lblModalidad
            // 
            this.lblModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.Location = new System.Drawing.Point(525, 506);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(173, 29);
            this.lblModalidad.TabIndex = 113;
            this.lblModalidad.Text = "Modo: ACIERTOS";
            // 
            // Minijuego_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 541);
            this.ControlBox = false;
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.iniciar_minijuego);
            this.Controls.Add(this.texto_descripcion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Minijuego_2";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Minijuego_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciar_minijuego;
        private System.Windows.Forms.Label texto_descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Regresar;
        private System.Windows.Forms.Label lblModalidad;
    }
}