using dominio;
using negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2.FormMarcas
{
    public partial class FrmBuscarMarca : Form
    {
        List<Marca> lista = new List<Marca>();
        NegocioMarca negocioMarca = new NegocioMarca();
        
        public void cargarGrilla()
        {
            try
            {
                lista = negocioMarca.listar();
                dtgMarcas.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
        public FrmBuscarMarca()
        {
            InitializeComponent();
        }

        private void BuscarMarca_Load(object sender, EventArgs e)
        {  
            cargarGrilla();

        }

        private void TexBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = TexBoxBuscar.Text;
                List<Marca> listaFiltrada = new List<Marca>();
                listaFiltrada = lista.FindAll(x => x.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.id.ToString().Contains(filtro));
                dtgMarcas.DataSource = null;
                dtgMarcas.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
                

        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
  }

