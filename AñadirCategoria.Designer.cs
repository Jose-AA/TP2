namespace TP2
{
    partial class AñadirCategoria
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
            this.labelNombreCategoria = new System.Windows.Forms.Label();
            this.labelNumeroCategoria = new System.Windows.Forms.Label();
            this.labelDescripcionCategoria = new System.Windows.Forms.Label();
            this.textBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.textBoxNumeroCategoria = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.buttonAñadirCategoria = new System.Windows.Forms.Button();
            this.buttonVolverCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombreCategoria
            // 
            this.labelNombreCategoria.AutoSize = true;
            this.labelNombreCategoria.Location = new System.Drawing.Point(47, 99);
            this.labelNombreCategoria.Name = "labelNombreCategoria";
            this.labelNombreCategoria.Size = new System.Drawing.Size(56, 16);
            this.labelNombreCategoria.TabIndex = 0;
            this.labelNombreCategoria.Text = "Nombre";
            // 
            // labelNumeroCategoria
            // 
            this.labelNumeroCategoria.AutoSize = true;
            this.labelNumeroCategoria.Location = new System.Drawing.Point(48, 133);
            this.labelNumeroCategoria.Name = "labelNumeroCategoria";
            this.labelNumeroCategoria.Size = new System.Drawing.Size(55, 16);
            this.labelNumeroCategoria.TabIndex = 1;
            this.labelNumeroCategoria.Text = "Número";
            // 
            // labelDescripcionCategoria
            // 
            this.labelDescripcionCategoria.AutoSize = true;
            this.labelDescripcionCategoria.Location = new System.Drawing.Point(24, 162);
            this.labelDescripcionCategoria.Name = "labelDescripcionCategoria";
            this.labelDescripcionCategoria.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcionCategoria.TabIndex = 2;
            this.labelDescripcionCategoria.Text = "Descripción";
            // 
            // textBoxNombreCategoria
            // 
            this.textBoxNombreCategoria.Location = new System.Drawing.Point(124, 93);
            this.textBoxNombreCategoria.Name = "textBoxNombreCategoria";
            this.textBoxNombreCategoria.Size = new System.Drawing.Size(223, 22);
            this.textBoxNombreCategoria.TabIndex = 3;
            // 
            // textBoxNumeroCategoria
            // 
            this.textBoxNumeroCategoria.Location = new System.Drawing.Point(124, 127);
            this.textBoxNumeroCategoria.Name = "textBoxNumeroCategoria";
            this.textBoxNumeroCategoria.Size = new System.Drawing.Size(223, 22);
            this.textBoxNumeroCategoria.TabIndex = 4;
            // 
            // textBoxDescripcionCategoria
            // 
            this.textBoxDescripcionCategoria.Location = new System.Drawing.Point(124, 162);
            this.textBoxDescripcionCategoria.Name = "textBoxDescripcionCategoria";
            this.textBoxDescripcionCategoria.Size = new System.Drawing.Size(223, 22);
            this.textBoxDescripcionCategoria.TabIndex = 5;
            // 
            // buttonAñadirCategoria
            // 
            this.buttonAñadirCategoria.Location = new System.Drawing.Point(27, 211);
            this.buttonAñadirCategoria.Name = "buttonAñadirCategoria";
            this.buttonAñadirCategoria.Size = new System.Drawing.Size(127, 30);
            this.buttonAñadirCategoria.TabIndex = 6;
            this.buttonAñadirCategoria.Text = "Añadir";
            this.buttonAñadirCategoria.UseVisualStyleBackColor = true;
            this.buttonAñadirCategoria.Click += new System.EventHandler(this.buttonAñadirCategoria_Click);
            // 
            // buttonVolverCategoria
            // 
            this.buttonVolverCategoria.Location = new System.Drawing.Point(233, 211);
            this.buttonVolverCategoria.Name = "buttonVolverCategoria";
            this.buttonVolverCategoria.Size = new System.Drawing.Size(127, 30);
            this.buttonVolverCategoria.TabIndex = 7;
            this.buttonVolverCategoria.Text = "Volver";
            this.buttonVolverCategoria.UseVisualStyleBackColor = true;
            this.buttonVolverCategoria.Click += new System.EventHandler(this.buttonVolverCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva categoría";
            // 
            // AñadirCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolverCategoria);
            this.Controls.Add(this.buttonAñadirCategoria);
            this.Controls.Add(this.textBoxDescripcionCategoria);
            this.Controls.Add(this.textBoxNumeroCategoria);
            this.Controls.Add(this.textBoxNombreCategoria);
            this.Controls.Add(this.labelDescripcionCategoria);
            this.Controls.Add(this.labelNumeroCategoria);
            this.Controls.Add(this.labelNombreCategoria);
            this.Name = "AñadirCategoria";
            this.Text = "AñadirCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreCategoria;
        private System.Windows.Forms.Label labelNumeroCategoria;
        private System.Windows.Forms.Label labelDescripcionCategoria;
        private System.Windows.Forms.TextBox textBoxNombreCategoria;
        private System.Windows.Forms.TextBox textBoxNumeroCategoria;
        private System.Windows.Forms.TextBox textBoxDescripcionCategoria;
        private System.Windows.Forms.Button buttonAñadirCategoria;
        private System.Windows.Forms.Button buttonVolverCategoria;
        private System.Windows.Forms.Label label1;
    }
}