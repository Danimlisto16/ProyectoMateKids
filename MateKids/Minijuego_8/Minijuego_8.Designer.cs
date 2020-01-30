namespace MateKids.Minijuego_8
{
    partial class Minijuego_8
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
            this.iniciar_minijuego = new System.Windows.Forms.Button();
            this.texto_descripcion = new System.Windows.Forms.Label();
            this.titulo_minijuego8 = new System.Windows.Forms.PictureBox();
            this.Regresar = new System.Windows.Forms.PictureBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titulo_minijuego8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // iniciar_minijuego
            // 
            this.iniciar_minijuego.BackColor = System.Drawing.Color.Transparent;
            this.iniciar_minijuego.BackgroundImage = global::MateKids.Properties.Resources.fondo_panel_boton;
            this.iniciar_minijuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iniciar_minijuego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iniciar_minijuego.Font = new System.Drawing.Font("Sitka Subheading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iniciar_minijuego.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iniciar_minijuego.Location = new System.Drawing.Point(365, 462);
            this.iniciar_minijuego.Margin = new System.Windows.Forms.Padding(2);
            this.iniciar_minijuego.Name = "iniciar_minijuego";
            this.iniciar_minijuego.Size = new System.Drawing.Size(279, 68);
            this.iniciar_minijuego.TabIndex = 15;
            this.iniciar_minijuego.Text = "Iniciar ";
            this.iniciar_minijuego.UseVisualStyleBackColor = false;
            this.iniciar_minijuego.Click += new System.EventHandler(this.iniciar_minijuego_Click);
            // 
            // texto_descripcion
            // 
            this.texto_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.texto_descripcion.Font = new System.Drawing.Font("Rockwell Extra Bold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_descripcion.Location = new System.Drawing.Point(116, 135);
            this.texto_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texto_descripcion.Name = "texto_descripcion";
            this.texto_descripcion.Size = new System.Drawing.Size(793, 288);
            this.texto_descripcion.TabIndex = 14;
            this.texto_descripcion.Text = "Hola\r\nEn este minijuego te hemos puesto algunos problemas de divisiones, donde tú" +
    " tendrás que elegir la respuesta correcta. \r\n\r\nRecuerda que tienes 3 intentos pa" +
    "ra hacerlo.\r\nComencemos...";
            this.texto_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titulo_minijuego8
            // 
            this.titulo_minijuego8.BackColor = System.Drawing.Color.Transparent;
            this.titulo_minijuego8.Image = global::MateKids.Properties.Resources.divitest_juego;
            this.titulo_minijuego8.Location = new System.Drawing.Point(282, 22);
            this.titulo_minijuego8.Margin = new System.Windows.Forms.Padding(2);
            this.titulo_minijuego8.Name = "titulo_minijuego8";
            this.titulo_minijuego8.Size = new System.Drawing.Size(469, 134);
            this.titulo_minijuego8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titulo_minijuego8.TabIndex = 13;
            this.titulo_minijuego8.TabStop = false;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.Image = global::MateKids.Properties.Resources.back__1_;
            this.Regresar.Location = new System.Drawing.Point(11, 11);
            this.Regresar.Margin = new System.Windows.Forms.Padding(2);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(59, 58);
            this.Regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Regresar.TabIndex = 113;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // lblModalidad
            // 
            this.lblModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidad.Location = new System.Drawing.Point(840, 521);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(173, 29);
            this.lblModalidad.TabIndex = 114;
            this.lblModalidad.Text = "Modo: ACIERTOS";
            // 
            // Minijuego_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateKids.Properties.Resources.Photo_from_album__Летние_пейзажи__природа__on_Yandex_Disk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 559);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.iniciar_minijuego);
            this.Controls.Add(this.texto_descripcion);
            this.Controls.Add(this.titulo_minijuego8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Minijuego_8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minijuego_8";
            ((System.ComponentModel.ISupportInitialize)(this.titulo_minijuego8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciar_minijuego;
        private System.Windows.Forms.Label texto_descripcion;
        private System.Windows.Forms.PictureBox titulo_minijuego8;
        private System.Windows.Forms.PictureBox Regresar;
        private System.Windows.Forms.Label lblModalidad;
    }
}