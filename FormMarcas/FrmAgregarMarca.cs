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
    public partial class FrmAgregarMarca : Form
    {
        List<Marca> lista = new List<Marca>();
        
        public void cargarGrillayvaloresPredeterminados()
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioMarca Id = new NegocioMarca();
            int id = Id.UltimoIdmarcaRegistrada() + 1;
            TexBoxIdNM.Text = id.ToString();
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
        public FrmAgregarMarca()
        {
            InitializeComponent();
            
        }

        public void FormMarcas_Load(object sender, EventArgs e)
        {
            cargarGrillayvaloresPredeterminados();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptarNM_Click(object sender, EventArgs e)
        {   

            Marca nuevaMarca = new Marca();
       
            nuevaMarca.descripcion = TexBoxNombreNM.Text;

            try
            {
                if (TexBoxNombreNM.Text == "")
                {
                    MessageBox.Show("No se puede agregar una marca sin nombre");
                    return;
                }
                NegocioMarca negocioMarca = new NegocioMarca();
                negocioMarca.agregar(nuevaMarca);
                MessageBox.Show("Marca agregada correctamente");
                cargarGrillayvaloresPredeterminados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
