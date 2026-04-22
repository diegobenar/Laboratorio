using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Bienvenido, " + nombre);
        Console.WriteLine();

        // Ejercicio 1
        Console.WriteLine("=== Ejercicio 1: Validación de contraseña ===");
        Console.Write("Ingrese una contraseña: ");
        string password = Console.ReadLine();

        bool tieneMinimo8 = password.Length >= 8;
        bool tieneMayuscula = false;
        bool tieneNumero = false;
        bool tieneEspecial = false;
        string especiales = "@#$%!&*";

        foreach (char c in password)
        {
            if (char.IsUpper(c)) tieneMayuscula = true;
            if (char.IsDigit(c)) tieneNumero = true;
            if (especiales.IndexOf(c) >= 0) tieneEspecial = true;
        }

        if (tieneMinimo8 && tieneMayuscula && tieneNumero && tieneEspecial)
        {
            Console.WriteLine("Contraseña válida");
        }
        else
        {
            Console.Write("Inválida: ");
            if (!tieneMinimo8) Console.WriteLine("falta longitud mínima de 8 caracteres");
            if (!tieneMayuscula) Console.WriteLine("falta mayúscula");
            if (!tieneNumero) Console.WriteLine("falta número");
            if (!tieneEspecial) Console.WriteLine("falta carácter especial");
        }

        Console.WriteLine();

        // Ejercicio 2
        Console.WriteLine("=== Ejercicio 2: Invertir texto ===");
        Console.Write("Ingrese una cadena: ");
        string texto = Console.ReadLine();

        string invertida = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertida += texto[i];
        }

        Console.WriteLine("Texto invertido: " + invertida);
        Console.WriteLine();

        // Ejercicio 3
        Console.WriteLine("=== Ejercicio 3: Suma y promedio ===");
        Console.Write("¿Cuántos números desea ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        double[] numeros = new double[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número [{i + 1}]: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        double suma = 0;
        double mayor = numeros[0];
        double menor = numeros[0];

        foreach (double n in numeros)
        {
            suma += n;
            if (n > mayor) mayor = n;
            if (n < menor) menor = n;
        }

        double promedio = suma / cantidad;

        Console.WriteLine($"Suma     = {suma}");
        Console.WriteLine($"Promedio = {promedio}");
        Console.WriteLine($"Mayor    = {mayor}");
        Console.WriteLine($"Menor    = {menor}");
        Console.WriteLine();

        // Ejercicio 4
        Console.WriteLine("=== Ejercicio 4: Buscar un número ===");
        int[] arreglo = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Ingrese el número [{i + 1}]: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a buscar: ");
        int buscar = int.Parse(Console.ReadLine());

        bool encontrado = false;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == buscar)
            {
                Console.WriteLine($"El número sí existe en la posición {i + 1}");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("El número no existe en el arreglo");
        }

        Console.WriteLine();

        // Ejercicio 5
        Console.WriteLine("=== Ejercicio 5: Nombres en arreglo ===");
        string[] nombres = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese el nombre [{i + 1}]: ");
            nombres[i] = Console.ReadLine();
        }

        int masde5letras = 0;
        string masLargo = nombres[0];

        foreach (string n in nombres)
        {
            if (n.Length > 5) masde5letras++;
            if (n.Length > masLargo.Length) masLargo = n;
        }

        Console.Write("Nombres ingresados: ");
        Console.WriteLine(string.Join(", ", nombres));
        Console.WriteLine($"Más de 5 letras: {masde5letras}");
        Console.WriteLine($"Nombre más largo: {masLargo}");
    }
}