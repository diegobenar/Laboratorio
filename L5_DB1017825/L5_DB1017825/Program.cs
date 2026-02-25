using System;
    namespace lab_5
{
    class Program
    {
        static void Main()
        {
            int ID;
            int PIN;
            int Token;
            bool modo_seguro = true;

            // ejercicio 1

            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese su ID: ");
            string? idInput = Console.ReadLine();
            if (!int.TryParse(idInput, out ID))
            {
                Console.WriteLine("ID inválido.");
                return;
            }
            if (ID == 2026)
            {
                Console.WriteLine("Usuario reconocido");
            }
            else
            {
                Console.WriteLine("Usuario no reconocido");
            }

            Console.Write("Ingrese su PIN: ");
            string? pinInput = Console.ReadLine();
            if (!int.TryParse(pinInput, out PIN))
            {
                Console.WriteLine("PIN inválido.");
                return;
            }
            if (PIN == 1234)
            {
                Console.WriteLine("PIN correcto");
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            Console.Write("Ingrese su token: ");
            string? tokenInput = Console.ReadLine();
            if (!int.TryParse(tokenInput, out Token))
            {
                Console.WriteLine("Token inválido.");
                return;
            }
            if (Token == 777)
            {
                Console.WriteLine("Token válido");
            }
            else
            {
                Console.WriteLine("Token inválido");
            }

            Console.Write("Modo seguro: ");
            string? modoInput = Console.ReadLine()?.Trim();
            if (modoInput == "1")
            {
                modo_seguro = true;
            }
            else if (modoInput == "0")
            {
                modo_seguro = false;
            }
            else if (!bool.TryParse(modoInput, out modo_seguro))
            {
                Console.WriteLine("Entrada inválida para modo seguro. Use true/false o 1/0.");
                return;
            }
            if (modo_seguro == true)
            {
                Console.WriteLine("Modo seguro activado: se aplican reglas extra");
            }
            else
            {
                Console.WriteLine("Modo seguro desactivado");
            }

            // ejercicio 2

            Console.WriteLine("\n--- Ejercicio 2 ---");
            Console.Write("Ingrese su PIN: ");
            string? pin2Input = Console.ReadLine();
            if (!int.TryParse(pin2Input, out int pin2))
            {
                Console.WriteLine("PIN inválido.");
                return;
            }

            if (pin2 >= 1000 && pin2 <= 9999)
            {
                Console.WriteLine("PIN de 4 dígitos: OK.");
            }
            else
            {
                Console.WriteLine("PIN inválido: debe tener 4 dígitos.");
            }

            if (pin2 % 2 == 0)
            {
                Console.WriteLine("PIN par.");
            }
            else
            {
                Console.WriteLine("PIN impar.");
            }

            if (pin2 % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 5.");
            }
            else
            {
                Console.WriteLine("No es múltiplo de 5.");
            }

            if ((pin2 >= 1000 && pin2 <= 9999) && (pin2 % 2 == 0) && (pin2 % 5 != 0))
            {
                Console.WriteLine("PIN aceptado por política.");
            }
            else
            {
                Console.WriteLine("PIN rechazado por política.");
            }

            // ejercicio 3
            Console.WriteLine("\n--- Ejercicio 3 ---");
            Console.Write("Código de activación: ");
            string? codigoInput = Console.ReadLine();
            if (!int.TryParse(codigoInput, out int codigo))
            {
                Console.WriteLine("Código inválido.");
                return;
            }
            Console.Write("Edad: ");
            string? edadInput = Console.ReadLine();
            if (!int.TryParse(edadInput, out int edad))
            {
                Console.WriteLine("Edad inválida.");
                return;
            }
            Console.Write("¿Aceptó términos? (1/0): ");
            string? terminosInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(terminosInput, out int terminos) || (terminos != 0 && terminos != 1))
            {
                Console.WriteLine("Entrada inválida para términos. Use 1 o 0.");
                return;
            }
            Console.Write("¿2FA activado? (1/0): ");
            string? fa2Input = Console.ReadLine()?.Trim();
            if (!int.TryParse(fa2Input, out int fa2) || (fa2 != 0 && fa2 != 1))
            {
                Console.WriteLine("Entrada inválida para 2FA. Use 1 o 0.");
                return;
            }
            Console.Write("Puntaje (0-100): ");
            string? puntajeInput = Console.ReadLine();
            if (!int.TryParse(puntajeInput, out int puntaje))
            {
                Console.WriteLine("Puntaje inválido.");
                return;
            }

            if (codigo == 2026) Console.WriteLine("Código correcto.");
            else Console.WriteLine("Código incorrecto.");

            if (edad >= 18) Console.WriteLine("Edad válida.");
            else Console.WriteLine("Edad no válida.");

            if (terminos == 1) Console.WriteLine("Términos aceptados.");
            else Console.WriteLine("Debe aceptar términos.");

            if (fa2 == 1) Console.WriteLine("2FA activado.");
            else Console.WriteLine("2FA no activado.");

            if (puntaje >= 70) Console.WriteLine("Puntaje suficiente.");
            else Console.WriteLine("Puntaje insuficiente.");

            if (codigo == 2026 && edad >= 18 && terminos == 1 && fa2 == 1 && puntaje >= 70)
            {
                Console.WriteLine("Cuenta activada exitosamente.");
            }
            else
            {
                Console.WriteLine("Cuenta NO activada.");
            }




        }


    }


}