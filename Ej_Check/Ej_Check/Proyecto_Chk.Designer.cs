namespace Ej_Check
{
    partial class Proyecto_Chk
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
            this.BtAceptar = new System.Windows.Forms.Button();
            this.chkHombre = new System.Windows.Forms.CheckBox();
            this.chkMujer = new System.Windows.Forms.CheckBox();
            this.BtSalir = new System.Windows.Forms.Button();
            this.lbRes = new System.Windows.Forms.Label();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtAceptar
            // 
            this.BtAceptar.Location = new System.Drawing.Point(52, 194);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtAceptar.TabIndex = 0;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // chkHombre
            // 
            this.chkHombre.AutoSize = true;
            this.chkHombre.Location = new System.Drawing.Point(52, 76);
            this.chkHombre.Name = "chkHombre";
            this.chkHombre.Size = new System.Drawing.Size(63, 17);
            this.chkHombre.TabIndex = 1;
            this.chkHombre.Text = "Hombre";
            this.chkHombre.UseVisualStyleBackColor = true;
            // 
            // chkMujer
            // 
            this.chkMujer.AutoSize = true;
            this.chkMujer.Location = new System.Drawing.Point(52, 113);
            this.chkMujer.Name = "chkMujer";
            this.chkMujer.Size = new System.Drawing.Size(52, 17);
            this.chkMujer.TabIndex = 2;
            this.chkMujer.Text = "Mujer";
            this.chkMujer.UseVisualStyleBackColor = true;
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(52, 223);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(205, 23);
            this.BtSalir.TabIndex = 3;
            this.BtSalir.Text = "Cerrar programa";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(49, 158);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 13);
            this.lbRes.TabIndex = 4;
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(133, 194);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(124, 23);
            this.BtLimpiar.TabIndex = 5;
            this.BtLimpiar.Text = "Limpiar resultado";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // Proyecto_Chk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 356);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.chkMujer);
            this.Controls.Add(this.chkHombre);
            this.Controls.Add(this.BtAceptar);
            this.Name = "Proyecto_Chk";
            this.Text = "Ejemplo Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.CheckBox chkHombre;
        private System.Windows.Forms.CheckBox chkMujer;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.Button BtLimpiar;
    }
}

