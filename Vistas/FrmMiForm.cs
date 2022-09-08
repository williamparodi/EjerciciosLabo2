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
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = this.txtNombre.Text;//accedo al nombre y con la propiedad text accedo al valor

            if(string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Hubo un error","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Hola {nombre}", "Bienvenido");
            }

            //MessageBox.Show($"Hola {nombre}","BIENVENIDO",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning); 
        }

        private void button1_click(object sender, EventArgs e)
        {
            string nombre;
            nombre=this.txtNombre.Text;

            FrmSaludar frmSaludar = new FrmSaludar();
            if(frmSaludar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usted acepta su nombre");
            }
            else
            {
                MessageBox.Show("No le gusta su nombre");
            }
        }



     
    }
}
