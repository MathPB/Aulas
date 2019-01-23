
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel  
    {
        public string Senha { get; set; }
        public string CPF { get; private set; }

        public ParceiroComercial(string cpf)
        {
            CPF = cpf;
        }


        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public bool Logar(ParceiroComercial funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema parceiro comercial!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }

        }
    }
}
