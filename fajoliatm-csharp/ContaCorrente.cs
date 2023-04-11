using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
	internal class ContaCorrente : InterfaceConta
	{
		private int id;
		private double saldo;
		private ContaGeral contaGeral;

		public int Id { get { return id; } set { id = value; } }
		public double Saldo { get { return saldo; } set { saldo = value; } }
		public ContaGeral ContaGeral { get { return contaGeral; } set { contaGeral = value; } }

		public ContaCorrente ( ContaGeral conta, double saldoConta )
		{
		Id = conta.Id;
		ContaGeral = conta;
		Saldo = saldoConta;
		}

		public void Sacar ( double valor )
		{

		}

		public void Depositar ( double valor )
		{

		}
	}
}
