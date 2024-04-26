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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = null;
            CategoriaNegocio negocio = new CategoriaNegocio();
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("Por favor seleccione primero una categoria");
                return;
            }


            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar la selección '" + seleccionado.Descripcion + "''?", "Eliminar Categoría", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado);
                    MessageBox.Show("Se ha eliminado la categoría exitosamente");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

                
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            cargar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;

            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaCategorias.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.ID.ToString().Contains(filtro));
            }
            else
            {
                listaFiltrada = listaCategorias;
            }


            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;
        }
    }
}
