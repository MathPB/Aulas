using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUdemy
{
    public class Operacao
    {
        public double _saldo = 0;
        private int _conta;

        private string Nome { get; set; }
        public int Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value > 0)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        public Operacao(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;

        }

        public void Depositar(double valor)
        {
           _saldo += valor;
        }

        public double Sacar(double saque)
        {
            if(_saldo < saque)
            {
                return 0;
            }
            else
            {
                return _saldo -= saque;
            }
        }





    }
}
