using System;

namespace Matematica.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            var primerNumero = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            var segundoNumero =Console.ReadLine();
            var calculadora = new Matematica.Negocio.Calculadora();
            var resultado = calculadora.Sumar(int.Parse(primerNumero) , int.Parse(segundoNumero));
            Console.WriteLine("La suma de los dos numeros es:" + resultado);

            Random rnd = new Random();
            int productoEscalar = 0, n;
            Console.WriteLine("Favor ingresar el valor de n:");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] w = new int[n];

            for (int i = 0; i < 0; i++)
            {
                v[i] = (int) (rnd.Next(1, 101));
                w[i] = (int) (rnd.Next(1, 101));
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + "\t");

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(w[i] + "\t");

            }
            for (int i = 0; i < n; i++)
            {
                productoEscalar = productoEscalar + v[i] * w[i];
                Console.WriteLine("\n El producto escalar entre los dos vectores es de:" + productoEscalar);
                Console.ReadKey();
            }
        }
    }
}
