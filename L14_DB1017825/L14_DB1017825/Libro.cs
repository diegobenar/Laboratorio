using System;
using System.Collections.Generic;
using System.Text;

namespace L14_DB1017825
{
    public class Libro
    {
        public string titulo;
        public string autor;
        public int anioPublicacion;
        public bool disponible;

        public Libro(string txtTitulo, string txtAutor, int numAnio, bool estaDisponible)
        {
            this.titulo = txtTitulo;
            this.autor = txtAutor;
            this.anioPublicacion = numAnio;
            this.disponible = estaDisponible;
        }
        public void MostrarInfo()
        {
            Console.WriteLine("\n=== INFORMACION DEL LIBRO ===");
            Console.WriteLine("Titulo " + titulo);
            Console.WriteLine("Autor " + autor);
            Console.WriteLine("Anio de publicacion " + anioPublicacion);
            Console.WriteLine("Disponible " + disponible);
            Console.WriteLine("==============================");
        }
        public void prestarLibro()
        {
            if (disponible == true)
            {
                disponible = false;
                Console.WriteLine("El libro" + titulo + " ha sido prestado");
            }
            else
            {
                Console.WriteLine("El libro ya esta prestado");
            }
        }
        public void devolverLibro ()
        {
            disponible = true;
            Console.WriteLine("El libro ha sido devuelto con exito");
        }
    }
}
