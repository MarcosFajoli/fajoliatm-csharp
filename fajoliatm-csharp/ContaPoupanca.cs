using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    internal class ContaPoupanca : Conta
    {
        private int id;
        private double saldo;

        public int Id { get { return id; } set { id = value; } }
        public double Saldo { get { return saldo; } set { saldo = value; } }

        public ContaPoupanca (double saldoConta, string nome) : base(nome)
        {
            Random random = new Random();

            this.Id = random.Next(100000, 999999);
            this.Saldo = saldoConta;
        }
    }
}
