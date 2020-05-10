/**
 * Interface Documento Imprimivel
 * 
 * Uma interface é 100% abstrata, é o nível máximo de abstração do C#
 * 
 * Todos os métodos de uma Interface são abstratos, nenhum método tem implementação
 * 
 * Na Interface abaixo vamos definir um contrato para um Documento Imprimível.
 * 
 */

namespace ProjetoInterfaces.Interfaces
{
    public interface InterfaceDocumentoImprimivel
    {
        /*
         * Impressora que assina esse contrato sabe criar um Cabeçalho
         *
         * param: 
         *
         * return: string text
         */
         string Cabecalho();

        /*
         * Impressora que assina esse contrato sabe criar o Corpo da Página
         *
         * param: 
         *
         * return: string text
         */
         string CorpoDaPagina();
    }
}