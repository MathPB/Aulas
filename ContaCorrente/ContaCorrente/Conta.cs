using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    

    public class Conta
    {
        
        private double _saldo;


        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Você não tem saldo suficiente!");
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor, Conta contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                valor -= _saldo;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

