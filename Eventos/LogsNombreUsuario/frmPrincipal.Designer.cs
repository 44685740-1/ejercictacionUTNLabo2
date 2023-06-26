namespace LogsNombreUsuario
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
            btnFrmUno = new Button();
            btnfrmDos = new Button();
            SuspendLayout();
            // 
            // btnFrmUno
            // 
            btnFrmUno.Location = new Point(217, 178);
            btnFrmUno.Name = "btnFrmUno";
            btnFrmUno.Size = new Size(119, 90);
            btnFrmUno.TabIndex = 0;
            btnFrmUno.Text = "frm Uno";
            btnFrmUno.UseVisualStyleBackColor = true;
            btnFrmUno.Click += btnFrmUno_Click;
            // 
            // btnfrmDos
            // 
            btnfrmDos.Location = new Point(428, 178);
            btnfrmDos.Name = "btnfrmDos";
            btnfrmDos.Size = new Size(126, 90);
            btnfrmDos.TabIndex = 1;
            btnfrmDos.Text = "frm Dos";
            btnfrmDos.UseVisualStyleBackColor = true;
            btnfrmDos.Click += btnfrmDos_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfrmDos);
            Controls.Add(btnFrmUno);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmUno;
        private Button btnfrmDos;
    }
}