using System;
using System.Collections.Generic;
using System.Text;

namespace L14_DB1017825
{
    internal class Estudiante
    {
        public string nombre;
        public string edad;
        public int edadNumerica;
        public string grado;
        public double[] notas;

        public Estudiante(string txtNombre, int numEdad, string txtGrado, double[] notasIniciales)
        {
            this.nombre = txtNombre;
            this.edadNumerica = numEdad;
            this.grado = txtGrado;
            this.notas = notasIniciales;
        }
        public double CalcularPromedio()
        {
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }

            double promedio = suma / notas.Length;
            return promedio;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("\n----- REPORTE DEL ESTUDIANTE -----");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edadNumerica + " años");
            Console.WriteLine("Grado: " + grado);

            Console.Write("Notas actuales: ");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("[" + notas[i] + "] ");
            }
            Console.WriteLine();

            double prom = CalcularPromedio();
            Console.WriteLine("Promedio Final: " + prom);
            Console.WriteLine("----------------------------------");
        }

        public void Aprobar()
        {
            double prom = CalcularPromedio();

            if (prom >= 61)
            {
                Console.WriteLine("Estado: ¡APROBADO! 🎉");
            }
            else
            {
                Console.WriteLine("Estado: REPROBADO. ❌");
            }
        }

        public void AgregarNota(double nuevaNota)
        {
            int tamañoActual = notas.Length;
            Array.Resize(ref notas, tamañoActual + 1);

            notas[tamañoActual] = nuevaNota;
            Console.WriteLine("¡Nota de " + nuevaNota + " agregada correctamente a " + nombre + "!");
        }
    }
}
