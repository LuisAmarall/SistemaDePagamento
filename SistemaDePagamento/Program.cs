using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace SistemaDePagamento
{
    internal class Program
    {
        public static void Main (String [] arg)
        {
            Armazenamento entrada = new Armazenamento(100, 10, 0.06, 1000, 1000);

            Cobranca.PagamentoComCredito(entrada);
            //Console.WriteLine();
            //Cobranca.PagamentoComPix(entrada);
            //Console.WriteLine();
            //Cobranca.PagamentoSimples(entrada);
            

        }
    }
}