namespace fajoliatm_csharp
{
    public partial class FormMain : Form
    {
        private int index_conta_origem;

        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private string[] MapearItens()
        {
            List<string> items = new List<string>();
            foreach (var item in ComboBoxContas.Items)
            {
                items.Add(item.ToString());
            }

            var newItems = items.ToArray();
            string[] conta = newItems[ComboBoxContas.SelectedIndex].Trim('(', ')').Split(", ");

            return conta;
        }

        private void CarregarItems()
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

            string[] arrayItems = items.ToArray();

            ComboBoxContas.DataSource = items;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CarregarItems();
            ComboBoxContas.SelectedIndex = 0;

            string[] conta = MapearItens();

            NomeConta.Text = conta[1];
            TipoConta.Text = conta[2];
            SaldoValor.Text = conta[3];
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            CarregarItems();
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro tela_cadastro = new FormCadastro(false);
            this.Hide();
            tela_cadastro.ShowDialog();
        }

        private void ButtonTransferir_Click(object sender, EventArgs e)
        {
            index_conta_origem = ComboBoxContas.SelectedIndex;
            FormTransferencia tela_transferencia = new FormTransferencia(index_conta_origem);

            this.Hide();
            tela_transferencia.ShowDialog();
        }

        private void ButtonSacar_Click(object sender, EventArgs e)
        {
            index_conta_origem = ComboBoxContas.SelectedIndex;
            FormSacarDepositar tela_saque = new FormSacarDepositar(index_conta_origem, "Sacar");

            this.Hide();
            tela_saque.ShowDialog();
        }

        private void ButtonDepositar_Click(object sender, EventArgs e)
        {
            index_conta_origem = ComboBoxContas.SelectedIndex;
            FormSacarDepositar tela_deposito = new FormSacarDepositar(index_conta_origem, "Depositar");

            this.Hide();
            tela_deposito.ShowDialog();
        }

        private void ComboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] conta = MapearItens();

            NomeConta.Text = conta[1];
            TipoConta.Text = conta[2];
            SaldoValor.Text = decimal.Parse(conta[3]).ToString("C");
        }
    }
}