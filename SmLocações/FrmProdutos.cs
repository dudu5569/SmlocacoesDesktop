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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            MemoryStream ms = new MemoryStream();
            ImagemProduto.Image.Save(ms, ImagemProduto.Image.RawFormat);
            byte[] img = ms.ToArray();

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
                        Produtos produtos = new(
                            Categorias.ObterPorId(Convert.ToInt32(cmbCategoriaProduto.SelectedValue)),
                            txtNomeProduto.Text,
                            img.ToString(),
                            Convert.ToDecimal(txtValorProduto.Text),
                            cmbUnidadeVenda.Text,
                            txtDescricaoProduto.Text,
                            cmbDestaqueProduto.Text
                        );

                        produtos.InserirProduto();

                        if (produtos.ID > 0)
                        {
                            MessageBox.Show($"{produtos.Nome_Produto} foi inserido com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEscolherFuncionarioEndereco_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagemProduto.Image = Image.FromFile(openFileDialog.FileName);

                }
                else
                {
                    MessageBox.Show("Nenhuma imagem foi selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 
