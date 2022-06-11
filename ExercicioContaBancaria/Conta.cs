using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContaBancaria
{
     class Conta
    {
        public string Titular { get; set; }
        public int Numero { get; set; }        
        public double Saldo { get; set; }


        public Conta()
        {

        }

        public Conta(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public Conta(string titular, int numero, double saldo)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldo;
        }

        public double AdicionarlSaldo(double saldo) {

            Saldo = Saldo + saldo;
            return Saldo;
        }

        public double Sacar(double saldo) { 
            
            return Saldo =  (Saldo - saldo) - 5;
        }

        public override string ToString()
        {
            return  "Numero da Conta: " + Numero + "\nTitular da Conta: " + Titular + "\nSaldo Atual: $" + Saldo;

        }
    }
}
