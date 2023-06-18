namespace logsAbrirCerrasFrm
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
            btnFrmDos = new Button();
            lbformulario = new Label();
            SuspendLayout();
            // 
            // btnFrmUno
            // 
            btnFrmUno.Location = new Point(246, 210);
            btnFrmUno.Name = "btnFrmUno";
            btnFrmUno.Size = new Size(106, 83);
            btnFrmUno.TabIndex = 0;
            btnFrmUno.Text = "frm Uno";
            btnFrmUno.UseVisualStyleBackColor = true;
            btnFrmUno.Click += btnFrmUno_Click;
            // 
            // btnFrmDos
            // 
            btnFrmDos.Location = new Point(456, 206);
            btnFrmDos.Name = "btnFrmDos";
            btnFrmDos.Size = new Size(103, 91);
            btnFrmDos.TabIndex = 1;
            btnFrmDos.Text = "frm dos";
            btnFrmDos.UseVisualStyleBackColor = true;
            btnFrmDos.Click += btnFrmDos_Click;
            // 
            // lbformulario
            // 
            lbformulario.AutoSize = true;
            lbformulario.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbformulario.Location = new Point(374, 100);
            lbformulario.Name = "lbformulario";
            lbformulario.Size = new Size(0, 30);
            lbformulario.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbformulario);
            Controls.Add(btnFrmDos);
            Controls.Add(btnFrmUno);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFrmUno;
        private Button btnFrmDos;
        private Label lbformulario;
    }
}