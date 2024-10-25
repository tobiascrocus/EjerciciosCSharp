using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre, int edad) : base(nombre, edad) { }

        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando.");
        }
        public void VerEdad()
        {
            Console.WriteLine($"Mi edad es: {Edad} años.");
        }
    }
}