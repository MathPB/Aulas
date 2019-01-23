using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel  
    {

        public override double GetBonificacao()
        {
            return Salario *= 0.5;       
        }

        public Diretor (string cpf) : base(5000,cpf){

            Console.WriteLine("DIRETOR CRIADO");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
