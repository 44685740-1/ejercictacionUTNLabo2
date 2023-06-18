namespace problemaParcial
{
    partial class frmAdd
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
            lbAddProducto = new Label();
            lbNombre = new Label();
            lbPrecio = new Label();
            Cantidad = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lbAddProducto
            // 
            lbAddProducto.AutoSize = true;
            lbAddProducto.Location = new Point(126, 65);
            lbAddProducto.Name = "lbAddProducto";
            lbAddProducto.Size = new Size(94, 15);
            lbAddProducto.TabIndex = 0;
            lbAddProducto.Text = "Añadir Producto";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(55, 136);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(55, 195);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(40, 15);
            lbPrecio.TabIndex = 2;
            lbPrecio.Text = "Precio";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(55, 265);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(53, 15);
            Cantidad.TabIndex = 3;
            Cantidad.Text = "cantidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(195, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(195, 265);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(119, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 57);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(Cantidad);
            Controls.Add(lbPrecio);
            Controls.Add(lbNombre);
            Controls.Add(lbAddProducto);
            Name = "frmAdd";
            Text = "frmAdd";
            Load += frmAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAddProducto;
        private Label lbNombre;
        private Label lbPrecio;
        private Label Cantidad;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnAdd;
    }
}