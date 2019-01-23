using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class OperacaoException : Exception
    {
        
        public OperacaoException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
