using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular depto = new DepartamentoVehicular();

        private void button1_Click(object sender, EventArgs e)
        {

            string dni = tbDNI.Text;
            string nombre = tbNombre.Text;
            string patente = tbPatente.Text;
            Persona p = new Persona(dni, nombre);
            RegistroVehiculo reg = depto.RegistrarVehiculo(p, patente);
            lbLista.Items.Add(reg.VerDetalle());
            tbDNI.Clear();
            tbNombre.Clear();
            tbPatente.Clear();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            int nroSerie = Convert.ToInt32(tbNroSerie.Text);
            if (depto.VerRegistro(nroSerie) == null)
            {
                MessageBox.Show("No se encontró un registro con ese número de serie");
            }
            else
            {
                MessageBox.Show(depto.VerRegistro(nroSerie).VerDetalle());
            }
        }
    }
}
