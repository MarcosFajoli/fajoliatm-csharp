using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
	internal class ContaCorrente : Conta
	{
		private int id;
		private decimal saldo; 

		public int Id { get { return id; } set { id = value; } }
		public decimal Saldo { get { return saldo; } set { saldo = value; } }

		public ContaCorrente (int id, decimal saldoConta, string nome ) : base(nome)
		{
            Id = id;
            Saldo = saldoConta;
        }

        public override void Salvar ()
        {
            string path_accounts_file = "accounts.txt";

            using (StreamWriter writer = new StreamWriter(path_accounts_file, true))
            {
                var conta = (
                    Id,
                    Nome,
                    "Conta Corrente",
                    Saldo
                );
                writer.WriteLine(conta);
            }
        }
	}
}
