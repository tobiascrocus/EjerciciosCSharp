using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Profesor : Persona
    {
        public Profesor(string nombre, int edad) : base(nombre, edad) { }

        public void Explicar()
        {
            Console.WriteLine("Estoy Explicando.");
        }
    }
}