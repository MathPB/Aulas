using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Matheus\source\repos\Agenda\Agenda\bin\Debug\Arquivo.txt";

            List<Contato> lista = new List<Contato>();

            try
            {

                string[] lines = File.ReadAllLines(path);


                using (StreamWriter sw = File.AppendText(path))
                {

                    foreach (string line in lines)
                    {


                        Console.WriteLine("Digite o número de contatos que irá adicionar: ");
                        int N = int.Parse(Console.ReadLine());

                        for (int i = 0; i < N; i++)
                        {

                            Console.WriteLine("Digite o " + (i + 1) + "° nome:");
                            string nome = Console.ReadLine();

                            Console.WriteLine("Em seguida, digite o " + (i + 1) + "° número de telefone:");

                            int telefone = int.Parse(Console.ReadLine());

                            
                            lista.Add(new Contato(nome));

                            

                            Console.WriteLine("Foi adicionado o contato: " + nome + " com o número: " + telefone);
                        }

                        
                    }

                
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }


             Console.ReadLine();

        }
    }
}

