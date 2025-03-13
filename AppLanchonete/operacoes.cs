using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanchonete
{
    class operacoes
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Pedido> lista = new List<Pedido>();
        public void CadastrarNovoProduto()
        {

            Produto novosProdutos = new Produto();
            Console.WriteLine("Digite o nome do produto:");
            novosProdutos.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preço:");
            novosProdutos.PrecoProduto = double.Parse(Console.ReadLine());
            produtos.Add(novosProdutos);
            Console.WriteLine("Produto cadastrado!");
        }
        public void ListarProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado!");
            }
            else
            {
                for (int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"{i+1} - {produtos[i].NomeProduto} = {produtos[i].PrecoProduto} reais");
                }
            }
            //foreach(var i in produtos)// ver o que é var
        }
        public void FazerPedido()
        {
            string resposta;
            if (produtos.Count == 0)
            {
                Console.WriteLine("Cadastre um produto para depois realizar um pedido!");
            }
            else
            {
                int numeroPedido = lista.Count + 1;
                Pedido novoPedido = new Pedido(numeroPedido);
                do
                {
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine($"{i+1} - {produtos[i].NomeProduto} = {produtos[i].PrecoProduto} reais");
                    }

                    Console.WriteLine("Qual item deseja selecionar?");
                    int n1 = int.Parse(Console.ReadLine());
                    novoPedido.Produtos.Add(produtos[n1]);
                    Console.WriteLine("Item adicionado! Gostaria de adicionar mais algum? S/N");
                    resposta = Console.ReadLine().ToUpper();
                    if (resposta == "S")
                    {
                        Console.Clear();
                    }


                } while (resposta != "N");
                lista.Add(novoPedido);
                Console.WriteLine($"Pedido #{novoPedido.NumeroPedido} registrado! =)");
            }

        }
        public void Lista()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Você não fez nenhum pedido!");
            }
            else
            {
                foreach (var pedido in lista)
                {
                    Console.WriteLine($"\nPedido #{pedido.NumeroPedido}:");
                    for (int i = 0; i < pedido.Produtos.Count; i++)
                    {
                        Console.WriteLine($"Produto {i + 1} - {pedido.Produtos[i].NomeProduto} = {pedido.Produtos[i].PrecoProduto} reais");
                    }
                    double total = pedido.SomarTotal();
                    Console.WriteLine($"Preço total do Pedido #{pedido.NumeroPedido}: {total} reais");
                }
            }
        }
       

    }
}
