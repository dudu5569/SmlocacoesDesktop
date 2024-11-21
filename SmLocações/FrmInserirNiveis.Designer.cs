namespace SmLocações
{
    partial class FrmInserirNiveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInserirNiveis));
            groupBox1 = new GroupBox();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnInserir = new Guna.UI2.WinForms.Guna2Button();
            txtSiglaNivel = new TextBox();
            txtNomeNivel = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtSiglaNivel);
            groupBox1.Controls.Add(txtNomeNivel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 255);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inserindo Niveis";
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
            btnCancelar.Location = new Point(223, 186);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelar.Size = new Size(122, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "&Cancelar";
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
            btnInserir.Location = new Point(79, 186);
            btnInserir.Name = "btnInserir";
            btnInserir.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnInserir.Size = new Size(122, 23);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "&Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // txtSiglaNivel
            // 
            txtSiglaNivel.Location = new Point(102, 137);
            txtSiglaNivel.Name = "txtSiglaNivel";
            txtSiglaNivel.Size = new Size(215, 23);
            txtSiglaNivel.TabIndex = 1;
            // 
            // txtNomeNivel
            // 
            txtNomeNivel.Location = new Point(102, 87);
            txtNomeNivel.Name = "txtNomeNivel";
            txtNomeNivel.Size = new Size(215, 23);
            txtNomeNivel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 119);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 69);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome do Nível";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 30);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 1;
            label1.Text = "Inserir Níveis";
            // 
            // FrmInserirNiveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 350);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInserirNiveis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Cargos";
            Load += FrmInserirNiveis_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSiglaNivel;
        private TextBox txtNomeNivel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}