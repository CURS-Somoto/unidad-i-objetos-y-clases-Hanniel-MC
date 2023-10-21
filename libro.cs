using System;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }
}

class Program
{
    static void Main()
    {
        Libro libro1 = new Libro("El Principito", "Antoine de Saint-Exupéry");
        Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez");

        Console.WriteLine("Información del Libro 1:");
        libro1.MostrarInformacion();

        Console.WriteLine("\nInformación del Libro 2:");
        libro2.MostrarInformacion();
    }
}
