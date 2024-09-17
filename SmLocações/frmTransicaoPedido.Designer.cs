namespace SmLocações
{
    partial class frmTransicaoPedido
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
            btnNovo = new Button();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(356, 108);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(155, 74);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "&Novo Pedido";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(356, 220);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 74);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "&Consultar Pedido";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button2_Click;
            // 
            // frmTransicaoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 499);
            Controls.Add(btnConsultar);
            Controls.Add(btnNovo);
            Name = "frmTransicaoPedido";
            Text = "frmTransicaoPedido";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovo;
        private Button btnConsultar;
    }
}