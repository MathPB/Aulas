using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        private double _salario;

        public double Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    _salario = value;
                }
            }
        }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;

        }

        public void aumentarSalario(double valor)
        {
            _salario = _salario - (valor / 100 * _salario);
        }


    }
    
}
