using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp_Encapsulamento
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } //Será private porque o Saldo só pode ser alterado por Depósito e Saque.


        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero,titular)
        {
            Saldo = saldo;
        }


        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
               
        }

        public void Deposito(double quantia) //Acrescenta valor no saldo da conta.
        {
            Saldo += quantia;
        }

        public void Saque(double quantia) // Retira valor do saldo da conta e retira $ 5.00 de taxa.
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

    }
}
