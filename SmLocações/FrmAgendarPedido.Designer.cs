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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendarPedido));
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
            btnEscolherCliente = new Guna.UI2.WinForms.Guna2Button();
            txtIdCliente = new TextBox();
            label11 = new Label();
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
            cmbCategoria = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            dgvClientes = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 56);
            label1.Name = "label1";
            label1.Size = new Size(228, 45);
            label1.TabIndex = 0;
            label1.Text = "Nova Locação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 76);
            label2.Name = "label2";
            label2.Size = new Size(201, 15);
            label2.TabIndex = 8;
            label2.Text = "Funcionário responsável pelo Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 17);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome do Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 128);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 9;
            label4.Text = "Data de Retirada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 187);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 0;
            label5.Text = "Data de Entrega";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(205, 35);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.ReadOnly = true;
            txtNomeCliente.Size = new Size(277, 23);
            txtNomeCliente.TabIndex = 0;
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(205, 94);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(277, 23);
            cmbFuncionario.TabIndex = 1;
            // 
            // dataRetirada
            // 
            dataRetirada.Format = DateTimePickerFormat.Short;
            dataRetirada.Location = new Point(205, 146);
            dataRetirada.Name = "dataRetirada";
            dataRetirada.Size = new Size(277, 23);
            dataRetirada.TabIndex = 2;
            // 
            // dataEntrega
            // 
            dataEntrega.Format = DateTimePickerFormat.Short;
            dataEntrega.Location = new Point(205, 205);
            dataEntrega.Name = "dataEntrega";
            dataEntrega.Size = new Size(277, 23);
            dataEntrega.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(108, 121);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(715, 360);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEscolherCliente);
            tabPage1.Controls.Add(txtIdCliente);
            tabPage1.Controls.Add(label11);
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
            // btnEscolherCliente
            // 
            btnEscolherCliente.Animated = true;
            btnEscolherCliente.AutoRoundedCorners = true;
            btnEscolherCliente.BorderRadius = 10;
            btnEscolherCliente.BorderThickness = 1;
            btnEscolherCliente.CustomizableEdges = customizableEdges1;
            btnEscolherCliente.DisabledState.BorderColor = Color.DarkGray;
            btnEscolherCliente.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEscolherCliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEscolherCliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEscolherCliente.FillColor = Color.DodgerBlue;
            btnEscolherCliente.Font = new Font("Segoe UI", 9F);
            btnEscolherCliente.ForeColor = Color.White;
            btnEscolherCliente.Location = new Point(502, 35);
            btnEscolherCliente.Name = "btnEscolherCliente";
            btnEscolherCliente.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEscolherCliente.Size = new Size(122, 23);
            btnEscolherCliente.TabIndex = 12;
            btnEscolherCliente.Text = "&Escolher Cliente";
            btnEscolherCliente.Click += btnEscolherCliente_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(108, 35);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(53, 23);
            txtIdCliente.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 17);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 10;
            label11.Text = "ID Cliente";
            // 
            // btnCancelarAgendamento
            // 
            btnCancelarAgendamento.Animated = true;
            btnCancelarAgendamento.AutoRoundedCorners = true;
            btnCancelarAgendamento.BorderRadius = 10;
            btnCancelarAgendamento.BorderThickness = 1;
            btnCancelarAgendamento.CustomizableEdges = customizableEdges3;
            btnCancelarAgendamento.DisabledState.BorderColor = Color.DarkGray;
            btnCancelarAgendamento.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelarAgendamento.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelarAgendamento.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelarAgendamento.FillColor = Color.Red;
            btnCancelarAgendamento.Font = new Font("Segoe UI", 9F);
            btnCancelarAgendamento.ForeColor = Color.White;
            btnCancelarAgendamento.Location = new Point(380, 267);
            btnCancelarAgendamento.Name = "btnCancelarAgendamento";
            btnCancelarAgendamento.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelarAgendamento.Size = new Size(122, 23);
            btnCancelarAgendamento.TabIndex = 4;
            btnCancelarAgendamento.Text = "&Cancelar Pedido";
            btnCancelarAgendamento.Click += btnCancelarAgendamento_Click;
            // 
            // btnInserirAgendamento
            // 
            btnInserirAgendamento.Animated = true;
            btnInserirAgendamento.AutoRoundedCorners = true;
            btnInserirAgendamento.BorderRadius = 10;
            btnInserirAgendamento.BorderThickness = 1;
            btnInserirAgendamento.CustomizableEdges = customizableEdges5;
            btnInserirAgendamento.DisabledState.BorderColor = Color.DarkGray;
            btnInserirAgendamento.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserirAgendamento.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserirAgendamento.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserirAgendamento.FillColor = Color.Green;
            btnInserirAgendamento.Font = new Font("Segoe UI", 9F);
            btnInserirAgendamento.ForeColor = Color.White;
            btnInserirAgendamento.Location = new Point(205, 267);
            btnInserirAgendamento.Name = "btnInserirAgendamento";
            btnInserirAgendamento.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnInserirAgendamento.Size = new Size(122, 23);
            btnInserirAgendamento.TabIndex = 5;
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
            tabPage2.Controls.Add(cmbCategoria);
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
            btnEscolherLocacao.CustomizableEdges = customizableEdges7;
            btnEscolherLocacao.DisabledState.BorderColor = Color.DarkGray;
            btnEscolherLocacao.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEscolherLocacao.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEscolherLocacao.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEscolherLocacao.FillColor = Color.DodgerBlue;
            btnEscolherLocacao.Font = new Font("Segoe UI", 9F);
            btnEscolherLocacao.ForeColor = Color.White;
            btnEscolherLocacao.Location = new Point(438, 220);
            btnEscolherLocacao.Name = "btnEscolherLocacao";
            btnEscolherLocacao.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEscolherLocacao.Size = new Size(122, 23);
            btnEscolherLocacao.TabIndex = 7;
            btnEscolherLocacao.Text = "&Escolher Pedido";
            // 
            // btnCancelarProduto
            // 
            btnCancelarProduto.Animated = true;
            btnCancelarProduto.AutoRoundedCorners = true;
            btnCancelarProduto.BorderRadius = 10;
            btnCancelarProduto.BorderThickness = 1;
            btnCancelarProduto.CustomizableEdges = customizableEdges9;
            btnCancelarProduto.DisabledState.BorderColor = Color.DarkGray;
            btnCancelarProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelarProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelarProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelarProduto.FillColor = Color.Red;
            btnCancelarProduto.Font = new Font("Segoe UI", 9F);
            btnCancelarProduto.ForeColor = Color.White;
            btnCancelarProduto.Location = new Point(297, 220);
            btnCancelarProduto.Name = "btnCancelarProduto";
            btnCancelarProduto.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelarProduto.Size = new Size(122, 23);
            btnCancelarProduto.TabIndex = 5;
            btnCancelarProduto.Text = "&Cancelar Pedido";
            // 
            // btnInserirProduto
            // 
            btnInserirProduto.Animated = true;
            btnInserirProduto.AutoRoundedCorners = true;
            btnInserirProduto.BorderRadius = 10;
            btnInserirProduto.BorderThickness = 1;
            btnInserirProduto.CustomizableEdges = customizableEdges11;
            btnInserirProduto.DisabledState.BorderColor = Color.DarkGray;
            btnInserirProduto.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserirProduto.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserirProduto.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserirProduto.FillColor = Color.Green;
            btnInserirProduto.Font = new Font("Segoe UI", 9F);
            btnInserirProduto.ForeColor = Color.White;
            btnInserirProduto.Location = new Point(156, 220);
            btnInserirProduto.Name = "btnInserirProduto";
            btnInserirProduto.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnInserirProduto.Size = new Size(122, 23);
            btnInserirProduto.TabIndex = 6;
            btnInserirProduto.Text = "&inserir Pedido";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(276, 165);
            txtValor.Name = "txtValor";
            txtValor.ReadOnly = true;
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(156, 165);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(156, 104);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(72, 23);
            txtIdPedido.TabIndex = 0;
            // 
            // cmbProduto
            // 
            cmbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(408, 104);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "" });
            cmbCategoria.Location = new Point(255, 104);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 1;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(254, 84);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 10;
            label10.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 86);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 11;
            label9.Text = "Produto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 147);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 9;
            label8.Text = "Valor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 147);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 12;
            label7.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 86);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 9;
            label6.Text = "ID do Pedido";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(707, 332);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Consultar Pedidos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvClientes);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(707, 332);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Clientes";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { id, cliente, cpf });
            dgvClientes.Location = new Point(6, 6);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(695, 323);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // cliente
            // 
            cliente.Frozen = true;
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Width = 450;
            // 
            // cpf
            // 
            cpf.Frozen = true;
            cpf.HeaderText = "CPF";
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Width = 200;
            // 
            // FrmAgendarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 533);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAgendarPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar Pedido";
            Load += FrmAgendarPedido_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
        private ComboBox cmbCategoria;
        private Label label10;
        private Label label9;
        private Label label8;
        private Guna.UI2.WinForms.Guna2Button btnEscolherLocacao;
        private TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2Button btnEscolherCliente;
        private TextBox txtIdCliente;
        private Label label11;
        private TabPage tabPage4;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn cpf;
    }
}