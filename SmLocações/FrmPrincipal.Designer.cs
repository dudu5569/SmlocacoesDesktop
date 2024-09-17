namespace SmLocações
{
    partial class FrmPrincipal
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
            btnCadastro = new Button();
            btnPedidos = new Button();
            btnVizualizar = new Button();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(341, 190);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(134, 73);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "&Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(510, 190);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(134, 73);
            btnPedidos.TabIndex = 1;
            btnPedidos.Text = "&Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnVizualizar
            // 
            btnVizualizar.Location = new Point(429, 269);
            btnVizualizar.Name = "btnVizualizar";
            btnVizualizar.Size = new Size(134, 73);
            btnVizualizar.TabIndex = 2;
            btnVizualizar.Text = "&Vizualizar";
            btnVizualizar.UseVisualStyleBackColor = true;
            btnVizualizar.Click += btnVizualizar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1084, 623);
            Controls.Add(btnVizualizar);
            Controls.Add(btnPedidos);
            Controls.Add(btnCadastro);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastro;
        private Button btnPedidos;
        private Button btnVizualizar;
    }
}