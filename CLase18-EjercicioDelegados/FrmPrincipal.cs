using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLase18_EjercicioDelegados
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
            frmMostrar = new FrmMostrar();
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar.MdiParent = this;
            frmTestDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}
