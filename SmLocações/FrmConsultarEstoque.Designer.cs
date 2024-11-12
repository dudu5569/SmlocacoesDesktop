namespace SmLocações
{
    partial class FrmConsultarEstoque
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
            dgvProdutos = new DataGridView();
            produto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            unidadevenda = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            destaque = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { produto, categoria, valor, unidadevenda, descricao, destaque });
            dgvProdutos.Location = new Point(6, 186);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(981, 438);
            dgvProdutos.TabIndex = 0;
            // 
            // produto
            // 
            produto.Frozen = true;
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.ReadOnly = true;
            produto.Width = 200;
            // 
            // categoria
            // 
            categoria.Frozen = true;
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            // 
            // valor
            // 
            valor.Frozen = true;
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 50;
            // 
            // unidadevenda
            // 
            unidadevenda.Frozen = true;
            unidadevenda.HeaderText = "Unidade de Venda";
            unidadevenda.Name = "unidadevenda";
            unidadevenda.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.Frozen = true;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            descricao.Width = 450;
            // 
            // destaque
            // 
            destaque.Frozen = true;
            destaque.HeaderText = "Destaque";
            destaque.Name = "destaque";
            destaque.ReadOnly = true;
            destaque.Width = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 47);
            label1.Name = "label1";
            label1.Size = new Size(139, 45);
            label1.TabIndex = 4;
            label1.Text = "Estoque";
            // 
            // FrmConsultarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 621);
            Controls.Add(label1);
            Controls.Add(dgvProdutos);
            Name = "FrmConsultarEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += FrmConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn unidadevenda;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn destaque;
        private Label label1;
    }
}