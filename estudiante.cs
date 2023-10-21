class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Curso { get; set; }

    public Estudiante(string nombre, int edad, string curso)
    {
        Nombre = nombre;
        Edad = edad;
        Curso = curso;
    }
}

class Program
{
    static void Main()
    {
        // Crear varios objetos Estudiante
        Estudiante estudiante1 = new Estudiante("Juan", 20, "Matemáticas");
        Estudiante estudiante2 = new Estudiante("María", 22, "Historia");
        Estudiante estudiante3 = new Estudiante("Pedro", 19, "Biología");

        // Acceder a las propiedades de los objetos
        Console.WriteLine("Estudiante 1: Nombre - " + estudiante1.Nombre + ", Edad - " + estudiante1.Edad + ", Curso - " + estudiante1.Curso);
        Console.WriteLine("Estudiante 2: Nombre - " + estudiante2.Nombre + ", Edad - " + estudiante2.Edad + ", Curso - " + 
                          estudiante2.Curso);
        Console.WriteLine("Estudiante 3: Nombre - " + estudiante3.Nombre + ", Edad - " + estudiante3.Edad + ", Curso - " + estudiante3.Curso);
    }
}
