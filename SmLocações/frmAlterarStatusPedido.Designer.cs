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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            dgvPedidos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            FUncionario = new DataGridViewTextBoxColumn();
            retirada = new DataGridViewTextBoxColumn();
            entrega = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(807, 363);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alterar Status";
            tabPage1.UseVisualStyleBackColor = true;
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
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { id, cliente, FUncionario, retirada, entrega, status });
            dgvPedidos.Location = new Point(6, 3);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.Size = new Size(798, 357);
            dgvPedidos.TabIndex = 0;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // cliente
            // 
            cliente.Frozen = true;
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            // 
            // FUncionario
            // 
            FUncionario.Frozen = true;
            FUncionario.HeaderText = "Funcionário";
            FUncionario.Name = "FUncionario";
            FUncionario.ReadOnly = true;
            // 
            // retirada
            // 
            retirada.Frozen = true;
            retirada.HeaderText = "Data Retirada";
            retirada.Name = "retirada";
            retirada.ReadOnly = true;
            // 
            // entrega
            // 
            entrega.Frozen = true;
            entrega.HeaderText = "Data Entrega";
            entrega.Name = "entrega";
            entrega.ReadOnly = true;
            // 
            // status
            // 
            status.Frozen = true;
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
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
    }
}