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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produtos.ObterListaProdutos(nome);
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Nome_Produto;

                dgvProdutos.Rows[cont].Cells[1].Value = produto.Id_Categoria.Categoria; 

                dgvProdutos.Rows[cont].Cells[2].Value = produto.Valor;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.Unidade_Venda;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Imagem;

                cont++;
            }
        }

    }
}
