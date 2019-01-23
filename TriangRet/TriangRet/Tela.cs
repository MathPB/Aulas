using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangRet
{
    public class Tela 
    {

        public static Triangulo lerTriangulo()
        {
            Console.WriteLine("Lado A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Lado B:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Lado C:");
            double c = double.Parse(Console.ReadLine());

            return new Triangulo(a, b, c);
        }

        public static Retangulo lerRetangulo()
        {
            Console.WriteLine("Largura:");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura:");
            double altura = double.Parse(Console.ReadLine());

            return new Retangulo(largura, altura);
        }
    }
}
