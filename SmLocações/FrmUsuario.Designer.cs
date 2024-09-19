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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 19);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 6;
            label1.Text = "Usuários";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(135, 221);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(213, 23);
            txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 149);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 203);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(135, 113);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(338, 23);
            cmbFuncionarios.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 95);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Funcionário";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(135, 263);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(122, 23);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbFuncionarios);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 312);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inserir Usuários";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(273, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            AcceptButton = btnInserir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(630, 374);
            Controls.Add(groupBox1);
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnCancelar;
    }
}