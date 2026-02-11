using System;
namespace Laboratorio03
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            string curso;
            Console.Write("Ingrese su curso: ");
            curso = Console.ReadLine();
            Console.WriteLine("Hola "+ nombre + ", seguro vas a pasar el curso "+  curso+ ", nunca te rindas.");
            Console.WriteLine("Bye bye medicina.");
            Console.Write("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            
        }



    }


}