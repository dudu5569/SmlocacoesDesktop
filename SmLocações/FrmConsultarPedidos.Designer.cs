namespace SmLocações
{
    partial class FrmConsultarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarPedidos));
            dgvPedidos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            funcionario = new DataGridViewTextBoxColumn();
            Dataret = new DataGridViewTextBoxColumn();
            dataent = new DataGridViewTextBoxColumn();
            stati = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dgvProdutos = new DataGridView();
            Idlocacao = new DataGridViewTextBoxColumn();
            idproduto = new DataGridViewTextBoxColumn();
            qntd = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { id, cliente, funcionario, Dataret, dataent, stati });
            dgvPedidos.Location = new Point(12, 123);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.Size = new Size(1050, 107);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
            dgvPedidos.CellContentClick += dgvPedidos_CellContentClick;
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
            cliente.Width = 300;
            // 
            // funcionario
            // 
            funcionario.Frozen = true;
            funcionario.HeaderText = "Funcionário";
            funcionario.Name = "funcionario";
            funcionario.ReadOnly = true;
            funcionario.Width = 300;
            // 
            // Dataret
            // 
            Dataret.Frozen = true;
            Dataret.HeaderText = "Data Retirada";
            Dataret.Name = "Dataret";
            Dataret.ReadOnly = true;
            Dataret.Width = 150;
            // 
            // dataent
            // 
            dataent.Frozen = true;
            dataent.HeaderText = "Data Entrega";
            dataent.Name = "dataent";
            dataent.ReadOnly = true;
            dataent.Width = 150;
            // 
            // stati
            // 
            stati.Frozen = true;
            stati.HeaderText = "Status";
            stati.Name = "stati";
            stati.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 43);
            label1.Name = "label1";
            label1.Size = new Size(291, 45);
            label1.TabIndex = 1;
            label1.Text = "Consultar Pedidos";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Idlocacao, idproduto, qntd, valor });
            dgvProdutos.Location = new Point(198, 249);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(603, 150);
            dgvProdutos.TabIndex = 2;
            // 
            // Idlocacao
            // 
            Idlocacao.Frozen = true;
            Idlocacao.HeaderText = "Id Pedido";
            Idlocacao.Name = "Idlocacao";
            Idlocacao.ReadOnly = true;
            // 
            // idproduto
            // 
            idproduto.Frozen = true;
            idproduto.HeaderText = "Produto";
            idproduto.Name = "idproduto";
            idproduto.ReadOnly = true;
            idproduto.Width = 300;
            // 
            // qntd
            // 
            qntd.Frozen = true;
            qntd.HeaderText = "Quantidade";
            qntd.Name = "qntd";
            qntd.ReadOnly = true;
            // 
            // valor
            // 
            valor.Frozen = true;
            valor.HeaderText = "Valor Total";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // FrmConsultarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 491);
            Controls.Add(dgvProdutos);
            Controls.Add(label1);
            Controls.Add(dgvPedidos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmConsultarPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Pedidos";
            Load += ConsultarPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private Label label1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn funcionario;
        private DataGridViewTextBoxColumn Dataret;
        private DataGridViewTextBoxColumn dataent;
        private DataGridViewTextBoxColumn stati;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn Idlocacao;
        private DataGridViewTextBoxColumn idproduto;
        private DataGridViewTextBoxColumn qntd;
        private DataGridViewTextBoxColumn valor;
    }
}