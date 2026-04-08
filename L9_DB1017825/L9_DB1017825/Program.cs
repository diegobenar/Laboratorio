using System;

class Program
{
    // ejercicio 1
    static void MostrarSaludo(string nombre)
    {
        Console.WriteLine($"¡Hola, {nombre}! Bienvenido.");
    }

    static void MostrarInfoCurso()
    {
        Console.WriteLine("Curso: Diseño de Algoritmos y Lenguajes de Programación");
        Console.WriteLine("Laboratorio: 9");
    }

    // ejercicio 2
    static void AreaCuadrado(double lado)
    {
        Console.WriteLine($"Área del cuadrado: {lado * lado}");
    }

    static void AreaRectangulo(double base_, double altura)
    {
        Console.WriteLine($"Área del rectángulo: {base_ * altura}");
    }

    static void AreaTriangulo(double base_, double altura)
    {
        Console.WriteLine($"Área del triángulo: {(base_ * altura) / 2}");
    }

    // ejercicio 3
    static void DibujarCuadrado(int n)
    {
        for (int i = 0; i < n; i++)
            Console.WriteLine(new string('*', n));
    }

    static void DibujarTriangulo(int n)
    {
        for (int i = 1; i <= n; i++)
            Console.WriteLine(new string('*', i));
    }

    static void DibujarLinea(int n)
    {
        Console.WriteLine(new string('*', n));
    }

    // ejercicio 4
    static void EvaluarNota(double nota, ref int aprobados, ref int reprobados)
    {
        if (nota >= 61)
        {
            Console.WriteLine($"Nota {nota}: APROBADO");
            aprobados++;
        }
        else
        {
            Console.WriteLine($"Nota {nota}: REPROBADO");
            reprobados++;
        }
    }

    static void MostrarResumen(double promedio, int aprobados, int reprobados)
    {
        Console.WriteLine($"\nPromedio: {promedio:F2}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
    }

    // ejercicio 5
    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        // ejercicio 1
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        MostrarSaludo(nombre);
        MostrarInfoCurso();

        // ejercicio 2
        Console.WriteLine("\n--- Áreas ---");
        Console.Write("Lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());
        AreaCuadrado(lado);

        Console.Write("Base del rectángulo: ");
        double baseR = double.Parse(Console.ReadLine());
        Console.Write("Altura del rectángulo: ");
        double altR = double.Parse(Console.ReadLine());
        AreaRectangulo(baseR, altR);

        Console.Write("Base del triángulo: ");
        double baseT = double.Parse(Console.ReadLine());
        Console.Write("Altura del triángulo: ");
        double altT = double.Parse(Console.ReadLine());
        AreaTriangulo(baseT, altT);

        // ejercicio 3
        Console.WriteLine("\n--- Menú de Figuras ---");
        int opcion;
        do
        {
            Console.WriteLine("1. Cuadrado  2. Triángulo  3. Línea  4. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion != 4)
            {
                Console.Write("Ingresa N: ");
                int n = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: DibujarCuadrado(n); break;
                    case 2: DibujarTriangulo(n); break;
                    case 3: DibujarLinea(n); break;
                }
            }
        } while (opcion != 4);

        // ejercicio 4
        Console.WriteLine("\n--- Registro de Notas ---");
        int aprobados = 0, reprobados = 0;
        double suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Nota estudiante {i}: ");
            double nota = double.Parse(Console.ReadLine());
            suma += nota;
            EvaluarNota(nota, ref aprobados, ref reprobados);
        }
        MostrarResumen(suma / 5, aprobados, reprobados);

        // ejercicio 5
        Console.WriteLine("\n--- Intercambio de Valores ---");
        Console.Write("Primer número: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Antes: {x}, {y}");
        Intercambiar(ref x, ref y);
        Console.WriteLine($"Después: {x}, {y}");
    }
}