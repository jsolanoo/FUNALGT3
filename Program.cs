using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
