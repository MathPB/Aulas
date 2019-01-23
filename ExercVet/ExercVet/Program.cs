using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercVet
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            double soma, media;
            int N = 0;

            N = int.Parse(Console.ReadLine());

            vet = new double[N];

            for(int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            soma = 0.0;

            for(int i =0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            media = soma / N;

            Console.WriteLine(media);

            Console.ReadLine();

        }
    }
}
