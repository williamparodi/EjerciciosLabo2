using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clase10_Ejer02_Exception;


namespace Vistas
{
    public partial class FrmCalculador : Form
    {
        private int kilometros;
        private int litros;
        private double resultado;
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionTomaDeDatos();
                this.resultado = Calculador.Calcular(kilometros, litros);
                this.rtx_Texto.Text = $"El consumo es de : {this.resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }


        public void FuncionTomaDeDatos()
        {
            try
            {
                if (this.txt_Litros.Text == "" && this.txt_Kilometros.Text == "")// preguntar por que no toma argumentNullException
                {
                    throw new MisExceptions("No se ingresaron Datos");
                }

                this.kilometros = int.Parse(this.txt_Kilometros.Text);
                this.litros = int.Parse(this.txt_Litros.Text);
            }
            catch (FormatException ex)
            {
                throw new MisExceptions("No es un numero", ex);
            }
            catch (OverflowException ex)
            {
                throw new MisExceptions("Numero demasiado largo", ex);
            }
           
        }

    }
}
