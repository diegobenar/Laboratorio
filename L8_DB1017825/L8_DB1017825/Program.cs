using System;
class Program
{
    static void Main()
    {
        int contador = 1;
        int aprobado = 0;
        int desaprobado = 0;
        double sumaNotas = 0;
        double notaActual;

        while (contador <= 10)
        {
            Console.Write("Ingrese la nota del estudiante " + contador + ": ");
            notaActual = double.Parse(Console.ReadLine());
          

            if (notaActual < 0 || notaActual > 100)
            {
                Console.WriteLine("Nota inválida. Ingrese un valor entre 0 y 100.");
                continue;
            }

            if (notaActual >= 61)
            {
                aprobado++;
            }

            else
            {
                desaprobado++;
            }
            sumaNotas += notaActual;
            contador++;
        }

        double promedioClase = sumaNotas / 10;
        Console.WriteLine("Cantidad de aprobados: " + aprobado);
        Console.WriteLine("Cantidad de desaprobados: " + desaprobado);
        Console.WriteLine("Promedio de la clase: " + promedioClase);

        // ejercicio 2
        Console.WriteLine("--- Ejercicio 2: Rango 1 a N ---");
        Console.Write("Ingrese un número entero positivo: ");
        int numeroLimite = int.Parse(Console.ReadLine());

        int sumaRango = 0;
        int pares = 0;
        int impares = 0;

        for (int j = 1; j <= numeroLimite; j++)
        {
            sumaRango += j;

            if (j % 2 == 0) { pares++; }
            else { impares++; }
        }

        Console.WriteLine("Suma total del 1 al " + numeroLimite + ": " + sumaRango);
        Console.WriteLine("Números pares encontrados: " + pares);
        Console.WriteLine("Números impares encontrados: " + impares);

        // ejercicio 3
        double totalVentas = 0;
        int clientesAtendidos = 0;
        int opcionTienda;

        do
        {
            Console.WriteLine("--- SISTEMA DE VENTAS ---");
            Console.WriteLine("1. Registrar compra");
            Console.WriteLine("2. Mostrar total de ventas");
            Console.WriteLine("3. Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcionTienda = int.Parse(Console.ReadLine());

            switch (opcionTienda)
            {
                case 1:
                    Console.Write("Ingrese el monto de la compra: ");
                    double monto = double.Parse(Console.ReadLine());
                    totalVentas += monto;
                    clientesAtendidos++;
                    Console.WriteLine("Compra registrada con éxito.");
                    break;

                case 2:
                    Console.WriteLine("Total acumulado de ventas: Q" + Math.Round(totalVentas, 2));
                    break;

                case 3:
                    Console.WriteLine("Clientes atendidos hoy: " + clientesAtendidos);
                    break;

                case 4:
                    Console.WriteLine("Cerrando sistema de ventas...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

        } while (opcionTienda != 4);

        // ejercicio 4
        int totalIngresados = 0;
        int positivos = 0;
        int negativos = 0;
        double sumaNumeros = 0;
        double numero;

        Console.WriteLine("--- ANALIZADOR DE NÚMEROS (Ingrese 0 para terminar) ---");

        do
        {
            Console.Write("Ingrese un número: ");
            numero = double.Parse(Console.ReadLine());

            if (numero != 0)
            {
                totalIngresados++;
                sumaNumeros += numero;

                if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }

        } while (numero != 0);

        Console.WriteLine("--- RESULTADOS ---");
        Console.WriteLine("Total de números ingresados: " + totalIngresados);
        Console.WriteLine("Números positivos: " + positivos);
        Console.WriteLine("Números negativos: " + negativos);
        Console.WriteLine("Suma total: " + sumaNumeros);

        // ejercicio 5
        Console.WriteLine("--- GENERADOR DE FIGURA ---");
        Console.Write("Ingrese un número N para la altura de la figura: ");
        int nFigura = int.Parse(Console.ReadLine());

        for (int fila = 1; fila <= nFigura; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write(columna);
            }

            Console.WriteLine();
        }
    }
}
