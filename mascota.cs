using System;

namespace ClaseMascota
{
    class Mascota
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Edad { get; set; }

        public Mascota(string nombre, string tipo, int edad)
        {
            Nombre = nombre;
            Tipo = tipo;
            Edad = edad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota("Luna", "Perro", 2);
            Mascota mascota2 = new Mascota("Simba", "Gato", 4);
            Mascota mascota3 = new Mascota("Nemo", "Pez", 1);

            Console.WriteLine("Mascota 1 - Nombre: " + mascota1.Nombre + " Tipo: " + mascota1.Tipo + " Edad: " + mascota1.Edad + " años");
            Console.WriteLine("Mascota 2 - Nombre: " + mascota2.Nombre + " Tipo: " + mascota2.Tipo + " Edad: " + mascota2.Edad + " años");
            Console.WriteLine("Mascota 3 - Nombre: " + mascota3.Nombre + " Tipo: " + mascota3.Tipo + " Edad: " + mascota3.Edad + " años");
        }
    }
}


