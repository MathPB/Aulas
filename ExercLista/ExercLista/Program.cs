using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Matheus");
            lista.Add("João");
            lista.Add("Maria");

            int pos = lista.FindIndex(x => x == "Maria");

            Console.WriteLine(pos);

            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
