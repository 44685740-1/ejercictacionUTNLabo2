namespace ejercicio101
{
    partial class fmr1
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
            lbNombre = new Label();
            lbApellido = new Label();
            lbMateria = new Label();
            btnSaludar = new Button();
            cmbMateria = new ComboBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(284, 71);
            lbNombre.Margin = new Padding(4, 0, 4, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(60, 19);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(491, 71);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(62, 19);
            lbApellido.TabIndex = 1;
            lbApellido.Text = "Apellido";
            // 
            // lbMateria
            // 
            lbMateria.AutoSize = true;
            lbMateria.Location = new Point(252, 161);
            lbMateria.Name = "lbMateria";
            lbMateria.Size = new Size(116, 19);
            lbMateria.TabIndex = 2;
            lbMateria.Text = "Materia Favorita";
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(467, 262);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 28);
            btnSaludar.TabIndex = 3;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.AllowDrop = true;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(252, 206);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(290, 27);
            cmbMateria.TabIndex = 4;
            cmbMateria.Text = "Arquitectura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(252, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su Nombre";
            txtNombre.Size = new Size(138, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(441, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese Su Apellido";
            txtApellido.Size = new Size(135, 27);
            txtApellido.TabIndex = 6;
            // 
            // fmr1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 570);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cmbMateria);
            Controls.Add(btnSaludar);
            Controls.Add(lbMateria);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmr1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hola Windows Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label lbApellido;
        private Label lbMateria;
        private Button btnSaludar;
        private ComboBox cmbMateria;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}