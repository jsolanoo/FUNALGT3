using System;
using System.Collections.Generic;

public static class CitaUtil
{
    public static void CrearCita(List<Cita> citas)
    {
        Console.Write("Número de la cita: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Código del estudiante: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Nombre del estudiante: ");
        string nombre = Console.ReadLine();
        Console.Write("Universidad del estudiante: ");
        string universidad = Console.ReadLine();

        Estudiante estudiante = new Estudiante
        {
            Codigo = codigo,
            Nombre = nombre,
            Universidad = universidad
        };

        Console.Write("Enfermedad: ");
        string enfermedad = Console.ReadLine();
        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        Cita cita = new Cita
        {
            Numero = numero,
            Estudiante = estudiante,
            Enfermedad = enfermedad,
            Precio = precio
        };

        citas.Add(cita);
    }

    public static void ListarCitas(List<Cita> citas)
    {
        double total = 0;
        foreach (var cita in citas)
        {
            Console.WriteLine(cita);
            total += cita.Precio;
        }
        Console.WriteLine($"Total de precios: {total:C}");
    }

    public static void ModificarUniversidad(List<Cita> citas, string buscar, string reemplazar)
    {
        foreach (var cita in citas)
        {
            if (cita.Estudiante.Universidad.Contains(buscar))
            {
                cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(buscar, reemplazar);
            }
        }
    }
}
