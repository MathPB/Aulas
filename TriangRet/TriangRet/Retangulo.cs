using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangRet
{
    public class Retangulo : Operacao
    {
        


        public double LARGURA { get; set; }
        public double ALTURA { get; set; }

        public Retangulo(double largura, double altura)
        {
            LARGURA = largura;
            ALTURA = altura;
            
        }

        public double area()
        {
            return LARGURA * ALTURA;
        }
    }
}
