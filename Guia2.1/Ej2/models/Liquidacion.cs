using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Liquidacion
    {
        public Empleado Empleado { get; private set; }
        public int Año { get; private set; }
        public int Mes { get; private set; }
        public double MontoBasico { get; set; }
        public double PorcAntiguedad
        {
            get
            {
                double porc = (Año - Empleado.AñoContratado) * 1.0 / 20 * 100;
                return porc;
            }
        }
        public double MontoAntiguedad
        {
            get
            {
                return MontoBasico * PorcAntiguedad/100;
            }
        }
        public double HorasExtras50
        {
            get
            {
                return Empleado.HorasExtra50;
            }
            set
            {
                HorasExtras50 = Empleado.HorasExtra50;
            }
        }
        public double HorasExtras100
        {
            get
            {
                return Empleado.HorasExtra100;
            }
            set
            {
                HorasExtras100 = Empleado.HorasExtra100;
            }
        }
        public double MontoExtras50
        {
            get
            {
                return (MontoBasico / 40) * (HorasExtras50 * 1.5);
            }
        }
        public double MontoExtras100
        {
            get
            {
                return (MontoBasico / 40) * (HorasExtras100 * 2.0);
            }
        }
        public double Nominal
        {
            get
            {
                return MontoBasico + MontoAntiguedad + MontoExtras100 + MontoExtras50;
            }
        }
        public double MontoObraSocial
        {
            get
            {
                return Nominal * 0.03;
            }
        }
        public double MontoJubilado
        {
            get
            {
                return Nominal * 0.18;
            }
        }
        public double MontoGremial
        {
            get
            {
                return Nominal * 0.015;
            }
        }
        public double Neto
        {
            get
            {
                return Nominal - MontoGremial - MontoJubilado - MontoObraSocial;
            }
        }
        public double MontoProductividad
        {
            get
            {
                return Neto * 0.3;
            }
        }
        public double ACobrar
        {
            get
            {
                return Neto + MontoProductividad;
            }
        }
        public Liquidacion(Empleado e, int mes, int año)
        {
            Empleado = e;
            Año = año;
            Mes = mes;
        }
        public string VerImpreso()
        {
            return "Empleado: " + Empleado.ApellidoNombre +
                Environment.NewLine + "Básico: " + MontoBasico +
                Environment.NewLine + "Antiguedad(" + Empleado.Antiguedad + "%):" + MontoAntiguedad
                + Environment.NewLine + "Extras al 50%(" + Empleado.HorasExtra50 + ")" + MontoExtras50
                + Environment.NewLine + "Extras al 100%(" + Empleado.HorasExtra100 + ")" + MontoExtras100
                + Environment.NewLine + "Obra social: " + MontoObraSocial
                + Environment.NewLine + "Jubilación: " + MontoJubilado
                + Environment.NewLine + "Ap. Gremiales: " + MontoGremial
                + Environment.NewLine + "Productividad: " + MontoProductividad
                + Environment.NewLine + "Haberes totales: " + Nominal + MontoProductividad
                + Environment.NewLine + "Descuentos totales: " + (MontoObraSocial + MontoJubilado + MontoGremial)
                + Environment.NewLine + "Total a cobrar: " + ACobrar;
        }


    }
}
