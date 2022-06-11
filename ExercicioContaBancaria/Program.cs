using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Progam
    {
        static void Main(string[] args)
        {   string escolha;
            Conta p = new Conta();
            
            Console.WriteLine("-----CONTA BANCARIA-----");
            Console.WriteLine();
            Console.Write("Digite o numero da conta: ");
            p.Numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            p.Titular = Console.ReadLine();

            Console.Write("Deseja fazer um deposito s/n : ");
            escolha = Console.ReadLine();
            if (escolha == "s")
            {
                Console.Write("Digite o valor a ser aplicado: $");
                p.Saldo = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine($"Dados da Conta: {p.Titular}");
            Console.WriteLine(p);
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: $");
            double novoDeposito = double.Parse(Console.ReadLine());
            Console.WriteLine();
            p.AdicionarlSaldo(novoDeposito);

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(p);

            Console.Write("Insira um valor para saque (*taxa administrativa de $5,00) :");
            double sacar = double.Parse(Console.ReadLine());
            p.Sacar(sacar);
            Console.WriteLine();

            Console.WriteLine(p);


        }
    }
}
