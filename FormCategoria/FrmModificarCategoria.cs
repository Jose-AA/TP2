using dominio;
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

namespace TP2
{
    public partial class FrmModificarCategoria : Form
    {
        private Categoria categoria = null;
        public FrmModificarCategoria()
        {
            InitializeComponent();
        }

        public FrmModificarCategoria(Categoria modificar)
        {
            categoria = modificar;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nuevaDescripcionCategoria = txtDescripcion.Text.Trim();
            categoria.Descripcion = nuevaDescripcionCategoria;
            CategoriaNegocio negocio = new CategoriaNegocio();

            if(string.IsNullOrEmpty(nuevaDescripcionCategoria))
            {
                MessageBox.Show("Por favor ingrese una descripción");
                return;
            }

            try
            {
                negocio.modificar(categoria);
                MessageBox.Show("Categoria modificada exitosamente");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
