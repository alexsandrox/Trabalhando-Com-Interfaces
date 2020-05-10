/**
 * Interface Documento Autorizável
 * 
 * Uma interface é 100% abstrata, é o nível máximo de abstração do C#
 * 
 * Todos os métodos de uma Interface são abstratos, nenhum método tem implementação
 * 
 * Na Interface abaixo vamos definir um contrato para um Documento Autorizável.
 * 
 */

namespace ProjetoInterfaces.Interfaces
{
    public interface InterfaceDocumentoAutorizavel
    {
        /*
         * Impressora que assina esse contrato sabe verificar se existe um Valor para ser autorizável
         * 
         * param: 
         *
         * return: double
         */
        double GetValorTotal();  
    }
}