﻿using SmLocaçõesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            CarregaProdutos();
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
                Funcionario.ObterporId(Convert.ToInt32(cmbFuncionario.SelectedValue)),
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

        private void CarregaProdutos(string nome = "")
        {
            var lista = Produtos.ObterListaProdutos(nome);
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.ID.ToString();
                dgvProdutos.Rows[cont].Cells[1].Value = produto.Nome_Produto.ToString();
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Id_Categoria.Categoria.ToString();
                dgvProdutos.Rows[cont].Cells[3].Value = produto.Unidade_Venda.ToString();
                dgvProdutos.Rows[cont].Cells[4].Value = produto.Valor.ToString();
                cont++;
            }
        }



        private void btnEscolherProduto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int posicaoLinha = dgvProdutos.CurrentRow.Index;
            txtNomeProduto.Text = dgvProdutos.Rows[posicaoLinha].Cells[1].Value.ToString();
            txtValorTotal.Text = dgvProdutos.Rows[posicaoLinha].Cells[4].Value.ToString();


        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int posicaolinha = 0;
            if (txtQuantidade.Text == string.Empty) txtValorTotal.Text = dgvProdutos.Rows[posicaolinha].Cells[4].Value.ToString();

            try
            {
                string valorTexto = txtValorTotal.Text.Trim();
                string quantidadeTexto = txtQuantidade.Text.Trim();

                if (string.IsNullOrEmpty(valorTexto) || string.IsNullOrEmpty(quantidadeTexto))
                {
                    txtValorTotal.Text = "Preencha ambos os campos.";
                    return; // Se algum campo estiver vazio, não faz o cálculo
                }

                Console.WriteLine($"Valor inserido: '{valorTexto}', Quantidade inserida: '{quantidadeTexto}'");

                if (decimal.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorProduto) &&
                    decimal.TryParse(quantidadeTexto, out decimal quantidade))
                {
                    decimal valorTotal = quantidade * valorProduto;

                    txtValorTotal.Text = valorTotal.ToString("F2");
                }
                else
                {
                    txtValorTotal.Text = "Valor inválido";
                }
            }
            catch (Exception ex)
            {
                txtValorTotal.Text = "Erro: " + ex.Message;
            }
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
