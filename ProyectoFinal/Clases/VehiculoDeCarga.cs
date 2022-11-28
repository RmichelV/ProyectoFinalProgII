using System;
namespace ProyectoFinal.Clases
{
    public class VehiculoDeCarga:Vehiculos
    {
        //atributos //
        private double capacidadDeCarga;


        //constructores//
        public VehiculoDeCarga():base()
        {
            this.capacidadDeCarga = 30;
        }

        //methods//
        public override void VerDatosVehiculo()
        {
            base.VerDatosVehiculo();
            Console.WriteLine($"Capacidad de Carga: {this.capacidadDeCarga}");
        }

        public override void LeerDatosVehiculo()
        {
            base.LeerDatosVehiculo();
            Console.Write($"Ingrese la capacidad de carga del vehiculo: ");
            this.capacidadDeCarga = double.Parse(Console.ReadLine());
        }
    }
}

