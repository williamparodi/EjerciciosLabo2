using Clase20AnotacionesEventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormReloj
{
    public partial class FrmPrincipalReloj : Form
    {
        public FrmPrincipalReloj()
        {
            InitializeComponent();
        }

        private void FrmPrincipalReloj_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();
            reloj.SegundoCambiado += AsignarHora;// Asocio el evento al metodo manejador sin esto no anda
            //reloj.SegundoCambiado -= AsignarHora; con el - desasocio el eventp al metodo manejador. 
            reloj.Iniciar();//inicio el evento
        }

        private void btnAcutalizar_Click(object sender, EventArgs e)
        {

        }

        public void AsignarHora(Reloj reloj)//metodo manejador igual q la firma del delegado
        {
            if(lbl.InvokeRequired)// modifico esto que esta en el hilo principal desde un hilo secundario
            {
                Action<Reloj> delegado = AsignarHora;// el generico es del tipo reloj asi le puedo pasar Asignar hora.
                lbl.Invoke(delegado,reloj); // si o si recibe un array de objects
            }
            else
            {
                this.lbl.Text = reloj.ToString();
            }
            
        }

        private void FrmPrincipalReloj_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //cierro el evento.
        }
    }
}
