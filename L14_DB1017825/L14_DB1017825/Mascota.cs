using System;
using System.Collections.Generic;
using System.Text;

namespace L14_DB1017825
{
    public class Mascota
    {
        public string nombre;
        public string especie;
        public int edad;
        public bool vacunado;


        public Mascota(string nom, string espec, int eda, bool vacu)
        {
            this.nombre = nom;
            this.especie = espec;
            this.edad = eda;
            this.vacunado = vacu;
        }

        public void mostrarInfo ()
        {
            Console.WriteLine("\n=== INFORMACION DE LA MASCOTA ===");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Edad: " + edad + " años");
            Console.WriteLine("Vacunado: " +vacunado);
            Console.WriteLine("==================================");

        }
        public void vacunar()
        {
            if (vacunado == true)
            {
                Console.WriteLine(nombre + " ya esta vacunado");
            }
            else
            {
                vacunado = true;
                Console.WriteLine(nombre + " ha sido vacunad@");
            }
         
        }
        public void cumplirAnios()
        {
            edad++;
            Console.WriteLine(nombre + " ahora tiene " + edad + " anios");
        }
    }
}
