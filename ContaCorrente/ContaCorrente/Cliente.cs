﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class Cliente : Conta
    {
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }






    }
}