﻿using SmLocaçõesLib;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string isAtivo = "Nao";
            if (chkAtivo.Checked) isAtivo = "Sim";

            int idfuncionario = Convert.ToInt32(cmbFuncionarios.SelectedValue);
            Usuario usuario = new(
                Funcionario.ObterporId(idfuncionario),
                txtUsuario.Text,
                txtSenha.Text,
                isAtivo
                );

           if (!Usuario.ObterIdFuncionario(idfuncionario))
            {
              usuario.InserirUsuario();
                if (usuario.Id > 0)
                {
                    MessageBox.Show($"O usuário {usuario.Login}, foi inserido com sucesso e \n Pertence ao funcionário: {cmbFuncionarios.Text}", "SmLocações");
                    txtUsuario.Clear();
                    txtSenha.Clear();
                }
            }
            else
            {
                MessageBox.Show($"O funcionário {cmbFuncionarios.Text} já possui um usuário cadastrado", "SmLocações");
            } 
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
           // Text += $" ({Program.UsuarioLogado.Login})";
        }

        public void CarregaComboBox()
        {
            var funcionario = Funcionario.ObterListaFuncionario();
            cmbFuncionarios.DataSource = funcionario;
            cmbFuncionarios.DisplayMember = "Nome";
            cmbFuncionarios.ValueMember = "ID";
        }
    }
}
