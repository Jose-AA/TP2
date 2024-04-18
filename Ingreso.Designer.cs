namespace TP2
{
    partial class Ingreso
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelConstrasenia = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.botonIngresoOK = new System.Windows.Forms.Button();
            this.botonIngresoCANCELAR = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario.Location = new System.Drawing.Point(40, 239);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(54, 16);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelConstrasenia
            // 
            this.labelConstrasenia.AutoSize = true;
            this.labelConstrasenia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelConstrasenia.Location = new System.Drawing.Point(21, 270);
            this.labelConstrasenia.Name = "labelConstrasenia";
            this.labelConstrasenia.Size = new System.Drawing.Size(76, 16);
            this.labelConstrasenia.TabIndex = 1;
            this.labelConstrasenia.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(117, 239);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(187, 22);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(117, 267);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(187, 22);
            this.textBoxContraseña.TabIndex = 3;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // botonIngresoOK
            // 
            this.botonIngresoOK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonIngresoOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIngresoOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonIngresoOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonIngresoOK.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIngresoOK.Location = new System.Drawing.Point(82, 332);
            this.botonIngresoOK.Name = "botonIngresoOK";
            this.botonIngresoOK.Size = new System.Drawing.Size(75, 31);
            this.botonIngresoOK.TabIndex = 4;
            this.botonIngresoOK.Text = "Ingresar";
            this.botonIngresoOK.UseVisualStyleBackColor = false;
            this.botonIngresoOK.Click += new System.EventHandler(this.botonIngresoOK_Click);
            // 
            // botonIngresoCANCELAR
            // 
            this.botonIngresoCANCELAR.Location = new System.Drawing.Point(178, 332);
            this.botonIngresoCANCELAR.Name = "botonIngresoCANCELAR";
            this.botonIngresoCANCELAR.Size = new System.Drawing.Size(75, 31);
            this.botonIngresoCANCELAR.TabIndex = 5;
            this.botonIngresoCANCELAR.Text = "Salir";
            this.botonIngresoCANCELAR.UseVisualStyleBackColor = true;
            this.botonIngresoCANCELAR.Click += new System.EventHandler(this.botonIngresoCANCELAR_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.ForeColor = System.Drawing.Color.Yellow;
            this.labelRegistro.Location = new System.Drawing.Point(123, 303);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(88, 16);
            this.labelRegistro.TabIndex = 6;
            this.labelRegistro.Text = "Registrarse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP2.Properties.Resources.ktalogLogoGrande;
            this.pictureBox1.Location = new System.Drawing.Point(24, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 208);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(365, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.botonIngresoCANCELAR);
            this.Controls.Add(this.botonIngresoOK);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelConstrasenia);
            this.Controls.Add(this.labelUsuario);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelConstrasenia;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button botonIngresoOK;
        private System.Windows.Forms.Button botonIngresoCANCELAR;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}