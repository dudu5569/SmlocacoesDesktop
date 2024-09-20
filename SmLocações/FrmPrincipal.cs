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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new();
            frmClientes.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frmFuncionarios = new();
            frmFuncionarios.ShowDialog();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendarPedido frmAgendarPedido = new();
            frmAgendarPedido.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarUser frmEditarUsuario = new();
            frmEditarUsuario.ShowDialog();
        }

        private void vizualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        FrmConsultar frmConsultar = new();
        frmConsultar.ShowDialog();
        }
    }
}
