using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fajoliatm_csharp
{
    public partial class FormSacarDepositar : Form
    {
        private int index_conta;
        private string saque_deposito;
        private List<string> fileContent = File.ReadAllLines("accounts.txt").ToList();
        private string contaMod;

        public FormSacarDepositar(int index_conta, string saque_deposito)
        {
            this.index_conta = index_conta;
            this.saque_deposito = saque_deposito;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormSacarDepositar_Load(object sender, EventArgs e)
        {
            string[] conta = fileContent[this.index_conta].Trim('(', ')').Split(", ");

            ButtonSacarDepositar.Text = saque_deposito;
            SaldoAtual.Text = conta[3];
        }

        private void ButtonSacarDepositar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(ValorSaqueDeposito.Text, out decimal valor))
            {
                MessageBox.Show("Informe um valor válido. ");
                return;
            }

            string[] conta = fileContent[this.index_conta].Trim('(', ')').Split(", ");

            if (saque_deposito == "Sacar")
            {  
                if (conta[2] == "Conta Corrente")
                {
                    ContaCorrente contaAtual = new ContaCorrente(int.Parse(conta[0]), decimal.Parse(conta[3]), conta[1]);
                    contaMod = contaAtual.Sacar(valor);
                }
                else
                {
                    ContaPoupanca contaAtual = new ContaPoupanca(int.Parse(conta[0]), decimal.Parse(conta[3]), conta[1]);
                    contaMod = contaAtual.Sacar(valor);
                }
            } 
            else
            {
                if (conta[2] == "Conta Corrente")
                {
                    ContaCorrente contaAtual = new ContaCorrente(int.Parse(conta[0]), decimal.Parse(conta[3]), conta[1]);
                    contaMod = contaAtual.Depositar(valor);
                }
                else
                {
                    ContaPoupanca contaAtual = new ContaPoupanca(int.Parse(conta[0]), decimal.Parse(conta[3]), conta[1]);
                    contaMod = contaAtual.Depositar(valor);
                }
            }

            if (contaMod != "erro")
            {
                fileContent[this.index_conta] = contaMod;
                File.WriteAllLines("accounts.txt", fileContent);

                MessageBox.Show(saque_deposito + " realizado com sucesso. ");

                this.Close();
                Program.tela_main.Show();
            }
        }
    }
}
