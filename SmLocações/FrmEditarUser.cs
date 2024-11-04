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
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id_funcionario.Nome;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Login;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Ativo;
                cont++;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicaoLinha = 0;
            string nome = "";
            nome = dgvUsuarios.Rows[posicaoLinha].Cells[0].Value.ToString();
            Usuario.ObterListaUsuario(nome);
            Usuario usuario = new(nome);
            txtIdUsuario.Text = usuario.Id.ToString();
            txtEmail.Text = usuario.Login;
            txtSenha.Text = usuario.Senha;
            txtConfSenha.Text = usuario.Senha;
            
        }
    }
}
