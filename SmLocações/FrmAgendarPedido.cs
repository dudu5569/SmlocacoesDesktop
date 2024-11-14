using SmLocaçõesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmLocações
{
    public partial class FrmAgendarPedido : Form
    {
        public FrmAgendarPedido()
        {
            InitializeComponent();
        }

        private void FrmAgendarPedido_Load(object sender, EventArgs e)
        {
            carregaGrid();
            CarregaFuncionario();
            CarregaComboboxCategoria();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            AgendamentoPedido agendar = new(
               Cliente.ObterPorId(int.Parse(txtIdCliente.Text)),
                Funcionario.ObterporId(int.Parse(cmbFuncionario.ValueMember)),
                dataRetirada.Value,
                dataEntrega.Value
                );

            agendar.InserirPedido();
            if (agendar.ID > 0)
            {
                MessageBox.Show("Pedido agendado com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tabControl1.SelectedTab = tabPage2;
                txtIdCliente.Clear();
                txtNomeCliente.Clear();
                txtIdPedido.Text = agendar.ID.ToString();

            }
            else
            {
                MessageBox.Show("Falha ao agendar pedido!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEscolherCliente_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage4;
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {

        }

        private void carregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista(nome);
            dgvClientes.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = cliente.CPF;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicaolinha = dgvClientes.CurrentRow.Index;
            txtIdCliente.Text = dgvClientes.Rows[posicaolinha].Cells[0].Value.ToString();
            txtNomeCliente.Text = dgvClientes.Rows[posicaolinha].Cells[1].Value.ToString();
            this.tabControl1.SelectedTab = tabPage1;
        }

        private void CarregaFuncionario()
        {
            var funcionairios = Funcionario.ObterListaFuncionario();
            cmbFuncionario.DataSource = funcionairios;
            cmbFuncionario.DisplayMember = "Nome";
            cmbFuncionario.ValueMember = "ID";

        }

        private void CarregaComboboxCategoria()
        {
            var categorias = Categorias.ObterCategoria();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "Id";

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            if (cmbCategoria.SelectedValue != null)
            {
                produtos.ObterIdProdutosporCategoria(Convert.ToInt32(cmbCategoria.SelectedValue));
                MessageBox.Show(cmbCategoria.SelectedValue.ToString());
                cmbProduto.DataSource = produtos;
                cmbProduto.DisplayMember = "Nome_Produto";
                cmbProduto.ValueMember = "Id";  
            }

        }


    }
}
