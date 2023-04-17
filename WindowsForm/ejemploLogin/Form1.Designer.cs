namespace ejemploLogin
{
    partial class frmLogin
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
            lbUsuario = new Label();
            lbContrasenia = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            texContrasenia = new TextBox();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.BackColor = SystemColors.ActiveCaption;
            lbUsuario.Location = new Point(366, 77);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario";
            // 
            // lbContrasenia
            // 
            lbContrasenia.AutoSize = true;
            lbContrasenia.BackColor = SystemColors.ActiveCaption;
            lbContrasenia.Location = new Point(357, 165);
            lbContrasenia.Name = "lbContrasenia";
            lbContrasenia.Size = new Size(67, 15);
            lbContrasenia.TabIndex = 1;
            lbContrasenia.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(357, 267);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(325, 120);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su Usuario";
            txtUsuario.Size = new Size(149, 23);
            txtUsuario.TabIndex = 3;
            // 
            // texContrasenia
            // 
            texContrasenia.Location = new Point(325, 208);
            texContrasenia.Name = "texContrasenia";
            texContrasenia.PasswordChar = '*';
            texContrasenia.PlaceholderText = "Ingrese la contraseña";
            texContrasenia.Size = new Size(149, 23);
            texContrasenia.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(texContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lbContrasenia);
            Controls.Add(lbUsuario);
            Name = "frmLogin";
            Text = "frmLoging";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private Label lbContrasenia;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox texContrasenia;
    }
}