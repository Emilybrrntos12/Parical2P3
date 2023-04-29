namespace Parical2P3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListaCanciones = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.PictureBox();
            this.Eliminar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Reproducir = new System.Windows.Forms.PictureBox();
            this.Pausa = new System.Windows.Forms.PictureBox();
            this.Siguiente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaCanciones
            // 
            this.ListaCanciones.FormattingEnabled = true;
            this.ListaCanciones.Location = new System.Drawing.Point(53, 175);
            this.ListaCanciones.Name = "ListaCanciones";
            this.ListaCanciones.Size = new System.Drawing.Size(227, 199);
            this.ListaCanciones.TabIndex = 1;
            this.ListaCanciones.SelectedIndexChanged += new System.EventHandler(this.ListaCanciones_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.Image = global::Parical2P3.Properties.Resources.agregar2;
            this.Agregar.Location = new System.Drawing.Point(53, 21);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(69, 81);
            this.Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agregar.TabIndex = 2;
            this.Agregar.TabStop = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = global::Parical2P3.Properties.Resources.elim;
            this.Eliminar.Location = new System.Drawing.Point(53, 119);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(43, 50);
            this.Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eliminar.TabIndex = 3;
            this.Eliminar.TabStop = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Parical2P3.Properties.Resources.detener;
            this.pictureBox3.Location = new System.Drawing.Point(235, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Reproducir
            // 
            this.Reproducir.Image = global::Parical2P3.Properties.Resources.repro;
            this.Reproducir.Location = new System.Drawing.Point(93, 380);
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Size = new System.Drawing.Size(57, 50);
            this.Reproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Reproducir.TabIndex = 5;
            this.Reproducir.TabStop = false;
            this.Reproducir.Click += new System.EventHandler(this.Reproducir_Click);
            // 
            // Pausa
            // 
            this.Pausa.Image = global::Parical2P3.Properties.Resources.pausa;
            this.Pausa.Location = new System.Drawing.Point(187, 380);
            this.Pausa.Name = "Pausa";
            this.Pausa.Size = new System.Drawing.Size(54, 50);
            this.Pausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pausa.TabIndex = 6;
            this.Pausa.TabStop = false;
            this.Pausa.Click += new System.EventHandler(this.Pausa_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Image = global::Parical2P3.Properties.Resources.siguiente;
            this.Siguiente.Location = new System.Drawing.Point(139, 119);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(54, 50);
            this.Siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Siguiente.TabIndex = 7;
            this.Siguiente.TabStop = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preciona la imagen para \r\nAgregar tus Canciones";
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(539, 60);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(249, 57);
            this.WMP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Pausa);
            this.Controls.Add(this.Reproducir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.ListaCanciones);
            this.Controls.Add(this.WMP);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.ListBox ListaCanciones;
        private System.Windows.Forms.PictureBox Agregar;
        private System.Windows.Forms.PictureBox Eliminar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Reproducir;
        private System.Windows.Forms.PictureBox Pausa;
        private System.Windows.Forms.PictureBox Siguiente;
        private System.Windows.Forms.Label label1;
    }
}

