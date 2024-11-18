namespace SmLocações
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            groupBox1 = new GroupBox();
            btnLogar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 43);
            label1.Name = "label1";
            label1.Size = new Size(270, 30);
            label1.TabIndex = 5;
            label1.Text = "Área de login SmLocações";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 154);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(46, 172);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(203, 23);
            txtSenha.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(47, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 293);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnLogar
            // 
            btnLogar.Animated = true;
            btnLogar.AutoRoundedCorners = true;
            btnLogar.BorderRadius = 10;
            btnLogar.BorderThickness = 1;
            btnLogar.CustomizableEdges = customizableEdges1;
            btnLogar.DisabledState.BorderColor = Color.DarkGray;
            btnLogar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogar.FillColor = Color.Green;
            btnLogar.Font = new Font("Segoe UI", 9F);
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(46, 216);
            btnLogar.Name = "btnLogar";
            btnLogar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogar.Size = new Size(122, 23);
            btnLogar.TabIndex = 8;
            btnLogar.Text = "&Entrar";
            btnLogar.Click += btnLogar_Click;
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
            btnCancelar.Location = new Point(194, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 344);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEntrar;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnLogar;
    }
}