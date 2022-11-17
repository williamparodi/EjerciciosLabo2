using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase18_Ejer101Hilos
{
    public partial class FrmPrincipal : Form
    {
        public DateTime date;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)//ejecuta de manera async se llama al main thread
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.UtcNow.ToString();
                    });
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }

            }
        }           


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            this.timer2.Start();
            //Task tarea = Task.Run(AsignarHora);
            Task tarea2 = Task.Run(AsignarHora3);// intancio y inicio un hilo en una misma linea ademas retorna la instancia de la task
           
        }

        //punto 3 2
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        
        //otra manera de ahacer el punto 3-1
        public void AsignarHora3()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)//ejecuta de manera async se llama al main thread
                {
                    Action ac = new Action(() => { this.lblHora.Text = DateTime.UtcNow.ToString(); });
                    this.lblHora.BeginInvoke(ac);
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }

            }
        }
    }
}
