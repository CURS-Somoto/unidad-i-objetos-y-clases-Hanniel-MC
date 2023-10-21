using System;

class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre)
    {
        Nombre = nombre;
        Salario = 0;
    }

    public void AgregarSalarioManualmente()
    {
        Console.Write($"Introduce el salario de {Nombre}: ");
        if (double.TryParse(Console.ReadLine(), out double salario))
        {
            Salario = salario;
        }
        else
        {
            Console.WriteLine("Salario no válido. Se ha establecido en 0.");
        }
    }

    public double CalcularSalarioAnualManual()
    {
          return Salario * 12;
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado1 = new Empleado("Juan");
        Empleado empleado2 = new Empleado("María");

        empleado1.AgregarSalarioManualmente();
        empleado2.AgregarSalarioManualmente();

        double salarioAnualManualEmpleado1 = empleado1.CalcularSalarioAnualManual();
        double salarioAnualManualEmpleado2 = empleado2.CalcularSalarioAnualManual();

        Console.WriteLine($"El salario anual de {empleado1.Nombre} es: {salarioAnualManualEmpleado1:C}");
        Console.WriteLine($"El salario anual de {empleado2.Nombre} es: {salarioAnualManualEmpleado2:C}");
    }
}
