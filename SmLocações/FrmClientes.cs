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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage3;
        }
    }
}
