namespace MateKids.Miinijuego_7
{
    partial class Minijuego7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minijuego7));
            this.iniciar_minijuego = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.texto_descripcion = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // iniciar_minijuego
            // 
            this.iniciar_minijuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_minijuego.Location = new System.Drawing.Point(268, 490);
            this.iniciar_minijuego.Margin = new System.Windows.Forms.Padding(2);
            this.iniciar_minijuego.Name = "iniciar_minijuego";
            this.iniciar_minijuego.Size = new System.Drawing.Size(138, 34);
            this.iniciar_minijuego.TabIndex = 5;
            this.iniciar_minijuego.Text = "INICIAR";
            this.iniciar_minijuego.UseVisualStyleBackColor = true;
            this.iniciar_minijuego.Click += new System.EventHandler(this.iniciar_minijuego_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MateKids.Properties.Resources.divipractis_juego;
            this.pictureBox1.Location = new System.Drawing.Point(158, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // texto_descripcion
            // 
            this.texto_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_descripcion.ForeColor = System.Drawing.Color.Blue;
            this.texto_descripcion.Location = new System.Drawing.Point(22, 135);
            this.texto_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texto_descripcion.Name = "texto_descripcion";
            this.texto_descripcion.Size = new System.Drawing.Size(664, 310);
            this.texto_descripcion.TabIndex = 8;
            this.texto_descripcion.Text = resources.GetString("texto_descripcion.Text");
            this.texto_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Regresar.TabIndex = 111;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Minijuego7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 581);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.texto_descripcion);
            this.Controls.Add(this.iniciar_minijuego);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Minijuego7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minijuego7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciar_minijuego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label texto_descripcion;
        private System.Windows.Forms.PictureBox Regresar;
    }
}