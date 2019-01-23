using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        private static double _num1;
        private static double _num2;

        
        public double Numero1
        {
            get{
                return _num1;
            }
            set{

            }
        }

        public void Somar(double _num1,double _num2)
        {
            _num1 += _num2;
        }

        public void Subitrair(double _num1, double _num2)
        {
            _num1 -= _num2;
        }
        
        public void Multiplicar(int num1, int num2)
        {
            _num1 *= _num2;
        }

        public void Dividir(int num1, int num2)
        {
            _num1 /= _num2;
        }

    }
}
