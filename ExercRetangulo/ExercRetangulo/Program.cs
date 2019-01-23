using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularRetangulo c = new CalcularRetangulo();

            c.AreaRet();
            c.PerRet();
            c.DiagRet();

            Console.ReadLine();

        }
    }
}
