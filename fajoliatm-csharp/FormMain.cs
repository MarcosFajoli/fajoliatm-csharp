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
            FormCadastro formCadastro = new FormCadastro(); 
            formCadastro.ShowDialog();
        }
    }
}