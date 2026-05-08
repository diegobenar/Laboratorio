using System;

class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;

    public void MostrarInfo()
    {
        Console.WriteLine("── Persona ──────────────────");
        Console.WriteLine("Nombre:      " + nombre);
        Console.WriteLine("Edad:        " + edad);
        Console.WriteLine("Altura:      " + altura + " m");
        Console.WriteLine("Estudiante:  " + (estudiante ? "Sí" : "No"));
    }
}

class Vehiculo
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;

    public void MostrarInfo()
    {
        Console.WriteLine("── Vehículo ─────────────────");
        Console.WriteLine("Marca:   " + marca);
        Console.WriteLine("Modelo:  " + modelo);
        Console.WriteLine("Año:     " + anio);
        Console.WriteLine("Color:   " + color);
        Console.WriteLine("Placa:   " + placa);
    }
}

class Producto
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;

    public void MostrarInfo()
    {
        Console.WriteLine("── Producto ─────────────────");
        Console.WriteLine("Código:      " + codigo);
        Console.WriteLine("Nombre:      " + nombre);
        Console.WriteLine("Precio:      " + precio);
        Console.WriteLine("Stock:       " + stock + " unidades");
        Console.WriteLine("Disponible:  " + (disponible ? "Sí" : "No"));
    }
}

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;

    public void MostrarInfo()
    {
        Console.WriteLine("── Mascota ──────────────────");
        Console.WriteLine("Nombre:    " + nombre);
        Console.WriteLine("Especie:   " + especie);
        Console.WriteLine("Edad:      " + edad + " años");
        Console.WriteLine("Peso:      " + peso + " kg");
        Console.WriteLine("Vacunado:  " + (vacunado ? "Sí" : "No"));
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1");
        Persona p1 = new Persona();
        p1.nombre = "Diego";
        p1.edad = 20;
        p1.altura = 1.70;
        p1.estudiante = true;
        p1.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2");
        Vehiculo v1 = new Vehiculo();
        v1.marca = "BYD";
        v1.modelo = "Seagull";
        v1.anio = 2025;
        v1.color = "Negro";
        v1.placa = "P-893FFM";
        v1.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 3");

        Producto prod1 = new Producto();
        prod1.codigo = "PROD-123";
        prod1.nombre = "Audífonos Bluetooth";
        prod1.precio = 599.99;
        prod1.stock = 15;
        prod1.disponible = true;
        prod1.MostrarInfo();
        Console.WriteLine();

        Producto prod2 = new Producto();
        prod2.codigo = "PROD-321";
        prod2.nombre = "Teclado Mecánico";
        prod2.precio = 799.50;
        prod2.stock = 0;
        prod2.disponible = false;
        prod2.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 4");
        Mascota m1 = new Mascota();
        m1.nombre = "Leo";
        m1.especie = "Gato";
        m1.edad = 1;
        m1.peso = 12.5;
        m1.vacunado = true;
        m1.MostrarInfo();
    }
}