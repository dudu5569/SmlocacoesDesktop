namespace SmLocações
{
    partial class FrmConsultarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarPedidos));
            dgvVerPedidos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVerPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvVerPedidos
            // 
            dgvVerPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerPedidos.Location = new Point(12, 123);
            dgvVerPedidos.Name = "dgvVerPedidos";
            dgvVerPedidos.Size = new Size(1112, 356);
            dgvVerPedidos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 47);
            label1.Name = "label1";
            label1.Size = new Size(291, 45);
            label1.TabIndex = 1;
            label1.Text = "Consultar Pedidos";
            // 
            // FrmConsultarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 491);
            Controls.Add(label1);
            Controls.Add(dgvVerPedidos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmConsultarPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Pedidos";
            Load += ConsultarPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVerPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVerPedidos;
        private Label label1;
    }
}