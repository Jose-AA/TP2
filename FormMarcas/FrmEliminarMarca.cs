using dominio;
using negocio;
using System;
using System.Collections;
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
    
    public partial class FrmEliminarMarca : Form
    {
        List<Marca> lista = new List<Marca>();
        public FrmEliminarMarca()
        {
            InitializeComponent();
           
        }

        private bool validarBajaMarca(Marca seleccionado)
        {

            //Para validar si existen articulos cargados antes de borrar la marca
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> articulosCargados;
            articulosCargados = articuloNegocio.listar();

            foreach (var articulo in articulosCargados)
            {
                if (articulo.marcaArticulo.id == seleccionado.id)
                {
                    return false;
                }
            }

            return true;
        }

        public void cargarGrilla()
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            try
            {
                lista = negocioMarca.listar();
                dgvEliminarM.DataSource = lista;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmEliminarMarca_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            
        }

        private void BtnSeleccionarEM_Click(object sender, EventArgs e)
        {

            try
            {

             IdEliminacion.Text = dgvEliminarM.CurrentRow.Cells[0].Value.ToString();
             Descripcion_a_Eliminar.Text = dgvEliminarM.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                throw;
            }

            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Marca marca = new Marca();
                    NegocioMarca negocioMarca = new NegocioMarca();
                    marca.descripcion = Descripcion_a_Eliminar.Text;
                    marca.id = int.Parse(IdEliminacion.Text);

                    if(validarBajaMarca(marca) == true)
                    {
                        negocioMarca.eliminar(marca);
                        IdEliminacion.Text = "";
                        Descripcion_a_Eliminar.Text = "";
                        cargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("La marca " + marca.descripcion + " tiene articulos asociados. Por favor, modifique los artículos asociados para continuar con la baja de la marca");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    if (IdEliminacion.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar una marca para poder eliminarla ");
                    }
                    else 
                    {
                        MessageBox.Show(ex.Message);
                    }
                 
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
