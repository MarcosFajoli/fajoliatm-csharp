using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fajoliatm_csharp
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            string path_accounts_file = "accounts.txt";

            string nome_cliente = TextBoxNome.Text;
            string valor_inicial_string = ValorDeposito.Text;

            if (nome_cliente.Length != 0) 
            { 
                if (double.TryParse(valor_inicial_string, out double valor_inicial))
                {
                    Cliente cliente = new Cliente(nome_cliente);

                    int tipoConta = TipoConta.SelectedIndex;

                    if (tipoConta == 0) 
                    {
                        Conta conta_cliente = new Conta(nome_cliente);
                        ContaCorrente conta_corrente_cliente = new ContaCorrente(valor_inicial, nome_cliente);

                        using (StreamWriter writer = new StreamWriter(path_accounts_file, true))
                        {
                            var conta = (
                                conta_corrente_cliente.Id,
                                conta_corrente_cliente.Nome,
                                TipoConta.Text,
                                conta_corrente_cliente.Saldo
                            );
                            writer.WriteLine(conta);
                        }

                    } else if (tipoConta == 1)
                    {
                        Conta conta_cliente = new Conta(nome_cliente);
                        ContaPoupanca conta_poupanca_cliente = new ContaPoupanca(valor_inicial, nome_cliente);

                        using (StreamWriter writer = new StreamWriter(path_accounts_file, true))
                        {
                            var conta = (
                                conta_poupanca_cliente.Id,
                                conta_poupanca_cliente.Nome,
                                TipoConta.Text,
                                conta_poupanca_cliente.Saldo
                            );

                            writer.WriteLine(conta);
                        }

                    } else
                    {
                        MessageBox.Show("Selecione um tipo de conta");
                    }
                } else
                {
                    MessageBox.Show("Informe um valor inicial valido");
                }
            } else {
                MessageBox.Show("Informe um nome");
            }
        }
    }
}
