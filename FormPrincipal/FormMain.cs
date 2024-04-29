using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.FormMarcas;

namespace TP2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void añadirArtículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FrmCargarArticulo ventanaCargaArticulo = new FrmCargarArticulo();
            ventanaCargaArticulo.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            FrmCargarArticulo ventanaCargaArticulo = new FrmCargarArticulo();
            ventanaCargaArticulo.ShowDialog();
        }

        private void nombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmBuscarMarca ventanaBuscarMarca = new FrmBuscarMarca();
            ventanaBuscarMarca.ShowDialog();

        }

        private void buscarPorNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca ventanaAgregarMarca = new FrmAgregarMarca();
            ventanaAgregarMarca.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmModificarMarca ventanaModificarMarca = new FrmModificarMarca();
            ventanaModificarMarca.ShowDialog();
        
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEliminarMarca ventanaEliminarMarca = new FrmEliminarMarca(); 
            ventanaEliminarMarca.ShowDialog();
        }

        private void buscarPorNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCargarCategoria ventanaCargarCategoria = new FrmCargarCategoria();
            ventanaCargarCategoria.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias ventanaCategorias = new FrmCategorias();
            ventanaCategorias.ShowDialog(); 
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ListadoArticulos ventanaListadoArticulos = new ListadoArticulos();  
            ventanaListadoArticulos.ShowDialog();

        }

        private void buscarPorNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog();
        }

        private void añadirCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog();
        }

        private void toolStripButtonEliminarArticulo_Click(object sender, EventArgs e)
        {
            ListadoArticulos ventanaListadoArticulos = new ListadoArticulos();
            ventanaListadoArticulos.ShowDialog();

        }

        private void toolStripButtonEditarArticulo_Click(object sender, EventArgs e)
        {
            ListadoArticulos ventanaListadoArticulos = new ListadoArticulos();
            ventanaListadoArticulos.ShowDialog();

        }

        private void toolStripButtonMarcas_Click(object sender, EventArgs e)
        {
            FrmBuscarMarca ventanaBuscarMarca = new FrmBuscarMarca();
            ventanaBuscarMarca.ShowDialog();
        }

        private void toolStripButtonCategorias_Click(object sender, EventArgs e)
        {
           FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog(); 
        }

        private void toolStripButtonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
