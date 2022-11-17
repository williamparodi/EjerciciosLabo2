using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase20Ejecicio101Avisame
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
        }

        static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                // Estas dos lineas podrian ir al ctor del form
                persona = new Persona();
                persona.EventoString += NotificarCambio;// grita q se le cambio el nombre y muestra
                this.btn_actualizar.Text = "Actualizar"; 
            }

            if(this.txt_Apellido.Text != persona.Apellido)
            {
                persona.Apellido = this.txt_Apellido.Text;
            }
            if(this.txt_nombre.Text != persona.Nombre)
            {
                persona.Nombre = this.txt_nombre.Text;
            }

            this.lbl_NombreCompleto.Text = persona.Mostrar();
        }
       


    }
}
