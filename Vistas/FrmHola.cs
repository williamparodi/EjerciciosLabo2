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

            if(Validar(nombre,apellido)) // valido que se hayan ingresado los datos 
            {
                FrmSaludo frmSaludo = new FrmSaludo(nombre, apellido, materia);
                frmSaludo.ShowDialog();
            }

            /* Primera parte
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(materia))
            {
                MessageBox.Show("Se deben completar los siguientes datos : ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                FrmSaludo frmSaludo = new FrmSaludo(nombre,apellido,materia);
                frmSaludo.ShowDialog();
            }
            */
        }

        private bool Validar(string nombre,string apellido)
        {
            bool flag = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes datos : ");

            if(string.IsNullOrEmpty(nombre))
            {
                flag = false;
                sb.AppendLine("Nombre");
            }
            if (string.IsNullOrEmpty(apellido))    
            {
                flag = false;
                sb.AppendLine("Apellido");
            }
            if(!flag)
            {
                MessageBox.Show(sb.ToString(),"Error,",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return flag;


        }

        private void FrmHola_Load(object sender, EventArgs e)// Al cargar el form ya seteo que aparezca la primera materia, es un evento el form
        {
            cboMateria.SelectedIndex = 0;
        }
    }
}
