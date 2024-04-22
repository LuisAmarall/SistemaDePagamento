using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagamento
{
    internal class Armazenamento
    {
        public double Divida { get; private set; }

        public double Desconto { get; private set; }

        public double Juros { get; private set; }

        public double Debito { get; private set; }

        public double Credito { get; private set; }

        public bool PagarComPix()
        {
            Divida = Divida -  Desconto;
            if (Divida < Debito)
            {
                Debito -= Divida;
                Divida = 0;
                return true;
            }

            return false;
        }

        public bool PagarComCredito()
        {
            Divida = Divida + (Divida * Juros);
            if (Divida < Credito)
            {
                Credito -= Divida;
                Divida = 0;
                return true;
            }

            return false;
        }

        public bool PagarComDebito()
        {
            if (Divida < Debito)
            {
                Desconto -= Divida;
                Divida = 0;
                return true;
            }

            return false;
        }

        public Armazenamento(double divida, double desconto, double juros, double debito, double credito)
        {
            Divida = divida;
            Desconto = desconto;
            Juros = juros;
            Debito = debito;
            Credito = credito;
        }
    }
}
