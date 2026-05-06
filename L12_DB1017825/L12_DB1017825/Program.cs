using System;

class Program
{
    static void LlenarMatriz(int[,] m)
    {
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"  m[{i}][{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaFila(int[,] m, int fila)
    {
        int suma = 0;
        for (int j = 0; j < 4; j++)
            suma += m[fila, j];
        return suma;
    }

    static int SumaColumna(int[,] m, int col)
    {
        int suma = 0;
        for (int i = 0; i < 4; i++)
            suma += m[i, col];
        return suma;
    }

    static void CargarMatriz(float[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"  m[{i}][{j}]: ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
    }

    static float MayorMatriz(float[,] m)
    {
        float mayor = m[0, 0];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 5; j++)
                if (m[i, j] > mayor) mayor = m[i, j];
        return mayor;
    }

    static void LlenarMatrizA(int[,] m)
    {
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"  A[{i}][{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static void LlenarMatrizB(int[,] m)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"  B[{i}][{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static void Multiplicar(int[,] A, int[,] B, int[,] R)
    {
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                R[i, j] = 0;
                for (int k = 0; k < 3; k++)
                    R[i, j] += A[i, k] * B[k, j];
            }
    }

    static void Llenar(int[,] m)
    {
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"  m[{i}][{j}]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
    }

    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, i];
        return suma;
    }

    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
            suma += m[i, 4 - i];
        return suma;
    }

    static void Main()
    {
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!\n");

        Console.WriteLine("Ejercicio 1");
        int[,] mat1 = new int[4, 4];
        LlenarMatriz(mat1);

        Console.Write("¿Qué fila desea sumar? (0-3): ");
        int fila = int.Parse(Console.ReadLine());
        Console.Write("¿Qué columna desea sumar? (0-3): ");
        int col = int.Parse(Console.ReadLine());

        Console.WriteLine($"Suma de la fila {fila}    = {SumaFila(mat1, fila)}");
        Console.WriteLine($"Suma de la columna {col} = {SumaColumna(mat1, col)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2");
        float[,] mat2 = new float[3, 5];
        CargarMatriz(mat2);
        Console.WriteLine($"Valor mayor de la matriz: {MayorMatriz(mat2)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 3");
        int[,] A = new int[2, 3];
        int[,] B = new int[3, 2];
        int[,] R = new int[2, 2];

        Console.WriteLine("Ingrese valores de A:");
        LlenarMatrizA(A);
        Console.WriteLine("Ingrese valores de B:");
        LlenarMatrizB(B);

        Multiplicar(A, B, R);

        Console.WriteLine("Matriz resultante R (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write($"{R[i, j],6}");
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 4");
        int[,] mat4 = new int[5, 5];
        Llenar(mat4);

        Console.WriteLine($"Suma diagonal principal  = {SumaDiagonalPrincipal(mat4)}");
        Console.WriteLine($"Suma diagonal secundaria = {SumaDiagonalSecundaria(mat4)}");
    }
}