using MySql.Data.MySqlClient;
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
            msktxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
             Funcionario funcionario = new Funcionario(
                Niveis.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue)), // Passando o objeto Niveis
                txtNome.Text,
                msktxtCpf.Text,
                Data_Nascimento.Value,
                DateTime.Now,
                isAtivo
            );





            funcionario.Inserir();

            if (funcionario.ID > 0)
            {
                MessageBox.Show($"Funcionário {funcionario.Nome}, foi inserido com sucesso!", "SmLocações");
                this.tabControl1.SelectedTab = tabPage2;
                txtNome.Clear();
                msktxtCpf.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao gravar dados!","Smlocações");
            }



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
            carregacombobox();
        }

        public void carregacombobox()
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
