using System;
namespace ProyectoFinal
{
    public class Empresa
    {
        //atributos//
        private string nombreDeLaEmpresa;
        private int nitDeLaEmpresa;

        //contructores//
        public Empresa()
        {
            this.nombreDeLaEmpresa = "Mi Empresa";
            this.nitDeLaEmpresa = 1111;
        }

        //methods//
        public void VerDatos()
        {
            Console.WriteLine($"Empresa: {this.nombreDeLaEmpresa} \t NIT: {this.nitDeLaEmpresa}");
        }

        public void LeerDatos()
        {
            Console.Write($"Ingresa el nombre de la Empresa: ");
            this.nombreDeLaEmpresa = Console.ReadLine();

            try
            {
                Console.Write($"Ingresa el nit de la empresa {this.nombreDeLaEmpresa}: ");
                this.nitDeLaEmpresa = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ingresaste un nit no valido, por Defecto se usara el nit: 1111111");
                this.nitDeLaEmpresa = 1111111;
            }
        }
        
    }
}

