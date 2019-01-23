using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY;
            CalcularArea X = new CalcularArea();
            CalcularArea Y = new CalcularArea();

            areaX = X.Area();
            areaY = Y.Area();

            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX == areaY)
            {
                Console.WriteLine("AREAS IGUAIS!");
            }
            else if (areaX > areaY)
            {
                Console.WriteLine("AREA DO TRIANGULO X É MAIOR!");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("AREA DO TRIANGULO Y É MAIOR!");
            }
            else if (areaX <= 0 || areaY <= 0)
            {
                Console.WriteLine("AREA MENOR OU IGUAL A ZERO");
            }


            Console.ReadLine();


        }
    }
}
