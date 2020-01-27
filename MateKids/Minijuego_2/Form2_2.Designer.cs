namespace MateKids.Minijuego_2
{
    partial class Form2_2
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
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblintentos = new System.Windows.Forms.Label();
            this.intentos = new System.Windows.Forms.Label();
            this.marcador = new System.Windows.Forms.Label();
            this.SiguienteDivision = new System.Windows.Forms.Button();
            this.mtm_res_5 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod2_4 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_res_1 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_res_2 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_res_3 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_res_4 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtm_prod2_3 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod1_4 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod2_2 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod2_1 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod1_3 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod1_2 = new System.Windows.Forms.MaskedTextBox();
            this.mtm_prod1_1 = new System.Windows.Forms.MaskedTextBox();
            this.TerminarDivision = new System.Windows.Forms.Button();
            this.imagenlinea2 = new System.Windows.Forms.PictureBox();
            this.imagendivision = new System.Windows.Forms.PictureBox();
            this.Regresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenlinea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagendivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblpuntaje.Location = new System.Drawing.Point(770, 102);
            this.lblpuntaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(30, 33);
            this.lblpuntaje.TabIndex = 107;
            this.lblpuntaje.Text = "3";
            // 
            // lblintentos
            // 
            this.lblintentos.AutoSize = true;
            this.lblintentos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblintentos.Location = new System.Drawing.Point(770, 199);
            this.lblintentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblintentos.Name = "lblintentos";
            this.lblintentos.Size = new System.Drawing.Size(30, 33);
            this.lblintentos.TabIndex = 106;
            this.lblintentos.Text = "3";
            // 
            // intentos
            // 
            this.intentos.AutoSize = true;
            this.intentos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intentos.Location = new System.Drawing.Point(684, 155);
            this.intentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(136, 32);
            this.intentos.TabIndex = 105;
            this.intentos.Text = "INTENTOS";
            // 
            // marcador
            // 
            this.marcador.AutoSize = true;
            this.marcador.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.marcador.Location = new System.Drawing.Point(654, 62);
            this.marcador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(174, 32);
            this.marcador.TabIndex = 104;
            this.marcador.Text = "MARCADOR";
            // 
            // SiguienteDivision
            // 
            this.SiguienteDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiguienteDivision.Location = new System.Drawing.Point(680, 361);
            this.SiguienteDivision.Margin = new System.Windows.Forms.Padding(2);
            this.SiguienteDivision.Name = "SiguienteDivision";
            this.SiguienteDivision.Size = new System.Drawing.Size(132, 30);
            this.SiguienteDivision.TabIndex = 103;
            this.SiguienteDivision.Text = "Siguiente";
            this.SiguienteDivision.UseVisualStyleBackColor = true;
            this.SiguienteDivision.Visible = false;
            this.SiguienteDivision.Click += new System.EventHandler(this.SiguienteDivision_Click);
            // 
            // mtm_res_5
            // 
            this.mtm_res_5.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_res_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_res_5.Location = new System.Drawing.Point(131, 498);
            this.mtm_res_5.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_res_5.Mask = "9";
            this.mtm_res_5.Name = "mtm_res_5";
            this.mtm_res_5.Size = new System.Drawing.Size(42, 80);
            this.mtm_res_5.TabIndex = 102;
            this.mtm_res_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_res_5.ValidatingType = typeof(int);
            // 
            // mtm_prod2_4
            // 
            this.mtm_prod2_4.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod2_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod2_4.Location = new System.Drawing.Point(131, 375);
            this.mtm_prod2_4.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod2_4.Mask = "9";
            this.mtm_prod2_4.Name = "mtm_prod2_4";
            this.mtm_prod2_4.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod2_4.TabIndex = 95;
            this.mtm_prod2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod2_4.ValidatingType = typeof(int);
            // 
            // mtm_res_1
            // 
            this.mtm_res_1.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_res_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_res_1.Location = new System.Drawing.Point(363, 498);
            this.mtm_res_1.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_res_1.Mask = "9";
            this.mtm_res_1.Name = "mtm_res_1";
            this.mtm_res_1.Size = new System.Drawing.Size(42, 80);
            this.mtm_res_1.TabIndex = 97;
            this.mtm_res_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_res_1.ValidatingType = typeof(int);
            // 
            // mtm_res_2
            // 
            this.mtm_res_2.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_res_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_res_2.Location = new System.Drawing.Point(304, 498);
            this.mtm_res_2.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_res_2.Mask = "9";
            this.mtm_res_2.Name = "mtm_res_2";
            this.mtm_res_2.Size = new System.Drawing.Size(42, 80);
            this.mtm_res_2.TabIndex = 99;
            this.mtm_res_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_res_2.ValidatingType = typeof(int);
            // 
            // mtm_res_3
            // 
            this.mtm_res_3.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_res_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_res_3.Location = new System.Drawing.Point(250, 498);
            this.mtm_res_3.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_res_3.Mask = "9";
            this.mtm_res_3.Name = "mtm_res_3";
            this.mtm_res_3.Size = new System.Drawing.Size(42, 80);
            this.mtm_res_3.TabIndex = 100;
            this.mtm_res_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_res_3.ValidatingType = typeof(int);
            // 
            // mtm_res_4
            // 
            this.mtm_res_4.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_res_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_res_4.Location = new System.Drawing.Point(188, 498);
            this.mtm_res_4.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_res_4.Mask = "9";
            this.mtm_res_4.Name = "mtm_res_4";
            this.mtm_res_4.Size = new System.Drawing.Size(42, 80);
            this.mtm_res_4.TabIndex = 101;
            this.mtm_res_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_res_4.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 39);
            this.label1.TabIndex = 96;
            this.label1.Text = "+";
            // 
            // mtm_prod2_3
            // 
            this.mtm_prod2_3.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod2_3.Location = new System.Drawing.Point(189, 375);
            this.mtm_prod2_3.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod2_3.Mask = "9";
            this.mtm_prod2_3.Name = "mtm_prod2_3";
            this.mtm_prod2_3.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod2_3.TabIndex = 94;
            this.mtm_prod2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod2_3.ValidatingType = typeof(int);
            // 
            // mtm_prod1_4
            // 
            this.mtm_prod1_4.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod1_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod1_4.Location = new System.Drawing.Point(189, 277);
            this.mtm_prod1_4.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod1_4.Mask = "9";
            this.mtm_prod1_4.Name = "mtm_prod1_4";
            this.mtm_prod1_4.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod1_4.TabIndex = 91;
            this.mtm_prod1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod1_4.ValidatingType = typeof(int);
            // 
            // mtm_prod2_2
            // 
            this.mtm_prod2_2.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod2_2.Location = new System.Drawing.Point(250, 375);
            this.mtm_prod2_2.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod2_2.Mask = "9";
            this.mtm_prod2_2.Name = "mtm_prod2_2";
            this.mtm_prod2_2.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod2_2.TabIndex = 93;
            this.mtm_prod2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod2_2.ValidatingType = typeof(int);
            // 
            // mtm_prod2_1
            // 
            this.mtm_prod2_1.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod2_1.Location = new System.Drawing.Point(304, 375);
            this.mtm_prod2_1.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod2_1.Mask = "9";
            this.mtm_prod2_1.Name = "mtm_prod2_1";
            this.mtm_prod2_1.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod2_1.TabIndex = 92;
            this.mtm_prod2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod2_1.ValidatingType = typeof(int);
            // 
            // mtm_prod1_3
            // 
            this.mtm_prod1_3.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod1_3.Location = new System.Drawing.Point(247, 277);
            this.mtm_prod1_3.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod1_3.Mask = "9";
            this.mtm_prod1_3.Name = "mtm_prod1_3";
            this.mtm_prod1_3.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod1_3.TabIndex = 90;
            this.mtm_prod1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod1_3.ValidatingType = typeof(int);
            // 
            // mtm_prod1_2
            // 
            this.mtm_prod1_2.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod1_2.Location = new System.Drawing.Point(304, 277);
            this.mtm_prod1_2.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod1_2.Mask = "9";
            this.mtm_prod1_2.Name = "mtm_prod1_2";
            this.mtm_prod1_2.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod1_2.TabIndex = 89;
            this.mtm_prod1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod1_2.ValidatingType = typeof(int);
            // 
            // mtm_prod1_1
            // 
            this.mtm_prod1_1.BackColor = System.Drawing.Color.AliceBlue;
            this.mtm_prod1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtm_prod1_1.Location = new System.Drawing.Point(363, 277);
            this.mtm_prod1_1.Margin = new System.Windows.Forms.Padding(2);
            this.mtm_prod1_1.Mask = "9";
            this.mtm_prod1_1.Name = "mtm_prod1_1";
            this.mtm_prod1_1.Size = new System.Drawing.Size(42, 80);
            this.mtm_prod1_1.TabIndex = 88;
            this.mtm_prod1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtm_prod1_1.ValidatingType = typeof(int);
            // 
            // TerminarDivision
            // 
            this.TerminarDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminarDivision.Location = new System.Drawing.Point(482, 599);
            this.TerminarDivision.Margin = new System.Windows.Forms.Padding(2);
            this.TerminarDivision.Name = "TerminarDivision";
            this.TerminarDivision.Size = new System.Drawing.Size(85, 30);
            this.TerminarDivision.TabIndex = 108;
            this.TerminarDivision.Text = "Termine";
            this.TerminarDivision.UseVisualStyleBackColor = true;
            this.TerminarDivision.Click += new System.EventHandler(this.TerminarDivision_Click);
            // 
            // imagenlinea2
            // 
            this.imagenlinea2.Image = global::MateKids.Properties.Resources.linea2;
            this.imagenlinea2.Location = new System.Drawing.Point(128, 459);
            this.imagenlinea2.Margin = new System.Windows.Forms.Padding(2);
            this.imagenlinea2.Name = "imagenlinea2";
            this.imagenlinea2.Size = new System.Drawing.Size(310, 34);
            this.imagenlinea2.TabIndex = 98;
            this.imagenlinea2.TabStop = false;
            // 
            // imagendivision
            // 
            this.imagendivision.Image = global::MateKids.Properties.Resources.m2;
            this.imagendivision.Location = new System.Drawing.Point(160, 62);
            this.imagendivision.Margin = new System.Windows.Forms.Padding(2);
            this.imagendivision.Name = "imagendivision";
            this.imagendivision.Size = new System.Drawing.Size(306, 235);
            this.imagendivision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagendivision.TabIndex = 87;
            this.imagendivision.TabStop = false;
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
            this.Regresar.TabIndex = 114;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Form2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 639);
            this.ControlBox = false;
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.TerminarDivision);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblintentos);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.marcador);
            this.Controls.Add(this.SiguienteDivision);
            this.Controls.Add(this.mtm_res_5);
            this.Controls.Add(this.mtm_prod2_4);
            this.Controls.Add(this.mtm_res_1);
            this.Controls.Add(this.mtm_res_2);
            this.Controls.Add(this.mtm_res_3);
            this.Controls.Add(this.mtm_res_4);
            this.Controls.Add(this.imagenlinea2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtm_prod2_3);
            this.Controls.Add(this.mtm_prod1_4);
            this.Controls.Add(this.mtm_prod2_2);
            this.Controls.Add(this.mtm_prod2_1);
            this.Controls.Add(this.mtm_prod1_3);
            this.Controls.Add(this.mtm_prod1_2);
            this.Controls.Add(this.mtm_prod1_1);
            this.Controls.Add(this.imagendivision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2_2";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form2_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenlinea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagendivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblintentos;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Label marcador;
        private System.Windows.Forms.Button SiguienteDivision;
        private System.Windows.Forms.MaskedTextBox mtm_res_5;
        private System.Windows.Forms.MaskedTextBox mtm_prod2_4;
        private System.Windows.Forms.MaskedTextBox mtm_res_1;
        private System.Windows.Forms.MaskedTextBox mtm_res_2;
        private System.Windows.Forms.MaskedTextBox mtm_res_3;
        private System.Windows.Forms.MaskedTextBox mtm_res_4;
        private System.Windows.Forms.PictureBox imagenlinea2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtm_prod2_3;
        private System.Windows.Forms.MaskedTextBox mtm_prod1_4;
        private System.Windows.Forms.MaskedTextBox mtm_prod2_2;
        private System.Windows.Forms.MaskedTextBox mtm_prod2_1;
        private System.Windows.Forms.MaskedTextBox mtm_prod1_3;
        private System.Windows.Forms.MaskedTextBox mtm_prod1_2;
        private System.Windows.Forms.MaskedTextBox mtm_prod1_1;
        private System.Windows.Forms.PictureBox imagendivision;
        private System.Windows.Forms.Button TerminarDivision;
        private System.Windows.Forms.PictureBox Regresar;
    }
}