﻿namespace vistaLogs
{
    partial class frmUno
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
            lbCount = new Label();
            SuspendLayout();
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lbCount.Location = new Point(401, 148);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(0, 128);
            lbCount.TabIndex = 0;
            // 
            // frmUno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCount);
            Name = "frmUno";
            Text = "frmUno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCount;
    }
}