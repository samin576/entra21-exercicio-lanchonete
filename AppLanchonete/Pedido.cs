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
            Console.WriteLine("1 - hambúrguer");
            Console.WriteLine("2 - peixe");
            Console.WriteLine("3 - água");
            Console.WriteLine("4 - coca-cola");
            Console.WriteLine("Seriam quantos produtos?");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Digite o número do produto:");
                int produto = int.Parse(Console.ReadLine());
                produtos.Add(produto);
            }
        }
        public void Produtos(List<int> n1)
        {
            Produto _1 = new Produto();
            Produto _2 = new Produto();
            Produto _3 = new Produto();
            Produto _4 = new Produto();
            int fim =1;
            do
            {
                for (int i = 0; i < n1.Count; i++)
                {

                    switch (n1[i])
                    {

                        case 1:
                            _1.NomeProduto = "hambúrguer";
                            _1.PrecoProduto = 8.99;
                            break;
                        case 2:
                            _2.NomeProduto = "peixe";
                            _2.PrecoProduto = 7;
                            break;
                        case 3:
                            _3.NomeProduto = "água";
                            _3.PrecoProduto = 5;
                            break;
                        case 4:
                            _4.NomeProduto = "coca-cola";
                            _4.PrecoProduto = 8;
                            break;
                        default:
                            Console.WriteLine("Você não digitiou nenhum produto cadastrado!");
                            fim = 1;
                            break;

                    }
                }
            } while (fim!=1);






        }


        public void Lista()
        {
            Console.WriteLine($"Pedido #{NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto.NomeProduto);
            }
            Console.WriteLine($"\nTotal é de {PrecoTotal():F2} reais\n");
        }


    }

}
