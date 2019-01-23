using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercConj
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            A.UnionWith(B);

            foreach (int i in A)
            {
                Console.WriteLine(i);
            }


            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine("Pertence!");
            }

            Console.ReadLine();
        }
    }
}
