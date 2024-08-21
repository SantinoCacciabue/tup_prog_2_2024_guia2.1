﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Persona
    {
        public string DNI {  get; private set; }
        public string Nombre { get; private set; }
        public Persona(string dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
    }
}
