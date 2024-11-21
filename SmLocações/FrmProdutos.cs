using SmLocaçõesLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[] textboxes = { txtDescricaoProduto, txtNomeProduto, txtValorProduto };
            bool Textospreenchidos = true;

            foreach (var text in textboxes)
            {
                if (string.IsNullOrEmpty(text.Text))
                {
                    Textospreenchidos = false;
                    break;
                }
            }

            if (string.IsNullOrEmpty(ImagemProduto.ImageLocation))
            {
                MessageBox.Show("Por favor, selecione uma imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Textospreenchidos)
            {
                string caminhoImagem = ImagemProduto.ImageLocation; 

                Produtos produtos = new(
                    Categorias.ObterPorId(Convert.ToInt32(cmbCategoriaProduto.SelectedValue)),
                    txtNomeProduto.Text,
                    caminhoImagem,  
                    Convert.ToDecimal(txtValorProduto.Text),
                    txtUnidades.Text,
                    txtDescricaoProduto.Text,
                    cmbDestaqueProduto.Text
                );

                produtos.InserirProduto();

                if (produtos.ID > 0)
                {
                    MessageBox.Show($"{produtos.Nome_Produto} foi inserido com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();       
                }
                else
                {
                    MessageBox.Show("Falha ao inserir produto", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtUnidades.Clear();
            txtNomeProduto.Clear();
            txtDescricaoProduto.Clear();
            txtValorProduto.Clear();
            ImagemProduto.Image = null; 
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregaCategorias();
            DestaqueProdutos destaque = new();
            cmbDestaqueProduto.Items.AddRange(destaque.produtoDestaque);
            Text += $" ({Program.UsuarioLogado.Login})";
        }

        private void CarregaCategorias()
        {
            var categorias = Categorias.ObterCategoria();
            cmbCategoriaProduto.DataSource = categorias;
            cmbCategoriaProduto.DisplayMember = "Categoria";
            cmbCategoriaProduto.ValueMember = "Id";
        }

        private void btnEscolherFuncionarioEndereco_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagemProduto.ImageLocation = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem foi selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
