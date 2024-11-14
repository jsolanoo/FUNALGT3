using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cita
{
    // Propiedades públicas con acceso tradicional
    public int Numero { get; set; }
    public Estudiante Estudiante { get; set; }
    public string Enfermedad { get; set; }
    public double Precio { get; set; }

    // Constructor tradicional
    public Cita(int numero, Estudiante estudiante, string enfermedad, double precio)
    {
        this.Numero = numero;
        this.Estudiante = estudiante;
        this.Enfermedad = enfermedad;
        this.Precio = precio;
    }

    // Método ToString para mostrar información de la cita
    public override string ToString()
    {
        return $"Cita #{Numero}\nEnfermedad: {Enfermedad}\nPrecio: {Precio:C}\nEstudiante: {Estudiante}";
    }
}   