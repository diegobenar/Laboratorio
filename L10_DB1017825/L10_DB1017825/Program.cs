using System;

class Program
{
    // Ejercicio 1
    static int SumaDigitos(int numero)
    {
        int suma = 0;
        numero = Math.Abs(numero); // Manejo de negativos por si acaso
        while (numero > 0)
        {
            suma += numero % 10; // Extrae el último dígito
            numero /= 10;        // Descarta el último dígito
        }
        return suma;
    }

    // Ejercicio 2
    static string ElevarAlCuadrado(ref int numero)
    {
        numero = numero * numero;
        return "Operación realizada: el número fue elevado al cuadrado.";
    }

    // Ejercicio 3
    static double AplicarDescuento(double porcentaje, ref double precio)
    {
        double montoDescontado = precio * porcentaje;
        precio -= montoDescontado;
        return montoDescontado;
    }

    // Ejercicio 4
    static int ConsumirEnergia(ref int energia)
    {
        energia -= 4;
        if (energia < 0) energia = 0;
        return energia;
    }

    static int RecargarEnergia(ref int energia)
    {
        energia += 6;
        if (energia > 20) energia = 20;
        return energia;
    }

    static string ObtenerEstado(int energia)
    {
        if (energia >= 15) return "Alta";
        if (energia >= 8) return "Media";
        return "Baja";
    }

    static string CalcularRendimiento(int energia)
    {
        if (energia == 20) return "S";
        if (energia >= 15) return "A";
        if (energia >= 8) return "B";
        return "C";
    }

    static void Main()
    {
        // Ejercicio 1
        Console.WriteLine("=== Ejercicio 1: Suma de dígitos ===");
        Console.Write("Ingresa un número entero positivo: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Suma de dígitos de {num1}: {SumaDigitos(num1)}");

        // Ejercicio 2
        Console.WriteLine("\n=== Ejercicio 2: Elevar al cuadrado (ref) ===");
        Console.Write("Ingresa un número entero: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"N antes: {n}");
        string resultado = ElevarAlCuadrado(ref n);
        Console.WriteLine($"N después: {n}");
        Console.WriteLine(resultado);

        // Ejercicio 3
        Console.WriteLine("\n=== Ejercicio 3: Descuento en tienda ===");
        Console.Write("Ingresa el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el porcentaje de descuento (ej. 0.25): ");
        double porcDescuento = double.Parse(Console.ReadLine());

        double precioOriginal = precio;
        double monto = AplicarDescuento(porcDescuento, ref precio);
        Console.WriteLine($"Precio original:  {precioOriginal}");
        Console.WriteLine($"Descuento:        {monto}");
        Console.WriteLine($"Precio final:     {precio}");

        // Ejercicio 4
        Console.WriteLine("\n=== Ejercicio 4: Sistema de energía del jugador ===");
        Console.Write("Ingresa la energía inicial del jugador (0-20): ");
        int energiaJugador = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nEnergía inicial: {energiaJugador}");
        Console.WriteLine($"Estado:          {ObtenerEstado(energiaJugador)}");
        Console.WriteLine($"Rendimiento:     {CalcularRendimiento(energiaJugador)}");

        Console.WriteLine("\n-- Consumiendo energía --");
        int e1 = ConsumirEnergia(ref energiaJugador);
        Console.WriteLine($"Tras consumir: {e1} | Estado: {ObtenerEstado(e1)} | Rendimiento: {CalcularRendimiento(e1)}");

        int e2 = ConsumirEnergia(ref energiaJugador);
        Console.WriteLine($"Tras consumir: {e2} | Estado: {ObtenerEstado(e2)} | Rendimiento: {CalcularRendimiento(e2)}");

        Console.WriteLine("\n-- Recargando energía --");
        int e3 = RecargarEnergia(ref energiaJugador);
        Console.WriteLine($"Tras recargar: {e3} | Estado: {ObtenerEstado(e3)} | Rendimiento: {CalcularRendimiento(e3)}");

        int e4 = RecargarEnergia(ref energiaJugador);
        Console.WriteLine($"Tras recargar: {e4} | Estado: {ObtenerEstado(e4)} | Rendimiento: {CalcularRendimiento(e4)}");
    }
}