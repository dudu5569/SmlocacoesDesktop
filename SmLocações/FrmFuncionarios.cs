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
                MessageBox.Show("Erro ao gravar dados!", "Smlocações");
            }

            txtIdFuncionário.Text = funcionario.ID.ToString();



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsereEndereco_Click(object sender, EventArgs e)
        {
        
            if (txtCEP.Text.Length > 0 && txtLogradouro.Text.Length > 0)
            {

                Endereco endereco = new Endereco(
                    txtLogradouro.Text,
                    Convert.ToInt32(txtNumero.Text),
                    txtBairro.Text,
                    txtCidade.Text,
                    txtEstado.Text,
                    Convert.ToInt32(txtCEP.Text),
                    cmbTipoEndereco.SelectedValue.ToString()
                    );
                endereco.Inserir();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                txtCEP.Clear();
                this.tabControl1.SelectedTab = tabPage3;
            }
            else
            {
                MessageBox.Show("Endereço inválido, insira um endereço válido para concluir o cadastro", "SmLocações");
            } 
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


        private async Task<EnderecoForCep> BuscaEndereco(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Faz a requisição para a API ViaCEP
                    var response = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<EnderecoForCep>(response);
                }
                catch
                {
                    return null; // Em caso de erro
                }
            }
        }

        private async void txtBusca_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text; // Remove o traço e espaços
            if (!string.IsNullOrEmpty(cep))
            {
                var endereco = await BuscaEndereco(cep);
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.Logradouro;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Localidade;
                    txtEstado.Text = endereco.Uf;
                }
                else
                {
                    MessageBox.Show("CEP não encontrado.");
                }
            }
        }

        private void btnEscolherFuncionarioEndereco_Click(object sender, EventArgs e)
        {
            txtIdFuncionário.ReadOnly = false;
            txtIdFuncionário.Focus();
        }
    }


}
