using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
{
    public partial class Form1 : Form
    {
        ControlRadar control = new ControlRadar();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            control.Ordenar();
            Vehiculo buscado = control.Buscar(tbPatente.Text);
            if (buscado != null)
            {
                MessageBox.Show("Encontrado! Velocidad: " + buscado.Velocidad.ToString());
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormDatos fDatos = new FormDatos();
            while (fDatos.ShowDialog() == DialogResult.OK)
            {
                control.AgregarContol(fDatos.tbPatente.Text, Convert.ToDouble(fDatos.tbVelocidad.Text), fDatos.rbEsOficial.Checked);
                fDatos.tbVelocidad.Clear();
                fDatos.tbPatente.Clear();
            }
            fDatos.Dispose();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            control.Ordenar();
            for (int i = 0; i < control.CantVehiculos; i++)
            {
                listBox.Items.Add(control.VerVehiculosInfractores(i).Patente + " | Vel [km]: " + control.VerVehiculosInfractores(i).Velocidad.ToString());
            }
        }
    }
}
