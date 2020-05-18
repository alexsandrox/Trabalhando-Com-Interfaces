using ProjetoInterfaces.Interfaces;
using System;

namespace ProjetoInterfaces.Models
{
    public class ImpressoraEpson : InterfaceImpressora
    {
        public void Imprimir(InterfaceDocumentoImprimivel document)
        {
            Console.WriteLine("   ====================================================");
            Console.WriteLine("   ===============   EPSON DESKJET 1200   =============");
            Console.WriteLine("   ====================================================\n");
            Console.WriteLine("   " + document.Cabecalho());
            Console.WriteLine("   ====================================================\n");
            Console.WriteLine("   " + document.CorpoDaPagina());
            Console.WriteLine("   ====================================================");
        }
    }
}
