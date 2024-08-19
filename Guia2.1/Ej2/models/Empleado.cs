using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Empleado
    {
        public int DNI { get; private set; }
        public string Apellido {  get; private set; }
        public string Nombre {  get; private set; }
        public string ApellidoNombre
        {
            get
            {
                return $"{Apellido}, {Nombre}";
            }
        }
        public int AñoContratado {  get; private set; }
        public double MontoBasicoNominal {  get; private set; }
        public int HorasExtra50 {  get;  set; }
        public int HorasExtra100 {  get;  set; }
        public int Antiguedad { get; set; }
        public Empleado(int dni, string nombre, string apellido, int añoContratado, int horas50, int horas100)
        {
            DNI = dni;
            Apellido = apellido;
            Nombre = nombre;
            AñoContratado = añoContratado;
            HorasExtra50 = horas50;
            HorasExtra100 = horas100;
            
        }
    }
}
