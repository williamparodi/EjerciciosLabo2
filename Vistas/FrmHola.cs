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
    public partial class FrmHola : Form
    {
       
        public FrmHola()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string materia = " ";
            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;
            materia = this.cboMateria.Text;

            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(materia))
            {
                MessageBox.Show("Hubo un error no ingreso los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                FrmSaludo frmSaludo = new FrmSaludo(nombre,apellido,materia);
                frmSaludo.ShowDialog();
            }
        }
    }
}
