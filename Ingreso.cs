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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void botonIngresoCANCELAR_Click(object sender, EventArgs e)
        {

        }

        private void botonIngresoOK_Click(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "martin" && textBoxContraseña.Text == "garcia" ||
               textBoxUsuario.Text == "franco" && textBoxContraseña.Text == "formia" ||
               textBoxUsuario.Text == "jose" && textBoxContraseña.Text == "arias" ||
               textBoxUsuario.Text == "admin" && textBoxContraseña.Text == "admin")
            {
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
