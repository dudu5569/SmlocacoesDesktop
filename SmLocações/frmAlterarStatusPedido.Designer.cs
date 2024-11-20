namespace SmLocações
{
    partial class frmAlterarStatusPedido
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEscolherPedido = new Guna.UI2.WinForms.Guna2Button();
            cmbStatus = new ComboBox();
            txtDataEntrega = new TextBox();
            txtDataRetirada = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtCliente = new TextBox();
            txtFuncionario = new TextBox();
            txtIdPedido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnInserir = new Guna.UI2.WinForms.Guna2Button();
            tabPage2 = new TabPage();
            dgvPedidos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            FUncionario = new DataGridViewTextBoxColumn();
            retirada = new DataGridViewTextBoxColumn();
            entrega = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(104, 101);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(815, 391);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEscolherPedido);
            tabPage1.Controls.Add(cmbStatus);
            tabPage1.Controls.Add(txtDataEntrega);
            tabPage1.Controls.Add(txtDataRetirada);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtCliente);
            tabPage1.Controls.Add(txtFuncionario);
            tabPage1.Controls.Add(txtIdPedido);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(807, 363);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alterar Status";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEscolherPedido
            // 
            btnEscolherPedido.Animated = true;
            btnEscolherPedido.AutoRoundedCorners = true;
            btnEscolherPedido.BorderRadius = 10;
            btnEscolherPedido.BorderThickness = 1;
            btnEscolherPedido.CustomizableEdges = customizableEdges1;
            btnEscolherPedido.DisabledState.BorderColor = Color.DarkGray;
            btnEscolherPedido.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEscolherPedido.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEscolherPedido.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEscolherPedido.FillColor = Color.DodgerBlue;
            btnEscolherPedido.Font = new Font("Segoe UI", 9F);
            btnEscolherPedido.ForeColor = Color.White;
            btnEscolherPedido.Location = new Point(567, 268);
            btnEscolherPedido.Name = "btnEscolherPedido";
            btnEscolherPedido.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEscolherPedido.Size = new Size(122, 23);
            btnEscolherPedido.TabIndex = 8;
            btnEscolherPedido.Text = "&Escolher Pedido";
            btnEscolherPedido.Click += btnEscolherPedido_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Para Enviar", "Para Receber", "Concluído" });
            cmbStatus.Location = new Point(497, 163);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 5;
            // 
            // txtDataEntrega
            // 
            txtDataEntrega.Location = new Point(333, 163);
            txtDataEntrega.Name = "txtDataEntrega";
            txtDataEntrega.ReadOnly = true;
            txtDataEntrega.Size = new Size(125, 23);
            txtDataEntrega.TabIndex = 4;
            // 
            // txtDataRetirada
            // 
            txtDataRetirada.Location = new Point(177, 163);
            txtDataRetirada.Name = "txtDataRetirada";
            txtDataRetirada.ReadOnly = true;
            txtDataRetirada.Size = new Size(125, 23);
            txtDataRetirada.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 145);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 145);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 15;
            label6.Text = "Data Entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 145);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 14;
            label5.Text = "Data Retirada";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(497, 100);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(192, 23);
            txtCliente.TabIndex = 2;
            // 
            // txtFuncionario
            // 
            txtFuncionario.Location = new Point(248, 100);
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.ReadOnly = true;
            txtFuncionario.Size = new Size(192, 23);
            txtFuncionario.TabIndex = 1;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(92, 95);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(92, 23);
            txtIdPedido.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 82);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 82);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 9;
            label3.Text = "Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 77);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "ID do Pedido";
            // 
            // btnCancelar
            // 
            btnCancelar.Animated = true;
            btnCancelar.AutoRoundedCorners = true;
            btnCancelar.BorderRadius = 10;
            btnCancelar.BorderThickness = 1;
            btnCancelar.CustomizableEdges = customizableEdges3;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(407, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "&Cancelar";
            // 
            // btnInserir
            // 
            btnInserir.Animated = true;
            btnInserir.AutoRoundedCorners = true;
            btnInserir.BorderRadius = 10;
            btnInserir.BorderThickness = 1;
            btnInserir.CustomizableEdges = customizableEdges5;
            btnInserir.DisabledState.BorderColor = Color.DarkGray;
            btnInserir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserir.FillColor = Color.Green;
            btnInserir.Font = new Font("Segoe UI", 9F);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(248, 268);
            btnInserir.Name = "btnInserir";
            btnInserir.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnInserir.Size = new Size(122, 23);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "&Atualizar";
            btnInserir.Click += btnInserir_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPedidos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(807, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { id, cliente, FUncionario, retirada, entrega, status });
            dgvPedidos.Location = new Point(6, 3);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.Size = new Size(798, 357);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
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
            cliente.Width = 175;
            // 
            // FUncionario
            // 
            FUncionario.Frozen = true;
            FUncionario.HeaderText = "Funcionário";
            FUncionario.Name = "FUncionario";
            FUncionario.ReadOnly = true;
            FUncionario.Width = 175;
            // 
            // retirada
            // 
            retirada.Frozen = true;
            retirada.HeaderText = "Data Retirada";
            retirada.Name = "retirada";
            retirada.ReadOnly = true;
            retirada.Width = 150;
            // 
            // entrega
            // 
            entrega.Frozen = true;
            entrega.HeaderText = "Data Entrega";
            entrega.Name = "entrega";
            entrega.ReadOnly = true;
            entrega.Width = 150;
            // 
            // status
            // 
            status.Frozen = true;
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 41);
            label1.Name = "label1";
            label1.Size = new Size(338, 45);
            label1.TabIndex = 1;
            label1.Text = "Alterar Status Pedido";
            label1.Click += label1_Click;
            // 
            // frmAlterarStatusPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 504);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "frmAlterarStatusPedido";
            Text = "frmAlterarStatusPedido";
            Load += frmAlterarStatusPedido_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn FUncionario;
        private DataGridViewTextBoxColumn retirada;
        private DataGridViewTextBoxColumn entrega;
        private DataGridViewTextBoxColumn status;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private Label label6;
        private Label label5;
        private TextBox txtCliente;
        private TextBox txtFuncionario;
        private TextBox txtIdPedido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private ComboBox cmbStatus;
        private TextBox txtDataEntrega;
        private TextBox txtDataRetirada;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button btnEscolherPedido;
    }
}