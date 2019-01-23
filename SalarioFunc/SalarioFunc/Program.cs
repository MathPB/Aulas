using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            f.Pessoal();
            f.salarioLiquido();
            f.aumentarSalario();

            Console.ReadLine();

        }
    }
}
