using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class DepartamentoVehicular
    {
        public int CantidadRegistros
        {
            get
            {
                return registros.Count;
            }
        }
        public int nroSerie;
        public string Patente { get; set; }
        private ArrayList registros = new ArrayList();
        public RegistroVehiculo RegistrarVehiculo(Persona propietario, string patente)
        {
            nroSerie++;
            Patente = patente;
            RegistroVehiculo nuevo = new RegistroVehiculo(propietario, Patente, nroSerie);
            registros.Add(nuevo);
            return nuevo;
        }
        public RegistroVehiculo VerRegistro(int nroSerie)
        {
            for(int i = 0; i < CantidadRegistros; i++)
            {
                RegistroVehiculo reg = registros[i] as RegistroVehiculo;
                if(reg.NroSerie == nroSerie)
                {
                    return reg;
                }
            }
            return null;
        }
    }
}
