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
    public partial class FrmInserirNiveis : Form
    {
        public FrmInserirNiveis()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtNomeNivel.Text = char.ToUpper(txtNomeNivel.Text[0]) + txtNomeNivel.Text.Substring(1);
            Niveis niveis = new(
                txtNomeNivel.Text,
                txtSiglaNivel.Text.ToUpper()
                );

            niveis.Inserir();
            if (niveis.ID > 0)
            {
                MessageBox.Show($"Nível {niveis.Nome} foi inserido com sucesso!", "SmLocações");
                txtNomeNivel.Clear();
                txtSiglaNivel.Clear();
            }
            else
            {
                MessageBox.Show("Falha ao gravar registro!", "SmLocações");
            }
        }

        private void FrmInserirNiveis_Load(object sender, EventArgs e)
        {
            Text += $" ({Program.UsuarioLogado.Login})";
        }
    }
}
