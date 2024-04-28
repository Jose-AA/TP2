using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FrmCargarArticulo : Form
    {
        private Articulo articulo = null;
        private List<Imagen> listaImagenes;
        private int imagenActual = 0;
        public FrmCargarArticulo()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            try
            {
                NegocioMarca accesoMarcas = new NegocioMarca();
                CategoriaNegocio accesoCategorias = new CategoriaNegocio();

                ddlMarca.DataSource = accesoMarcas.listar();
                ddlCategoria.DataSource = accesoCategorias.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            if(string.IsNullOrEmpty(txtNombre.Text)) { MessageBox.Show("El nombre no puede estar vacio"); return; }
            if (string.IsNullOrEmpty(txtCodigo.Text)) { MessageBox.Show("El codigo no puede estar vacio"); return; }
            if (string.IsNullOrEmpty(textBoxDescripcion.Text)) { MessageBox.Show("La descripcion no puede estar vacia"); return; }
            if (string.IsNullOrEmpty(textBoxPrecio.Text)) { MessageBox.Show("El precio no puede estar vacio"); return; }
            if(ddlCategoria.SelectedItem == null) { MessageBox.Show("Debe seleccionar una categoria"); return; }
            if (ddlMarca.SelectedItem == null) { MessageBox.Show("Debe seleccionar una marca"); return; }


            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                bool ArticuloNoexistente = false;
                if (articulo == null) { 
                articulo = new Articulo();
                ArticuloNoexistente = true;
                    articulo.id = negocio.UltimoArticuloRegistrado();
                }

                articulo.nombre = txtNombre.Text;
                articulo.codigo = txtCodigo.Text;
                articulo.descripcion = textBoxDescripcion.Text;
                articulo.precio = decimal.Parse(textBoxPrecio.Text);
                articulo.marcaArticulo = new Marca();
                articulo.marcaArticulo.id = ((Marca)ddlMarca.SelectedItem).id;
                articulo.marcaArticulo.descripcion = ((Marca)ddlMarca.SelectedItem).descripcion;
                articulo.categoriaArticulo = new Categoria();
                articulo.categoriaArticulo.Descripcion = ((Categoria)ddlCategoria.SelectedItem).Descripcion;
                articulo.categoriaArticulo.ID = ((Categoria)ddlCategoria.SelectedItem).ID;

             
                articulo.imagenes = new List<Imagen>();

                Imagen ima = new Imagen(articulo.id, textBoxURL.Text);

                articulo.imagenes.Add(ima);                

                if(!ArticuloNoexistente)
                {
                    MessageBox.Show("modificando ....");
                    negocio.modificar(articulo);
                    negocio.agregarImagen(articulo.id, ima.Url);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                  
                    MessageBox.Show("agregando ....");
                    negocio.agregarImagen(articulo.id, ima.Url);
                    negocio.Agregar2(articulo);
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

            cargar();

            ddlCategoria.DisplayMember = "Descripcion";
            ddlCategoria.ValueMember = "ID";

            ddlMarca.DisplayMember = "descripcion";
            ddlMarca.ValueMember = "id";

            if (articulo != null)
            {
                textBoxDescripcion.Text = articulo.descripcion;
                textBoxPrecio.Text = articulo.precio.ToString();
                txtCodigo.Text = articulo.codigo;
                txtNombre.Text = articulo.nombre;
                ddlMarca.SelectedValue = articulo.marcaArticulo.id;
                ddlCategoria.SelectedValue = articulo.categoriaArticulo.ID;
              
                cargarImagen(articulo.imagenes[0].Url);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca nuevaMarca = new FrmAgregarMarca();
            nuevaMarca.ShowDialog();
            cargar();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
             
            ArticuloNegocio negocio = new ArticuloNegocio();
            int IdArticuloEstimado = negocio.UltimoArticuloRegistrado();
                
            
            Imagen ima = new Imagen();

            ima.Url = textBoxURL.Text;
            ima.IDArticulo = IdArticuloEstimado;
            
            
            
            articulo.imagenes.Add(ima);
            negocio.agregarImagen(ima.IDArticulo, ima.Url);

            cargarImagen(textBoxURL.Text);
            MessageBox.Show("Imagen cargada al articulo");

            //negocio.EliminarImagenesSinArticulo();
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

        private void buttonAñadirCategoria_Click(object sender, EventArgs e)
        {
            FrmCargarCategoria nuevaCategoria = new FrmCargarCategoria();
            nuevaCategoria.ShowDialog();
            cargar();
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            string imagenUrl = textBoxURL.Text;

            try
            {
                pbxImagenes.Load(imagenUrl);

            }
            catch (Exception ex)
            {
                pbxImagenes.Load("https://t4.ftcdn.net/jpg/04/73/25/49/360_F_473254957_bxG9yf4ly7OBO5I0O5KABlN930GwaMQz.jpg");

            }
        }

        private void buttonBorrarCampoUrl_Click(object sender, EventArgs e)
        {
            textBoxURL.Text = "";
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Imagen> lista = negocio.generarListaImagenes(articulo.id);
            try
            {
            if (lista.Count > 0)
            {
                imagenActual--;

                if (imagenActual < 0)
                {
                    imagenActual = lista.Count - 1;
                }
                pbxImagenes.Load(lista[imagenActual].Url);
            }

            }
            catch (Exception ex)
            {

                pbxImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSU2M2diJJpxg3MzhWDaIGVGSFLQdYJrElwI9gDAecHbQ&s");
                //MessageBox.Show(ex.ToString());
            }

        }

        

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Imagen> lista = negocio.generarListaImagenes(articulo.id);
            try
            {
            if (lista.Count > 0)
            {
                imagenActual++;
                if (imagenActual >= lista.Count)
                {
                    imagenActual = 0;
                }
                pbxImagenes.Load(lista[imagenActual].Url);
            }

            }
            catch (Exception ex)
            {

                pbxImagenes.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSU2M2diJJpxg3MzhWDaIGVGSFLQdYJrElwI9gDAecHbQ&s");
                MessageBox.Show("Nada para mostrar");
            }
        }
    }
}
