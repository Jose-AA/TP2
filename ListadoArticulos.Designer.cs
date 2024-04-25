namespace TP2
{
    partial class ListadoArticulos
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
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.labelTituloCatalogo = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminarFisicoArticulo = new System.Windows.Forms.Button();
            this.buttonEditarArticulo = new System.Windows.Forms.Button();
            this.buttonAgregarArticulo = new System.Windows.Forms.Button();
            this.buttonImagenDerecha = new System.Windows.Forms.Button();
            this.buttonImagenIzquierda = new System.Windows.Forms.Button();
            this.pictureBoxImagenesArticulos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenesArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(35, 154);
            this.dgvListadoArticulos.MultiSelect = false;
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.ReadOnly = true;
            this.dgvListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoArticulos.Size = new System.Drawing.Size(742, 363);
            this.dgvListadoArticulos.TabIndex = 0;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // labelTituloCatalogo
            // 
            this.labelTituloCatalogo.AutoSize = true;
            this.labelTituloCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCatalogo.ForeColor = System.Drawing.Color.Navy;
            this.labelTituloCatalogo.Location = new System.Drawing.Point(478, 31);
            this.labelTituloCatalogo.Name = "labelTituloCatalogo";
            this.labelTituloCatalogo.Size = new System.Drawing.Size(363, 39);
            this.labelTituloCatalogo.TabIndex = 7;
            this.labelTituloCatalogo.Text = "Catálogo de artículos";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.Location = new System.Drawing.Point(79, 117);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(56, 20);
            this.labelFiltro.TabIndex = 8;
            this.labelFiltro.Text = "Filtrar";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltro.Location = new System.Drawing.Point(152, 108);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(164, 40);
            this.textBoxFiltro.TabIndex = 10;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            this.textBoxFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltro_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::TP2.Properties.Resources.agregar_contacto;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBuscar.Location = new System.Drawing.Point(322, 108);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(81, 40);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonEliminarFisicoArticulo
            // 
            this.buttonEliminarFisicoArticulo.BackgroundImage = global::TP2.Properties.Resources.agregar_contacto;
            this.buttonEliminarFisicoArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEliminarFisicoArticulo.Location = new System.Drawing.Point(409, 108);
            this.buttonEliminarFisicoArticulo.Name = "buttonEliminarFisicoArticulo";
            this.buttonEliminarFisicoArticulo.Size = new System.Drawing.Size(81, 40);
            this.buttonEliminarFisicoArticulo.TabIndex = 6;
            this.buttonEliminarFisicoArticulo.Text = "   Eliminar";
            this.buttonEliminarFisicoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarFisicoArticulo.UseVisualStyleBackColor = true;
            this.buttonEliminarFisicoArticulo.Click += new System.EventHandler(this.buttonEliminarFisicoArticulo_Click);
            // 
            // buttonEditarArticulo
            // 
            this.buttonEditarArticulo.BackgroundImage = global::TP2.Properties.Resources.editar__1_;
            this.buttonEditarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEditarArticulo.Location = new System.Drawing.Point(496, 108);
            this.buttonEditarArticulo.Name = "buttonEditarArticulo";
            this.buttonEditarArticulo.Size = new System.Drawing.Size(81, 40);
            this.buttonEditarArticulo.TabIndex = 5;
            this.buttonEditarArticulo.Text = "Editar";
            this.buttonEditarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditarArticulo.UseVisualStyleBackColor = true;
            this.buttonEditarArticulo.Click += new System.EventHandler(this.buttonEditarArticulo_Click);
            // 
            // buttonAgregarArticulo
            // 
            this.buttonAgregarArticulo.BackgroundImage = global::TP2.Properties.Resources.agregar_producto;
            this.buttonAgregarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAgregarArticulo.Location = new System.Drawing.Point(584, 108);
            this.buttonAgregarArticulo.Name = "buttonAgregarArticulo";
            this.buttonAgregarArticulo.Size = new System.Drawing.Size(118, 40);
            this.buttonAgregarArticulo.TabIndex = 4;
            this.buttonAgregarArticulo.Text = "     Nuevo artículo";
            this.buttonAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregarArticulo.UseVisualStyleBackColor = true;
            this.buttonAgregarArticulo.Click += new System.EventHandler(this.buttonAgregarArticulo_Click);
            // 
            // buttonImagenDerecha
            // 
            this.buttonImagenDerecha.BackgroundImage = global::TP2.Properties.Resources.agregar_contacto;
            this.buttonImagenDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonImagenDerecha.Location = new System.Drawing.Point(1154, 241);
            this.buttonImagenDerecha.Name = "buttonImagenDerecha";
            this.buttonImagenDerecha.Size = new System.Drawing.Size(39, 35);
            this.buttonImagenDerecha.TabIndex = 3;
            this.buttonImagenDerecha.UseVisualStyleBackColor = true;
            // 
            // buttonImagenIzquierda
            // 
            this.buttonImagenIzquierda.BackgroundImage = global::TP2.Properties.Resources.agregar_usuario;
            this.buttonImagenIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonImagenIzquierda.Location = new System.Drawing.Point(783, 241);
            this.buttonImagenIzquierda.Name = "buttonImagenIzquierda";
            this.buttonImagenIzquierda.Size = new System.Drawing.Size(39, 35);
            this.buttonImagenIzquierda.TabIndex = 2;
            this.buttonImagenIzquierda.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImagenesArticulos
            // 
            this.pictureBoxImagenesArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxImagenesArticulos.Location = new System.Drawing.Point(828, 136);
            this.pictureBoxImagenesArticulos.Name = "pictureBoxImagenesArticulos";
            this.pictureBoxImagenesArticulos.Size = new System.Drawing.Size(320, 243);
            this.pictureBoxImagenesArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenesArticulos.TabIndex = 1;
            this.pictureBoxImagenesArticulos.TabStop = false;
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1209, 601);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelTituloCatalogo);
            this.Controls.Add(this.buttonEliminarFisicoArticulo);
            this.Controls.Add(this.buttonEditarArticulo);
            this.Controls.Add(this.buttonAgregarArticulo);
            this.Controls.Add(this.buttonImagenDerecha);
            this.Controls.Add(this.buttonImagenIzquierda);
            this.Controls.Add(this.pictureBoxImagenesArticulos);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Name = "ListadoArticulos";
            this.Text = "ListadoArticulos";
            this.Load += new System.EventHandler(this.ListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenesArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.PictureBox pictureBoxImagenesArticulos;
        private System.Windows.Forms.Button buttonImagenIzquierda;
        private System.Windows.Forms.Button buttonImagenDerecha;
        private System.Windows.Forms.Button buttonAgregarArticulo;
        private System.Windows.Forms.Button buttonEditarArticulo;
        private System.Windows.Forms.Button buttonEliminarFisicoArticulo;
        private System.Windows.Forms.Label labelTituloCatalogo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxFiltro;
    }
}