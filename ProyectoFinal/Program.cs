using System;

namespace ProyectoFinal.Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa emp1 = new Empresa();
            Vehiculos ve1 = new Vehiculos();
         
            Console.WriteLine($"/////////");
            ve1.LeerDatosVehiculo();
            ve1.VerDatosVehiculo();
            Console.ReadKey();
        }
    }
}
