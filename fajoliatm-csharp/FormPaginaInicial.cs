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
    public partial class FormPaginaInicial : Form
    {
        private ContaGeral contaAberta;
        public FormPaginaInicial(ContaGeral conta)
        {
            InitializeComponent();
            contaAberta = conta;

            labelNome.Text = "Bem vindo(a), " + contaAberta.Cliente.Nome;
        }
    }
}
