using System;

class Pelicula
{
    public string Titulo { get; set; }
    public int AnioLanzamiento { get; set; }
    public double Calificacion { get; private set; }

    public Pelicula(string titulo, int anioLanzamiento)
    {
        Titulo = titulo;
        AnioLanzamiento = anioLanzamiento;
        Calificacion = 0; // Inicializamos la calificación en 0.
    }

    public void Calificar(int calificacion)
    {
        if (calificacion >= 1 && calificacion <= 5)
        {
            Calificacion = calificacion;
        }
        else
        {
            Console.WriteLine("La calificación debe estar en el rango de 1 a 5.");
        }
    }
}
class Program
{
    static void Main()
    {
        Pelicula pelicula1 = new Pelicula("Talk to me", 2023);
        pelicula1.Calificar(5); // Calificamos la película con un 4.

        Pelicula pelicula2 = new Pelicula("Barbie", 2023);
        pelicula2.Calificar(4); // Calificamos la película con un 5.

        Console.WriteLine($"Pelicula 1: {pelicula1.Titulo} ({pelicula1.AnioLanzamiento}), Calificación: {pelicula1.Calificacion}");
        Console.WriteLine($"Pelicula 2: {pelicula2.Titulo} ({pelicula2.AnioLanzamiento}), Calificación: {pelicula2.Calificacion}");
    }
}
