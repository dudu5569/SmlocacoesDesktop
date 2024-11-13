namespace SmLocações
{
    partial class frmEditarProduto
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtArquivoImagem = new TextBox();
            cmbDestaqueProduto = new ComboBox();
            txtNomeProduto = new TextBox();
            label9 = new Label();
            pbImagemProduto = new PictureBox();
            btnEscolherImagem = new Guna.UI2.WinForms.Guna2Button();
            txtUnidadesVenda = new TextBox();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtIdProduto = new TextBox();
            dgvProdutos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            produto = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            unidades = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            dest = new DataGridViewTextBoxColumn();
            img = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagemProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 60);
            label1.Name = "label1";
            label1.Size = new Size(255, 45);
            label1.TabIndex = 4;
            label1.Text = "Editar Produtos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArquivoImagem);
            groupBox1.Controls.Add(cmbDestaqueProduto);
            groupBox1.Controls.Add(txtNomeProduto);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(pbImagemProduto);
            groupBox1.Controls.Add(btnEscolherImagem);
            groupBox1.Controls.Add(txtUnidadesVenda);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtIdProduto);
            groupBox1.Controls.Add(dgvProdutos);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 503);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Produtos";
            // 
            // txtArquivoImagem
            // 
            txtArquivoImagem.Location = new Point(800, 243);
            txtArquivoImagem.Name = "txtArquivoImagem";
            txtArquivoImagem.ReadOnly = true;
            txtArquivoImagem.Size = new Size(100, 23);
            txtArquivoImagem.TabIndex = 23;
            // 
            // cmbDestaqueProduto
            // 
            cmbDestaqueProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestaqueProduto.FormattingEnabled = true;
            cmbDestaqueProduto.Location = new Point(709, 196);
            cmbDestaqueProduto.Name = "cmbDestaqueProduto";
            cmbDestaqueProduto.Size = new Size(106, 23);
            cmbDestaqueProduto.TabIndex = 22;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(232, 196);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(195, 23);
            txtNomeProduto.TabIndex = 21;
            txtNomeProduto.TextChanged += txtNomeProdut_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 178);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 20;
            label9.Text = "Nome do Produto";
            // 
            // pbImagemProduto
            // 
            pbImagemProduto.BackColor = SystemColors.ControlDarkDark;
            pbImagemProduto.Location = new Point(915, 186);
            pbImagemProduto.Name = "pbImagemProduto";
            pbImagemProduto.Size = new Size(144, 109);
            pbImagemProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagemProduto.TabIndex = 18;
            pbImagemProduto.TabStop = false;
            // 
            // btnEscolherImagem
            // 
            btnEscolherImagem.Animated = true;
            btnEscolherImagem.AutoRoundedCorners = true;
            btnEscolherImagem.BorderRadius = 10;
            btnEscolherImagem.BorderThickness = 1;
            btnEscolherImagem.CustomizableEdges = customizableEdges7;
            btnEscolherImagem.DisabledState.BorderColor = Color.DarkGray;
            btnEscolherImagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEscolherImagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEscolherImagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEscolherImagem.Font = new Font("Segoe UI", 9F);
            btnEscolherImagem.ForeColor = Color.White;
            btnEscolherImagem.Location = new Point(787, 272);
            btnEscolherImagem.Name = "btnEscolherImagem";
            btnEscolherImagem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnEscolherImagem.Size = new Size(122, 23);
            btnEscolherImagem.TabIndex = 17;
            btnEscolherImagem.Text = "&Escolher Imagem";
            btnEscolherImagem.Click += btnEscolherImagem_Click;
            // 
            // txtUnidadesVenda
            // 
            txtUnidadesVenda.Location = new Point(574, 196);
            txtUnidadesVenda.Name = "txtUnidadesVenda";
            txtUnidadesVenda.Size = new Size(100, 23);
            txtUnidadesVenda.TabIndex = 13;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(446, 196);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 12;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(301, 132);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(327, 23);
            txtDescricao.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.Animated = true;
            btnCancelar.AutoRoundedCorners = true;
            btnCancelar.BorderRadius = 10;
            btnCancelar.BorderThickness = 1;
            btnCancelar.CustomizableEdges = customizableEdges9;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(498, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "&Cancelar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Animated = true;
            btnAtualizar.AutoRoundedCorners = true;
            btnAtualizar.BorderRadius = 10;
            btnAtualizar.BorderThickness = 1;
            btnAtualizar.CustomizableEdges = customizableEdges11;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.Green;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(348, 272);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAtualizar.Size = new Size(122, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(960, 168);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 9;
            label8.Text = "Imagem";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(709, 178);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "Destaque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 114);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(575, 178);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Unidade Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 178);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Valor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 114);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 9;
            label7.Text = "ID";
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(232, 132);
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.ReadOnly = true;
            txtIdProduto.Size = new Size(57, 23);
            txtIdProduto.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { id, categoria, produto, valor, unidades, desc, dest, img });
            dgvProdutos.Location = new Point(6, 311);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(1071, 186);
            dgvProdutos.TabIndex = 7;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // categoria
            // 
            categoria.Frozen = true;
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            // 
            // produto
            // 
            produto.Frozen = true;
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.ReadOnly = true;
            produto.Width = 150;
            // 
            // valor
            // 
            valor.Frozen = true;
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // unidades
            // 
            unidades.Frozen = true;
            unidades.HeaderText = "Unidades";
            unidades.Name = "unidades";
            unidades.ReadOnly = true;
            unidades.Width = 50;
            // 
            // desc
            // 
            desc.Frozen = true;
            desc.HeaderText = "Descrição";
            desc.Name = "desc";
            desc.ReadOnly = true;
            desc.Width = 300;
            // 
            // dest
            // 
            dest.Frozen = true;
            dest.HeaderText = "Destaque";
            dest.Name = "dest";
            dest.ReadOnly = true;
            // 
            // img
            // 
            img.HeaderText = "Imagem";
            img.Name = "img";
            img.ReadOnly = true;
            img.Resizable = DataGridViewTriState.True;
            img.Width = 218;
            // 
            // frmEditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 553);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmEditarProduto";
            Text = "frmEditarProduto";
            Load += frmEditarProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagemProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtUnidadesVenda;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtIdProduto;
        private DataGridView dgvProdutos;
        private Guna.UI2.WinForms.Guna2Button btnEscolherImagem;
        private PictureBox pbImagemProduto;
        private Label label9;
        private TextBox txtNomeProduto;
        private ComboBox cmbDestaqueProduto;
        private TextBox txtArquivoImagem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn unidades;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn dest;
        private DataGridViewTextBoxColumn img;
    }
}