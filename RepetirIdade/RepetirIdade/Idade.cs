using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetirIdade
{
    public class Idade
    {
        public int idade;
        public double media;
        public int n;
        public string nome;
        public int soma;

        

       

        public void ExibirIdade()
        {
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma = soma + idade;
                n = n + 1;

                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 0)
                {
                    Console.WriteLine("IMPOSSIVEL RETORNAR!");
                    
                }
                else
                {
                    double media = soma / n;
                    Console.WriteLine("Media: " + media);


                }

                
            }

            
        }
    }
}
