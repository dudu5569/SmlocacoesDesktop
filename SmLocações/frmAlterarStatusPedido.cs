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
    public partial class frmAlterarStatusPedido : Form
    {
        public frmAlterarStatusPedido()
        {
            InitializeComponent();
        }

        private void frmAlterarStatusPedido_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
