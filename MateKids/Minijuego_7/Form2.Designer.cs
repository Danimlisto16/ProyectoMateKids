﻿namespace MateKids.Miinijuego_7
{
    partial class Form_2
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
            this.mtb_div7 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_div5 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_div6 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_div3 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_div4 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_div1 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_div2 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_res2 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_res1 = new System.Windows.Forms.MaskedTextBox();
            this.TerminarDivision = new System.Windows.Forms.Button();
            this.imagenlinea2 = new System.Windows.Forms.PictureBox();
            this.imagenlinea1 = new System.Windows.Forms.PictureBox();
            this.imagendivision = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenlinea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenlinea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagendivision)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblpuntaje.Location = new System.Drawing.Point(1048, 88);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(35, 40);
            this.lblpuntaje.TabIndex = 167;
            this.lblpuntaje.Text = "3";
            // 
            // lblintentos
            // 
            this.lblintentos.AutoSize = true;
            this.lblintentos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblintentos.Location = new System.Drawing.Point(1048, 208);
            this.lblintentos.Name = "lblintentos";
            this.lblintentos.Size = new System.Drawing.Size(35, 40);
            this.lblintentos.TabIndex = 166;
            this.lblintentos.Text = "3";
            // 
            // intentos
            // 
            this.intentos.AutoSize = true;
            this.intentos.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intentos.Location = new System.Drawing.Point(923, 155);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(164, 39);
            this.intentos.TabIndex = 165;
            this.intentos.Text = "INTENTOS";
            // 
            // marcador
            // 
            this.marcador.AutoSize = true;
            this.marcador.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.marcador.Location = new System.Drawing.Point(877, 36);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(210, 39);
            this.marcador.TabIndex = 164;
            this.marcador.Text = "MARCADOR";
            // 
            // SiguienteDivision
            // 
            this.SiguienteDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiguienteDivision.Location = new System.Drawing.Point(930, 401);
            this.SiguienteDivision.Name = "SiguienteDivision";
            this.SiguienteDivision.Size = new System.Drawing.Size(177, 37);
            this.SiguienteDivision.TabIndex = 163;
            this.SiguienteDivision.Text = "Siguiente";
            this.SiguienteDivision.UseVisualStyleBackColor = true;
            this.SiguienteDivision.Visible = false;
            this.SiguienteDivision.Click += new System.EventHandler(this.SiguienteDivision_Click);
            // 
            // mtb_div7
            // 
            this.mtb_div7.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div7.Location = new System.Drawing.Point(328, 667);
            this.mtb_div7.Mask = "9";
            this.mtb_div7.Name = "mtb_div7";
            this.mtb_div7.Size = new System.Drawing.Size(54, 98);
            this.mtb_div7.TabIndex = 156;
            this.mtb_div7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div7.ValidatingType = typeof(int);
            // 
            // mtb_div5
            // 
            this.mtb_div5.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div5.Location = new System.Drawing.Point(248, 515);
            this.mtb_div5.Mask = "9";
            this.mtb_div5.Name = "mtb_div5";
            this.mtb_div5.Size = new System.Drawing.Size(54, 98);
            this.mtb_div5.TabIndex = 155;
            this.mtb_div5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div5.ValidatingType = typeof(int);
            // 
            // mtb_div6
            // 
            this.mtb_div6.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div6.Location = new System.Drawing.Point(328, 517);
            this.mtb_div6.Mask = "9";
            this.mtb_div6.Name = "mtb_div6";
            this.mtb_div6.Size = new System.Drawing.Size(54, 98);
            this.mtb_div6.TabIndex = 154;
            this.mtb_div6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div6.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 51);
            this.label2.TabIndex = 161;
            this.label2.Text = "-";
            // 
            // mtb_div3
            // 
            this.mtb_div3.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div3.Location = new System.Drawing.Point(248, 401);
            this.mtb_div3.Mask = "9";
            this.mtb_div3.Name = "mtb_div3";
            this.mtb_div3.Size = new System.Drawing.Size(54, 98);
            this.mtb_div3.TabIndex = 151;
            this.mtb_div3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div3.ValidatingType = typeof(int);
            // 
            // mtb_div4
            // 
            this.mtb_div4.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div4.Location = new System.Drawing.Point(328, 403);
            this.mtb_div4.Mask = "9";
            this.mtb_div4.Name = "mtb_div4";
            this.mtb_div4.Size = new System.Drawing.Size(54, 98);
            this.mtb_div4.TabIndex = 152;
            this.mtb_div4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div4.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 51);
            this.label1.TabIndex = 159;
            this.label1.Text = "-";
            // 
            // mtb_div1
            // 
            this.mtb_div1.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div1.Location = new System.Drawing.Point(170, 241);
            this.mtb_div1.Mask = "9";
            this.mtb_div1.Name = "mtb_div1";
            this.mtb_div1.Size = new System.Drawing.Size(54, 98);
            this.mtb_div1.TabIndex = 150;
            this.mtb_div1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div1.ValidatingType = typeof(int);
            // 
            // mtb_div2
            // 
            this.mtb_div2.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_div2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_div2.Location = new System.Drawing.Point(243, 241);
            this.mtb_div2.Mask = "9";
            this.mtb_div2.Name = "mtb_div2";
            this.mtb_div2.Size = new System.Drawing.Size(54, 98);
            this.mtb_div2.TabIndex = 149;
            this.mtb_div2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_div2.ValidatingType = typeof(int);
            // 
            // mtb_res2
            // 
            this.mtb_res2.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_res2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_res2.Location = new System.Drawing.Point(600, 241);
            this.mtb_res2.Mask = "9";
            this.mtb_res2.Name = "mtb_res2";
            this.mtb_res2.Size = new System.Drawing.Size(54, 98);
            this.mtb_res2.TabIndex = 153;
            this.mtb_res2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_res2.ValidatingType = typeof(int);
            // 
            // mtb_res1
            // 
            this.mtb_res1.BackColor = System.Drawing.Color.AliceBlue;
            this.mtb_res1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_res1.Location = new System.Drawing.Point(529, 241);
            this.mtb_res1.Mask = "9";
            this.mtb_res1.Name = "mtb_res1";
            this.mtb_res1.Size = new System.Drawing.Size(54, 98);
            this.mtb_res1.TabIndex = 148;
            this.mtb_res1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_res1.ValidatingType = typeof(int);
            // 
            // TerminarDivision
            // 
            this.TerminarDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminarDivision.Location = new System.Drawing.Point(592, 737);
            this.TerminarDivision.Name = "TerminarDivision";
            this.TerminarDivision.Size = new System.Drawing.Size(113, 37);
            this.TerminarDivision.TabIndex = 157;
            this.TerminarDivision.Text = "Termine";
            this.TerminarDivision.UseVisualStyleBackColor = true;
            this.TerminarDivision.Click += new System.EventHandler(this.TerminarDivision_Click);
            // 
            // imagenlinea2
            // 
            this.imagenlinea2.Image = global::MateKids.Properties.Resources.linea;
            this.imagenlinea2.Location = new System.Drawing.Point(204, 619);
            this.imagenlinea2.Name = "imagenlinea2";
            this.imagenlinea2.Size = new System.Drawing.Size(198, 42);
            this.imagenlinea2.TabIndex = 162;
            this.imagenlinea2.TabStop = false;
            // 
            // imagenlinea1
            // 
            this.imagenlinea1.Image = global::MateKids.Properties.Resources.linea;
            this.imagenlinea1.Location = new System.Drawing.Point(125, 345);
            this.imagenlinea1.Name = "imagenlinea1";
            this.imagenlinea1.Size = new System.Drawing.Size(188, 50);
            this.imagenlinea1.TabIndex = 160;
            this.imagenlinea1.TabStop = false;
            // 
            // imagendivision
            // 
            this.imagendivision.Image = global::MateKids.Properties.Resources.d2;
            this.imagendivision.Location = new System.Drawing.Point(114, 12);
            this.imagendivision.Name = "imagendivision";
            this.imagendivision.Size = new System.Drawing.Size(542, 210);
            this.imagendivision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagendivision.TabIndex = 158;
            this.imagendivision.TabStop = false;
            // 
            // Form_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 786);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblintentos);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.marcador);
            this.Controls.Add(this.SiguienteDivision);
            this.Controls.Add(this.mtb_div7);
            this.Controls.Add(this.imagenlinea2);
            this.Controls.Add(this.mtb_div5);
            this.Controls.Add(this.mtb_div6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_div3);
            this.Controls.Add(this.mtb_div4);
            this.Controls.Add(this.imagenlinea1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_div1);
            this.Controls.Add(this.mtb_div2);
            this.Controls.Add(this.mtb_res2);
            this.Controls.Add(this.mtb_res1);
            this.Controls.Add(this.TerminarDivision);
            this.Controls.Add(this.imagendivision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenlinea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenlinea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagendivision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblintentos;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Label marcador;
        private System.Windows.Forms.Button SiguienteDivision;
        private System.Windows.Forms.MaskedTextBox mtb_div7;
        private System.Windows.Forms.PictureBox imagenlinea2;
        private System.Windows.Forms.MaskedTextBox mtb_div5;
        private System.Windows.Forms.MaskedTextBox mtb_div6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_div3;
        private System.Windows.Forms.MaskedTextBox mtb_div4;
        private System.Windows.Forms.PictureBox imagenlinea1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_div1;
        private System.Windows.Forms.MaskedTextBox mtb_div2;
        private System.Windows.Forms.MaskedTextBox mtb_res2;
        private System.Windows.Forms.MaskedTextBox mtb_res1;
        private System.Windows.Forms.Button TerminarDivision;
        private System.Windows.Forms.PictureBox imagendivision;
    }
}