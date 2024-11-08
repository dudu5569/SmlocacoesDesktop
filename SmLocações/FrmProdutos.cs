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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Escolha uma imagem(*.JPG;*.PNG) | *.jpg;*.png;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ImagemProduto.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox[] textboxes = { txtDescricaoProduto, txtNomeProduto, txtValorProduto };
            bool Textospreenchidos = true;

            if (ImagemProduto == null) MessageBox.Show("Insira uma imagem do produto", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string caminhoImagem = "Imagens\\";
            ImagemProduto.Image.Save(caminhoImagem);
            Produtos produtos = new(
                Categorias.ObterPorId(Convert.ToInt32(cmbCategoriaProduto.SelectedValue)),
                txtNomeProduto.Text,
                caminhoImagem,
                Convert.ToDecimal(txtValorProduto.Text),
                cmbUnidadeVenda.Text,
                dataCadastro.Value = DateTime.Now,
                txtDescricaoProduto.Text,
                cmbDestaqueProduto.Text
                );

            foreach (var text in textboxes)
            {
                if (string.IsNullOrEmpty(text.Text))
                {
                    Textospreenchidos = false;
                    break;
                }
            }

            if (Textospreenchidos)
            {
                produtos.InserirProduto(ImagemProduto.Image.ToString());
                if (produtos.ID > 0)
                {
                    MessageBox.Show($"{produtos.Nome_Produto} foi inserido com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir produto", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregaCategorias();
            DestaqueProdutos destaque = new();
            UnidadeVenda unidadeVenda = new();
            cmbDestaqueProduto.Items.AddRange(destaque.produtoDestaque);
            cmbUnidadeVenda.Items.AddRange(unidadeVenda.tipodeVenda);
        }

        private void CarregaCategorias()
        {
            var categorias = Categorias.ObterCategoria();
            cmbCategoriaProduto.DataSource = categorias;
            cmbCategoriaProduto.DisplayMember = "Categoria";
            cmbCategoriaProduto.ValueMember = "Id";
        }
    }
}
