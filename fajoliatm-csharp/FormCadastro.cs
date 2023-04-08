using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fajoliatm_csharp
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void ButtonCriarConta_Click(object sender, EventArgs e)
        { 
            string erros = "";
            string nome = InputNomeCompleto.Text;
            string login = InputUserLogin.Text;
            DateTime dataNasc = InputDataNasc.Value;
            DateTime dataAgora = DateTime.Now;

            // Verificações sobre as strings inseridas
            if (ContemNumeros(nome) || ContemNomeInvalido(nome))
            {
                erros += "Escreva seu nome corretamente, sem dígitos ou caracteres especiais. \n\n";
            }
            if (ContemCaracteresEspeciais(login))
            {
                erros += "Seu login não pode conter caracteres especiais. \n\n";
            }
            if (dataAgora.Year - dataNasc.Year < 18)
            {
                erros += "Faça 18 anos para abrir uma conta no Banco Lemarciao. \n\n";
            }

            if (erros != "")
            {
                MessageBox.Show(erros);
                erros = "";
            } 
            else
            {
                Cliente cliente = new Cliente(nome, dataNasc);
                ContaGeral contaGeral = new ContaGeral(cliente, 0);
            }
        }

        private bool ContemNumeros(string input)
        {
            // Define a expressão regular para procurar dígitos
            Regex regex = new Regex(@"\d+");
            return regex.IsMatch(input);
        }

        private bool ContemCaracteresEspeciais(string input)
        {
            // Define a expressão regular para caracteres especiais
            Regex regex = new Regex(@"[^a-zA-Z0-9]");
            return regex.IsMatch(input);
        }

        private bool ContemNomeInvalido(string input)
        {
            // Define a expressão regular para caracteres especiais
            Regex regex = new Regex(@"^[a-zA-Z0-9\s]*$");
            return !regex.IsMatch(input);
        }
    }
}
