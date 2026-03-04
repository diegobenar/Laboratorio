using System;

namespace lab_6
{
    class Program
    {
        static void Main()
        {
            //ejercico 1
            Console.WriteLine("--TIPO DE VEHICULO--");
            Console.WriteLine("Ingrese tu tipo de vehiculo: ");
            int vehiculo = int.Parse(Console.ReadLine());
            switch (vehiculo)
            {
                case 1: Console.WriteLine("Bicicleta -> No motorizado"); break;
                case 2: Console.WriteLine("Motocicleta -> Ligero"); break;
                case 3: Console.WriteLine("Auto -> Mediano"); break;
                case 4: Console.WriteLine("Camión -> Pesado"); break;
                case 5: Console.WriteLine("Autobús -> Transporte público"); break;
                default: Console.WriteLine("Error!"); break;
            }
            Console.WriteLine("--------------------");

            // ejercicio 2
            Console.WriteLine("---BANCO INDUSTRIAL---");
            Console.WriteLine("Ingrese su tipo de tarjeta: ");
            int tarjeta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su limite actual: ");
            double limite = int.Parse(Console.ReadLine());
            double aumento = 0;
            switch (tarjeta)
            {
                case 1: aumento = 0.25; break;
                case 2: aumento = 0.35; break;
                case 3: aumento = 0.40; break;
                default: aumento = 0.50; break;
            }
            double monto = limite * aumento;
            double nuevo_limite = limite + (limite * aumento);

            Console.WriteLine("--RESULTADOS--");
            Console.WriteLine("Tipo de tarjeta: Tipo " + tarjeta);
            Console.WriteLine("Porcentaje de aumento aplicado: " + aumento + "%");
            Console.WriteLine("Monto del aumento: Q" + monto);
            Console.WriteLine("Su nuevo limite de credito es: Q" + nuevo_limite);
            Console.WriteLine("--------------");

            // ejercicio 3
            Console.WriteLine("--PUNTUACION DE EMPLEADOS--");
            Console.WriteLine("Ingrese su puntuacion: ");
            double puntuacion = double.Parse(Console.ReadLine());
            string nivel = "";
            switch (puntuacion)
            {
                case 0.0:
                    nivel = "INACEPTABLE"; break;
                case 0.4:
                    nivel = "ACEPTABLE"; break;
                case double n when (n >= 60): nivel = "MERITORIO"; break;
                default:
                    Console.WriteLine("Puntuación no válida"); break;
            }
            double cantidad_dinero = 2400 * puntuacion;
            Console.WriteLine("--RESULTADOS--");
            Console.WriteLine("Su puntuacion es: " + nivel);
            Console.WriteLine("Cantidad de dinero a recibir: " + cantidad_dinero);
            Console.WriteLine("--------------");

            // ejercicio 4
            Console.WriteLine("--PIZZERIA BELLA NAPOLI--");
            Console.WriteLine("Tipos de pizza:");
            Console.WriteLine("1: Vegetariana");
            Console.WriteLine("2: No Vegetariana");
            Console.WriteLine("Ingrese su tipo de pizza: ");
            int tipoPizza = int.Parse(Console.ReadLine());
            string nombrePizza = string.Empty;
            string ingredientesBase = string.Empty;
            string ingredientesExtra = "Mozzarella, Tomate";
            switch (tipoPizza)
            {
                case 1:
                    nombrePizza = "Vegetariana";
                    Console.WriteLine("Ingredientes vegetarianos disponibles: ");
                    Console.WriteLine("1: Pimiento");
                    Console.WriteLine("2: Tofu");
                    Console.Write("Elija un ingrediente: ");
                    int opcionVeg = int.Parse(Console.ReadLine());
                    switch (opcionVeg)
                    {
                        case 1: ingredientesBase = "Pimiento"; break;
                        case 2: ingredientesBase = "Tofu"; break;
                        default:
                            Console.WriteLine("Error!"); break;
                    }
                    break;
                case 2:
                    nombrePizza = "No vegetariana";
                    Console.WriteLine("Ingredientes no vegetarianos disponibles: ");
                    Console.WriteLine("1: Peperoni");
                    Console.WriteLine("2: Jamon");
                    Console.WriteLine("3: Salmon");
                    Console.Write("Elija un ingrediente: ");
                    int opcionNoVeg = int.Parse(Console.ReadLine());
                    switch (opcionNoVeg)
                    {
                        case 1: ingredientesBase = "Peperoni"; break;
                        case 2: ingredientesBase = "Jamon"; break;
                        case 3: ingredientesBase = "Salmon"; break;
                        default:
                            Console.WriteLine("Error!"); break;
                    }
                    break;
                default: Console.WriteLine("Error!"); break;
            }
            Console.WriteLine("\n--- Resumen de su pedido ---");
            Console.WriteLine("Tipo de pizza: " + nombrePizza);
            Console.WriteLine("Ingredientes: " + ingredientesBase + ", " + ingredientesExtra + ".");
        }
    }
}