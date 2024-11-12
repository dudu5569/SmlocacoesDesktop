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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            txtIdUsuario = new TextBox();
            dgvUsuarios = new DataGridView();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            btncolherImagem = new Guna.UI2.WinForms.Guna2Button();
            id = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            produto = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            unidades = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            dest = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btncolherImagem);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtIdUsuario);
            groupBox1.Controls.Add(dgvUsuarios);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(987, 503);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Produtos";
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
            btnCancelar.Location = new Point(498, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            btnAtualizar.CustomizableEdges = customizableEdges5;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.Green;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(348, 272);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAtualizar.Size = new Size(122, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "&Atualizar";
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
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(232, 132);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(57, 23);
            txtIdUsuario.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, categoria, produto, valor, unidades, desc, dest });
            dgvUsuarios.Location = new Point(6, 311);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(972, 186);
            dgvUsuarios.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(498, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(626, 132);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(370, 196);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 114);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 114);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(627, 114);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Unidade Venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 178);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 178);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "Destaque";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 172);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 9;
            label8.Text = "Imagem";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(507, 190);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // btncolherImagem
            // 
            btncolherImagem.Animated = true;
            btncolherImagem.AutoRoundedCorners = true;
            btncolherImagem.BorderRadius = 10;
            btncolherImagem.BorderThickness = 1;
            btncolherImagem.CustomizableEdges = customizableEdges1;
            btncolherImagem.DisabledState.BorderColor = Color.DarkGray;
            btncolherImagem.DisabledState.CustomBorderColor = Color.DarkGray;
            btncolherImagem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncolherImagem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncolherImagem.Font = new Font("Segoe UI", 9F);
            btncolherImagem.ForeColor = Color.White;
            btncolherImagem.Location = new Point(498, 219);
            btncolherImagem.Name = "btncolherImagem";
            btncolherImagem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btncolherImagem.Size = new Size(122, 23);
            btncolherImagem.TabIndex = 17;
            btncolherImagem.Text = "&Escolher Imagem";
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
            // 
            // desc
            // 
            desc.Frozen = true;
            desc.HeaderText = "Descrição";
            desc.Name = "desc";
            desc.ReadOnly = true;
            // 
            // dest
            // 
            dest.Frozen = true;
            dest.HeaderText = "Destaque";
            dest.Name = "dest";
            dest.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(638, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 109);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(341, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 19;
            // 
            // frmEditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 553);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmEditarProduto";
            Text = "frmEditarProduto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtIdUsuario;
        private DataGridView dgvUsuarios;
        private Guna.UI2.WinForms.Guna2Button btncolherImagem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn unidades;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn dest;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}