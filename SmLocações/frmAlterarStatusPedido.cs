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
    public partial class frmAlterarStatusPedido : Form
    {
        public frmAlterarStatusPedido()
        {
            InitializeComponent();
        }

        private void frmAlterarStatusPedido_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            CarregaPedidos();
            Text += $" ({Program.UsuarioLogado.Login})";

        }

        private void CarregaPedidos()
        {
            var lista = Pedidos.ListarPedidos();
            dgvPedidos.Rows.Clear();
            int cont = 0;
            foreach (var pedido in lista)
            {
                dgvPedidos.Rows.Add();
                dgvPedidos.Rows[cont].Cells[0].Value = pedido.Id;
                dgvPedidos.Rows[cont].Cells[1].Value = pedido.Id_Cliente.Nome;
                dgvPedidos.Rows[cont].Cells[2].Value = pedido.Id_Funcionario.Nome;
                dgvPedidos.Rows[cont].Cells[3].Value = pedido.Data_Retirada;
                dgvPedidos.Rows[cont].Cells[4].Value = pedido.Data_Entrega;
                dgvPedidos.Rows[cont].Cells[5].Value = pedido.Status_Pedido;

                cont++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicaolinha = dgvPedidos.CurrentRow.Index;

            txtIdPedido.Text = dgvPedidos.Rows[posicaolinha].Cells[0].Value.ToString();
            txtCliente.Text = dgvPedidos.Rows[posicaolinha].Cells[1].Value.ToString();
            txtFuncionario.Text = dgvPedidos.Rows[posicaolinha].Cells[2].Value.ToString();
            txtDataRetirada.Text = dgvPedidos.Rows[posicaolinha].Cells[3].Value.ToString();
            txtDataEntrega.Text = dgvPedidos.Rows[posicaolinha].Cells[4].Value.ToString();
            this.tabControl1.SelectedTab = tabPage1;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ControleEstoque controleEstoque = new();
            Pedidos pedidos = new();

            // Atualiza o status do pedido
            pedidos.AtualizarStatusPedido(int.Parse(txtIdPedido.Text), cmbStatus.Text);
            MessageBox.Show("Status do pedido atualizado com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Verifica se o status é "Concluído"
            if (cmbStatus.Text == "Concluído")
            {
                // Lista de quantidades de itens no pedido
                List<int> quantidades = controleEstoque.ConsultaItensPedido(int.Parse(txtIdPedido.Text));
                // Lista de IDs dos produtos relacionados ao pedido
                List<int> produtos = controleEstoque.ConsultaProdutosDoPedido(int.Parse(txtIdPedido.Text));

                // Devolve os produtos ao estoque
                for (int i = 0; i < produtos.Count; i++)
                {
                    int produtoId = produtos[i];
                    int quantidade = quantidades[i];

                    controleEstoque.DevolverEstoque(produtoId, quantidade);
                }

                MessageBox.Show("Estoque atualizado com a devolução dos itens!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaPedidos();
            }

            // Limpa os campos após a operação
            txtIdPedido.Clear();
            txtFuncionario.Clear();
            txtDataRetirada.Clear();
            txtDataEntrega.Clear();
            txtCliente.Clear();
        }

        private void btnEscolherPedido_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }
    }
}
