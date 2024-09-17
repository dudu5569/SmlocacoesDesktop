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
            label1 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbFuncionarios = new ComboBox();
            label4 = new Label();
            btnInserir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 53);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 0;
            label1.Text = "Usuários";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(185, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(185, 284);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(213, 23);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 211);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 266);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(185, 176);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(161, 23);
            cmbFuncionarios.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 158);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Funcionário";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(185, 323);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(122, 23);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInserir);
            Controls.Add(label4);
            Controls.Add(cmbFuncionarios);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private ComboBox cmbFuncionarios;
        private Label label4;
        private Button btnInserir;
    }
}