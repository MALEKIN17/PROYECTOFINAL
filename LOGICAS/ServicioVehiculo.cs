using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAS
{
    public partial class ServicioVehiculo
    {

        GestionVehiculo gestionvehiculo = new GestionVehiculo();

        public string Insertarvehiculo(Vehiculo vehiculo)
        {
            return gestionvehiculo.Insertarvehiculo(vehiculo);
        }

        public string Eliminarvehiculo(string identificador)
        {
            return gestionvehiculo.Eliminarvehiculo(identificador);
        }

        public List<Vehiculo> ObtenerTodosvehiculos()
        {
            return gestionvehiculo.Consultarvehiculos();
        }
        public Vehiculo Obtenervehiculo(string cl_placa)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos = gestionvehiculo.Consultarvehiculos();
            Vehiculo Vehiculo = new Vehiculo();
            foreach (Vehiculo Vehiculo1 in vehiculos)
            {
                if (Vehiculo1.placa == cl_placa)
                {
                    Vehiculo = Vehiculo1; break;
                }
            }
            return Vehiculo;
        }

        public Vehiculo Obtenervehiculocliente(string cledulacliente)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos = gestionvehiculo.Consultarvehiculos();
            Vehiculo Vehiculo = new Vehiculo();
            foreach (Vehiculo Vehiculo1 in vehiculos)
            {
                if (Vehiculo1.cedulaCliente == cledulacliente)
                {
                    Vehiculo = Vehiculo1; break;
                }
            }
            return Vehiculo;
        }


    }
}
