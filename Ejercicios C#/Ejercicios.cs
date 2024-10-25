using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_C_
{
    public class Ejercicios
    {
        static void Main()
        {
            //Ejercicio 1
            string nombre = "Tobias";

            Console.WriteLine($"Ejercicio 1");
            Console.WriteLine($"Hola, {nombre}!");
            Console.WriteLine($" ");

            //Ejercicio 2
            double cuenta = 2 + 10 / 5 * 2 - 7 % 1;

            Console.WriteLine($"Ejercicio 11");
            Console.WriteLine(cuenta);
            Console.WriteLine($" ");

            //Ejercicio 3
            int numero1 = 87;
            int numero2 = 94;
            double resultado = numero1 * numero2;

            Console.WriteLine($"Ejercicio 21");
            Console.WriteLine(resultado);
            Console.WriteLine($" ");

            //Ejercicio 4
            Console.WriteLine($"Ejercicio 31");
            Console.Write("Introduce un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.Write(" " + numero + " x " + i + " = ");
                Console.WriteLine(numero * i);
            }
            Console.WriteLine($" ");

            //Ejercicio 5
            Console.WriteLine($"Ejercicio 41");
            Console.Write("Introduce un número entero: ");
            int numeroEntero = Convert.ToInt32(Console.ReadLine());

            if (numeroEntero % 2 == 0)
            {
                Console.WriteLine($"{numeroEntero} es múltiplo de 2.");
            }
            else
            {
                Console.WriteLine($"{numeroEntero} no es múltiplo de 2.");
            }

            if (numeroEntero % 3 == 0)
            {
                Console.WriteLine($"{numeroEntero} es múltiplo de 3.");
            }
            else
            {
                Console.WriteLine($"{numeroEntero} no es múltiplo de 3.");
            }
            Console.WriteLine($" ");

            //Ejercicio 6
            Console.WriteLine($"Ejercicio 52");
            Console.Write("Ingrese el primer número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            if (numero3 > numero4)
            {
                Console.WriteLine("El primer número es mayor.");
            }
            else if (numero4 > numero3)
            {
                Console.WriteLine("El segundo número es mayor.");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
            Console.WriteLine($" ");

            //Ejercicio 7
            Console.WriteLine($"Ejercicio 61");
            Console.WriteLine($"1111");
            int contrasena;

            do
            {
                Console.Write("Ingrese su contraseña (número): ");
                contrasena = Convert.ToInt32(Console.ReadLine());
            } while (contrasena != 1111);
            Console.WriteLine("Contraseña correcta. Acceso concedido.");
            Console.WriteLine($" ");

            //Ejercicio 8
            Console.WriteLine($"Ejercicio 71");
            int numeroPositivo;
            int suma = 0;

            do
            {
                Console.Write("Ingrese un número positivo (0 o negativo para terminar): ");
                numeroPositivo = Convert.ToInt32(Console.ReadLine());

                if (numeroPositivo > 0)
                {
                    suma += numeroPositivo;
                }
            } while (numeroPositivo > 0);

            Console.WriteLine($"La suma de los números positivos ingresados es: {suma}");
            Console.WriteLine($" ");

            //Ejercicio 9
            Console.WriteLine($"Ejercicio 81");
            for (int i = 15; i >= 5; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($" ");

            //Ejercicio 10
            Console.WriteLine($"Ejercicio POO");

            Console.ReadKey();
        }
    }
}