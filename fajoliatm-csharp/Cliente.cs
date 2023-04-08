using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private DateTime dataNasc;

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public DateTime DataNasc { get { return dataNasc; } set { dataNasc = value; } }

        internal Cliente(string nomeCliente, DateTime dataCliente)
        {
            Random rand = new Random();

            Id = rand.Next(1000, 9999);
            Nome = nomeCliente;
            DataNasc = dataCliente;
        }
    }
}
