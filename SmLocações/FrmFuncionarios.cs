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
            txtNome.Clear();
            msktxtCpf.Clear();
        }

        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {
            string isAtivo = "Nao";
            if (chkAivo.Checked) isAtivo = "Sim";


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
                string tipoendereco = cmbTipoEndereco.Text.Substring(0, 3);

                Endereco endereco = new Endereco(
                    txtLogradouro.Text,
                    Convert.ToInt32(txtNumero.Text),
                    txtBairro.Text,
                    txtCidade.Text,
                    txtEstado.Text,
                    Convert.ToInt32(txtCEP.Text),
                    tipoendereco
                    );
                endereco.Inserir();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                txtCEP.Clear();
                this.tabControl1.SelectedTab = tabPage3;
                txtIDFuncionárioTelefone.Text = txtIdFuncionário.Text;

                endereco.Endereco_Associado_Funcionario(Convert.ToInt32(txtIdFuncionário.Text), endereco.Id);
                MessageBox.Show("Endereço Cadastrado com Sucesso", "SmLocações");
            }
            else
            {
                MessageBox.Show("Endereço inválido, insira um endereço válido para concluir o cadastro", "SmLocações");
            }
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            carregacombobox();
            TiposEnderecos tiposEnderecos = new();
            cmbTipoEndereco.Items.AddRange(tiposEnderecos.tiposdeEnderecos);
            Telefones telefones = new();
            cmbTipoTelefone.Items.AddRange(telefones.TipodeTelefone);
            msktxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

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
            string cep = txtCEP.Text;
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
                    MessageBox.Show("CEP não encontrado.", "SmLocações");
                }
            }
        }

        private void btnEscolherFuncionarioEndereco_Click(object sender, EventArgs e)
        {
            txtIdFuncionário.ReadOnly = false;
            txtIdFuncionário.Focus();
        }

        private void btnInsereTelefone_Click(object sender, EventArgs e)
        {

            string tipotelefone = cmbTipoTelefone.Text.ToString();

            msktxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Telefones telefones = new(
                msktxtTelefone.Text,
                tipotelefone
                );
            if (!string.IsNullOrWhiteSpace(msktxtTelefone.Text))
            {
                telefones.Inserir_Telefone(msktxtTelefone.Text, tipotelefone);
                telefones.Telefone_Associado_Funcionario(Convert.ToInt32(txtIDFuncionárioTelefone.Text),
                    telefones.Id);
                MessageBox.Show("Telefone cadastrado com Sucesso!", "SmLocações");
                txtIdFuncionarioEmail.Text = txtIDFuncionárioTelefone.Text;
                this.tabControl1.SelectedTab = tabPage4;
            }
        }

        private void btnEscoleFuncionarioTelefone_Click(object sender, EventArgs e)
        {
            txtIDFuncionárioTelefone.ReadOnly = false;
            txtIDFuncionárioTelefone.Focus();
        }

        private void msktxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            msktxtTelefone.Mask = "00,00000-0000";
        }

        private void btnCancelaEndereco_Click(object sender, EventArgs e)
        {
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
            txtCidade.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelaEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void btnCancelaTelefone_Click(object sender, EventArgs e)
        {
            msktxtTelefone.Clear();
        }

        private void BtnInsereEmail_Click(object sender, EventArgs e)
        {
            Emails emails = new(
                txtEmail.Text
                );
            emails.InserirEmail(txtEmail.Text);
            if (emails.Id > 0)
            {
                emails.Email_Associado_Funcionario(Convert.ToInt32(txtIdFuncionarioEmail.Text), emails.Id);
                MessageBox.Show("Email inserido com sucesso!", "SmLocações");
                txtEmail.Clear();
            }
        }

        private void btnEscolhaFuncionarioEmail_Click(object sender, EventArgs e)
        {
            txtIdFuncionarioEmail.ReadOnly = false;
            txtIdFuncionarioEmail.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }


}
