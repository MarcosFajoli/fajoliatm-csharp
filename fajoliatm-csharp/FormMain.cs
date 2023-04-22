namespace fajoliatm_csharp
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            List<string> items = new List<string>();

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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