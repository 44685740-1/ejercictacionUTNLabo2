namespace logsBaseHerencia
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
            btnfrmUno = new Button();
            btnfrmDos = new Button();
            SuspendLayout();
            // 
            // btnfrmUno
            // 
            btnfrmUno.Location = new Point(227, 195);
            btnfrmUno.Name = "btnfrmUno";
            btnfrmUno.Size = new Size(111, 128);
            btnfrmUno.TabIndex = 0;
            btnfrmUno.Text = "frmUno";
            btnfrmUno.UseVisualStyleBackColor = true;
            btnfrmUno.Click += btnfrmUno_Click;
            // 
            // btnfrmDos
            // 
            btnfrmDos.Location = new Point(465, 185);
            btnfrmDos.Name = "btnfrmDos";
            btnfrmDos.Size = new Size(132, 138);
            btnfrmDos.TabIndex = 1;
            btnfrmDos.Text = "frmDos";
            btnfrmDos.UseVisualStyleBackColor = true;
            btnfrmDos.Click += btnfrmDos_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfrmDos);
            Controls.Add(btnfrmUno);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnfrmUno;
        private Button btnfrmDos;
    }
}