using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppLanchonete
{
    public class Pedido
    {
        public int NumeroPedido;
        public List<Produto> listaProduto = new List<Produto>();
        public double PrecoTotal()
        {
            double soma = 0;
            foreach (var produto in listaProduto)
            {
                soma += produto.PrecoProduto;
            }
            return soma;
        }
        public void Lista()
        {
            Console.WriteLine($"Pedido #{NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var produto in listaProduto)
            {
                Console.WriteLine(produto.NomeProduto);
            }
            Console.WriteLine($"\nTotal é de {PrecoTotal():F2} reais\n");
        }

    }
}