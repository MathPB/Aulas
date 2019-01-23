using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Pensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int quarto;
            double[] vet;

            Console.WriteLine("Informe quantos quartos serão locados: ");
            int N = int.Parse(Console.ReadLine());
            vet = new double[N];

            quarto = rand.Next(1, 10);
            int j = quarto;

            if (j != quarto)
            { 
            


                for (int i = 1; i < N; i++)
                {


                    Console.WriteLine("Dados do " + i + "° aluguel:");
                    Console.WriteLine("Digite o nome:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o email:");
                    string email = Console.ReadLine();

                    Console.WriteLine(quarto);

                }


            }
            Console.ReadLine();

        }
    }
}
