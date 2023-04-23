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
    public partial class FormTransferencia : Form
    {
        private int index_conta_origem;
        public FormTransferencia(int index_conta_origem)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.index_conta_origem = index_conta_origem;
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            string path_accounts_file = "accounts.txt";
            List<string> items = new List<string>();

            using (StreamReader reader = new StreamReader(path_accounts_file))
            {
                string item;
                while ((item = reader.ReadLine()) != null)
                {
                    items.Add(item);
                }
            }

            ContaDestino.DataSource = items;
        }

        private void ButtonTransferir_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(ValorTransferencia.Text, out decimal valor_inicial))
            {
                MessageBox.Show("Informe um valor de transferencia válido");
                return;
            }

            if (this.index_conta_origem == ContaDestino.SelectedIndex)
            {
                MessageBox.Show("Não é possivel transferir pra você mesmo!");
                return;
            }

            string filePath = "accounts.txt";
            List<string> fileContent = File.ReadAllLines(filePath).ToList();

            string[] conta_origem = fileContent[this.index_conta_origem].Trim('(', ')').Split(", ");
            string[] conta_destino = fileContent[ContaDestino.SelectedIndex].Trim('(', ')').Split(", ");

            decimal valor_trans = Decimal.Parse(ValorTransferencia.Text);
            decimal valor_conta_origem = Decimal.Parse(conta_origem[3]);

            if (valor_conta_origem < valor_trans)
            {
                MessageBox.Show("Sem saldo suficiente");
                return;
            }

            decimal valor_conta_destino = Decimal.Parse(conta_destino[3]);

            decimal novo_saldo_origem = valor_conta_origem -= valor_trans;
            decimal novo_saldo_destino = valor_conta_destino += valor_trans;

            var conta_origem_nova = Tuple.Create(int.Parse(conta_origem[0]), conta_origem[1], conta_origem[2], novo_saldo_origem);
            var conta_destino_nova = Tuple.Create(int.Parse(conta_destino[0]), conta_destino[1], conta_destino[2], novo_saldo_destino);

            fileContent[this.index_conta_origem] = conta_origem_nova.ToString();
            fileContent[ContaDestino.SelectedIndex] = conta_destino_nova.ToString();

            File.WriteAllLines(filePath, fileContent);

            this.Close();
            Program.tela_main.Show();
        }
    }
}
