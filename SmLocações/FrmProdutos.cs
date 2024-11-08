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
    }
}
