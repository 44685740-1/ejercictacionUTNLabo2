namespace ejemploMDI
{
    partial class frmLsitados
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
            dgListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgListado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "listado";
            label1.Click += label1_Click;
            // 
            // dgListado
            // 
            dgListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListado.Location = new Point(12, 68);
            dgListado.Name = "dgListado";
            dgListado.RowTemplate.Height = 25;
            dgListado.Size = new Size(768, 370);
            dgListado.TabIndex = 1;
            // 
            // frmLsitados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgListado);
            Controls.Add(label1);
            Name = "frmLsitados";
            Text = "frmLsitados";
            Load += frmLsitados_Load;
            ((System.ComponentModel.ISupportInitialize)dgListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgListado;
    }
}