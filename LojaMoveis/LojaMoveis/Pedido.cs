using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaMoveis
{
    public class Pedido
    {
        public int _codigo;
        public double _preco;

        public string Descricao { get; set; }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _codigo = value;
                }
            }
        }

        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _preco = value;
                }
            }
        }

        public Pedido
    }
}
