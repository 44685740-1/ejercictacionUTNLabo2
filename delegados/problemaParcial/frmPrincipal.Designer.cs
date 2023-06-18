namespace problemaParcial
{
    partial class frmPrincipal
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
            dtgProductos = new DataGridView();
            lbProductos = new Label();
            btnAñadir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProductos).BeginInit();
            SuspendLayout();
            // 
            // dtgProductos
            // 
            dtgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProductos.Location = new Point(207, 94);
            dtgProductos.Name = "dtgProductos";
            dtgProductos.RowTemplate.Height = 25;
            dtgProductos.Size = new Size(365, 244);
            dtgProductos.TabIndex = 0;
            // 
            // lbProductos
            // 
            lbProductos.AutoSize = true;
            lbProductos.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductos.Location = new Point(276, 40);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(224, 30);
            lbProductos.TabIndex = 1;
            lbProductos.Text = "lista Productos";
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(357, 373);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 2;
            btnAñadir.Text = "Add";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAñadir);
            Controls.Add(lbProductos);
            Controls.Add(dtgProductos);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgProductos;
        private Label lbProductos;
        private Button btnAñadir;
    }
}