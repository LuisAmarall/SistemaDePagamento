using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagamento
{
    internal class Cobranca
    {
        public static void PagamentoComPix(Armazenamento dados)
        {
            if (dados.PagarComPix())
            {
                Console.WriteLine("Sua divida foi paga com sucesso.");
                Console.WriteLine("Seu saldo de debito atual é " + dados.Debito);
            }
            else
            {
                Console.WriteLine("Sua divida não foi paga, saldo insuficiente.");
                Console.WriteLine("Seu saldo atual é de R$" + dados.Debito);
            }
        }

        public static void PagamentoComCredito(Armazenamento dados)
        {

            if (dados.PagarComCredito())
            {
                Console.WriteLine("Sua divida foi paga com sucesso.");
                Console.WriteLine("Seu saldo de credito atual é "+ dados.Credito);
            }
            else
            {
                Console.WriteLine("Sua divida não foi paga, saldo insuficiente.");
                Console.WriteLine("Seu saldo de credito atual é de R$" + dados.Debito );
            }
        }

        public static void PagamentoSimples(Armazenamento dados)
        {

            if (dados.PagarComDebito())
            {
                Console.WriteLine("Sua divida foi paga com sucesso.");
                Console.WriteLine("Seu saldo de credito atual é " + dados.Debito);
            }
            else
            {
                Console.WriteLine("Sua divida não foi paga, saldo insuficiente.");
                Console.WriteLine("Seu saldo atual é de R$" + dados.Debito);
            }
        }
    }
}
