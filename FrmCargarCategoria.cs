using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using dominio;
using negocio;

namespace TP2
{
    public partial class FrmCargarCategoria : Form
    {
        public FrmCargarCategoria()
        {
            InitializeComponent();
        }
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();
            
            categoria.Descripcion = txtCategoria.Text;

            if(categoria.Descripcion == "")
            {
                MessageBox.Show("Por favor ingrese una descripción");
                return;
            }

            try
            {

                negocio.agregar(categoria);
                MessageBox.Show("Categoria agregada exitosamente");
             
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
