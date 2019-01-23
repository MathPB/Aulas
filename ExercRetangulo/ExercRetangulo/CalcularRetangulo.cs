using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercRetangulo
{
    public class CalcularRetangulo
    {
        public double larg, alt, diag;
        public double area, per;


        public void AreaRet()
        {
            Console.WriteLine("Digite a largura do retangulo:");
            larg = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a altura do retangulo:");
                    alt = double.Parse(Console.ReadLine());

            area = larg * alt;

            Console.WriteLine("Area do retangulo: " + area);
        }

        public void PerRet()
        {
            per = 2 * (larg + alt);

            Console.WriteLine("Perimetro do retangulo: " + per);
        }

        public void DiagRet()
        {
            diag = Math.Sqrt((larg * larg) + (alt * alt));

            Console.WriteLine("Diagonal do retangulo: " + diag);
        }

    }
}
