using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string nombre) : this()
        {
            this.lblSaludo.Text = $"Hola {nombre} que tenga buen dia";
        }
        /*
        private void btnAceptar(object sender, EventArgs e)
        {
            string equipo;
            equipo = this.cboBox.Text;
            MessageBox.Show(equipo);
        }
        private void btnAceptar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        */
    }
}
