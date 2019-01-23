using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato 
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }


        public Contato(string nome, int telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public Contato(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Telefone: " + Telefone.ToString();
        }
    }
}
