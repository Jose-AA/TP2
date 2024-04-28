namespace TP2
{
    partial class FrmCargarArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.ddlMarca = new System.Windows.Forms.ComboBox();
            this.ddlCategoria = new System.Windows.Forms.ComboBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelNuevaMarca = new System.Windows.Forms.Label();
            this.labelCategoriaNueva = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.buttonAñadirCategoria = new System.Windows.Forms.Button();
            this.buttonAñadirMarca = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pbxImagenes = new System.Windows.Forms.PictureBox();
            this.buttonBorrarCampoUrl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(22, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigo.Location = new System.Drawing.Point(27, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Navy;
            this.lblMarca.Location = new System.Drawing.Point(33, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Navy;
            this.lblCategoria.Location = new System.Drawing.Point(292, 94);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Navy;
            this.lblDescripcion.Location = new System.Drawing.Point(279, 21);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(364, 17);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.ForeColor = System.Drawing.Color.Navy;
            this.btnAnterior.Location = new System.Drawing.Point(137, 478);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.ForeColor = System.Drawing.Color.Navy;
            this.btnSiguiente.Location = new System.Drawing.Point(340, 478);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // ddlMarca
            // 
            this.ddlMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMarca.FormattingEnabled = true;
            this.ddlMarca.Location = new System.Drawing.Point(88, 89);
            this.ddlMarca.Name = "ddlMarca";
            this.ddlMarca.Size = new System.Drawing.Size(121, 21);
            this.ddlMarca.TabIndex = 2;
            // 
            // ddlCategoria
            // 
            this.ddlCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategoria.FormattingEnabled = true;
            this.ddlCategoria.Location = new System.Drawing.Point(364, 89);
            this.ddlCategoria.Name = "ddlCategoria";
            this.ddlCategoria.Size = new System.Drawing.Size(121, 21);
            this.ddlCategoria.TabIndex = 3;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Navy;
            this.labelPrecio.Location = new System.Drawing.Point(312, 57);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 16);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(364, 53);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecio.TabIndex = 12;
            // 
            // labelNuevaMarca
            // 
            this.labelNuevaMarca.AutoSize = true;
            this.labelNuevaMarca.Location = new System.Drawing.Point(20, 126);
            this.labelNuevaMarca.Name = "labelNuevaMarca";
            this.labelNuevaMarca.Size = new System.Drawing.Size(229, 13);
            this.labelNuevaMarca.TabIndex = 13;
            this.labelNuevaMarca.Text = "(Si la marca no existe puede añadir una nueva)";
            // 
            // labelCategoriaNueva
            // 
            this.labelCategoriaNueva.AutoSize = true;
            this.labelCategoriaNueva.Location = new System.Drawing.Point(279, 126);
            this.labelCategoriaNueva.Name = "labelCategoriaNueva";
            this.labelCategoriaNueva.Size = new System.Drawing.Size(246, 13);
            this.labelCategoriaNueva.TabIndex = 15;
            this.labelCategoriaNueva.Text = "(Si la categoría no existe puede añadir una nueva)";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(120, 537);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(338, 20);
            this.textBoxURL.TabIndex = 17;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.ForeColor = System.Drawing.Color.Navy;
            this.labelURL.Location = new System.Drawing.Point(85, 540);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(29, 13);
            this.labelURL.TabIndex = 18;
            this.labelURL.Text = "URL";
            // 
            // buttonAñadirCategoria
            // 
            this.buttonAñadirCategoria.BackgroundImage = global::TP2.Properties.Resources.categorias;
            this.buttonAñadirCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAñadirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirCategoria.ForeColor = System.Drawing.Color.Navy;
            this.buttonAñadirCategoria.Location = new System.Drawing.Point(340, 142);
            this.buttonAñadirCategoria.Name = "buttonAñadirCategoria";
            this.buttonAñadirCategoria.Size = new System.Drawing.Size(145, 39);
            this.buttonAñadirCategoria.TabIndex = 16;
            this.buttonAñadirCategoria.Text = "Añadir Categoría";
            this.buttonAñadirCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAñadirCategoria.UseVisualStyleBackColor = true;
            this.buttonAñadirCategoria.Click += new System.EventHandler(this.buttonAñadirCategoria_Click);
            // 
            // buttonAñadirMarca
            // 
            this.buttonAñadirMarca.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAñadirMarca.BackgroundImage = global::TP2.Properties.Resources.imagen_de_marca;
            this.buttonAñadirMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAñadirMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirMarca.ForeColor = System.Drawing.Color.Navy;
            this.buttonAñadirMarca.Location = new System.Drawing.Point(67, 142);
            this.buttonAñadirMarca.Name = "buttonAñadirMarca";
            this.buttonAñadirMarca.Size = new System.Drawing.Size(145, 39);
            this.buttonAñadirMarca.TabIndex = 14;
            this.buttonAñadirMarca.Text = "         Añadir marca";
            this.buttonAñadirMarca.UseVisualStyleBackColor = false;
            this.buttonAñadirMarca.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = global::TP2.Properties.Resources.paquete__1_;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Navy;
            this.buttonCancelar.Location = new System.Drawing.Point(346, 621);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(109, 66);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Salir    ";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.BackgroundImage = global::TP2.Properties.Resources.paquete;
            this.btnCrearArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCrearArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArticulo.ForeColor = System.Drawing.Color.Navy;
            this.btnCrearArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearArticulo.Location = new System.Drawing.Point(88, 621);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(109, 66);
            this.btnCrearArticulo.TabIndex = 8;
            this.btnCrearArticulo.Text = "Añadir ";
            this.btnCrearArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearArticulo.UseVisualStyleBackColor = true;
            this.btnCrearArticulo.Click += new System.EventHandler(this.btnCrearArticulo_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarImagen.ForeColor = System.Drawing.Color.Navy;
            this.btnCargarImagen.Location = new System.Drawing.Point(240, 563);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(91, 39);
            this.btnCargarImagen.TabIndex = 7;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbxImagenes
            // 
            this.pbxImagenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxImagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagenes.Location = new System.Drawing.Point(137, 194);
            this.pbxImagenes.Name = "pbxImagenes";
            this.pbxImagenes.Size = new System.Drawing.Size(277, 278);
            this.pbxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenes.TabIndex = 9;
            this.pbxImagenes.TabStop = false;
            // 
            // buttonBorrarCampoUrl
            // 
            this.buttonBorrarCampoUrl.Location = new System.Drawing.Point(338, 564);
            this.buttonBorrarCampoUrl.Name = "buttonBorrarCampoUrl";
            this.buttonBorrarCampoUrl.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarCampoUrl.TabIndex = 19;
            this.buttonBorrarCampoUrl.Text = "Borrar campo";
            this.buttonBorrarCampoUrl.UseVisualStyleBackColor = true;
            this.buttonBorrarCampoUrl.Click += new System.EventHandler(this.buttonBorrarCampoUrl_Click);
            // 
            // FrmCargarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(550, 693);
            this.Controls.Add(this.buttonBorrarCampoUrl);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonAñadirCategoria);
            this.Controls.Add(this.labelCategoriaNueva);
            this.Controls.Add(this.buttonAñadirMarca);
            this.Controls.Add(this.labelNuevaMarca);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.ddlCategoria);
            this.Controls.Add(this.ddlMarca);
            this.Controls.Add(this.btnCrearArticulo);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbxImagenes);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmCargarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Articulos";
            this.Load += new System.EventHandler(this.FrmCargarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.PictureBox pbxImagenes;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.ComboBox ddlMarca;
        private System.Windows.Forms.ComboBox ddlCategoria;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelNuevaMarca;
        private System.Windows.Forms.Button buttonAñadirMarca;
        private System.Windows.Forms.Label labelCategoriaNueva;
        private System.Windows.Forms.Button buttonAñadirCategoria;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button buttonBorrarCampoUrl;
    }
}