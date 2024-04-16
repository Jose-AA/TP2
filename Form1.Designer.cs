namespace TP2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirArtículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNúmeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::TP2.Properties.Resources.Nuevo_artículo;
            this.button1.Location = new System.Drawing.Point(91, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 112);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.BackgroundImage = global::TP2.Properties.Resources.Nuevo;
            this.button5.Location = new System.Drawing.Point(170, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 89);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículoToolStripMenuItem
            // 
            this.artículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirArtículoToolStripMenuItem,
            this.modificarArtículoToolStripMenuItem,
            this.añadirArtículoToolStripMenuItem1,
            this.modificarArtículoToolStripMenuItem1,
            this.eliminarArtículoToolStripMenuItem});
            this.artículoToolStripMenuItem.Name = "artículoToolStripMenuItem";
            this.artículoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.artículoToolStripMenuItem.Text = "Artículo";
            // 
            // añadirArtículoToolStripMenuItem
            // 
            this.añadirArtículoToolStripMenuItem.Name = "añadirArtículoToolStripMenuItem";
            this.añadirArtículoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.añadirArtículoToolStripMenuItem.Text = "Buscar por nombre";
            // 
            // modificarArtículoToolStripMenuItem
            // 
            this.modificarArtículoToolStripMenuItem.Name = "modificarArtículoToolStripMenuItem";
            this.modificarArtículoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.modificarArtículoToolStripMenuItem.Text = "Buscar por nombre";
            this.modificarArtículoToolStripMenuItem.Click += new System.EventHandler(this.modificarArtículoToolStripMenuItem_Click);
            // 
            // añadirArtículoToolStripMenuItem1
            // 
            this.añadirArtículoToolStripMenuItem1.Name = "añadirArtículoToolStripMenuItem1";
            this.añadirArtículoToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.añadirArtículoToolStripMenuItem1.Text = "Añadir artículo";
            // 
            // modificarArtículoToolStripMenuItem1
            // 
            this.modificarArtículoToolStripMenuItem1.Name = "modificarArtículoToolStripMenuItem1";
            this.modificarArtículoToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.modificarArtículoToolStripMenuItem1.Text = "Modificar artículo";
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.eliminarArtículoToolStripMenuItem.Text = "Eliminar artículo";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem,
            this.buscarPorNumeroToolStripMenuItem});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // nombresToolStripMenuItem
            // 
            this.nombresToolStripMenuItem.Name = "nombresToolStripMenuItem";
            this.nombresToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.nombresToolStripMenuItem.Text = "Listado";
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.buscarPorNombreToolStripMenuItem.Text = "Buscar por nombre";
            // 
            // buscarPorNumeroToolStripMenuItem
            // 
            this.buscarPorNumeroToolStripMenuItem.Name = "buscarPorNumeroToolStripMenuItem";
            this.buscarPorNumeroToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.buscarPorNumeroToolStripMenuItem.Text = "Buscar por numero";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem1,
            this.buscarPorNúmeroToolStripMenuItem,
            this.añadirCategoríaToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // buscarPorNombreToolStripMenuItem1
            // 
            this.buscarPorNombreToolStripMenuItem1.Name = "buscarPorNombreToolStripMenuItem1";
            this.buscarPorNombreToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.buscarPorNombreToolStripMenuItem1.Text = "Buscar por nombre";
            // 
            // buscarPorNúmeroToolStripMenuItem
            // 
            this.buscarPorNúmeroToolStripMenuItem.Name = "buscarPorNúmeroToolStripMenuItem";
            this.buscarPorNúmeroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buscarPorNúmeroToolStripMenuItem.Text = "Buscar por número";
            // 
            // añadirCategoríaToolStripMenuItem
            // 
            this.añadirCategoríaToolStripMenuItem.Name = "añadirCategoríaToolStripMenuItem";
            this.añadirCategoríaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.añadirCategoríaToolStripMenuItem.Text = "Añadir Categoría";
            this.añadirCategoríaToolStripMenuItem.Click += new System.EventHandler(this.añadirCategoríaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirArtículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNumeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNúmeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCategoríaToolStripMenuItem;
    }
}

