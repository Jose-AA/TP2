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
    public partial class FrmCargarArticulo : Form
    {
        private Articulo articulo = null;
        public FrmCargarArticulo()
        {
            InitializeComponent();
        }

        public FrmCargarArticulo(Articulo arti)
        {
            InitializeComponent();
            this.articulo = arti;
            Text = "Modificar artículo";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            //Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                
                articulo.nombre = txtNombre.Text;
                articulo.codigo = txtCodigo.Text;
                articulo.descripcion = textBoxDescripcion.Text;
                articulo.precio = decimal.Parse(textBoxPrecio.Text);
                Imagen ima = new Imagen(articulo.id, textBoxURL.Text);
                articulo.imagenes.Add(ima);

                

                if(articulo.id != 0)
                {
                   negocio.modificar(articulo);
                    negocio.modificarImagenes(articulo);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                    negocio.agregarImagen(articulo.id, ima.Url);
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + "Error Click Crear Articulo");
            }
            finally
            {
                this.Close();
            }
        }

        private void FrmCargarArticulo_Load(object sender, EventArgs e)
        {
            

            
            if(articulo != null)
            {
                textBoxDescripcion.Text = articulo.descripcion;
                textBoxPrecio.Text = articulo.precio.ToString();
                txtCodigo.Text = articulo.codigo;
                txtNombre.Text = articulo.nombre;
                cargarImagen(articulo.imagenes[0].Url);

                //pbxImagenes.Load(articulo.imagenes[0].Url);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            cargarImagen(textBoxURL.Text);
        }

        private void cargarImagen(string imagen)
        {


            try
            {
                pbxImagenes.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenes.Load("https://miracomosehace.com/wp-content/uploads/2020/06/error-web.jpg");

            }
        }
    }
}
