using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Empresa
    {
        public ArrayList empleados = new ArrayList();
        public ArrayList liquidaciones = new ArrayList();
        public int CantidadLiq
        {
            get
            {
                return liquidaciones.Count;
            }
        }
        int AñoActual { get; set; }
        public Empleado RegistrarEmpleado(int dni, int h50, int h100, string nombre, string apellido, int añoContratado)
        {
            Empleado empleado = new Empleado(dni, nombre, apellido, añoContratado, h50, h100);
            empleados.Add(empleado);
            return empleado;
        }
        public void GenerarLiquidaciones(int mes, int año)
        {
            foreach(Empleado e in empleados)
            {
                Liquidacion liq = new Liquidacion(e, mes, año);
                liquidaciones.Add(liq);
            }
        }
        public ArrayList ListarLiqPorMes(int mes, int año)
        {
            ArrayList lista = new ArrayList();
            for( int i = 0;i < liquidaciones.Count; i++)
            {
                Liquidacion liq = liquidaciones[i] as Liquidacion;
                if(liq.Mes == mes && liq.Año == año)
                {
                    lista.Add(liq);
                }
            }
            return lista;
        }
        public string MostrarReciboSueldo(int mes, int año, int dni)
        {
            string ret = null;
            for(int i = 0;i<liquidaciones.Count; i++)
            {
                Liquidacion liq = liquidaciones[i] as Liquidacion;
                if(liq.Mes == mes && liq.Año == año && liq.Empleado.DNI == dni)
                {
                    ret = liq.VerImpreso();
                }
            }
            return ret;
        }
        
    }
}
