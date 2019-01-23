using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    public class CalcularArea
    {
        public double a, b, c;
        public double p;
        public double area, areaX, areaY;


        public double Area()
        {
            Console.WriteLine("Digite o lado A do triangulo: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B do triangulo: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C do triangulo: ");
            c = double.Parse(Console.ReadLine());

            p = (a + b + c) / 2;

            return area = Math.Sqrt(p) * (p - a) * (p - b) * (p - c);
        }



            
    }

    
}
