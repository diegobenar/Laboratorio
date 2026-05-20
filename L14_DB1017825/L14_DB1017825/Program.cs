using L14_DB1017825;
using System;
namespace L14
{
    class program
    {
        static void Main(string[] args)
        {
            // ejercicio 1
            Console.WriteLine("\n=== EJERCICIO 1 ===");
            Libro libro1 = new Libro("Almendra", "Won-pyung Sohn", 2019, true);
            Libro libro2 = new Libro("Rebelion en la Granja", "George Orwell", 1973, true);
            libro1.MostrarInfo();
            libro2.MostrarInfo();

            Console.WriteLine("Prestando el libro 1");
            libro1.prestarLibro();
            libro1.MostrarInfo();
            Console.WriteLine("Prestando el libro 1 de nuevo");
            libro1.prestarLibro();

            Console.WriteLine("Devolviendo el primer libro");
            libro1.devolverLibro();
            libro1.MostrarInfo();

            //ejercicio 2
            Console.WriteLine("\n=== EJERCICIO 2 ===");
            Mascota mascota1 = new Mascota("Chanchito", "Perro", 2, false);
            Mascota mascota2 = new Mascota("Leo", "Gato", 1, true);

            mascota1.mostrarInfo();
            mascota2.mostrarInfo();

            Console.WriteLine("Vacunando mascota 1");
            mascota1.vacunar();
            mascota1.mostrarInfo();
            Console.WriteLine("Agregando edad a mascota 1");
            mascota1.cumplirAnios();
            mascota1.mostrarInfo();

            //ejercicio 3
            Console.WriteLine("\n=== EJERCICIO 3 ===");
            double[] notasEstudiante1 = { 70, 85, 62 };
            double[] notasEstudiante2 = { 50, 60, 55 };

            Estudiante est1 = new Estudiante("Diego Benavente", 19, "Segundo Semestre", notasEstudiante1);
            Estudiante est2 = new Estudiante("Jose Reynoso", 20, "Segundo Semestre", notasEstudiante2);

            Console.WriteLine("=== SISTEMA DE CONTROL ACADÉMICO ===");

            est1.MostrarInformacion();
            est1.Aprobar();

            est2.MostrarInformacion();
            est2.Aprobar();

            Console.WriteLine("\n>>> Agregando zona extra a Jose Reynoso...");
            est2.AgregarNota(90);
            est2.MostrarInformacion();
            est2.Aprobar();


        }


    }
}