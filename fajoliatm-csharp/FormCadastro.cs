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
            if (Validacoes.ContemNumeros(nome) || Validacoes.ContemNomeInvalido(nome))
            {
                erros += "Escreva seu nome corretamente, sem dígitos ou caracteres especiais. \n\n";
            }
            if (Validacoes.ContemCaracteresEspeciais(login))
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
                ContaGeral contaGeral = new ContaGeral(nome, dataNasc, 0);

                FormPaginaInicial formPaginaInicial = new FormPaginaInicial(contaGeral);
                formPaginaInicial.ShowDialog();
            }
        }

        private void ButtonVoltarMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
