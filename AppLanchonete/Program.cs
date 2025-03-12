using AppLanchonete;
using System;
using System.Globalization;
using System.Text.Json.Serialization.Metadata;
class Program
{
    static void Main(string[] Args)
    {


        string decisao;
        int n1 = 1;
        do
        {
           
            for (int i = 0; i <n1 ; i++)
            {
                Pedido pedido1 = new Pedido();
                pedido1.NumeroPedido = n1;
                pedido1.Itens();
                pedido1.Lista();
            }
            
            Console.WriteLine("\nSe quiser sair, digite q. Senão, digite qualquer outra coisa");
            decisao = Console.ReadLine().ToLower();
            if (decisao != "q")
            {
                n1++;
            }
           
           


        } while (decisao != "q");
        Console.WriteLine("Tudo bem. Tchau!");

      

    }
}