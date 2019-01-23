using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular;
        private double _saldo = 100;
        public int _agencia;
        public int _numero;
        private static int TotalDeContas;
        public static int ContadorSaquesNaoPermitidos { get; private set; }
        public static int ContadorTransferenciasNaoPermitidas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        public int Numero { get; }
        public int Agencia { get; }

        public ContaCorrente(int agencia, int numero)
        {


            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0", nameof(agencia));
            }



            if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0", nameof(numero));

            }

            Agencia = agencia;
            Numero = numero;

            
          
            //TaxaOperacao = 30 / TotalDeContas;

            TotalDeContas++;

        }



        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if(valor < 0)
            {
                
                throw new ArgumentException("Valor inválido para tranferência." + nameof(valor)); 
            }
            else
            {
                try
                {
                    Sacar(valor);
                }
                catch(SaldoInsuficienteException ex)
                {
                    ContadorTransferenciasNaoPermitidas++;
                    throw new OperacaoException("Operação não realizada: " + ex);

                }
                contaDestino.Depositar(valor);
            }
        }


        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Valor invalido para saque: " + nameof(valor));
            }

            if(_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);


            }
            else
            {
                _saldo -= valor;

                
            }
        }
    }
}
