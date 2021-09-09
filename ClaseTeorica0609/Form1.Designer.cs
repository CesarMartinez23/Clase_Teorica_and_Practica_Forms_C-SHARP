
namespace ClaseTeorica0609
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClic = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClic
            // 
            this.btnClic.AutoSize = true;
            this.btnClic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClic.Location = new System.Drawing.Point(48, 135);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(108, 46);
            this.btnClic.TabIndex = 0;
            this.btnClic.Text = "Llenar";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.btnClic_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 16;
            this.lstData.Location = new System.Drawing.Point(282, 71);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(298, 228);
            this.lstData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnClic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClic;
        private System.Windows.Forms.ListBox lstData;
    }
}

