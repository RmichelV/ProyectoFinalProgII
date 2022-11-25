using System;
namespace ProyectoFinal.Clases
{
    abstract class Vehiculos
    {
        //atributos//
        protected string idVehiculo;
        protected string tipoDeVehiculo;

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
            
            do
            {
                Console.Write($"Ingrese correctamente el tipo de vehiculo  que es el {this.idVehiculo} (carga o pasajeros): ");
                this.tipoDeVehiculo = Console.ReadLine();
                
            } while (this.tipoDeVehiculo!="carga" || this.tipoDeVehiculo != "Carga" || this.tipoDeVehiculo!="Pasajeros" || this.tipoDeVehiculo!="pasajeros");
        }

    }   
}

