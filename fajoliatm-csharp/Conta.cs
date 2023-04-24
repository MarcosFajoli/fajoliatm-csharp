using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    internal class Conta : Cliente
    {
        public Conta(string nome) : base(nome)
        {

        }

        public virtual void Salvar() { }

        public virtual string Sacar(decimal valor) { return "erro"; }

        public virtual string Depositar(decimal valor) { return "erro"; }

        public virtual string Transferir() { return "erro"; }

    }
}
