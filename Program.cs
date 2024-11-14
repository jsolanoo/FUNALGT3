using System;
using System.Collections.Generic;
using ConsoleApp1;

class Program
{
    static void Main()
    {
        List<Cita> citas = new List<Cita>();
        int opcion;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Universidad");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CitaUtil.CrearCita(citas);
                    break;
                case 2:
                    CitaUtil.ListarCitas(citas);
                    break;
                case 3:
                    Console.Write("Texto a buscar: ");
                    string buscar = Console.ReadLine();
                    Console.Write("Texto a reemplazar: ");
                    string reemplazar = Console.ReadLine();
                    CitaUtil.ModificarUniversidad(citas, buscar, reemplazar);
                    break;
                case 4:
                    Console.WriteLine("Fin del programa.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 4);
    }
}
