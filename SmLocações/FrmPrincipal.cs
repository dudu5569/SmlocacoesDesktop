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

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmTransicaoPedido frmTransicaopedido = new();
            //frmTransicaopedido.MdiParent = this;
            frmTransicaopedido.Show();
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmTransicaoCadastro frmTransicaoCadastro = new();
            //frmTransicaoCadastro.MdiParent = this;
            frmTransicaoCadastro.Show();

        }

        private void btnVizualizar_Click(object sender, EventArgs e)
        {
            FrmTransicaoVizualizar frmTransicaoVizualizar = new();
            //frmTransicaoVizualizar .MdiParent = this;
            frmTransicaoVizualizar.Show();

        }
    }
}
