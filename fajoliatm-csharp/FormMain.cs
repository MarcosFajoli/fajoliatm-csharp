namespace fajoliatm_csharp
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMain_Load(object sender, EventArgs e)
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

        private void ButtonCadastro_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.tela_cadastro.Show();
        }

        private void ButtonTransferir_Click(object sender, EventArgs e)
        {
            int index_conta_origem = ComboBoxContas.SelectedIndex;
            FormTransferencia tela_transferecia = new FormTransferencia(index_conta_origem);

            this.Hide();
            tela_transferecia.Show();
        }
    }
}