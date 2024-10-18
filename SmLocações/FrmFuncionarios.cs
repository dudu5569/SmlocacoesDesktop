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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCancelarFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {

            bool isAtivo = chkAivo.Checked;

            Funcionario funcionario = new(
                Niveis.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)),
                txtNome.Text,
                msktxtCpf.Text,
                Data_Nascimento.Value,
                Data_Cadastro.Value = DateTime.Now,
                isAtivo
                );






            this.tabControl1.SelectedTab = tabPage2;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsereEndereco_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage3;
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            var niveis = Niveis.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "ID";
        }

        private void mxtdCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            msktxtCpf.Mask = "000.000.000-00";
        }
    }
}
