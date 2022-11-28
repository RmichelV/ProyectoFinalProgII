using System;
namespace ProyectoFinal.Clases
{
    public class Vehiculos
    {
        //atributos//
        private string idVehiculo;
        private string tipoDeVehiculo;

        //constructores//
        public Vehiculos()
        {
            this.idVehiculo = "ABC";
            this.tipoDeVehiculo = "Viaje";
        }

        //methods//
        public virtual void VerDatosVehiculo()
        {
            Console.WriteLine($"ID: {this.idVehiculo} \t TIPO de VEHICULO: {this.tipoDeVehiculo}");
        }

        public virtual void LeerDatosVehiculo()
        {
            Console.Write($"Ingrese el ID del vehiculo: ");
            this.idVehiculo = Console.ReadLine();
            Console.Write($"Ingrese correctamente el tipo de vehiculo  que es el {this.idVehiculo} (carga o pasajeros): ");
            this.tipoDeVehiculo = Console.ReadLine();
        }

    }   
}

