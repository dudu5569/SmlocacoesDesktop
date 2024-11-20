namespace SmLocações
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbFuncionarios = new ComboBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            chkAtivo = new CheckBox();
            btnInserir = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 19);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 6;
            label1.Text = "Usuários";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(71, 167);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(71, 221);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(213, 23);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 149);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 203);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(71, 113);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(280, 23);
            cmbFuncionarios.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 95);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Funcionário";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAtivo);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbFuncionarios);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(10, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inserir Usuários";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(310, 225);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 3;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Animated = true;
            btnInserir.AutoRoundedCorners = true;
            btnInserir.BorderRadius = 10;
            btnInserir.BorderThickness = 1;
            btnInserir.CustomizableEdges = customizableEdges1;
            btnInserir.DisabledState.BorderColor = Color.DarkGray;
            btnInserir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserir.FillColor = Color.Green;
            btnInserir.Font = new Font("Segoe UI", 9F);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(71, 263);
            btnInserir.Name = "btnInserir";
            btnInserir.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnInserir.Size = new Size(122, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&inserir";
            btnInserir.Click += btnInserir_Click;
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
            btnCancelar.Location = new Point(211, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmUsuario
            // 
            AcceptButton = btnInserir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(453, 374);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Usuários";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private ComboBox cmbFuncionarios;
        private Label label4;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private CheckBox chkAtivo;
    }
}