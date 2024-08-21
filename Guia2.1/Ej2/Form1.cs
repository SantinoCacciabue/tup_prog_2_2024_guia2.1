using Ej2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa miEmpresa = new Empresa();

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            
            string nombre = tBnombre.Text;
            string apellido = tbApellido.Text;
            int dni = Convert.ToInt32(tBdni.Text);
            int h50 = Convert.ToInt32(tBh50.Text);
            int h100 = Convert.ToInt32(tBh100.Text);
            int año = Convert.ToInt32(tBaño.Text);
            Empleado nuevo = miEmpresa.RegistrarEmpleado(dni, h50, h100, nombre, apellido, año);
            lbEmpleados.Items.Add(""+nuevo.ApellidoNombre+"| DNI: "+nuevo.DNI+"| Desde: "+nuevo.AñoContratado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbApellido.Clear();
            tBaño.Clear();
            tBdni.Clear();
            tBh100.Clear();
            tBh50.Clear();
            tBnombre.Clear();
        }

        private void bGenerarliq_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(nAño.Text);
            int mes = Convert.ToInt32(nMes.Text);
            miEmpresa.GenerarLiquidaciones(mes, año);
            for(int i = 0; i<miEmpresa.liquidaciones.Count;i++)
            {
                Liquidacion liq = miEmpresa.liquidaciones[i] as Liquidacion;
                tbliqs.Text = liq.VerImpreso();
            }
        }
    }
}
