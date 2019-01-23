using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFunc
{
    public class Funcionario
    {
        public string nome;
        public double salbruto, desc;
        public double salLiq, aumentSal, porc;

        public void Pessoal()
        {
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

                    Console.WriteLine("Informe seu salário:");
                    salbruto = double.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o desconto:");
                            desc = double.Parse(Console.ReadLine());
        }

        public void salarioLiquido()
        {
            salLiq = salbruto - desc;

            Console.WriteLine("Dados do funcionário: " + nome + ", R$ " + salLiq);
        }

        public void aumentarSalario()
        {
            Console.WriteLine("Deseja aumentar o salário em qual porcetagem? ");
            aumentSal = double.Parse(Console.ReadLine());

            aumentSal = ((aumentSal / 100) * salbruto) + salLiq;

            Console.WriteLine("Dados do funcionário: " + nome + ", R$ " + aumentSal);
        }
    }
}
