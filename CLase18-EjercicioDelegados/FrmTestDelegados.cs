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
    public partial class FrmTestDelegados : Form
    {
        public delegate void DelegadoNombre (string str);
        public DelegadoNombre actualizaNombre;
        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar();
            DelegadoNombre delegadoNombre = new DelegadoNombre(mostrar.ActualizarNombre);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizaNombre.Invoke(txtNombre.Text);
        }
    }
}
