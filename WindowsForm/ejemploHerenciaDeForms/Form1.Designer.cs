namespace ejemploHerenciaDeForms
{
    partial class frmHijo
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
            SuspendLayout();
            // 
            // lbPadre
            // 
            lbPadre.Location = new Point(346, 82);
            lbPadre.Size = new Size(133, 32);
            lbPadre.Text = "Padre Hijo";
            // 
            // btnFrmHijo
            // 
            btnFrmHijo.Text = "mensaje";
            btnFrmHijo.Click += btnFrmHijo_Click;
            // 
            // frmHijo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "frmHijo";
            Text = "frmHijo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}