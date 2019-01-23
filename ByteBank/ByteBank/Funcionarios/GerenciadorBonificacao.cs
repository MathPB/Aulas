using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        

        public void Registrar(Funcionario funcionario)
        {
          _totalBonificacao += funcionario.GetBonificacao();
                     
        }
        
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


            
    }
}
