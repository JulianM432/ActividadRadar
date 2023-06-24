using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar
{
    internal class ControlRadar
    {
        public int CantVehiculos { get; private set; }
        Vehiculo[] infracciones;
        public ControlRadar() 
        {
            infracciones = new Vehiculo[20];
            CantVehiculos = 0;
        }
        public void AgregarContol(string patente, double velocidad, bool esOficial)
        {
            Vehiculo v = new Vehiculo(patente,velocidad,esOficial);
            if (v.VerificarVelocidadInfractor())
            {
                infracciones[CantVehiculos] = v;
                CantVehiculos++;
            }
        }
        public Vehiculo VerVehiculosInfractores(int i)
        {
            Vehiculo v = null;
            if(i < CantVehiculos && i > -1)
            {
                v = infracciones[i];
            }
            return v;
        }
        public void Ordenar()
        {
            int j;
            Vehiculo aux = null;
            for ( int i = 0; i < CantVehiculos - 1; i++)
            {
                for (j = i + 1; j < CantVehiculos; j++)
                {
                    if (infracciones[i].Patente.CompareTo(infracciones[j].Patente) > 0)
                    {
                        aux = infracciones[i];
                        infracciones[i] = infracciones[j];
                        infracciones[j] = aux;
                    }
                }
            }
        }
        public Vehiculo Buscar(string patente)
        {
            int pos = -1;
            Vehiculo v = null;
            int i = 0;
            while(i < CantVehiculos && pos == -1)
            {
                if (infracciones[i].Patente == patente)
                {
                    pos = i;
                    v = infracciones[i];
                }
                i++;
            }
            return v;
        }
    }
}
