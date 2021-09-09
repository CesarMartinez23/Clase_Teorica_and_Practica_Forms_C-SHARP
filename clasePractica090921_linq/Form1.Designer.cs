
namespace clasePractica090921_linq
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
            this.btn_getData = new System.Windows.Forms.Button();
            this.btn_getName = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getData
            // 
            this.btn_getData.AutoSize = true;
            this.btn_getData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getData.Location = new System.Drawing.Point(12, 363);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(206, 85);
            this.btn_getData.TabIndex = 0;
            this.btn_getData.Text = "btn_getData()";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // btn_getName
            // 
            this.btn_getName.AutoSize = true;
            this.btn_getName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getName.Location = new System.Drawing.Point(12, 66);
            this.btn_getName.Name = "btn_getName";
            this.btn_getName.Size = new System.Drawing.Size(222, 77);
            this.btn_getName.TabIndex = 1;
            this.btn_getName.Text = "btn_getName()";
            this.btn_getName.UseVisualStyleBackColor = true;
            this.btn_getName.Click += new System.EventHandler(this.btn_getName_Click);
            // 
            // lstNames
            // 
            this.lstNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 36;
            this.lstNames.Location = new System.Drawing.Point(264, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(571, 184);
            this.lstNames.TabIndex = 2;
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(264, 260);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersWidth = 51;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.Size = new System.Drawing.Size(571, 270);
            this.dgData.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 562);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btn_getName);
            this.Controls.Add(this.btn_getData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getData;
        private System.Windows.Forms.Button btn_getName;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.DataGridView dgData;
    }
}

