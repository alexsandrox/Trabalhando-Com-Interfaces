using ProjetoInterfaces.Models;
using System;

namespace ProjetoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var operadoraDeCartao = new OperadoraDeCartaoCielo();
            var impressora = new ImpressoraEpson();

            var cartao = new Cartao("GLADYS M R T DE PAULA", "7432");
            var compra = new Compra(1899.99, "Playstation 4 PRO", "Alexsandro Andrade");
            var checkout = new Checkout(operadoraDeCartao, impressora);
            checkout.FecharCompra(compra, cartao);

            Console.ReadLine();
        }
    }
}