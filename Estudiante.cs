using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {public class Estudiante
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Universidad { get; set; }

            public override string ToString()
            {
                return $"Código: {Codigo}, Nombre: {Nombre}, Universidad: {Universidad}";
            }
        }
    }
}
=======
public class Estudiante
{
    // Propiedades públicas con acceso tradicional
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Universidad { get; set; }

    // Constructor tradicional
    public Estudiante(int codigo, string nombre, string universidad)
    {
        this.Codigo = codigo;
        this.Nombre = nombre;
        this.Universidad = universidad;
    }

    // Método ToString para mostrar información del estudiante
    public override string ToString()
    {
        return $"{Nombre} (Código: {Codigo}), Universidad: {Universidad}";
    }
}
>>>>>>> JACK
