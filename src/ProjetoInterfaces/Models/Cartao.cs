/**
 * Classe Cartao
 * 
 * 
 * Cria um objeto do tipo Cartao para que seja realizada a compra
 * 
 */
 
namespace ProjetoInterfaces.Models
{
    public class Cartao
    {
        /*
         * 
         * Construtor da classe Cartao
         *
         * params: string nomeDoTitular, string numeroDoCartao 
         *
         * return: Cartao
         */
        public Cartao(string nomeDoTitular, string numeroDoCartao )
        {
            NomeDoTitular = nomeDoTitular;
            NumeroDoCartao = numeroDoCartao;
        }

        /*
         * param: string nomeDoTitular
         *
         * return: string NomeDoTitular
         */
        public string NomeDoTitular { get; private set; }

        /*
         * param: string NumeroDoCartao
         *
         * return: string NumeroDoCartao
         */      
        public string NumeroDoCartao { get; private set; }
    }
}