using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmReloj
{
    public class Temporizador
    {
        public CancellationToken cancellationToken;
        public CancellationTokenSource cancellationTokenSource;
        public Task hilo;
        public int intervalo;

        public bool EstaActivo
        {
            get
            {
                bool retorno = false;
                if (this.hilo.Status)
                {
                    retorno = true;
                }
                return retorno;
            }
        }

        public int Intervalo
        {
            get { return intervalo; }
        }
    }
}
