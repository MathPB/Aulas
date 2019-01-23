using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetirIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Idade idade = new Idade();


            idade.ExibirIdade();

            Console.WriteLine(idade.media);

            Console.ReadLine();
        }
    }
}
