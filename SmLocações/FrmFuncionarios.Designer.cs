namespace SmLocações
{
    partial class FrmFuncionarios
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            Data_Nascimento = new DateTimePicker();
            Data_Cadastro = new DateTimePicker();
            chkAivo = new CheckBox();
            btnInserir = new Button();
            btnCancelar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 55);
            label1.Name = "label1";
            label1.Size = new Size(211, 45);
            label1.TabIndex = 0;
            label1.Text = "Funcionários";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(151, 103);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(777, 403);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(chkAivo);
            tabPage1.Controls.Add(Data_Cadastro);
            tabPage1.Controls.Add(Data_Nascimento);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(769, 375);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Funcionário";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 143);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 3;
            label5.Text = "Data de Cadastro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 143);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 2;
            label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 66);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(769, 375);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(63, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(484, 84);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(157, 23);
            txtCpf.TabIndex = 5;
            // 
            // Data_Nascimento
            // 
            Data_Nascimento.Format = DateTimePickerFormat.Short;
            Data_Nascimento.Location = new Point(63, 172);
            Data_Nascimento.Name = "Data_Nascimento";
            Data_Nascimento.Size = new Size(114, 23);
            Data_Nascimento.TabIndex = 6;
            // 
            // Data_Cadastro
            // 
            Data_Cadastro.Format = DateTimePickerFormat.Short;
            Data_Cadastro.Location = new Point(205, 172);
            Data_Cadastro.Name = "Data_Cadastro";
            Data_Cadastro.Size = new Size(114, 23);
            Data_Cadastro.TabIndex = 7;
            // 
            // chkAivo
            // 
            chkAivo.AutoSize = true;
            chkAivo.Location = new Point(353, 177);
            chkAivo.Name = "chkAivo";
            chkAivo.Size = new Size(54, 19);
            chkAivo.TabIndex = 8;
            chkAivo.Text = "Ativo";
            chkAivo.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(63, 234);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(114, 23);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 234);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 641);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "FrmFuncionarios";
            Text = "FrmFuncionarios";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private Button btnInserir;
        private CheckBox chkAivo;
        private DateTimePicker Data_Cadastro;
        private DateTimePicker Data_Nascimento;
        private TextBox txtCpf;
        private TextBox txtNome;
    }
}