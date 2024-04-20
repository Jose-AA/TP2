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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUsuarioConectado = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelUsuarios = new System.Windows.Forms.ToolStripLabel();
            this.AgregarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBuscarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelArticulos = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminarArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditarArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonListadoArticulos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMarcas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCategorias = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStripUsuarioConectado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículoToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1079, 40);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículoToolStripMenuItem
            // 
            this.artículoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.artículoToolStripMenuItem.CheckOnClick = true;
            this.artículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirArtículoToolStripMenuItem,
            this.modificarArtículoToolStripMenuItem,
            this.añadirArtículoToolStripMenuItem1,
            this.modificarArtículoToolStripMenuItem1,
            this.eliminarArtículoToolStripMenuItem});
            this.artículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artículoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.artículoToolStripMenuItem.Image = global::TP2.Properties.Resources.caja;
            this.artículoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artículoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.artículoToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark;
            this.artículoToolStripMenuItem.Name = "artículoToolStripMenuItem";
            this.artículoToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.artículoToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.artículoToolStripMenuItem.Text = "    &Artículo";
            this.artículoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.artículoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.artículoToolStripMenuItem.Click += new System.EventHandler(this.artículoToolStripMenuItem_Click);
            // 
            // añadirArtículoToolStripMenuItem
            // 
            this.añadirArtículoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.añadirArtículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirArtículoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.añadirArtículoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.añadirArtículoToolStripMenuItem.Name = "añadirArtículoToolStripMenuItem";
            this.añadirArtículoToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.añadirArtículoToolStripMenuItem.Text = "Buscar por nombre";
            // 
            // modificarArtículoToolStripMenuItem
            // 
            this.modificarArtículoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificarArtículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarArtículoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.modificarArtículoToolStripMenuItem.Name = "modificarArtículoToolStripMenuItem";
            this.modificarArtículoToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.modificarArtículoToolStripMenuItem.Text = "Buscar por nombre";
            this.modificarArtículoToolStripMenuItem.Click += new System.EventHandler(this.modificarArtículoToolStripMenuItem_Click);
            // 
            // añadirArtículoToolStripMenuItem1
            // 
            this.añadirArtículoToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.añadirArtículoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirArtículoToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.añadirArtículoToolStripMenuItem1.Name = "añadirArtículoToolStripMenuItem1";
            this.añadirArtículoToolStripMenuItem1.Size = new System.Drawing.Size(246, 30);
            this.añadirArtículoToolStripMenuItem1.Text = "Añadir artículo";
            this.añadirArtículoToolStripMenuItem1.Click += new System.EventHandler(this.añadirArtículoToolStripMenuItem1_Click);
            // 
            // modificarArtículoToolStripMenuItem1
            // 
            this.modificarArtículoToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modificarArtículoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarArtículoToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.modificarArtículoToolStripMenuItem1.Name = "modificarArtículoToolStripMenuItem1";
            this.modificarArtículoToolStripMenuItem1.Size = new System.Drawing.Size(246, 30);
            this.modificarArtículoToolStripMenuItem1.Text = "Modificar artículo";
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eliminarArtículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarArtículoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(246, 30);
            this.eliminarArtículoToolStripMenuItem.Text = "Eliminar artículo";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem,
            this.buscarPorNumeroToolStripMenuItem});
            this.marcasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.marcasToolStripMenuItem.Image = global::TP2.Properties.Resources.marca;
            this.marcasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.marcasToolStripMenuItem.Text = "&Marcas";
            // 
            // nombresToolStripMenuItem
            // 
            this.nombresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nombresToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.nombresToolStripMenuItem.Name = "nombresToolStripMenuItem";
            this.nombresToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.nombresToolStripMenuItem.Text = "Listado";
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buscarPorNombreToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.buscarPorNombreToolStripMenuItem.Text = "Buscar por nombre";
            // 
            // buscarPorNumeroToolStripMenuItem
            // 
            this.buscarPorNumeroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buscarPorNumeroToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.buscarPorNumeroToolStripMenuItem.Name = "buscarPorNumeroToolStripMenuItem";
            this.buscarPorNumeroToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.buscarPorNumeroToolStripMenuItem.Text = "Buscar por numero";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem1,
            this.buscarPorNúmeroToolStripMenuItem,
            this.añadirCategoríaToolStripMenuItem});
            this.categoríasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoríasToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.categoríasToolStripMenuItem.Image = global::TP2.Properties.Resources.menu;
            this.categoríasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.categoríasToolStripMenuItem.Text = "&Categorías";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listadoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // buscarPorNombreToolStripMenuItem1
            // 
            this.buscarPorNombreToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buscarPorNombreToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.buscarPorNombreToolStripMenuItem1.Name = "buscarPorNombreToolStripMenuItem1";
            this.buscarPorNombreToolStripMenuItem1.Size = new System.Drawing.Size(262, 34);
            this.buscarPorNombreToolStripMenuItem1.Text = "Buscar por nombre";
            // 
            // buscarPorNúmeroToolStripMenuItem
            // 
            this.buscarPorNúmeroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buscarPorNúmeroToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.buscarPorNúmeroToolStripMenuItem.Name = "buscarPorNúmeroToolStripMenuItem";
            this.buscarPorNúmeroToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.buscarPorNúmeroToolStripMenuItem.Text = "Buscar por número";
            // 
            // añadirCategoríaToolStripMenuItem
            // 
            this.añadirCategoríaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.añadirCategoríaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.añadirCategoríaToolStripMenuItem.Name = "añadirCategoríaToolStripMenuItem";
            this.añadirCategoríaToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.salirToolStripMenuItem.Image = global::TP2.Properties.Resources.cerrar_sesion;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 36);
            this.toolStripMenuItem1.Text = "               ";
            // 
            // toolStripUsuarioConectado
            // 
            this.toolStripUsuarioConectado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripUsuarioConectado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripUsuarioConectado.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripUsuarioConectado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelUsuarios,
            this.AgregarUsuario,
            this.toolStripButtonEliminarUsuario,
            this.toolStripButtonEditarUsuario,
            this.toolStripButtonBuscarUsuario,
            this.toolStripSeparator4,
            this.toolStripSeparator1,
            this.toolStripLabelArticulos,
            this.toolStripButton1,
            this.toolStripButtonEliminarArticulo,
            this.toolStripButtonEditarArticulo,
            this.toolStripButtonListadoArticulos,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripButtonMarcas,
            this.toolStripButtonCategorias,
            this.toolStripButtonLogOut,
            this.toolStripLabel1});
            this.toolStripUsuarioConectado.Location = new System.Drawing.Point(0, 514);
            this.toolStripUsuarioConectado.Name = "toolStripUsuarioConectado";
            this.toolStripUsuarioConectado.Size = new System.Drawing.Size(1079, 57);
            this.toolStripUsuarioConectado.TabIndex = 10;
            this.toolStripUsuarioConectado.Text = "toolStrip1";
            // 
            // toolStripLabelUsuarios
            // 
            this.toolStripLabelUsuarios.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelUsuarios.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripLabelUsuarios.Name = "toolStripLabelUsuarios";
            this.toolStripLabelUsuarios.Size = new System.Drawing.Size(104, 54);
            this.toolStripLabelUsuarios.Text = "Usuarios";
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AgregarUsuario.Image = global::TP2.Properties.Resources.agregar_contacto;
            this.AgregarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Size = new System.Drawing.Size(54, 54);
            this.AgregarUsuario.Text = "Nuevo Usuario";
            // 
            // toolStripButtonEliminarUsuario
            // 
            this.toolStripButtonEliminarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminarUsuario.Image = global::TP2.Properties.Resources.contacto__1_;
            this.toolStripButtonEliminarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarUsuario.Name = "toolStripButtonEliminarUsuario";
            this.toolStripButtonEliminarUsuario.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonEliminarUsuario.Text = "toolStripButton2";
            this.toolStripButtonEliminarUsuario.ToolTipText = "Eliminar usuario";
            // 
            // toolStripButtonEditarUsuario
            // 
            this.toolStripButtonEditarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditarUsuario.Image = global::TP2.Properties.Resources.editar_informacion;
            this.toolStripButtonEditarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditarUsuario.Name = "toolStripButtonEditarUsuario";
            this.toolStripButtonEditarUsuario.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonEditarUsuario.Text = "toolStripButton2";
            this.toolStripButtonEditarUsuario.ToolTipText = "Editar usuario";
            // 
            // toolStripButtonBuscarUsuario
            // 
            this.toolStripButtonBuscarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuscarUsuario.Image = global::TP2.Properties.Resources.lupa;
            this.toolStripButtonBuscarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuscarUsuario.Name = "toolStripButtonBuscarUsuario";
            this.toolStripButtonBuscarUsuario.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonBuscarUsuario.Text = "toolStripButton2";
            this.toolStripButtonBuscarUsuario.ToolTipText = "Buscar usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripLabelArticulos
            // 
            this.toolStripLabelArticulos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelArticulos.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripLabelArticulos.Name = "toolStripLabelArticulos";
            this.toolStripLabelArticulos.Size = new System.Drawing.Size(104, 54);
            this.toolStripLabelArticulos.Text = "Artículos";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TP2.Properties.Resources.paquete;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "Nuevo Ingreso";
            this.toolStripButton1.ToolTipText = "Nuevo artículo";
            // 
            // toolStripButtonEliminarArticulo
            // 
            this.toolStripButtonEliminarArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminarArticulo.Image = global::TP2.Properties.Resources.paquete__1_;
            this.toolStripButtonEliminarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminarArticulo.Name = "toolStripButtonEliminarArticulo";
            this.toolStripButtonEliminarArticulo.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonEliminarArticulo.Text = "toolStripButton2";
            this.toolStripButtonEliminarArticulo.ToolTipText = "Eliminar artículo";
            // 
            // toolStripButtonEditarArticulo
            // 
            this.toolStripButtonEditarArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditarArticulo.Image = global::TP2.Properties.Resources.paquete__4_;
            this.toolStripButtonEditarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditarArticulo.Name = "toolStripButtonEditarArticulo";
            this.toolStripButtonEditarArticulo.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonEditarArticulo.Text = "toolStripButton2";
            this.toolStripButtonEditarArticulo.ToolTipText = "Editar artículo";
            // 
            // toolStripButtonListadoArticulos
            // 
            this.toolStripButtonListadoArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonListadoArticulos.Image = global::TP2.Properties.Resources.almacenamiento;
            this.toolStripButtonListadoArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonListadoArticulos.Name = "toolStripButtonListadoArticulos";
            this.toolStripButtonListadoArticulos.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonListadoArticulos.Text = "toolStripButton2";
            this.toolStripButtonListadoArticulos.ToolTipText = "Listado de artículos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButtonMarcas
            // 
            this.toolStripButtonMarcas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMarcas.Image = global::TP2.Properties.Resources.imagen_de_marca;
            this.toolStripButtonMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMarcas.Name = "toolStripButtonMarcas";
            this.toolStripButtonMarcas.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonMarcas.Text = "Marcas";
            // 
            // toolStripButtonCategorias
            // 
            this.toolStripButtonCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCategorias.Image = global::TP2.Properties.Resources.categorias;
            this.toolStripButtonCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCategorias.Name = "toolStripButtonCategorias";
            this.toolStripButtonCategorias.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonCategorias.Text = "toolStripButton2";
            this.toolStripButtonCategorias.ToolTipText = "Categorías de artículos";
            // 
            // toolStripButtonLogOut
            // 
            this.toolStripButtonLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLogOut.Image = global::TP2.Properties.Resources.apagar;
            this.toolStripButtonLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogOut.Name = "toolStripButtonLogOut";
            this.toolStripButtonLogOut.Size = new System.Drawing.Size(54, 54);
            this.toolStripButtonLogOut.Text = "toolStripButton2";
            this.toolStripButtonLogOut.ToolTipText = "Logout";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 54);
            this.toolStripLabel1.Text = "USUARIO CONECTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::TP2.Properties.Resources.optimiza_tu_gestion_logistica_con_el_control_de_almacenes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 571);
            this.Controls.Add(this.toolStripUsuarioConectado);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripUsuarioConectado.ResumeLayout(false);
            this.toolStripUsuarioConectado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripUsuarioConectado;
        private System.Windows.Forms.ToolStripButton AgregarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditarUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscarUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminarArticulo;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditarArticulo;
        private System.Windows.Forms.ToolStripButton toolStripButtonListadoArticulos;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUsuarios;
        private System.Windows.Forms.ToolStripLabel toolStripLabelArticulos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonMarcas;
        private System.Windows.Forms.ToolStripButton toolStripButtonCategorias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogOut;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}

