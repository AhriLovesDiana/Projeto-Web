using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Web.Models;

namespace Projeto_Web
{
    public partial class TelaCadastro : Form
    {
        CadastroModel cliente;
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e)
        {
            cliente = new CadastroModel();

            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.User = txtUser.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Repitasenha = txtRepSenha.Text;
            ctrlCliente.Salvar(cliente);
            this.Close();
        }
    }
}
