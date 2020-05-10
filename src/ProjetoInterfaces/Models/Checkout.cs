/**
 * Classe Checkout
 * 
 * 
 * Cria um objeto do tipo Checkout
 * 
 * Injetando Dependência de InterfaceOperadoraDeCartao e InterfaceImpressora
 *
 */

using ProjetoInterfaces.Interfaces;

namespace ProjetoInterfaces.Models
{
    public class Checkout
    {
        /*
         * 
         * Construtor da classe Checkout
         *
         * params: InterfaceOperadoraDeCartao operadora, InterfaceImpressora impressora
         *
         * return: Checkout
         */
        public Checkout(InterfaceOperadoraDeCartao operadora, InterfaceImpressora impressora)
        {
            _operadora = operadora;
            _impressora = impressora;
        }

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de um checkout da compra
         *
         * param: NomeDoProduto
         *
         * return: string NomeDoProduto
         */      
        private readonly InterfaceOperadoraDeCartao _operadora;

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de um checkout da compra
         *
         * param: NomeDoProduto
         *
         * return: string NomeDoProduto
         */  
        private readonly InterfaceImpressora _impressora;

        /*
         * 
         * Lógica de Negócios aqui é totalmente para ilustrar ou fantasiar o funcionamento de um checkout da compra
         *
         * params: Compra compra, Cartao cartao
         *
         * return: string FecharCompra
         */         
        public string FecharCompra(Compra compra, Cartao cartao)
        {
            // Verificar com a operadora de cartão se a compra está ou não Autorizada
            bool autorizado = _operadora.AutorizarCompra(compra, cartao);

            // Compra assina o contrato InterfaceDocumentoImprimivel
            if(autorizado)
                return _impressora.Imprimir(compra);
            
            return "Compra não autorizada";
        }
    }
}