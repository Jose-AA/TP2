namespace TP2
{
    partial class ImagenesDeslizables
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
            this.labelNombreArticulo = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonDeslizaDerecha = new System.Windows.Forms.Button();
            this.buttonDeslizaIzquierda = new System.Windows.Forms.Button();
            this.pictureBoxImagenArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreArticulo
            // 
            this.labelNombreArticulo.AutoSize = true;
            this.labelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreArticulo.Location = new System.Drawing.Point(2, 32);
            this.labelNombreArticulo.Name = "labelNombreArticulo";
            this.labelNombreArticulo.Size = new System.Drawing.Size(382, 31);
            this.labelNombreArticulo.TabIndex = 3;
            this.labelNombreArticulo.Text = "*NOMBRE DEL ARTICULO*";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAceptar.BackgroundImage = global::TP2.Properties.Resources.cheque;
            this.buttonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(153, 433);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 65);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            // 
            // buttonDeslizaDerecha
            // 
            this.buttonDeslizaDerecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeslizaDerecha.BackgroundImage = global::TP2.Properties.Resources.flecha_derecha;
            this.buttonDeslizaDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeslizaDerecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDeslizaDerecha.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDeslizaDerecha.FlatAppearance.BorderSize = 0;
            this.buttonDeslizaDerecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDeslizaDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDeslizaDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeslizaDerecha.Location = new System.Drawing.Point(276, 382);
            this.buttonDeslizaDerecha.Name = "buttonDeslizaDerecha";
            this.buttonDeslizaDerecha.Size = new System.Drawing.Size(75, 65);
            this.buttonDeslizaDerecha.TabIndex = 2;
            this.buttonDeslizaDerecha.UseVisualStyleBackColor = false;
            // 
            // buttonDeslizaIzquierda
            // 
            this.buttonDeslizaIzquierda.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeslizaIzquierda.BackgroundImage = global::TP2.Properties.Resources.flecha_izquierda;
            this.buttonDeslizaIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeslizaIzquierda.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDeslizaIzquierda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDeslizaIzquierda.FlatAppearance.BorderSize = 0;
            this.buttonDeslizaIzquierda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDeslizaIzquierda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeslizaIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeslizaIzquierda.Location = new System.Drawing.Point(34, 382);
            this.buttonDeslizaIzquierda.Name = "buttonDeslizaIzquierda";
            this.buttonDeslizaIzquierda.Size = new System.Drawing.Size(75, 65);
            this.buttonDeslizaIzquierda.TabIndex = 1;
            this.buttonDeslizaIzquierda.UseVisualStyleBackColor = false;
            // 
            // pictureBoxImagenArticulo
            // 
            this.pictureBoxImagenArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImagenArticulo.Location = new System.Drawing.Point(34, 75);
            this.pictureBoxImagenArticulo.Name = "pictureBoxImagenArticulo";
            this.pictureBoxImagenArticulo.Size = new System.Drawing.Size(317, 287);
            this.pictureBoxImagenArticulo.TabIndex = 0;
            this.pictureBoxImagenArticulo.TabStop = false;
            // 
            // ImagenesDeslizables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(383, 510);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelNombreArticulo);
            this.Controls.Add(this.buttonDeslizaDerecha);
            this.Controls.Add(this.buttonDeslizaIzquierda);
            this.Controls.Add(this.pictureBoxImagenArticulo);
            this.Name = "ImagenesDeslizables";
            this.Text = "ImagenesDeslizables";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagenArticulo;
        private System.Windows.Forms.Button buttonDeslizaIzquierda;
        private System.Windows.Forms.Button buttonDeslizaDerecha;
        private System.Windows.Forms.Label labelNombreArticulo;
        private System.Windows.Forms.Button buttonAceptar;
    }
}