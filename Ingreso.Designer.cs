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
            this.labelUsuario.Location = new System.Drawing.Point(30, 194);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelConstrasenia
            // 
            this.labelConstrasenia.AutoSize = true;
            this.labelConstrasenia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelConstrasenia.Location = new System.Drawing.Point(16, 219);
            this.labelConstrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConstrasenia.Name = "labelConstrasenia";
            this.labelConstrasenia.Size = new System.Drawing.Size(61, 13);
            this.labelConstrasenia.TabIndex = 1;
            this.labelConstrasenia.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(88, 194);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(141, 20);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(88, 217);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(141, 20);
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
            this.botonIngresoOK.Location = new System.Drawing.Point(62, 270);
            this.botonIngresoOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonIngresoOK.Name = "botonIngresoOK";
            this.botonIngresoOK.Size = new System.Drawing.Size(56, 25);
            this.botonIngresoOK.TabIndex = 4;
            this.botonIngresoOK.Text = "Ingresar";
            this.botonIngresoOK.UseVisualStyleBackColor = false;
            this.botonIngresoOK.Click += new System.EventHandler(this.botonIngresoOK_Click);
            // 
            // botonIngresoCANCELAR
            // 
            this.botonIngresoCANCELAR.Location = new System.Drawing.Point(134, 270);
            this.botonIngresoCANCELAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonIngresoCANCELAR.Name = "botonIngresoCANCELAR";
            this.botonIngresoCANCELAR.Size = new System.Drawing.Size(56, 25);
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
            this.labelRegistro.Location = new System.Drawing.Point(92, 246);
            this.labelRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(71, 13);
            this.labelRegistro.TabIndex = 6;
            this.labelRegistro.Text = "Registrarse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP2.Properties.Resources.ktalogLogoGrande;
            this.pictureBox1.Location = new System.Drawing.Point(1, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 169);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(274, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.botonIngresoCANCELAR);
            this.Controls.Add(this.botonIngresoOK);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelConstrasenia);
            this.Controls.Add(this.labelUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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