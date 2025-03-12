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
        //public int NumeroPedido;
        //List<Produto> produtos = new List<Produto>();
        //List<Produto> itens2 = new List<Produto>();
        //public double PrecoTotal()
        //{
        //    double soma = 0;
        //    foreach (var produto in produtos)
        //    {
        //        soma += produto.PrecoProduto;
        //    }
        //    return soma;
        //}
        //public void Itens()
        //{

        //    Console.WriteLine("As opções de produto são:");
        //    Console.WriteLine("1 - hambúrguer = 8.99");
        //    Console.WriteLine("2 - peixe = 7");
        //    Console.WriteLine("3 - água = 5");
        //    Console.WriteLine("4 - coca-cola = 8");
        //    Console.WriteLine("Gostaria de acrescentar mais um item? sim ou não");
        //    string decisaoProduto = Console.ReadLine().ToLower();
        //    if (decisaoProduto == "sim")
        //    {
        //        NovosProdutos();
        //    }
        //    itens2.Add(new Produto { NomeProduto = "hambúrguer", PrecoProduto = 8.99 });
        //    itens2.Add(new Produto { NomeProduto = "peixe", PrecoProduto = 7.00 });
        //    itens2.Add(new Produto { NomeProduto = "água", PrecoProduto = 5.00 });
        //    itens2.Add(new Produto { NomeProduto = "coca-cola", PrecoProduto = 8.00 });
        //    for (int i =0; i<itens2.Count; i++)
        //    {
        //        Console.WriteLine($"1 - {itens2.NomeProduto[i]} = {itens2.PrecoProduto[i]}");
        //    }
        //    Console.WriteLine("Seriam quantos produtos?");
        //    int numero = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < numero; i++)
        //    {
        //        Console.WriteLine("Digite o número do produto:");
        //        int produtoEscolhido = int.Parse(Console.ReadLine());
        //        switch (produtoEscolhido)
        //        {
        //            case 1:
        //                produtos.Add(new Produto { NomeProduto = "hambúrguer", PrecoProduto = 8.99 });
        //                break;
        //            case 2:
        //                produtos.Add(new Produto { NomeProduto = "peixe", PrecoProduto = 7.00 });
        //                break;
        //            case 3:
        //                produtos.Add(new Produto { NomeProduto = "água", PrecoProduto = 5.00 });
        //                break;
        //            case 4:
        //                produtos.Add(new Produto { NomeProduto = "coca-cola", PrecoProduto = 8.00 });
        //                break;
        //            case 5:
        //                produtos.Add(new Produto { NomeProduto = novosProdutos.NomeProduto, PrecoProduto = novosProdutos.PrecoProduto });
        //                break;
        //            default:
        //                Console.WriteLine("Você não digitou nenhum produto cadastrado!");
        //                i--;
        //                break;
        //        }
        //    }
        //}
        //public void Lista()
        //{
        //    Console.WriteLine($"\nPedido #{NumeroPedido}");
        //    Console.WriteLine("Itens:");
        //    foreach (var produto in produtos)
        //    {
        //        Console.WriteLine(produto.NomeProduto);
        //    }
        //    Console.WriteLine($"\nTotal é de {PrecoTotal():F2} reais\n");
        //}
        //public void NovosProdutos()
        //{
        //    Produto novosProdutos = new Produto();
        //    Console.WriteLine("Digite o nome do produto:");
        //    novosProdutos.NomeProduto = Console.ReadLine();
        //    Console.WriteLine("Digite o preço:");
        //    novosProdutos.PrecoProduto = int.Parse(Console.ReadLine());
        //    itens2.Add(new Produto { NomeProduto = novosProdutos.NomeProduto, PrecoProduto = novosProdutos.PrecoProduto });
        //}
    }

}
