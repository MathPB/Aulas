using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBank
{
    public class LeitorDeArquivo
    {
        public string Arquivo { get; }


        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            throw new FileNotFoundException();

            Console.WriteLine(" Abrindo Arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo Linha . . .");

            throw new IOException();

            return "Linha do Arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
