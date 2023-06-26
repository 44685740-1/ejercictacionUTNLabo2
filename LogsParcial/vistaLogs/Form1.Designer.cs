namespace vistaLogs
{
    partial class Form1
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
            btnfrmUno = new Button();
            btnDos = new Button();
            SuspendLayout();
            // 
            // btnfrmUno
            // 
            btnfrmUno.Location = new Point(179, 176);
            btnfrmUno.Name = "btnfrmUno";
            btnfrmUno.Size = new Size(126, 110);
            btnfrmUno.TabIndex = 0;
            btnfrmUno.Text = "frm uno";
            btnfrmUno.UseVisualStyleBackColor = true;
            btnfrmUno.Click += btnfrmUno_Click;
            // 
            // btnDos
            // 
            btnDos.Location = new Point(472, 182);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(145, 99);
            btnDos.TabIndex = 1;
            btnDos.Text = "frm dos";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += btnDos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDos);
            Controls.Add(btnfrmUno);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnfrmUno;
        private Button btnDos;
    }
}