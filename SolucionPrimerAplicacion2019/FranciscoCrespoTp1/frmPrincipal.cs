using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FranciscoCrespoTp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoPersonas ventana = new frmListadoPersonas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void listadoDeObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeObjetos ventana = new frmListadoDeObjetos();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
