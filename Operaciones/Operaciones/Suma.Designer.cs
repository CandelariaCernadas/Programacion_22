namespace Operaciones
{
    partial class Suma
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
            this.BtRes = new System.Windows.Forms.Button();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtRes
            // 
            this.BtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRes.Location = new System.Drawing.Point(80, 44);
            this.BtRes.Name = "BtRes";
            this.BtRes.Size = new System.Drawing.Size(92, 41);
            this.BtRes.TabIndex = 0;
            this.BtRes.Text = "Resultado";
            this.BtRes.UseVisualStyleBackColor = true;
            this.BtRes.Click += new System.EventHandler(this.BtRes_Click);
            // 
            // TxtNum1
            // 
            this.TxtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum1.Location = new System.Drawing.Point(225, 51);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 26);
            this.TxtNum1.TabIndex = 1;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNum2.Location = new System.Drawing.Point(394, 51);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(100, 26);
            this.TxtNum2.TabIndex = 2;
            // 
            // TxtRes
            // 
            this.TxtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRes.Location = new System.Drawing.Point(527, 51);
            this.TxtRes.Name = "TxtRes";
            this.TxtRes.Size = new System.Drawing.Size(48, 26);
            this.TxtRes.TabIndex = 3;
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.TxtRes);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.BtRes);
            this.Name = "Suma";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRes;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtRes;
    }
}

