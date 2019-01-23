using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizFoda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N, M;

            string[] s = Console.ReadLine().Split(' '); 
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int X = int.Parse(Console.ReadLine());

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(mat[i,j] == X)
                    {
                        Console.WriteLine("O número " + X + " existe na matriz!");
                        if(j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if(j < N - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if(i < M - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
