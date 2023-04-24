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

        public virtual void Sacar() { }

        public virtual void Depositar() { }

        public virtual void Transferir() { }

    }
}
