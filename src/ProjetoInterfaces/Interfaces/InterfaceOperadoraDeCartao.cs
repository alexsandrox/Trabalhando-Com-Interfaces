/**
 * Interface Operadora de Cartao de Credito
 * 
 * Uma interface é 100% abstrata, é o nível máximo de abstração do C#
 * 
 * Todos os métodos de uma Interface são abstratos, nenhum método tem implementação
 * 
 * Na Interface abaixo vamos definir um contrato para uma Operadora de Cartao de Credito.
 * 
 */
 
using ProjetoInterfaces.Models;

namespace ProjetoInterfaces.Interfaces
{
    public interface InterfaceOperadoraDeCartao
    {
        /*
         * Impressora que assina esse contrato sabe autorizar uma compra feita pelo cliente
         * 
         * Para autorizar a compra devemos receber um Documento Autorizável e o número do Cartão
         *
         * param: 
         *
         * return: bool
         */
        bool AutorizarCompra(InterfaceDocumentoAutorizavel document, Cartao cartao);
    }
}