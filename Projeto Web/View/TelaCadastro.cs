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
using Projeto_Web.Controllers;

namespace Projeto_Web
{
    public partial class TelaCadastro : Form
    {
        UsuarioController ctrlUsuario;
        CadastroModel usuario;

        public TelaCadastro()
        {
            InitializeComponent();
            ctrlUsuario = new UsuarioController();
        }

        private void Salvar(object sender, EventArgs e)
        {
            usuario = new CadastroModel();

            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.User = txtUser.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Repitasenha = txtRepSenha.Text;

            ctrlUsuario.Salvar(usuario);
        }
    }
}
