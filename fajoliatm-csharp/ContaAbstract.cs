using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    internal abstract class ContaAbstract
    {
        public string ValidaSaque(double saldo, double valor, string tipo)
        {
            if (valor > saldo) {
                return "VALOR>SALDO";
            } 
            else {
                if (tipo == "poupanca" && valor > 1000)
                {
                    return "VALOR EXCEDIDO";
                }
            }

            return "OK";
        }

        /*public bool ValidaDeposito(double valor)
        {

        }*/
    }
}
