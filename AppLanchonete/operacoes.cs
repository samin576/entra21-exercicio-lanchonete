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
        public List<Produto> lista = new List<Produto>();
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
                    Console.WriteLine($"{i} - {produtos[i].NomeProduto} = {produtos[i].PrecoProduto} reais");
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
                do
                {
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine($"{i} - {produtos[i].NomeProduto} = {produtos[i].PrecoProduto} reais");
                    }
                  
                    Console.WriteLine("Qual item deseja selecionar?");
                    int n1 = int.Parse(Console.ReadLine());
                    lista.Add(produtos[n1]);
                    Console.WriteLine("Item adicionado! Gostaria de adicionar mais algum? S/N");
                    resposta = Console.ReadLine().ToUpper();
                    if(resposta == "S")
                    {
                        Console.Clear();
                    }
                   
                    
                } while (resposta != "N");
            }
           
        }
        public void Lista()//Ver como arrumar o pedido. Fazer pedido1, pedido2 e aparecer o número do pedido
        {
            if(lista.Count == 0)
            {
                Console.WriteLine("Você não fez nenhum pedido!");
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"Produto {i} - {lista[i].NomeProduto} = {lista[i].PrecoProduto} reais");
                }
                double total = Somatotal();
                Console.WriteLine($"\nO preço total do pedido é de {total} reais");

            }
        }
        public double Somatotal()
        {
            double soma = 0;
            for(int i=0; i<lista.Count; i++)
            {
                soma += lista[i].PrecoProduto;
            }
            return soma;
          

            
        }

    }
}
