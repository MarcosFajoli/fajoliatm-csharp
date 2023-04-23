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

            Random random = new Random();

            string nome_cliente = TextBoxNome.Text;
            string valor_inicial_string = ValorDeposito.Text;

            if (string.IsNullOrWhiteSpace(nome_cliente))
            {
                MessageBox.Show("Informe um nome válido");
                return;
            }

            if (!double.TryParse(valor_inicial_string, out double valor_inicial))
            {
                MessageBox.Show("Informe um valor inicial válido");
                return;
            }

            if (TipoConta.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um tipo de conta");
                return;
            }

            int tipoConta = TipoConta.SelectedIndex;

            using (StreamWriter writer = new StreamWriter(path_accounts_file, true))
            {
                var conta = (
                    random.Next(100000, 999999),
                    TextBoxNome.Text,
                    TipoConta.Text,
                    ValorDeposito.Text
                );
                writer.WriteLine(conta);
            }

            this.Hide();
            Program.tela_main.ShowDialog();

        }
    }
}
