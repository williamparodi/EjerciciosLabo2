using System;
using System.Threading;
using System.Threading.Tasks;

namespace Clase20AnotacionesEventos
{
    public class Reloj
    {
        int hora;
        int minuto;
        int segundo;

        public delegate void NotificacionCambioTiempo(Reloj reloj);
        public event NotificacionCambioTiempo SegundoCambiado;

        public void Iniciar()
        {
            Task.Run(() => //Hilo secundario
            {
                while (true)
                {
                    DateTime dateTime = DateTime.Now;
                    Thread.Sleep(100); // diez veces por segundo
                 
                    if (dateTime.Second != segundo)
                    {
                        if(SegundoCambiado is not null)// Si el manejador no es null lanzo el evento
                        {
                            SegundoCambiado.Invoke(this);// lanzo el evento notificando el cambio.
                        }
                        
                    }
                    hora = dateTime.Hour;
                    minuto = dateTime.Minute;
                    segundo = dateTime.Second;

                }
            });
           

        }

        public override string ToString()
        {
            return $"{hora} : {minuto} : {segundo}";
        }
    }
}
