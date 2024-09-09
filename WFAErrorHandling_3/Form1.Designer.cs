namespace WFAErrorHandling_3
{
    partial class Form1
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnSpesifik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(106, 56);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 22);
            this.txtSayi.TabIndex = 0;
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(106, 109);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(100, 23);
            this.btnCarp.TabIndex = 1;
            this.btnCarp.Text = "Carp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnSpesifik
            // 
            this.btnSpesifik.Location = new System.Drawing.Point(456, 99);
            this.btnSpesifik.Name = "btnSpesifik";
            this.btnSpesifik.Size = new System.Drawing.Size(75, 23);
            this.btnSpesifik.TabIndex = 2;
            this.btnSpesifik.Text = "Spesifik";
            this.btnSpesifik.UseVisualStyleBackColor = true;
            this.btnSpesifik.Click += new System.EventHandler(this.btnSpesifik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpesifik);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnSpesifik;
    }
}

