using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o numero da conta: ");
            int numerodaconta = int.Parse(Console.ReadLine());

            Console.Write("Escreva o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial?(s/n) ");
            char check = char.Parse(Console.ReadLine());
            if(check == 's' || check == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta (titular, numerodaconta, depositoinicial);
            }
            else
            {
                c = new Conta(titular, numerodaconta);
            }

            Console.WriteLine("Dados Atualizados: " + c);

            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.AdicionaSaldo(deposito);

            Console.WriteLine("Dados Atualizados: " + c);

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.SacaSaldo(saque);

            Console.WriteLine("Dados Atualizados: " + c);

        }
    }
}
