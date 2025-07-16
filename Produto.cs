using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade += quantidade;
            }
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0 && quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + 
                ", R$ " + 
                Preco.ToString("F2") + 
                ", " + Quantidade + 
                " unidades, Total: R$ " + 
                ValorTotalEmEstoque().ToString("F2");
        }



    }
}
