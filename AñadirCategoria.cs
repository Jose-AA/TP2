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
    public partial class AñadirCategoria : Form
    {
        Categoria cate = new Categoria();
        public AñadirCategoria()
        {
            InitializeComponent();
        }

        private void buttonAñadirCategoria_Click(object sender, EventArgs e)
        {
            
            if (textBoxNombreCategoria.Text != "" && textBoxNumeroCategoria.Text != "") 
            {
                cate.Nombre = textBoxNombreCategoria.Text;
                cate.ID = textBoxNumeroCategoria.Text;
                cate.Descripcion = textBoxDescripcionCategoria.Text;
                MessageBox.Show("Categoría añadida: " + cate.Nombre + 
                                "\nNúmero: " + cate.ID + 
                                "\nDescripción: " + cate.Descripcion, 
                                "Nueva categoría");
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos inválidos", "Nueva Categoría");
            }
        }

        private void buttonVolverCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
