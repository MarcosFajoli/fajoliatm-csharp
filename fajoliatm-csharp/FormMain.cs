namespace fajoliatm_csharp
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            string path_accounts_file = "accounts.txt";
            List<string> items = new List<string>();

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void ButtonTransferir_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}