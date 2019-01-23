using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratandoExc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch(DivideByZeroException excecao)
            {
                Console.WriteLine(excecao.StackTrace);
                Console.WriteLine(excecao.Message);

                //Console.WriteLine("Exceção tratada.");
            }
            
            
            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null
            return numero / divisor;
        }
        
        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }



    }
}
