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
    public partial class FrmEditarUser : Form
    {
        public FrmEditarUser()
        {
            InitializeComponent();
        }

        private void FrmEditarUser_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void CarregaDataGrid(string nome = "")
        {
            var lista = Usuario.ObterListaUsuario(nome);
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Id_funcionario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Login;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Ativo;
                cont++;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicaoLinha = dgvUsuarios.CurrentRow.Index;
            int id = 0;
            string nome = "";
            string login = "";
            bool ativo = false;
            id = Convert.ToInt32(dgvUsuarios.Rows[posicaoLinha].Cells[0].Value);
            nome = dgvUsuarios.Rows[posicaoLinha].Cells[1].Value.ToString();
            login = dgvUsuarios.Rows[posicaoLinha].Cells[2].Value.ToString();
            ativo = Convert.ToBoolean(dgvUsuarios.Rows[posicaoLinha].Cells[3].Value);
            txtIdUsuario.Text = id.ToString();
            txtEmail.Text = login;
            if (ativo = true) chkAtivo.Checked = ativo;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(
                Convert.ToInt32(txtIdUsuario.Text),
                txtEmail.Text,
                txtSenha.Text,
                chkAtivo.Checked
                );

            if (txtSenha.Text != string.Empty && txtConfSenha.Text != string.Empty)
            {
                usuario.AtualizarUsuario();
                MessageBox.Show($"Usuário: {usuario.Login} foi atualizado com sucesso!", "SmLocações");
                txtIdUsuario.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtConfSenha.Clear();
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Insira uma senha para a conclusão da atualização de usuário!", "SmLocações");
            }
            
        }
    }
}
