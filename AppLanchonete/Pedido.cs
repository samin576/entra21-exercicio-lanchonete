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
        List<Produto> produtos = new List<Produto>();
        public double PrecoTotal()
        {
            double soma = 0;
            foreach (var produto in produtos)
            {
                soma += produto.PrecoProduto;
            }
            return soma;
        }
        public void Itens()
        {
            Console.WriteLine("As opções de produto são:");
            Console.WriteLine("1 - hambúrguer = 8.99");
            Console.WriteLine("2 - peixe = 7");
            Console.WriteLine("3 - água = 5");
            Console.WriteLine("4 - coca-cola = 8");
            Console.WriteLine("Seriam quantos produtos?");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite o número do produto:");
                int produtoEscolhido = int.Parse(Console.ReadLine());
                switch (produtoEscolhido)
                {
                    case 1:
                        produtos.Add(new Produto { NomeProduto = "hambúrguer", PrecoProduto = 8.99 });
                        break;
                    case 2:
                        produtos.Add(new Produto { NomeProduto = "peixe", PrecoProduto = 7.00 });
                        break;
                    case 3:
                        produtos.Add(new Produto { NomeProduto = "água", PrecoProduto = 5.00 });
                        break;
                    case 4:
                        produtos.Add(new Produto { NomeProduto = "coca-cola", PrecoProduto = 8.00 });
                        break;
                    default:
                        Console.WriteLine("Você não digitiou nenhum produto cadastrado!");
                        i--;
                        break;
                }
            }
        }
        public void Lista()
        {
            Console.WriteLine($"\nPedido #{NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto.NomeProduto);
            }
            Console.WriteLine($"\nTotal é de {PrecoTotal():F2} reais\n");
        }
    }

}
