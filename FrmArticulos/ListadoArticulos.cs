using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
namespace TP2
{

    public partial class ListadoArticulos : Form
    {



        private List<Articulo> listaArticulos;



        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {

            actualizarListado();

        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.imagenes);

            }
        }


        private void actualizarListado()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar()
                                    .GroupBy(a => a.id)
                                    .Select(g => g.First())
                                    .ToList();

                dgvListadoArticulos.DataSource = listaArticulos;
                dgvListadoArticulos.Columns["UrlImagen"].Visible = false;

                if (listaArticulos.Count > 0)
                {
                    cargarImagen(listaArticulos[0].imagenes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "error en load de listado articulos");
            }
        }
        private void cargarImagen(List<Imagen> imagen)
        {

            if(imagen.Count == 0)
            {
                pictureBoxImagenesArticulos.Load("https://miracomosehace.com/wp-content/uploads/2020/06/error-web.jpg");
                return;
            }

            try
            {
                pictureBoxImagenesArticulos.Load(imagen[0].Url);
            }
            catch (Exception ex)
            {
                pictureBoxImagenesArticulos.Load("https://miracomosehace.com/wp-content/uploads/2020/06/error-web.jpg");
                
            }
        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
            FrmCargarArticulo form = new FrmCargarArticulo();
            form.ShowDialog();
            actualizarListado();
        }

        private void buttonEditarArticulo_Click(object sender, EventArgs e)
        {

            if (!(dgvListadoArticulos.CurrentRow is null))
            {
                try
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                    FrmCargarArticulo modificar = new FrmCargarArticulo(seleccionado);
                    modificar.ShowDialog();
                    actualizarListado();

                }
                catch (Exception ex)
                {

                    ex.ToString();
                }
            }
            else
            {
                MessageBox.Show("No hay articulos seleccionados", "Error");
            }
            
        }

        private void buttonEliminarFisicoArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {

                DialogResult respuesta = MessageBox.Show("Confirmar borrado permanente", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarFisica(seleccionado.id);
                    actualizarListado();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error en Eliminacion fisica");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void filtrar()
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.nombre.ToLower().Contains(textBoxFiltro.Text.ToLower()) || x.id.ToString().Contains(textBoxFiltro.Text.ToLower()) || x.marcaArticulo.descripcion.ToLower().Contains(textBoxFiltro.Text.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvListadoArticulos.DataSource = null;
            dgvListadoArticulos.DataSource = listaFiltrada;
            dgvListadoArticulos.Columns["UrlImagen"].Visible = false;
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }
    }
}
