using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace fajoliatm_csharp
{
    internal static class Validacoes
    {
        public static bool ContemNumeros(string input)
        {
            // Define a expressão regular para procurar dígitos
            Regex regex = new Regex(@"\d+");
            return regex.IsMatch(input);
        }

        public static bool ContemCaracteresEspeciais(string input)
        {
            // Define a expressão regular para caracteres especiais
            Regex regex = new Regex(@"[^a-zA-Z0-9]");
            return regex.IsMatch(input);
        }

        public static bool ContemNomeInvalido(string input)
        {
            // Define a expressão regular para caracteres especiais
            Regex regex = new Regex(@"^[a-zA-Z0-9\s]*$");
            return !regex.IsMatch(input);
        }
    }
}
