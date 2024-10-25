using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Persona persona = new Persona("Persona genérica", 0);
            persona.Saludar();

            Estudiante estudiante = new Estudiante("Ana", 20);
            estudiante.SetEdad(22);
            estudiante.Saludar();
            estudiante.VerEdad();
            estudiante.Estudiar();

            Profesor profesor = new Profesor("Carlos", 40);
            profesor.SetEdad(45);
            profesor.Saludar();
            profesor.Explicar();

            Console.ReadKey();
        }
    }
}