using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    public class ContaGeral
    {
        private int id;
        private Cliente cliente;
        private double saldoGeral;

        public int Id { get { return id; } set { id = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public double SaldoGeral { get { return saldoGeral; } set { saldoGeral = value; } }

        public ContaGeral (Cliente infoCliente, double saldo) 
        { 
            Random rand = new Random();

            Id = int.Parse(infoCliente.Id.ToString() + "0" + rand.Next(1000, 9999).ToString());
            Cliente = infoCliente;
            SaldoGeral = saldo;
        }
    }
}
