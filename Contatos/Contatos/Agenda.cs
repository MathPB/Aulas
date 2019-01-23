using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    public class Agenda
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }


        public Agenda(string nome, int telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public Agenda(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return "  Nome: " + Nome + ", Telefone: " + Telefone.ToString() + "  ";
        }
    }
}
