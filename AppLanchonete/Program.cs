using AppLanchonete;
using System;
using System.Globalization;
using System.Text.Json.Serialization.Metadata;
class Program
{
    static void Main(string[] Args)
    {
        operacoes operacoes = new operacoes();
        int operacao;
        do
        {
            Menu();
            operacao = int.Parse(Console.ReadLine());
            Console.Clear();
            Escolha(operacao, operacoes);
            if (operacao >= 0 && operacao <= 4)
            {
                Console.Clear();
            }


        } while (operacao != 0);
        Console.WriteLine("Tudo bem! Adeus!");
       


        //string decisao;
        //int n1 = 1;
        //do
        //{

        //    for (int i = 0; i < n1; i++)
        //    {
        //        Pedido pedido1 = new Pedido();
        //        pedido1.NumeroPedido = n1;
        //        pedido1.Itens();
        //        pedido1.Lista();
        //    }

        //    Console.WriteLine("\nSe quiser sair, digite q. Senão, digite qualquer outra coisa");
        //    decisao = Console.ReadLine().ToLower();
        //    if (decisao != "q")
        //    {
        //        n1++;
        //    }






        //} while (decisao != "q");
        //Console.WriteLine("Tudo bem. Tchau!");
    }
    static void Menu()
    {
        Console.WriteLine("1 - Cadastrar novo produto");
        Console.WriteLine("2 - Listar produto");
        Console.WriteLine("3 - Fazer pedido");
        Console.WriteLine("4 - Lista");
        Console.WriteLine("0 - Sair");

    }
    static void Escolha(int n1, operacoes operacoes)
    {
       

        switch (n1)
        {
            
            case 1:
                operacoes.CadastrarNovoProduto();
                break;
            case 2:
                operacoes.ListarProdutos();
                break;
            case 3:
                break;
            case 4:
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Você não digitou nenhuma opção válida!");
                break;
            

        }
    }
}