using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1
        Console.WriteLine("--- Ejercicio 1 ---");
        Console.WriteLine("Identificación y corrección de errores de sintaxis\n");

        // Error encontrado: Falta punto y coma después de "using System"
        // Tipo de error: sintaxis
        // Corrección realizada: Se añadió el punto y coma → using System;
        // Explicación: Cada directiva using requiere punto y coma al final.

        // Error encontrado: Falta punto y coma en la declaración de 'nombre'
        // Tipo de error: sintaxis
        // Corrección realizada: string nombre; (con punto y coma)
        // Explicación: Toda declaración de variable en C# termina con punto y coma.

        // Error encontrado: Falta punto y coma al final de int.Parse(Console.ReadLine())
        // Tipo de error: sintaxis
        // Corrección realizada: Se añadió el punto y coma al final de la asignación de 'edad'
        // Explicación: La instrucción de asignación es una statement y debe terminar con ;

        // Error encontrado: Falta llave de cierre del bloque if antes del else
        // Tipo de error: sintaxis
        // Corrección realizada: Se añadió '}' para cerrar el bloque if antes del else
        // Explicación: En C#, cada bloque if necesita su propio par de llaves {}.

        string nombre;
        int edad;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }

        // Prueba con edad 20 → "Eres mayor de edad"
        // Prueba con edad 15 → "Eres menor de edad"

        // Ejercicio 2
        Console.WriteLine("\n--- Ejercicio 2 ---");
        Console.WriteLine("Corrección de errores lógicos\n");

        // Error encontrado: La fórmula del promedio no usa paréntesis
        // Tipo de error: lógico
        // Corrección realizada: promedio = (nota1 + nota2 + nota3) / 3;
        // Explicación: Sin paréntesis, la precedencia de operadores hace que
        //              solo nota3 se divida entre 3. Con paréntesis, la suma
        //              total se divide correctamente. Por eso compilaba bien
        //              pero daba resultados incorrectos.

        // Error encontrado: Condición usa '>' en vez de '>='
        // Tipo de error: lógico
        // Corrección realizada: if (promedio >= 61)
        // Explicación: Con '>' un promedio exacto de 61 reprobaba, lo cual es
        //              incorrecto según la regla del enunciado (>= 61 aprueba).

        double nota1, nota2, nota3, promedio;

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 61)
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }

        // Caso 60,60,60 → promedio 60 → Reprobó 
        // Caso 61,61,61 → promedio 61 → Aprobó
        // Caso 80,70,90 → promedio 80 → Aprobó 

        // Ejercicio 3
        Console.WriteLine("\n--- Ejercicio 3 ---");
        Console.WriteLine("Identificación de errores de ejecución en arreglos\n");

        // Error encontrado: El ciclo usa i <= 5, lo que intenta acceder a numeros[5]
        // Tipo de error: ejecución (IndexOutOfRangeException)
        // Corrección realizada: Se cambió i <= 5 por i < 5 en ambos ciclos
        // Explicación: Un arreglo int[5] tiene índices válidos 0, 1, 2, 3 y 4.
        //              El índice 5 no existe. Al intentar acceder a él el runtime
        //              lanza IndexOutOfRangeException y el programa termina abruptamente.

        int[] numeros = new int[5];
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            bool valido = false;
            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");
                if (int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            suma = suma + numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);

        // Prueba: 1,2,3,4,5 → suma = 15 
        // Prueba: texto → pide de nuevo sin cerrarse 

        // Ejercicio 4
        Console.WriteLine("\n--- Ejercicio 4 ---");
        Console.WriteLine("Depuración de programa con métodos\n");

        // Error encontrado: CalcularArea suma en vez de multiplicar
        // Tipo de error: lógico
        // Corrección realizada: resultado = baseRectangulo * alturaRectangulo
        // Explicación: El área de un rectángulo es base × altura, no base + altura.

        // Error encontrado: Condición usa '>' en vez de '>='
        // Tipo de error: lógico
        // Corrección realizada: if (area >= 100)
        // Explicación: Un área de exactamente 100 debe clasificar como grande según el enunciado.

        double baseRectangulo = 0;
        double alturaRectangulo = 0;
        bool baseValida = false;
        bool alturaValida = false;

        while (!baseValida)
        {
            Console.WriteLine("Ingrese la base del rectángulo:");
            if (double.TryParse(Console.ReadLine(), out baseRectangulo) && baseRectangulo > 0)
            {
                baseValida = true;
            }
            else
            {
                Console.WriteLine("Valor inválido. La base debe ser un número mayor que cero.");
            }
        }

        while (!alturaValida)
        {
            Console.WriteLine("Ingrese la altura del rectángulo:");
            if (double.TryParse(Console.ReadLine(), out alturaRectangulo) && alturaRectangulo > 0)
            {
                alturaValida = true;
            }
            else
            {
                Console.WriteLine("Valor inválido. La altura debe ser un número mayor que cero.");
            }
        }

        double area = CalcularArea(baseRectangulo, alturaRectangulo);

        // Mensaje de depuración: verifica los valores antes de clasificar
        Console.WriteLine("[Debug] Base: " + baseRectangulo + " | Altura: " + alturaRectangulo + " | Área: " + area);

        Console.WriteLine("El área es: " + area);

        if (area >= 100)
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }

        // Prueba 10,10 → área 100 → Grande 
        // Prueba 5,8  → área 40  → Pequeña 
        // Prueba 20,6 → área 120 → Grande 
        // Prueba -5,8 → rechazado, pide valor válido 

        //Ejercicio 5
        Console.WriteLine("\n--- Ejercicio 5 ---");
        Console.WriteLine("Análisis de solución generada por IA\n");

        // Análisis de la solución generada por IA:
        //
        // Error 1: El ciclo inicia en i = 1 y llega hasta i = 5, lo que intenta
        //          acceder a edades[5] que no existe en un arreglo de tamaño 5.
        //          Esto produce IndexOutOfRangeException al intentar guardar la
        //          primera edad en edades[1] cuando debería ser edades[0]
        //
        // Error 2: La condición para contar mayores usa '>' en vez de '>=',
        //          por lo que una persona con exactamente 18 años no se cuenta
        //          como mayor de edad, lo cual es incorrecto legalmente
        //
        // Error 3: El promedio se calcula como suma / 5 donde ambos son int,
        //          por lo que la división entera trunca los decimales.
        //          Ejemplo: edades 10,15,18,20,30 → suma=93 → 93/5=18 (entero)
        //          cuando el promedio real es 18.6
        //
        // Limitación encontrada: El programa no valida si la entrada es numérica
        //          ni si la edad es un valor lógico (negativo). Si el usuario
        //          escribe texto, int.Parse lanza una excepción y el programa termina
        //
        // Importancia de la validación humana:
        //          La IA produce código que parece correcto visualmente pero puede
        //          contener errores sutiles de índices, precedencia, tipos y lógica
        //          de negocio. Sin revisión humana, estos errores llegan a producción

        int[] edades = new int[5];
        int sumaEdades = 0;
        int mayores = 0;
        double promedioEdades;

        for (int i = 0; i < 5; i++)
        {
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");
                if (int.TryParse(Console.ReadLine(), out edades[i]) && edades[i] >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Ingrese un número entero no negativo.");
                }
            }

            sumaEdades = sumaEdades + edades[i];

            if (edades[i] >= 18)
            {
                mayores++;
            }
        }

        promedioEdades = (double)sumaEdades / 5;

        Console.WriteLine("El promedio de edades es: " + promedioEdades);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

        // Prueba 10,15,18,20,30 promedio 18.6, mayores 3 
        // Prueba 18,18,18,18,18 promedio 18.0, mayores 5 
        // Prueba 5,6,7,8,9     promedio 7.0,  mayores 0 
        // Texto o negativo     rechazado, pide de nuevo 

        // Reflexión
        // Por qué una solución generada por IA debe ser revisada y validada por una persona?
        // Porque la IA genera código basado en patrones estadísticos, no en comprensión
        // real del problema. Puede producir código que compile sin errores pero que tenga
        // fallos lógicos sutiles, como índices incorrectos o condiciones mal planteadas,
        // que solo se detectan probando con datos reales
        //
        // Además la ia desconoce el contexto específico del sistema donde
        // se va a ejecutar el código. Una condición como '>=' vs '>' puede parecer menor
        // pero tiene consecuencias concretas, en este laboratorio, significaría que una
        // persona de 18 años no se contaría como mayor de eda lo cual es incorrecto
        //
        // La ia tampoco garantiza manejo de casos como: entradas inválidas, valores
        // negativos, desbordamientos o situaciones que un usuario real sí puede provocar
        //
        // Por eso el programador sigue siendo responsable, la ia es una herramienta que
        // acelera la escritura de código, pero la validación, las pruebas y el criterio
        // para determinar si el resultado es correcto siempre deben ser humanos
    }

    // CORRECCIÓN del método CalcularArea:
    // Error encontrado: usaba suma (baseRectangulo + alturaRectangulo) en vez de producto
    // Tipo de error: lógico
    // Corrección realizada: resultado = baseRectangulo * alturaRectangulo
    // Explicación: Área de rectángulo = base × altura. La suma no tiene sentido geométrico
    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        double resultado = baseRectangulo * alturaRectangulo;
        return resultado;
    }
}