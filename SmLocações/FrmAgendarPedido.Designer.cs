namespace SmLocações
{
    partial class FrmAgendarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeCliente = new TextBox();
            cmbFuncionario = new ComboBox();
            dataRetirada = new DateTimePicker();
            dataEntrega = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCancelarAgendamento = new Guna.UI2.WinForms.Guna2Button();
            btnInserirAgendamento = new Guna.UI2.WinForms.Guna2Button();
            tabPage2 = new TabPage();
            btnEscolherLocacao = new Guna.UI2.WinForms.Guna2Button();
            btnCancelarProduto = new Guna.UI2.WinForms.Guna2Button();
            btnInserirProduto = new Guna.UI2.WinForms.Guna2Button();
            txtValor = new TextBox();
            txtQuantidade = new TextBox();
            txtIdPedido = new TextBox();
            cmbProduto = new ComboBox();
            cmbCategoriaPedido = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 56);
            label1.Name = "label1";
            label1.Size = new Size(263, 45);
            label1.TabIndex = 0;
            label1.Text = "Agendar Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 76);
            label2.Name = "label2";
            label2.Size = new Size(201, 15);
            label2.TabIndex = 1;
            label2.Text = "Funcionário responsável pelo Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 17);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome do Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 128);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Retirada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 187);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de Entrega";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(205, 35);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(277, 23);
            txtNomeCliente.TabIndex = 5;
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(205, 94);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(277, 23);
            cmbFuncionario.TabIndex = 6;
            // 
            // dataRetirada
            // 
            dataRetirada.Format = DateTimePickerFormat.Short;
            dataRetirada.Location = new Point(205, 146);
            dataRetirada.Name = "dataRetirada";
            dataRetirada.Size = new Size(277, 23);
            dataRetirada.TabIndex = 7;
            // 
            // dataEntrega
            // 
            dataEntrega.Format = DateTimePickerFormat.Short;
            dataEntrega.Location = new Point(205, 205);
            dataEntrega.Name = "dataEntrega";
            dataEntrega.Size = new Size(277, 23);
            dataEntrega.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(108, 121);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(715, 360);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCancelarAgendamento);
            tabPage1.Controls.Add(btnInserirAgendamento);
            tabPage1.Controls.Add(cmbFuncionario);
            tabPage1.Controls.Add(dataEntrega);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataRetirada);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtNomeCliente);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(707, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agendar Pedido";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnCancelarAgendamento
            // 
            btnCancelarAgendamento.Animated = true;
            btnCancelarAgendamento.AutoRoundedCorners = true;
            btnCancelarAgendamento.BorderRadius = 10;
            btnCancelarAgendamento.BorderThickness = 1;
            btnCancelarAgendamento.CustomizableEdges = customizableEdges11;
            btnCancelarAgendamento.DisabledState.BorderColor = Color.DarkGray;
            btnCancelarAgendamento.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelarAgendamento.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelarAgendamento.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelarAgendamento.FillColor = Color.Red;
            btnCancelarAgendamento.Font = new Font("Segoe UI", 9F);
            btnCancelarAgendamento.ForeColor = Color.White;
            btnCancelarAgendamento.Location = new Point(380, 267);
            btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            btnCancelarAgendamento.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancelarAgendamento.Size = new Size(122, 23);
            btnCancelarAgendamento.TabIndex = 10;
            btnCancelarAgendamento.Text = "&Cancelar Pedido";
            // 
            // btnInserirAgendamento
            // 
            btnInserirAgendamento.Animated = true;
            btnInserirAgendamento.AutoRoundedCorners = true;
            btnInserirAgendamento.BorderRadius = 10;
            btnInserirAgendamento.BorderThickness = 1;
            btnInserirAgendamento.CustomizableEdges = customizableEdges13;
            btnInserirAgendamento.DisabledState.BorderColor = Color.DarkGray;
            btnInserirAgendamento.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserirAgendamento.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserirAgendamento.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserirAgendamento.FillColor = Color.Green;
            btnInserirAgendamento.Font = new Font("Segoe UI", 9F);
            btnInserirAgendamento.ForeColor = Color.White;
            btnInserirAgendamento.Location = new Point(205, 267);
            btnInserirAgendamento.Name = "btnInserirAgendamento";
            btnInserirAgendamento.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnInserirAgendamento.Size = new Size(122, 23);
            btnInserirAgendamento.TabIndex = 9;
            btnInserirAgendamento.Text = "&inserir Pedido";
            btnInserirAgendamento.Click += btnInserir_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEscolherLocacao);
            tabPage2.Controls.Add(btnCancelarProduto);
            tabPage2.Controls.Add(btnInserirProduto);
            tabPage2.Controls.Add(txtValor);
            tabPage2.Controls.Add(txtQuantidade);
            tabPage2.Controls.Add(txtIdPedido);
            tabPage2.Controls.Add(cmbProduto);
            tabPage2.Controls.Add(cmbCategoriaPedido);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(707, 332);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Itens Pedido";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnEscolherLocacao
            // 
            btnEscolherLocacao.Animated = true;
            btnEscolherLocacao.AutoRoundedCorners = true;
            btnEscolherLocacao.BorderRadius = 10;
            btnEscolherLocacao.BorderThickness = 1;
            btnEscolherLocacao.CustomizableEdges = customizableEdges15;
            btnEscolherLocacao.DisabledState.BorderColor = Color.DarkGray;
            btnEscolherLocacao.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEscolherLocacao.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEscolherLocacao.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEscolherLocacao.FillColor = Color.DodgerBlue;
            btnEscolherLocacao.Font = new Font("Segoe UI", 9F);
            btnEscolherLocacao.ForeColor = Color.White;
            btnEscolherLocacao.Location = new Point(290, 220);
            btnEscolherLocacao.Name = "btnEscolherLocacao";
            btnEscolherLocacao.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnEscolherLocacao.Size = new Size(122, 23);
            btnEscolherLocacao.TabIndex = 12;
            btnEscolherLocacao.Text = "&Escolher Pedido";
            // 
            // btnCancelarProduto
            // 
            btnCancelarProduto.Animated = true;
            btnCancelarProduto.AutoRoundedCorners = true;
            btnCancelarProduto.BorderRadius = 10;
            btnCancelarProduto.BorderThickness = 1;
            btnCancelarProduto.CustomizableEdges = customizableEdges17;
            btnCancelarProduto.DisabledState.BorderColor = Color.DarkGray;
            btnCancelarProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelarProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelarProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelarProduto.FillColor = Color.Red;
            btnCancelarProduto.Font = new Font("Segoe UI", 9F);
            btnCancelarProduto.ForeColor = Color.White;
            btnCancelarProduto.Location = new Point(424, 220);
            btnCancelarProduto.Name = "btnCancelarProduto";
            btnCancelarProduto.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnCancelarProduto.Size = new Size(122, 23);
            btnCancelarProduto.TabIndex = 11;
            btnCancelarProduto.Text = "&Cancelar Pedido";
            // 
            // btnInserirProduto
            // 
            btnInserirProduto.Animated = true;
            btnInserirProduto.AutoRoundedCorners = true;
            btnInserirProduto.BorderRadius = 10;
            btnInserirProduto.BorderThickness = 1;
            btnInserirProduto.CustomizableEdges = customizableEdges19;
            btnInserirProduto.DisabledState.BorderColor = Color.DarkGray;
            btnInserirProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserirProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserirProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserirProduto.FillColor = Color.Green;
            btnInserirProduto.Font = new Font("Segoe UI", 9F);
            btnInserirProduto.ForeColor = Color.White;
            btnInserirProduto.Location = new Point(156, 220);
            btnInserirProduto.Name = "btnInserirProduto";
            btnInserirProduto.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnInserirProduto.Size = new Size(122, 23);
            btnInserirProduto.TabIndex = 10;
            btnInserirProduto.Text = "&inserir Pedido";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(276, 165);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(156, 165);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 8;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(156, 104);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(72, 23);
            txtIdPedido.TabIndex = 7;
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(408, 104);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 6;
            // 
            // cmbCategoriaPedido
            // 
            cmbCategoriaPedido.FormattingEnabled = true;
            cmbCategoriaPedido.Location = new Point(255, 104);
            cmbCategoriaPedido.Name = "cmbCategoriaPedido";
            cmbCategoriaPedido.Size = new Size(121, 23);
            cmbCategoriaPedido.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 84);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 4;
            label10.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 86);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 3;
            label9.Text = "Produto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 147);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 2;
            label8.Text = "Valor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 147);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 1;
            label7.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 86);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 0;
            label6.Text = "ID";
            // 
            // FrmAgendarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 533);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "FrmAgendarPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgendarPedido";
            Load += FrmAgendarPedido_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeCliente;
        private ComboBox cmbFuncionario;
        private DateTimePicker dataRetirada;
        private DateTimePicker dataEntrega;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnInserirAgendamento;
        private Guna.UI2.WinForms.Guna2Button btnCancelarAgendamento;
        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button btnCancelarProduto;
        private Guna.UI2.WinForms.Guna2Button btnInserirProduto;
        private TextBox txtValor;
        private TextBox txtQuantidade;
        private TextBox txtIdPedido;
        private ComboBox cmbProduto;
        private ComboBox cmbCategoriaPedido;
        private Label label10;
        private Label label9;
        private Label label8;
        private Guna.UI2.WinForms.Guna2Button btnEscolherLocacao;
    }
}