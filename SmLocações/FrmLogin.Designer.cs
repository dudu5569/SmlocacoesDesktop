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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
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
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
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
            // btnEntrar
            // 
            btnEntrar.Location = new Point(46, 216);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(174, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(47, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 268);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(460, 344);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
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
        private Button btnCancelar;
        private GroupBox groupBox1;
    }
}