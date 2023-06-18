namespace frmPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnDelete = new Button();
            btnModificar = new Button();
            lbMovimiento = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 93);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(343, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 93);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(591, 225);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 87);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "btnModificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lbMovimiento
            // 
            lbMovimiento.AutoSize = true;
            lbMovimiento.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbMovimiento.Location = new Point(368, 88);
            lbMovimiento.Name = "lbMovimiento";
            lbMovimiento.Size = new Size(0, 29);
            lbMovimiento.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMovimiento);
            Controls.Add(btnModificar);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnModificar;
        private Label lbMovimiento;
    }
}