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

        public void ModificarMarca(Marca marca)
        { 
           
            try
            {
                marca.id = int.Parse(IdModificacion.Text);  
                marca.descripcion = Descripcion_a_Modificar.Text;
                NegocioMarca negocioMarca = new NegocioMarca();
                negocioMarca.modificar(marca);
                MessageBox.Show("Marca Modificada");
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No a selecionado la marca a modificar ");
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
            IdModificacion.Text = dgvModificarM.CurrentRow.Cells[0].Value.ToString();
            Descripcion_a_Modificar.Text = dgvModificarM.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Marca marca = new Marca();
            marca.descripcion = Descripcion_a_Modificar.Text;
            ModificarMarca(marca);
            IdModificacion.Text = "";
            Descripcion_a_Modificar.Text = "";
        }
    }
}
