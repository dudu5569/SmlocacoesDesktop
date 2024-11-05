namespace SmLocações
{
    partial class FrmEditarUser
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            label7 = new Label();
            label4 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtIdUsuario = new TextBox();
            chkAtivo = new CheckBox();
            txtConfSenha = new TextBox();
            label3 = new Label();
            label5 = new Label();
            dgvUsuarios = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            funcionario = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            ativo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 44);
            label1.Name = "label1";
            label1.Size = new Size(232, 45);
            label1.TabIndex = 2;
            label1.Text = "Editar Usuário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtIdUsuario);
            groupBox1.Controls.Add(chkAtivo);
            groupBox1.Controls.Add(txtConfSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dgvUsuarios);
            groupBox1.Location = new Point(45, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 476);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Usuário";
            // 
            // btnCancelar
            // 
            btnCancelar.Animated = true;
            btnCancelar.AutoRoundedCorners = true;
            btnCancelar.BorderRadius = 10;
            btnCancelar.BorderThickness = 1;
            btnCancelar.CustomizableEdges = customizableEdges1;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(368, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            btnAtualizar.CustomizableEdges = customizableEdges3;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.Green;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(218, 200);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAtualizar.Size = new Size(122, 23);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.Click += btnInserir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 130);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 9;
            label7.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 130);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(368, 148);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(90, 148);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 0;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(107, 200);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 4;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(507, 148);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.PasswordChar = '*';
            txtConfSenha.Size = new Size(100, 23);
            txtConfSenha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 130);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 130);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Confirmar Senha";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, funcionario, usuario, ativo });
            dgvUsuarios.Location = new Point(10, 270);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(689, 186);
            dgvUsuarios.TabIndex = 7;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // funcionario
            // 
            funcionario.Frozen = true;
            funcionario.HeaderText = "Funcoinário";
            funcionario.Name = "funcionario";
            funcionario.ReadOnly = true;
            funcionario.Width = 300;
            // 
            // usuario
            // 
            usuario.Frozen = true;
            usuario.HeaderText = "Usuário";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 250;
            // 
            // ativo
            // 
            ativo.Frozen = true;
            ativo.HeaderText = "Ativo";
            ativo.Name = "ativo";
            ativo.ReadOnly = true;
            // 
            // FrmEditarUser
            // 
            AcceptButton = btnAtualizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(807, 510);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmEditarUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarUser";
            Load += FrmEditarUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label4;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtIdUsuario;
        private CheckBox chkAtivo;
        private TextBox txtConfSenha;
        private Label label3;
        private Label label5;
        private DataGridView dgvUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn funcionario;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn ativo;
    }
}