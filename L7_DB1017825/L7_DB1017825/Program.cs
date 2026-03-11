using System;
namespace lab7
{
    class program
    {
        static void Main()
        {

            // Ejercicio 1
            Console.Write("¿Cuántos números desea sumar?: ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("Error: El número debe ser mayor a 0. Ingrese N de nuevo: ");
                n = int.Parse(Console.ReadLine());
            }
            int contador = 1;
            double sumaTotal = 0;
            while (contador <= n)
            {
                Console.Write("Ingrese el número " + contador + ": ");
                double valor = double.Parse(Console.ReadLine());

                sumaTotal += valor;
                contador++;
            }

            double promedio = sumaTotal / n;
            Console.WriteLine("--- RESULTADOS ---");
            Console.WriteLine("Total de la suma: " + sumaTotal);
            Console.WriteLine("Promedio obtenido: " + promedio);

            // Ejercicio 2
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ DE CONVERSIONES ---");
                Console.WriteLine("1. Convertir Celsius a Fahrenheit");
                Console.WriteLine("2. Convertir Fahrenheit a Celsius");
                Console.WriteLine("3. Convertir Kilómetros a Millas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese los grados Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahr = (celsius * 1.8) + 32;
                       Console.WriteLine("Resultado: " + Math.Round(fahr, 2) + " °F");
                    break;

                    case 2:
                        Console.Write("Ingrese los grados Fahrenheit: ");
                        double fahrenheit = double.Parse(Console.ReadLine());
                        double cels = (fahrenheit - 32) / 1.8;
                        Console.WriteLine("Resultado: " + Math.Round(cels, 2) + " °C");
                    break;

                    case 3:
                        Console.Write("Ingrese los kilómetros: ");
                        double km = double.Parse(Console.ReadLine());
                        double millas = km * 0.621371;
                        Console.WriteLine("Resultado: " + Math.Round(millas, 2) + " millas");
                    break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4);

            // Ejercicio 3
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int suposicion = 0;
            int intentosValidos = 0;

            Console.WriteLine("--- Juego: Adivina el Número (1-100) ---");

            while (suposicion != numeroSecreto)
            {
                Console.Write("Ingrese su número: ");
                suposicion = int.Parse(Console.ReadLine());

                if (suposicion < 1 || suposicion > 100)
                {
                    Console.WriteLine("Número fuera de rango. No cuenta como intento.");
    }
                else
                {
                    intentosValidos++;

                    if (suposicion < numeroSecreto)
                    {
                        Console.WriteLine("Más alto");
        }
                    else if (suposicion > numeroSecreto)
                    {
                        Console.WriteLine("Más bajo");
        }
                    else
                    {
                        Console.WriteLine("Correcto!");
                        Console.WriteLine("Cantidad de intentos: " + intentosValidos);
        }
                }
            }

            // Ejercicio 4
            int pinCorrecto = 1234;
            int pinIngresado;
            int intentos = 0;
            bool accesoConcedido = false;

            do
            {
                intentos++;
                Console.Write("Intento " + intentos + " - Ingrese su PIN: ");
                pinIngresado = int.Parse(Console.ReadLine());

                if (pinIngresado == pinCorrecto)
                {
                    accesoConcedido = true;
                }
                else if (intentos < 3)
                {
                    Console.WriteLine("PIN incorrecto.");
                }

            } while (accesoConcedido == false && intentos < 3);

            if (accesoConcedido)
            {
                Console.WriteLine("Acceso concedido");
            }
            else
            {
                Console.WriteLine("PIN incorrecto. Cuenta bloqueada.");
            }
        }
    }
}
