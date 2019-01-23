using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }


        public virtual double GetBonificacao()
        {
           return Salario * 0.10;
        }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            Console.WriteLine("FOI CRIADO UM FUNCIONÁRIO");
            TotalDeFuncionarios++;

        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
