/**
 * Interface Impressora
 * 
 * Uma interface é 100% abstrata, é o nível máximo de abstração do C#
 * 
 * Todos os métodos de uma Interface são abstratos, nenhum método tem implementação
 * 
 * Na Interface abaixo vamos definir um contrato para uma Impressora.
 * 
 */

namespace ProjetoInterfaces.Interfaces
{
    public interface InterfaceImpressora
    {
        /*
         * Impressora que assina esse contrato sabe imprimir um documento imprimível
         *
         * param: DocumentoImprimivel
         *
         * return: void
         */
        string Imprimir(InterfaceDocumentoImprimivel document);
        
        /*
         * Impressora que assina esse contrato sabe imprimir um documento imprimível e uma mensagem de texto
         *
         * param: DocumentoImprimivel document, string Message
         *
         * return: InterfaceDocumentoImprimivel document
         */
        InterfaceDocumentoImprimivel Imprimir(InterfaceDocumentoImprimivel document, string Message);


    }
}