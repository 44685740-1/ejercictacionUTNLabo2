namespace ejemploHerenciaDeForms
{
    partial class frmPadre
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
            lbPadre = new Label();
            btnFrmHijo = new Button();
            SuspendLayout();
            // 
            // lbPadre
            // 
            lbPadre.AutoSize = true;
            lbPadre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbPadre.Location = new Point(305, 82);
            lbPadre.Name = "lbPadre";
            lbPadre.Size = new Size(201, 32);
            lbPadre.TabIndex = 0;
            lbPadre.Text = "Padre Cambiado";
            // 
            // btnFrmHijo
            // 
            btnFrmHijo.Location = new Point(367, 170);
            btnFrmHijo.Name = "btnFrmHijo";
            btnFrmHijo.Size = new Size(75, 23);
            btnFrmHijo.TabIndex = 1;
            btnFrmHijo.Text = "Ir a Hijo";
            btnFrmHijo.UseVisualStyleBackColor = true;
            btnFrmHijo.Click += btnFrmHijo_Click;
            // 
            // frmPadre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrmHijo);
            Controls.Add(lbPadre);
            Name = "frmPadre";
            Text = "frmPadre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbPadre;
        public Button btnFrmHijo;
    }
}