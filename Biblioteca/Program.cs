using System;
using System.Runtime.CompilerServices;

namespace Colecciones
{
    internal class test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibros(10);
            cargarLibros(2);
            biblioteca.ListarLibros();
            biblioteca.EliminarLibro("Libro5");
            biblioteca.ListarLibros();
            void cargarLibros(int cantidad)
            {
                bool pude;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.AgregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                        Console.WriteLine("libro" + i + "Agregado correctamente");
                    else
                        Console.WriteLine("libro" + i + "Ya existe en biblioteca");
                }

            }
        }
    }
}