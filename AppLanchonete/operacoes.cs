using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLanchonete
{
    class operacoes
    {
       public  List<Produto> produtos = new List<Produto>();
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
                    Console.WriteLine($"{i}- {produtos[i].NomeProduto} = {produtos[i].PrecoProduto}");

                }
            }
                //foreach(var i in produtos)// ver o que é var
            
        }
    }
}
