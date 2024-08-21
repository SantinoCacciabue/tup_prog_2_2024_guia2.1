using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class RegistroVehiculo
    {
        public Persona Propietario { get; set; }
        public string Patente { get; private set; }
        public int NroSerie { get; private set; }
        public RegistroVehiculo(Persona propietario, string patente, int nroSerie)
        {
            Propietario = propietario;
            Patente = patente;
            NroSerie = nroSerie;
        }
        public string VerDetalle()
        {
            return $"Propietario: {Propietario.DNI} - {Propietario.Nombre} Patente: {Patente} Nro serie: {NroSerie}";
        }
    }
}
