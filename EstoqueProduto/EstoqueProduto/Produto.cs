
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProduto
{
    public class Produto
    {
        public string _nome;
        public double _preco;
        public int _quantidadeEmEstoque;
        public double total;
        public int valor;


        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            
            
        }

        public double valorTotalEmEstoque(double preco)
        {

            total = _preco * _quantidadeEmEstoque;

            valor = valor + _quantidadeEmEstoque;

            Console.WriteLine("Dados do Produto: " + _nome + ", R$ " + _preco + ", " + _quantidadeEmEstoque + " " +"unidades, Total: R$ " + total);
            Console.WriteLine("Quantidade:" + valor);


            return valor;
        }

        /*
        public void EntradaEstoque()
        {
            Console.WriteLine("Digite o nome do Produto: ");
            _nome = Console.ReadLine();

            Console.WriteLine("Digite o preco do Produto: R$");
            _preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade em estoque: ");
            _quantidadeEmEstoque = int.Parse(Console.ReadLine());

            total2 = _preco * _quantidadeEmEstoque;
            valor = valor - _quantidadeEmEstoque;

            Console.WriteLine("Dados do Produto: " + _nome + " ,R$ " + _preco + " ," + valor + " unidades, Total:" + total);

        }
        */

       
        
    }
}
