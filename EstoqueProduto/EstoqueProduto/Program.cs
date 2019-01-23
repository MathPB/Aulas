


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Produto[] vet;
            double soma, media;

            N = int.Parse(Console.ReadLine());
            vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite o nome do Produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o preco do Produto: R$");
                double preco = double.Parse(Console.ReadLine());

                vet[i] = new Produto(nome, preco);
            }

            soma = 0.0;
            for(int i = 0; i < N; i++)
            {
                soma = soma + vet[i]._preco;
            }

            media = soma / N;

            Console.WriteLine("Media de produtos = " + media.ToString("F2", CultureInfo.InvariantCulture));
            

            Console.ReadLine();
        }
    }
}
