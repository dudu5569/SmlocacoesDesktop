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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem2 = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem3 = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            vizualizarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, pedidosToolStripMenuItem, vizualizarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, funcionárioToolStripMenuItem, usuárioToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem1 });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(137, 22);
            clienteToolStripMenuItem.Text = "&Cliente";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(103, 22);
            novoToolStripMenuItem1.Text = "&Novo";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem2 });
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(137, 22);
            funcionárioToolStripMenuItem.Text = "&Funcionário";
            // 
            // novoToolStripMenuItem2
            // 
            novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            novoToolStripMenuItem2.Size = new Size(103, 22);
            novoToolStripMenuItem2.Text = "&Novo";
            novoToolStripMenuItem2.Click += novoToolStripMenuItem2_Click;
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem3, editarToolStripMenuItem });
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(137, 22);
            usuárioToolStripMenuItem.Text = "&Usuário";
            // 
            // novoToolStripMenuItem3
            // 
            novoToolStripMenuItem3.Name = "novoToolStripMenuItem3";
            novoToolStripMenuItem3.Size = new Size(104, 22);
            novoToolStripMenuItem3.Text = "&Novo";
            novoToolStripMenuItem3.Click += novoToolStripMenuItem3_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(104, 22);
            editarToolStripMenuItem.Text = "&Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "&Pedidos";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(125, 22);
            novoToolStripMenuItem.Text = "&Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "&Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // vizualizarToolStripMenuItem
            // 
            vizualizarToolStripMenuItem.Name = "vizualizarToolStripMenuItem";
            vizualizarToolStripMenuItem.Size = new Size(70, 20);
            vizualizarToolStripMenuItem.Text = "C&onsultar";
            vizualizarToolStripMenuItem.Click += vizualizarToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1084, 623);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem vizualizarToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem2;
        private ToolStripMenuItem novoToolStripMenuItem3;
        private ToolStripMenuItem editarToolStripMenuItem;
    }
}