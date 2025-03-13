using AppLanchonete;
using System;
using System.Globalization;
using System.Text.Json.Serialization.Metadata;
class Program
{
    static void Main(string[] Args)
    {
        try
        {
            operacoes operacoes = new operacoes();
            int operacao;
            do
            {
                Menu();
                operacao = int.Parse(Console.ReadLine());
                Escolha(operacao, operacoes);
                if (operacao != 0)
                {
                    Console.WriteLine("\n--Dê enter para sair--");
                    Console.ReadLine();
                }
                Console.Clear();



            } while (operacao != 0);
            Console.WriteLine("Tudo bem! Adeus!");
        }
        catch(Exception e)
        {
            Console.WriteLine($"Ops! Você fez algo errado. Reinicie o programa! {e.Message}");
        }
    }
    static void Menu()
    {
        Console.WriteLine("1 - Cadastrar novo produto");
        Console.WriteLine("2 - Listar produtos");
        Console.WriteLine("3 - Fazer pedido");
        Console.WriteLine("4 - Ver pedidos feitos");
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
                operacoes.FazerPedido();
                break;
            case 4:
                operacoes.Lista();
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Você não digitou nenhuma opção válida!");
                break;


        }
    }
}