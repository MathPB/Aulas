using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangRet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Operacao> op = new List<Operacao>();

            Console.WriteLine("Digite o número de figuras que serão calculadas:");
            int N = int.Parse(Console.ReadLine());

            for(int i=0; i < N; i++)
            {
                Console.WriteLine("Figura " + (i + 1)+ " - triangulo ou retângulo (t/r)");
                char ch = char.Parse(Console.ReadLine());

                if(ch == 't')
                {
                    Operacao t = Tela.lerTriangulo();
                    op.Add(t);
                }
                else
                {
                    Operacao r = Tela.lerRetangulo();
                    op.Add(r);
                }
            }

            Console.WriteLine("Áreas das figuras:");
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Figura " + (i + 1) + ":" + op[i].area());
            }

            Console.ReadLine();
        }
    }
}
