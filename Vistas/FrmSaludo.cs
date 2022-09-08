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
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        public FrmSaludo(string nombre, string apellido) : this()
        {
            this.lblSaludo.Text = "!Hola, Windows Forms!";
            this.lblMensaje.Text = $"Soy {nombre} {apellido} ";
        }

        public FrmSaludo(string nombre, string apellido,string materia) : this(nombre,apellido)
        {
            this.lblMensaje.Text += $"y mi materia favorita es {materia}";
        }
    }
}
