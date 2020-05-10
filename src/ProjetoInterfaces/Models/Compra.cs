/**
 * Classe Compra implementa InterfaceDocumentoAutorizavel e InterfaceDocumentoImprimível
 * 
 * 
 * Cria um objeto do tipo Compra
 * Verifica se essa Compra é ou não Autorizável
 * Caso a Compra seja Autorizada vamos Imprir a Compra
 *
 */

using System;
using ProjetoInterfaces.Interfaces;

namespace ProjetoInterfaces.Models
{
    public class Compra : InterfaceDocumentoAutorizavel, InterfaceDocumentoImprimivel
    {
        /*
         * 
         * Construtor da classe Compra
         *
         * params: double valorTotal, string nomeDoProduto, string nomeDoCliente
         *
         * return: Compra
         */
        public Compra(double valorTotal, string nomeDoProduto, string nomeDoCliente)
        {
            ValorTotal    = valorTotal;
            NomeDoProduto = nomeDoProduto;
            NomeDoCliente = nomeDoCliente;
            DataEHoraDaCompra  = DateTime.Now;
        }

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: ValorTotal
         *
         * return: double ValorTotal
         */
        public double ValorTotal { get; private set; }

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: NomeDoProduto
         *
         * return: string NomeDoProduto
         */        
        public string NomeDoProduto  { get; private set; }

                /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: NomeDoCliente
         *
         * return: string NomeDoCliente
         */
        public string NomeDoCliente { get; private set; }

            /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: DataDaCompra
         *
         * return: DateTime DataDaCompra
         */
        public DateTime DataEHoraDaCompra { get; private set; }
        
        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: 
         *
         * return: string Cabecalho
         */
        public string Cabecalho()
        {
            return NomeDoCliente + "                    " + DataEHoraDaCompra.ToString("/DD/MM/YYYY - HH:MM:SS");
        }

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: 
         *
         * return: string NomeDoProduto e o ValorTotal
         */
        public string CorpoDaPagina()
        {
            return NomeDoProduto + "                    " + GetValorTotal();
        }

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de uma compra
         *
         * param: 
         *
         * return: double ValorTotal
         */
        public double GetValorTotal()
        {
            return ValorTotal;
        }
    }
}