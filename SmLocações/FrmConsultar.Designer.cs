namespace SmLocações
{
    partial class FrmConsultar
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
            imagem = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { produto, categoria, valor, unidadevenda, descricao, imagem });
            dgvProdutos.Location = new Point(12, 12);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(1040, 617);
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
            descricao.Width = 300;
            // 
            // imagem
            // 
            imagem.Frozen = true;
            imagem.HeaderText = "Imagem";
            imagem.Name = "imagem";
            imagem.ReadOnly = true;
            imagem.Width = 300;
            // 
            // FrmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 641);
            Controls.Add(dgvProdutos);
            Name = "FrmConsultar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += FrmConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn unidadevenda;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn imagem;
    }
}