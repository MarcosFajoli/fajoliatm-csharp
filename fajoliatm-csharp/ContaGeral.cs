using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    public class ContaGeral : Cliente
    {
        private double saldoGeral;

        public double SaldoGeral { get { return saldoGeral; } set { saldoGeral = value; } }

        public ContaGeral (string nomeCliente, DateTime dataCliente, double saldo) 
        { 
            Random rand = new Random();

            Id = rand.Next(100000, 999999);
            Nome = nomeCliente;
            DataNasc = dataCliente;
            SaldoGeral = saldo;
        }
    }
}
