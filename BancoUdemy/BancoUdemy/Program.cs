using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular da conta:");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char letra = char.Parse(Console.ReadLine());
            Operacao op = new Operacao(nome, conta);

            while (letra != 'n' || letra != 's') {

                if (letra == 'n')
                {
                    Console.WriteLine("Digite um valor de depósito: ");
                    double valor = double.Parse(Console.ReadLine());
                    op.Depositar(valor);

                    Console.WriteLine("Conta criada:");
                    Console.WriteLine("Conta " + conta + ", Titular: " + nome + ", Saldo: R$" + op._saldo);

                }
                if (letra == 's')
                {
                    Console.WriteLine("Digite o valor do depósito: ");
                    double valor = double.Parse(Console.ReadLine());
                    op.Depositar(valor);

                    Console.WriteLine(valor);
                    Console.WriteLine("Conta criada:");
                    Console.WriteLine("Conta " + conta + ", Titular: " + nome + ", Saldo: R$" + op._saldo);

                }
            }
            Console.WriteLine("Digite um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            op.Sacar(saque);

            Console.WriteLine("Conta " + conta + ", Titular: " + nome + ", Saldo: R$" + op._saldo);


            Console.ReadLine();

        }
    }
}


