using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        private string _cpf;
        

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }

    }
}
