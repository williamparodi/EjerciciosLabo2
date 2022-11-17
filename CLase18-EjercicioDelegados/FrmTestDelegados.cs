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
        public delegate void DelegadoNombre (string str);//delcaro delegado 
        private DelegadoNombre actualizaNombre;//atributo delegado
        public FrmTestDelegados(DelegadoNombre actualizaNombre)
        {
            InitializeComponent();
            this.actualizaNombre = actualizaNombre;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizaNombre.Invoke(txtNombre.Text);
        }
    }
}
