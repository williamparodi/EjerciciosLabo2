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
           
            nombre = this.txtNombre.Text;
            apellido = this.txtApellido.Text;

            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Hubo un error no ingreso los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                FrmSaludo frmSaludo = new FrmSaludo(nombre,apellido);
                frmSaludo.ShowDialog();
            }
        }

        


    }
}
