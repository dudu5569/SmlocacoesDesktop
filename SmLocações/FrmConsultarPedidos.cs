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
    }
}
