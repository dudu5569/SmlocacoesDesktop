namespace SmLocações
{
    partial class FrmClientes
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            btnInserir = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(34, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(716, 389);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(708, 361);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(976, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contato";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(976, 525);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Endereço";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 52);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 136);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de Cadastro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 136);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(304, 70);
            maskedTextBox1.Mask = "___.___.___-__";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(126, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(40, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(189, 154);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(114, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(304, 23);
            label5.Name = "label5";
            label5.Size = new Size(137, 45);
            label5.TabIndex = 2;
            label5.Text = "Clientes";
            // 
            // btnInserir
            // 
            btnInserir.Animated = true;
            btnInserir.AutoRoundedCorners = true;
            btnInserir.BorderRadius = 10;
            btnInserir.BorderThickness = 1;
            btnInserir.CustomizableEdges = customizableEdges3;
            btnInserir.DisabledState.BorderColor = Color.DarkGray;
            btnInserir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInserir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInserir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInserir.FillColor = Color.Green;
            btnInserir.Font = new Font("Segoe UI", 9F);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(40, 208);
            btnInserir.Name = "btnInserir";
            btnInserir.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnInserir.Size = new Size(122, 23);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "&inserir";
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
            btnCancelar.Location = new Point(189, 208);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "&Cancelar";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 472);
            Controls.Add(label5);
            Controls.Add(tabControl1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}