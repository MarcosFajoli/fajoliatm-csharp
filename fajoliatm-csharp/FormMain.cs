namespace fajoliatm_csharp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastro formCadastro = new FormCadastro(); 
            formCadastro.ShowDialog();
        }
    }
}