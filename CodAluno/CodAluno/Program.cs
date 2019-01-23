using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodAluno
{
    class Program
    {
        static void Main(string[] args)
        {

            

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("Digite o número de alunos que irão participar:");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os códigos dos alunos do curso A:");
                int cod = int.Parse(Console.ReadLine());

                A.Add(cod);
            }

            Console.WriteLine("Digite o número de alunos que irão participar:");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os códigos dos alunos do curso B:");
                int cod = int.Parse(Console.ReadLine());

                B.Add(cod);
            }

            Console.WriteLine("Digite o número de alunos que irão participar:");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os códigos dos alunos do curso C:");
                int cod = int.Parse(Console.ReadLine());

                C.Add(cod);
            }

            HashSet<int> Novo = new HashSet<int>();

            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);

            Console.WriteLine("Valor total de alunos: " + Novo.Count);

            
            Console.ReadLine();
        }
    }
}
