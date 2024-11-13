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
    public partial class frmEditarProduto : Form
    {
        public frmEditarProduto()
        {
            InitializeComponent();
        }

        private void frmEditarProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            DestaqueProdutos destaque = new();
            cmbDestaqueProduto.Items.AddRange(destaque.produtoDestaque);
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produtos.ObterListaProdutos(nome);
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.ID;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.Id_Categoria.Categoria;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Nome_Produto;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.Valor;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.Unidade_Venda;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.Destaque;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.Imagem;

                cont++;
            }
        }




        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicaolinha = dgvProdutos.CurrentRow.Index;
            txtIdProduto.Text = dgvProdutos.Rows[posicaolinha].Cells[0].Value.ToString();
            txtNomeProduto.Text = dgvProdutos.Rows[posicaolinha].Cells[2].Value.ToString();
            txtValor.Text = dgvProdutos.Rows[posicaolinha].Cells[3].Value.ToString();
            txtUnidadesVenda.Text = dgvProdutos.Rows[posicaolinha].Cells[4].Value.ToString();
            txtDescricao.Text = dgvProdutos.Rows[posicaolinha].Cells[5].Value.ToString();
            txtArquivoImagem.Text = dgvProdutos.Rows[posicaolinha].Cells[7].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnEscolherFuncionarioEndereco_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoImagem = openFileDialog.FileName;

                    // Carrega a imagem diretamente para o PictureBox
                    pbImagemProduto.Image = Image.FromFile(caminhoImagem);
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem foi selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoImagem = openFileDialog.FileName;
                    txtArquivoImagem.Text = caminhoImagem;

                    pbImagemProduto.Image = Image.FromFile(caminhoImagem);
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem foi selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[] textBoxes = { txtArquivoImagem, txtDescricao, txtIdProduto, txtNomeProduto, txtUnidadesVenda, txtValor };
            Produtos produtos = new(
                int.Parse(txtIdProduto.Text),
                txtNomeProduto.Text,
                txtArquivoImagem.Text,
                Convert.ToDecimal(txtValor.Text),
                txtUnidadesVenda.Text,
                txtDescricao.Text,
                cmbDestaqueProduto.Text
                );
            produtos.AtualizaProdutos();
            MessageBox.Show($"{produtos.Nome_Produto} foi atualizado com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid();


            if (textBoxes.Length == 0)
            {
                MessageBox.Show("Erro ao atualizar os produtos, algum campo está vazio", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNomeProdut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
