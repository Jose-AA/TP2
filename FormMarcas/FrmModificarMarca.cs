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
    public partial class FrmModificarMarca : Form
    {
        List<Marca> lista = new List<Marca>();
        NegocioMarca negocioMarca = new NegocioMarca();

        public void cargarGrilla()
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            try
            {
                lista = negocioMarca.listar();
                dgvModificarM.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public FrmModificarMarca()
        {
            InitializeComponent();
        }

        private void FrmModificarMarca_Load(object sender, EventArgs e)
        {
            cargarGrilla();    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IdModificacion.Text = dgvModificarM.CurrentRow.Cells[0].Value.ToString();
                Descripcion_a_Modificar.Text = dgvModificarM.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
                
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(Descripcion_a_Modificar.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca para modificar");
                return;
            }
            
           else if (MessageBox.Show("¿Seguro que desea modificar la marca?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Marca marca = new Marca();
                marca.descripcion = Descripcion_a_Modificar.Text;
                marca.id = Convert.ToInt32(IdModificacion.Text);
                negocioMarca.modificar(marca);
                IdModificacion.Text = "";
                Descripcion_a_Modificar.Text = "";
                cargarGrilla();

            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
