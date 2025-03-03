using Accessibility;
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
    public partial class FrmConsultarPedidos : Form
    {
        public FrmConsultarPedidos()
        {
            InitializeComponent();
        }

        private void ConsultarPedidos_Load(object sender, EventArgs e)
        {
            CarregaPedidos();
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
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

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicaolinha = dgvPedidos.CurrentRow.Index;
            int id = 0;
            id = Convert.ToInt32(dgvPedidos.Rows[posicaolinha].Cells[0].Value);
            var lista = ItensPedido.ObterListaItensPedido(id);
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach(var produtos in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produtos.Id_pedido.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produtos.Id_produtos.Descricao;
                dgvProdutos.Rows[cont].Cells[2].Value = produtos.Quantidade;
                dgvProdutos.Rows[cont].Cells[3].Value = produtos.valor_total.ToString();
                cont++;
            }
        }


        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
