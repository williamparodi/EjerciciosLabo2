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
    public partial class FrmMonedas : Form
    {
        
        public FrmMonedas()
        {
            InitializeComponent();
        }

        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            txtCotizacionDolar.Text = "1";
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
