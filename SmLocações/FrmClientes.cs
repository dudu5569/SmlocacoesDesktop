using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (txtNomeCliente.Text != string.Empty)
            {
                mktxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                Cliente cliente = new(
                    txtNomeCliente.Text,
                    mktxtCPF.Text,
                    dataNascimento.Value,
                    dataCadastro.Value = DateTime.Now
                    );
                cliente.InserirCliente();
                if (cliente.Id > 0)
                {
                    MessageBox.Show($"Cliente {cliente.Nome} foi inserido com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdClienteContato.Text = cliente.Id.ToString();
                    this.tabControl1.SelectedTab = tabPage2;
                }
                else
                {
                    MessageBox.Show("Falha ao inserir registro!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O cliente precisa ter um nome para concluir o registro", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            string tipotelefone = cmbTipoTelefone.Text.ToString();

            mktxtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Telefones telefones = new(
                mktxtTelefone.Text,
                tipotelefone
                );
            if (!string.IsNullOrWhiteSpace(mktxtTelefone.Text))
            {
                if (txtIdClienteContato.Text == string.Empty)
                {
                    MessageBox.Show("O telefone precisa estar associado à um cliente", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    telefones.Inserir_Telefone(mktxtTelefone.Text, tipotelefone);
                    if (telefones.Id > 0)
                    {
                        telefones.Telefone_Associado_Cliente(Convert.ToInt32(txtIdClienteContato.Text),
                            telefones.Id);
                        MessageBox.Show("Telefone cadastrado com Sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdClienteEndereco.Text = txtIdClienteContato.Text;
                        this.tabControl1.SelectedTab = tabPage3;
                    }
                }
            }
        }


        public async Task<EnderecoForCep> BuscaEndereco(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<EnderecoForCep>(response);
                }
                catch
                {
                    return null;
                }
            }
        }

        private async void btnBuscaCep_Click(object sender, EventArgs e)
        {
            string cep = mktxtCEP.Text;
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
                    MessageBox.Show("CEP não encontrado.", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void mktxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mktxtCPF.Mask = "000.000.000-00";
        }

        private void btnInserirEndereco_Click(object sender, EventArgs e)
        {
            if (mktxtCEP.Text.Length > 0 && txtLogradouro.Text.Length > 0)
            {
                string tipoendereco = cmbTipoEndereco.Text.Substring(0, 3);

                Endereco endereco = new Endereco(
                    txtLogradouro.Text,
                    Convert.ToInt32(txtNumero.Text),
                    txtBairro.Text,
                    txtCidade.Text,
                    txtEstado.Text,
                    Convert.ToInt32(mktxtCEP.Text),
                    tipoendereco
                    );
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                mktxtCEP.Clear();
                txtBairro.Clear();
                if (txtIdClienteEndereco.Text == string.Empty)
                {
                    MessageBox.Show("O endereço precisa ter um cliente associado", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    endereco.Inserir();
                    if (endereco.Id > 0)
                    {
                        endereco.Endereco_Associado_Cliente(int.Parse(txtIdClienteEndereco.Text), endereco.Id);
                        MessageBox.Show("Endereço Cadastrado com Sucesso", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tabControl1.SelectedTab = tabPage4;
                        txtIdClienteEmail.Text = txtIdClienteEndereco.Text;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir registro!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Endereço inválido, insira um endereço válido para concluir o cadastro", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            TiposEnderecos tiposenderecos = new();
            cmbTipoEndereco.Items.AddRange(tiposenderecos.tiposdeEnderecos);
            Telefones telefones = new();
            cmbTipoTelefone.Items.AddRange(telefones.TipodeTelefone);
            TipoCartao tipoCartao = new ();
            cmbTipoCartao.Items.AddRange(tipoCartao.TipodeCartao);
            Text += $" ({Program.UsuarioLogado.Login})";
        }

        private void mktxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mktxtTelefone.Mask = "00,00000-0000";
        }

        private void BtnInsereEmail_Click(object sender, EventArgs e)
        {
            Emails emails = new(
    txtEmail.Text
    );
            if (txtEmail.Text != string.Empty)
            {
                if (txtIdClienteEmail.Text == string.Empty)
                {
                    MessageBox.Show("O email deve estar associado à um cliente", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    emails.InserirEmail(txtEmail.Text);
                    if (emails.Id > 0)
                    {
                        emails.Email_Associado_Cliente(Convert.ToInt32(txtIdClienteEmail.Text), emails.Id);
                        MessageBox.Show("Email inserido com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEmail.Clear();
                        this.tabControl1.SelectedTab = tabPage5;
                        txtIdClienteCartao.Text = txtIdClienteEmail.Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um email!", "SmLocações",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            mktxtCPF.Clear();
        }

        private void btnCancelarContato_Click(object sender, EventArgs e)
        {
            mktxtTelefone.Clear();
        }

        private void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            txtLogradouro.Clear();
            txtNumero.Clear();
            mktxtCEP.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEstado.Clear();
            txtBairro.Clear();
        }

        private void btnEscolherClienteContato_Click(object sender, EventArgs e)
        {
            txtIdClienteContato.ReadOnly = false;
            txtIdClienteContato.Focus();
        }

        private void btnEscolerClienteEndereco_Click(object sender, EventArgs e)
        {
            txtIdClienteEndereco.ReadOnly = false;
            txtIdClienteEndereco.Focus();
        }

        private void btnEscolhaFuncionarioEmail_Click(object sender, EventArgs e)
        {
            txtIdClienteEmail.ReadOnly = false;
            txtIdClienteEmail.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnEscolherClienteCartao_Click(object sender, EventArgs e)
        {
            txtIdClienteCartao.ReadOnly = false;
            txtIdClienteCartao.Focus();
        }

        private void btnInserirCartao_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[] textBoxes = {txtIdClienteCartao, txtTitularCartao, txtBandeiraCartao, txtNumeroCartao, txtCvvCartao,  txtValidadeCartao};
            bool preenchidos = true;
            foreach (var textBox  in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    preenchidos = false;
                    break;
                }
            }

            string cartao = txtNumeroCartao.Text;
            bool isValido = Cartoes.ValidarNumeroCartao(cartao);
            string tipocartao = cmbTipoCartao.Text;

            if (preenchidos)
            {
                if (isValido)
                {
                    Cartoes cartoes = new(
                          Cliente.ObterPorId(Convert.ToInt32(txtIdClienteCartao.Text)),
                          txtTitularCartao.Text,
                          txtBandeiraCartao.Text,
                          txtNumeroCartao.Text,
                          txtValidadeCartao.Text,
                          Convert.ToInt32(txtCvvCartao.Text),
                          tipocartao
                        );
                    cartoes.InserirCartao();
                    if (cartoes.ID > 0)
                    {
                        MessageBox.Show("Cartão registrado com sucesso!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdClienteCartao.Clear();
                        txtCvvCartao.Clear();
                        txtTitularCartao.Clear();
                        txtBandeiraCartao.Clear();
                        txtNumeroCartao.Clear();
                        txtValidadeCartao.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Número do cartão inválido! Caracteres especiais ou letras detectados.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "SmLocações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


