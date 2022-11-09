﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Leon : ICazador, ICarnivoro
    {
        public string Cazador()
        {
            return "Soy el rey de la selva";
        }

        public string Comer()
        {
            return "Estoy comiendo ";
        }

        string ICarnivoro.Cazador()
        {
            return "Estoy cazando como carnivoro";
        }
    }
}
