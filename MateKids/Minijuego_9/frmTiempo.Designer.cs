namespace MateKids.Minijuego_9
{
    partial class frmTiempo
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
            this.gbxTiempo = new System.Windows.Forms.GroupBox();
            this.rdb1m30s = new System.Windows.Forms.RadioButton();
            this.rdb1m = new System.Windows.Forms.RadioButton();
            this.rdb30s = new System.Windows.Forms.RadioButton();
            this.btnJugar = new System.Windows.Forms.Button();
            this.gbxTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTiempo
            // 
            this.gbxTiempo.Controls.Add(this.rdb1m30s);
            this.gbxTiempo.Controls.Add(this.rdb1m);
            this.gbxTiempo.Controls.Add(this.rdb30s);
            this.gbxTiempo.Location = new System.Drawing.Point(52, 82);
            this.gbxTiempo.Name = "gbxTiempo";
            this.gbxTiempo.Size = new System.Drawing.Size(663, 54);
            this.gbxTiempo.TabIndex = 2;
            this.gbxTiempo.TabStop = false;
            // 
            // rdb1m30s
            // 
            this.rdb1m30s.AutoSize = true;
            this.rdb1m30s.Location = new System.Drawing.Point(572, 20);
            this.rdb1m30s.Name = "rdb1m30s";
            this.rdb1m30s.Size = new System.Drawing.Size(88, 17);
            this.rdb1m30s.TabIndex = 2;
            this.rdb1m30s.TabStop = true;
            this.rdb1m30s.Text = "1 minuto 30 s";
            this.rdb1m30s.UseVisualStyleBackColor = true;
            // 
            // rdb1m
            // 
            this.rdb1m.AutoSize = true;
            this.rdb1m.Location = new System.Drawing.Point(293, 20);
            this.rdb1m.Name = "rdb1m";
            this.rdb1m.Size = new System.Drawing.Size(65, 17);
            this.rdb1m.TabIndex = 1;
            this.rdb1m.TabStop = true;
            this.rdb1m.Text = "1 minuto";
            this.rdb1m.UseVisualStyleBackColor = true;
            // 
            // rdb30s
            // 
            this.rdb30s.AutoSize = true;
            this.rdb30s.Location = new System.Drawing.Point(31, 20);
            this.rdb30s.Name = "rdb30s";
            this.rdb30s.Size = new System.Drawing.Size(86, 17);
            this.rdb30s.TabIndex = 0;
            this.rdb30s.TabStop = true;
            this.rdb30s.Text = "30 segundos";
            this.rdb30s.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJugar.Location = new System.Drawing.Point(308, 165);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(134, 31);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // frmTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(756, 206);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.gbxTiempo);
            this.MaximizeBox = false;
            this.Name = "frmTiempo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "TIEMPO DE JUEGO";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.frmTiempo_Load);
            this.gbxTiempo.ResumeLayout(false);
            this.gbxTiempo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTiempo;
        private System.Windows.Forms.RadioButton rdb1m30s;
        private System.Windows.Forms.RadioButton rdb1m;
        private System.Windows.Forms.RadioButton rdb30s;
        private System.Windows.Forms.Button btnJugar;
    }
}