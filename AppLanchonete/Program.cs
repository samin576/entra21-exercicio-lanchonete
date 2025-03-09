using AppLanchonete;
using System;
class Program
{
    static void Main(string[] Args)
    {

        Produto hamburguer = new Produto();
        hamburguer.NomeProduto = "hambúrguer";
        hamburguer.PrecoProduto = 8.99;

        Produto peixe = new Produto();
        peixe.NomeProduto = "peixe";
        peixe.PrecoProduto = 7;

        Produto agua = new Produto();
        agua.NomeProduto = "água";
        agua.PrecoProduto = 5;

        Produto coca = new Produto();
        coca.NomeProduto = "coca-cola";
        coca.PrecoProduto = 8;

        Pedido pedido1 = new Pedido();
        pedido1.NumeroPedido = 1;
        pedido1.listaProduto.Add(hamburguer);
        pedido1.listaProduto.Add(coca);
        pedido1.listaProduto.Add(peixe);
        pedido1.listaProduto.Add(agua);
        pedido1.Lista();

        Pedido pedido2 = new Pedido();
        pedido2.NumeroPedido = 2;
        pedido2.listaProduto.Add(agua);
        pedido2.Lista();


    }
}