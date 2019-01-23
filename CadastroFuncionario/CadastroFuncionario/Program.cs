using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Quantos funcionários serão cadastrados");
            N = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Dados do " + i + "° funcionário:");
                Console.WriteLine("CPF:");
                string cpf = Console.ReadLine();

                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Salario:");
                double salario = double.Parse(Console.ReadLine());

                Funcionario f = new Funcionario(cpf, nome, salario);
                lista.Add(f);
            }

            Console.WriteLine("Digite o CPF do funcionário que terá aumento:");
            string funcamt = Console.ReadLine();

            int pos = lista.FindIndex(x => x.CPF == funcamt);
            if(pos == -1)
            {
                Console.WriteLine("CPF INEXISTENTE!");
            }
            else
            {
                Console.WriteLine("Digite a porcentagem do aumento:");
                double porc = double.Parse(Console.ReadLine());
                lista[pos].aumentarSalario(porc);
            }


            Console.WriteLine("Lista atualizada de funcionários:");
            for(int i=0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
