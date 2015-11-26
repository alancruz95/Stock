namespace Stock
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
            this.btnCalcularCodBarras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularCodBarras
            // 
            this.btnCalcularCodBarras.Location = new System.Drawing.Point(42, 43);
            this.btnCalcularCodBarras.Name = "btnCalcularCodBarras";
            this.btnCalcularCodBarras.Size = new System.Drawing.Size(126, 55);
            this.btnCalcularCodBarras.TabIndex = 0;
            this.btnCalcularCodBarras.Text = "Calcular Codigo de Barras";
            this.btnCalcularCodBarras.UseVisualStyleBackColor = true;
            this.btnCalcularCodBarras.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 532);
            this.Controls.Add(this.btnCalcularCodBarras);
            this.Name = "frmPrincipal";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCodBarras;



    }
}

