using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    public class Cliente
    {
        private int id;
        private string nome;
        private DateTime dataNasc;

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public DateTime DataNasc { get { return dataNasc; } set { dataNasc = value; } }

        public Cliente(string nome, DateTime dataNasc) 
        {
            Random random = new Random();

            this.Id = random.Next(100000, 999999);
            this.Nome = nome;
            this.DataNasc = dataNasc;
        }
    }
}
