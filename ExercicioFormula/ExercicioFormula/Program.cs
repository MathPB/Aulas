using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFormula
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, delta, x1, x2;

            Console.WriteLine("Insira o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de C: ");
            c = double.Parse(Console.ReadLine());


            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR!");
                Console.WriteLine("Valor de Delta: " + delta);
            }
            else
            {
                x1 = -b + Math.Sqrt(delta) / (2.0 * a);
                x2 = -b - Math.Sqrt(delta) / (2.0 * a);

                Console.WriteLine("Valor de Delta: " + delta);
                Console.WriteLine("Valor de X1: " + x1.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor de X2: " + x2.ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
