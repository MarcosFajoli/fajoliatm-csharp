using System.IO;

namespace fajoliatm_csharp
{
    internal static class Program
    {

        public static FormMain tela_main = new FormMain();
        public static FormCadastro tela_cadastro = new FormCadastro(true);

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string files_accounts = "accounts.txt";

            if (!File.Exists(files_accounts))
            {
                File.Create(files_accounts).Close();

                tela_cadastro.ShowDialog();

            } else
            {
                string conteudo = File.ReadAllText(files_accounts);

                if (conteudo.Length == 0)
                {
                    tela_cadastro.ShowDialog();
                }
                else
                {
                    Application.Run(tela_main);
                }
            } 
        }
    }
}