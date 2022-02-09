using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios
{
    internal class Conta
    {
        public string Titular { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        
        private static double Taxa = 5.00;


        public Conta(string titular, int numerodaconta)
        {
            Titular = titular;
            NumeroConta = numerodaconta;
        }

        public Conta (string titular, int numerodaconta, double depositoInicial):this(titular, numerodaconta)
        {
            AdicionaSaldo(depositoInicial);
        }


        
        public void AdicionaSaldo(double deposito)
        {
             Saldo += deposito;
        }
        public void SacaSaldo(double saque)
        {
            Saldo -= saque;
            Saldo -= Taxa;
        }

        public override string ToString()
        {
            return
                "Conta: " + NumeroConta +
                ", Titular: " + Titular +
                ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
