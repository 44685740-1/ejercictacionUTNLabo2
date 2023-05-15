namespace ejemploHerenciaFrmDesign
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
            lbTitulo = new Label();
            btnIr = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitulo.Location = new Point(258, 94);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(273, 30);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Hola Winodws From";
            // 
            // btnIr
            // 
            btnIr.Location = new Point(350, 203);
            btnIr.Name = "btnIr";
            btnIr.Size = new Size(75, 23);
            btnIr.TabIndex = 1;
            btnIr.Text = "ir";
            btnIr.UseVisualStyleBackColor = true;
            btnIr.Click += btnIr_Click;
            // 
            // frmPadre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIr);
            Controls.Add(lbTitulo);
            Name = "frmPadre";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        public Button btnIr;
    }
}