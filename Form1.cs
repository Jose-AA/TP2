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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void añadirArtículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCargarArticulo ventanaCargaArticulo = new FrmCargarArticulo();
            ventanaCargaArticulo.ShowDialog();
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
