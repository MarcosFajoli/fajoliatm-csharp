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
            string nome_cliente = TextBoxNome.Text;
            string valor_inicial_string = ValorDeposito.Text;
            int tipoConta = TipoConta.SelectedIndex;

            Random random = new Random();
            int id = random.Next(100000, 999999);

            if (string.IsNullOrWhiteSpace(nome_cliente))
            {
                MessageBox.Show("Informe um nome válido. ");
                return;
            }

            if (!decimal.TryParse(valor_inicial_string, out decimal valor_inicial))
            {
                MessageBox.Show("Informe um valor inicial válido. ");
                return;
            }

            if (tipoConta < 0)
            {
                MessageBox.Show("Selecione um tipo de conta. ");
                return;
            }

            if (tipoConta == 0) //contacorrente
            {
                ContaCorrente contaCorrente = new ContaCorrente(id, valor_inicial, nome_cliente);
                contaCorrente.Salvar();
            } 
            else //contapoupanca
            {
                ContaPoupanca contaPoupanca = new ContaPoupanca(id,valor_inicial, nome_cliente);
                contaPoupanca.Salvar();
            }

            this.Close();
            Program.tela_main.Show();

        }
    }
}
