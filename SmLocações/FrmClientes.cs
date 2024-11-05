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
                MessageBox.Show($"Cliente {cliente.Nome} foi inserido com sucesso!", "SmLocações");
            }
            else
            {
                MessageBox.Show("Falha ao inserir registro!", "SmLocações");
            }


            this.tabControl1.SelectedTab = tabPage2;
        }

        private void btnInserirContato_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage3;
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
                    MessageBox.Show("CEP não encontrado.", "SmLocações");
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
    }
}
