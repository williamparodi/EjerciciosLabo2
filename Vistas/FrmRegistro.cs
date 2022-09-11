using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vistas
{
    public partial class FrmRegistro : Form
    {
        public string[] cursos = new string[3];
        public string genero;
        public FrmRegistro()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar ambos campos : Nombre y direccion");

            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show(sb.ToString(), "Error,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ingresante ingresante = new Ingresante(txtNombre.Text, txtDireccion.Text, genero, listBoxPaises.Text, cursos, (int)numericUpDownEdad.Value);
                MessageBox.Show(ingresante.Mostrar());
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            radioButtonMasculino.Checked = true;
            listBoxPaises.SetSelected(0, true);
            for(int i = 0;i < cursos.Length;i++)
            {
                cursos[i] = "";
            }
        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = radioButtonMasculino.Text;
        }

        private void radioButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = radioButtonFemenino.Text;
        }

        private void radioButtonNoBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.genero = radioButtonNoBinario.Text;
        }


        private void checkBoxCSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCSharp.Checked)
            {
                cursos[0] = checkBoxCSharp.Text;
            }
          
        }

        private void checkBoxCPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCPlus.Checked)
            {
                cursos[1] += checkBoxCPlus.Text;
            }
        }

        private void checkBoxJs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJs.Checked)
            {
                cursos[2] += checkBoxJs.Text;
            }
        }

        

    }
}
