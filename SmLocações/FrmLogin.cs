using SmLocaçõesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmLocações
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario != null && usuario.Id > 0)
                {
                    if (usuario.Ativo == "Sim")
                    {
                        Program.UsuarioLogado = usuario;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário está inativo. \nProcure a gerência.");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos ou inexistentes \nProcure a gerência.");
                    txtEmail.Focus();
                }

            }
            else
            {
                MessageBox.Show("Você deve preencher email e senha");
                txtEmail.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
