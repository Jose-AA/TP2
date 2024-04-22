using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private List<Categoria> listaCategorias;

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCargarCategoria nuevaCategoria = new FrmCargarCategoria();
            nuevaCategoria.ShowDialog();
            cargar();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = null;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            if(seleccionado == null)
            {
                MessageBox.Show("Por favor seleccione primero una categoria");
                return;
            }

            FrmModificarCategoria modificar = new FrmModificarCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
