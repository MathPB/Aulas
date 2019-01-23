using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Definir caminho do arquivo e criar o path
            string path = @"C:\Users\Matheus\source\repos\Contatos\Contatos\bin\Debug\Arquivo\Arquivo.txt";

            List<Agenda> lista = new List<Agenda>();

            // try e catch para tratar exceções
            try
            {
                // Utilizar System.IO para usar as bibliotecas File e Stream
                string[] lines = File.ReadAllLines(path);


                using (StreamWriter sw = File.AppendText(path))
                {

                    foreach (string line in lines)
                    {
                        int op = 0;
                        Console.WriteLine("Digite 1 - Para adicionar contatos");
                        Console.WriteLine("Digite 2 - Para remover um contato");
                        Console.WriteLine("Digite 3 - Para encontrar um contato");
                        Console.WriteLine("Digite 0 - Para finalizar");
                        op = int.Parse(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Digite o número de contatos que irá adicionar: ");
                                int N = int.Parse(Console.ReadLine());

                                for (int i = 0; i < N; i++)
                                {

                                    Console.WriteLine("Digite o " + (i + 1) + "° nome:");
                                    string nome = Console.ReadLine();

                                    Console.WriteLine("Em seguida, digite o " + (i + 1) + "° número de telefone:");

                                    int telefone = int.Parse(Console.ReadLine());

                                    Agenda a = new Agenda(nome, telefone);

                                    lista.Add(a);
                                    sw.WriteLine(lista[i]);

                                    Console.WriteLine("Foi adicionado o contato: " + nome + " com o número: " + telefone);
                                    break;
                                }
                                break;

                            case 2:
                                Console.WriteLine("Digite o número de contatos que irá excluir: ");
                                N = int.Parse(Console.ReadLine());

                                for (int i = 0; i < N; i++)
                                {

                                    Console.WriteLine("Digite o nome do contato que deseja excluir:");
                                    string nome = Console.ReadLine();


                                    Agenda a = new Agenda(nome);

                                    lista.RemoveAt(a);
                                    sw.WriteLine(lista[i]);


                                    Console.WriteLine("O usuário " + nome + " foi excluido");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Digite o nome do usuário que deseja encontrar:");
                                string ncont = Console.ReadLine();

                                int cont = lista.FindIndex(x => x.Nome == ncont);

                                break;

                            case 0:
                                Console.WriteLine("Obrigado e até a próxima!");
                                break;

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
