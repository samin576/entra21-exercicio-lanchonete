using AppLanchonete;
using System;
class Program
{
    static void Main(string[] Args)
    {


        Pedido pedido1 = new Pedido();
        pedido1.NumeroPedido = 1;
        pedido1.Itens();
        pedido1.Lista();

        //Pedido pedido2 = new Pedido();
        //pedido2.NumeroPedido = 2;
        //pedido2.listaProduto.Add(agua);
        //pedido2.Lista();


    }
}