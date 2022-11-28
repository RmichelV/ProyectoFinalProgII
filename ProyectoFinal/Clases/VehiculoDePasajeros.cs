using System;
namespace ProyectoFinal.Clases
{
    public class VehiculoDePasajeros:Vehiculos
    {
        private int capacidadDePasajeros;

        public VehiculoDePasajeros():base()
        {
            this.capacidadDePasajeros = 20;
        }

        public override void VerDatosVehiculo()
        {
            base.VerDatosVehiculo();
            Console.WriteLine($"Capacidad de pasajeros: {this.capacidadDePasajeros}");
        }

        public override void LeerDatosVehiculo()
        {
            base.LeerDatosVehiculo();
            Console.Write($"ingrese la capacidad del vehiculo: ");
            try
            {
                this.capacidadDePasajeros = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"El dato no fue correctamente ingresado, por defecto se usara una capacidad de 20 pasajeros");
                this.capacidadDePasajeros = 20;
            }

        }
    }
}

