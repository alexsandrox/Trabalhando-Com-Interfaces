using ProjetoInterfaces.Interfaces;

namespace ProjetoInterfaces.Models
{
    public class OperadoraDeCartaoCielo : InterfaceOperadoraDeCartao
    {
        /**
         * 
         * cada operadora tem sua própria regra de negócios, aqui estou criando a regra apenas para uso didático
         * 
         * params: InterfaceDocumentoAutorizavel document, Cartao cartao
         * 
         * return bool
         * 
         */
        public bool AutorizarCompra(InterfaceDocumentoAutorizavel document, Cartao cartao)
        {
            return cartao.NumeroDoCartao.StartsWith("3456") && document.GetValorTotal() < 3000.00;
        }
    }
}
