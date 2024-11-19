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
            label1 = new Label();
            id = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            funcionario = new DataGridViewTextBoxColumn();
            Dataret = new DataGridViewTextBoxColumn();
            dataent = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { id, cliente, funcionario, Dataret, dataent });
            dgvPedidos.Location = new Point(12, 123);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.Size = new Size(1054, 356);
            dgvPedidos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 47);
            label1.Name = "label1";
            label1.Size = new Size(291, 45);
            label1.TabIndex = 1;
            label1.Text = "Consultar Pedidos";
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
            Dataret.Width = 200;
            // 
            // dataent
            // 
            dataent.Frozen = true;
            dataent.HeaderText = "Data Entrega";
            dataent.Name = "dataent";
            dataent.ReadOnly = true;
            dataent.Width = 200;
            // 
            // FrmConsultarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 491);
            Controls.Add(label1);
            Controls.Add(dgvPedidos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmConsultarPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Pedidos";
            Load += ConsultarPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
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
    }
}