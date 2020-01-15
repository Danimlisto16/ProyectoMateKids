namespace MateKids.Minijuego_8
{
    partial class Form8_5
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
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.Siguiente = new System.Windows.Forms.PictureBox();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblintentos = new System.Windows.Forms.Label();
            this.intentos = new System.Windows.Forms.Label();
            this.marcador = new System.Windows.Forms.Label();
            this.Opcion3 = new System.Windows.Forms.Button();
            this.Opcion2 = new System.Windows.Forms.Button();
            this.problema = new System.Windows.Forms.Label();
            this.Opcion1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Siguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblrespuesta.Enabled = false;
            this.lblrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(389, 58);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(473, 39);
            this.lblrespuesta.TabIndex = 105;
            this.lblrespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblrespuesta.Visible = false;
            // 
            // Siguiente
            // 
            this.Siguiente.BackColor = System.Drawing.Color.Transparent;
            this.Siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Siguiente.Image = global::MateKids.Properties.Resources.rightarrow3_78482;
            this.Siguiente.Location = new System.Drawing.Point(1209, 368);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(131, 134);
            this.Siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Siguiente.TabIndex = 104;
            this.Siguiente.TabStop = false;
            this.Siguiente.Visible = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblpuntaje.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblpuntaje.Location = new System.Drawing.Point(1274, 170);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(35, 40);
            this.lblpuntaje.TabIndex = 103;
            this.lblpuntaje.Text = "3";
            // 
            // lblintentos
            // 
            this.lblintentos.AutoSize = true;
            this.lblintentos.BackColor = System.Drawing.Color.Transparent;
            this.lblintentos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblintentos.Location = new System.Drawing.Point(1274, 290);
            this.lblintentos.Name = "lblintentos";
            this.lblintentos.Size = new System.Drawing.Size(35, 40);
            this.lblintentos.TabIndex = 102;
            this.lblintentos.Text = "3";
            // 
            // intentos
            // 
            this.intentos.AutoSize = true;
            this.intentos.BackColor = System.Drawing.Color.Transparent;
            this.intentos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intentos.Location = new System.Drawing.Point(1160, 236);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(164, 39);
            this.intentos.TabIndex = 101;
            this.intentos.Text = "INTENTOS";
            // 
            // marcador
            // 
            this.marcador.AutoSize = true;
            this.marcador.BackColor = System.Drawing.Color.Transparent;
            this.marcador.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.marcador.Location = new System.Drawing.Point(1120, 121);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(210, 39);
            this.marcador.TabIndex = 100;
            this.marcador.Text = "MARCADOR";
            // 
            // Opcion3
            // 
            this.Opcion3.BackColor = System.Drawing.Color.Transparent;
            this.Opcion3.BackgroundImage = global::MateKids.Properties.Resources.fondo_panel_boton;
            this.Opcion3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Opcion3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Opcion3.Font = new System.Drawing.Font("Sitka Subheading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Opcion3.ForeColor = System.Drawing.Color.Black;
            this.Opcion3.Location = new System.Drawing.Point(578, 547);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Size = new System.Drawing.Size(268, 84);
            this.Opcion3.TabIndex = 99;
            this.Opcion3.Text = "13 boliches";
            this.Opcion3.UseVisualStyleBackColor = false;
            this.Opcion3.Click += new System.EventHandler(this.Opcion3_Click);
            // 
            // Opcion2
            // 
            this.Opcion2.BackColor = System.Drawing.Color.Transparent;
            this.Opcion2.BackgroundImage = global::MateKids.Properties.Resources.imagen_boton;
            this.Opcion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Opcion2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Opcion2.Font = new System.Drawing.Font("Sitka Subheading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Opcion2.ForeColor = System.Drawing.Color.Black;
            this.Opcion2.Location = new System.Drawing.Point(578, 457);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(268, 84);
            this.Opcion2.TabIndex = 98;
            this.Opcion2.Text = "14 boliches";
            this.Opcion2.UseVisualStyleBackColor = false;
            this.Opcion2.Click += new System.EventHandler(this.Opcion2_Click);
            // 
            // problema
            // 
            this.problema.BackColor = System.Drawing.Color.Transparent;
            this.problema.Font = new System.Drawing.Font("Rockwell Extra Bold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problema.Location = new System.Drawing.Point(26, 123);
            this.problema.Name = "problema";
            this.problema.Size = new System.Drawing.Size(1068, 152);
            this.problema.TabIndex = 97;
            this.problema.Text = "Hay que distribuir 56 boliches entre 4 niños.\r\n¿Cuántos boliches le corresponden " +
    "a cada niño?";
            // 
            // Opcion1
            // 
            this.Opcion1.BackColor = System.Drawing.Color.Transparent;
            this.Opcion1.BackgroundImage = global::MateKids.Properties.Resources.imagen_boton;
            this.Opcion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Opcion1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Opcion1.Font = new System.Drawing.Font("Sitka Subheading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Opcion1.ForeColor = System.Drawing.Color.Black;
            this.Opcion1.Location = new System.Drawing.Point(578, 368);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(268, 84);
            this.Opcion1.TabIndex = 96;
            this.Opcion1.Text = "12 boliches";
            this.Opcion1.UseVisualStyleBackColor = false;
            this.Opcion1.Click += new System.EventHandler(this.Opcion1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form8_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateKids.Properties.Resources.Photo_from_album__Летние_пейзажи__природа__on_Yandex_Disk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 688);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblintentos);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.marcador);
            this.Controls.Add(this.Opcion3);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.problema);
            this.Controls.Add(this.Opcion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form8_5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8_5";
            this.Load += new System.EventHandler(this.Form8_5Load);
            ((System.ComponentModel.ISupportInitialize)(this.Siguiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.PictureBox Siguiente;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblintentos;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Label marcador;
        private System.Windows.Forms.Button Opcion3;
        private System.Windows.Forms.Button Opcion2;
        private System.Windows.Forms.Label problema;
        private System.Windows.Forms.Button Opcion1;
        private System.Windows.Forms.Timer timer1;
    }
}