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

namespace FrmReloj
{
    public partial class Form1 : Form
    {
        public DateTime date;
        public Form1()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lbl_Hora.InvokeRequired)//ejecuta de manera async se llama al main thread
                {
                    this.lbl_Hora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lbl_Hora.Text = DateTime.UtcNow.ToString();
                    });
                }
                else
                {
                    this.lbl_Hora.Text = DateTime.UtcNow.ToString();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Start();
            //Task tarea = Task.Run(AsignarHora);
            Task tarea2 = Task.Run(AsignarHora3);// intancio y inicio un hilo en una misma linea ademas retorna la instancia de la task
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        public void AsignarHora3()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lbl_Hora.InvokeRequired)//ejecuta de manera async se llama al main thread
                {
                    Action ac = new Action(() => { this.lbl_Hora.Text = DateTime.UtcNow.ToString(); });
                    this.lbl_Hora.BeginInvoke(ac);
                }
                else
                {
                    this.lbl_Hora.Text = DateTime.UtcNow.ToString();
                }

            }
        }
    }
}
