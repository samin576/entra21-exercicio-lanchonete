using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppLanchonete
{
    class Pedido
    {
        public int NumeroPedido;
        public List<Produto> Produtos;
        public Pedido(int numeroPedido)
        {
            NumeroPedido  = numeroPedido;
            Produtos = new List<Produto>();
        }
        public double SomarTotal()
        {
            double soma = 0;
            foreach(var produto in Produtos)
            {
                soma += produto.PrecoProduto;
            }
            return soma;
        }
    }
}
