namespace ejercicio101
{
    partial class frm2
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
            lbHolaWindowsForm = new Label();
            lbNombreMateria = new Label();
            SuspendLayout();
            // 
            // lbHolaWindowsForm
            // 
            lbHolaWindowsForm.AutoSize = true;
            lbHolaWindowsForm.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbHolaWindowsForm.Location = new Point(285, 105);
            lbHolaWindowsForm.Name = "lbHolaWindowsForm";
            lbHolaWindowsForm.Size = new Size(201, 26);
            lbHolaWindowsForm.TabIndex = 0;
            lbHolaWindowsForm.Text = "Hola Windows Form!!";
            // 
            // lbNombreMateria
            // 
            lbNombreMateria.AutoSize = true;
            lbNombreMateria.Location = new Point(285, 176);
            lbNombreMateria.Name = "lbNombreMateria";
            lbNombreMateria.Size = new Size(0, 19);
            lbNombreMateria.TabIndex = 1;
            // 
            // frm2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 570);
            Controls.Add(lbNombreMateria);
            Controls.Add(lbHolaWindowsForm);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            Load += frm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHolaWindowsForm;
        private Label lbNombreMateria;
    }
}