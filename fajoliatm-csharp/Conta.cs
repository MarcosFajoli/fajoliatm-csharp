using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    internal class Conta : Cliente
    {
        public Conta(string nome, DateTime dataNasc) : base(nome, dataNasc)
        {

        }

        public double Sacar(ContaCorrente conta, double valor)
        {

            return conta.Saldo;
        }

        public double Sacar(ContaPoupanca conta, double valor)
        {

            return conta.Saldo;
        }

        public double Depositar(ContaCorrente conta, double valor)
        {

            return conta.Saldo;
        }

        public double Depositar(ContaPoupanca conta, double valor)
        {

            return conta.Saldo;
        }
    }
}
