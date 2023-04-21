using System.IO;

namespace fajoliatm_csharp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
                Application.Run(new FormCadastro());
            } else
            {
                string conteudo = File.ReadAllText(files_accounts);

                if (conteudo.Length == 0)
                {
                    Application.Run(new FormCadastro());
                }
                else
                {
                    Application.Run(new FormMain());
                }
            } 
        }
    }
}