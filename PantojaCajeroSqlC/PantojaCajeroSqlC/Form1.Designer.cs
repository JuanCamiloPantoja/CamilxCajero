namespace PantojaCajeroSqlC
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtIniciarSesion = new System.Windows.Forms.Button();
            this.BtRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // BtIniciarSesion
            // 
            this.BtIniciarSesion.Location = new System.Drawing.Point(285, 79);
            this.BtIniciarSesion.Name = "BtIniciarSesion";
            this.BtIniciarSesion.Size = new System.Drawing.Size(217, 85);
            this.BtIniciarSesion.TabIndex = 1;
            this.BtIniciarSesion.Text = "Iniciar Sesión";
            this.BtIniciarSesion.UseVisualStyleBackColor = true;
            this.BtIniciarSesion.Click += new System.EventHandler(this.BtIniciarSesion_Click);
            // 
            // BtRegistrarse
            // 
            this.BtRegistrarse.Location = new System.Drawing.Point(285, 229);
            this.BtRegistrarse.Name = "BtRegistrarse";
            this.BtRegistrarse.Size = new System.Drawing.Size(217, 90);
            this.BtRegistrarse.TabIndex = 2;
            this.BtRegistrarse.Text = "Registrarse";
            this.BtRegistrarse.UseVisualStyleBackColor = true;
            this.BtRegistrarse.Click += new System.EventHandler(this.BtRegistrarse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtRegistrarse);
            this.Controls.Add(this.BtIniciarSesion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtIniciarSesion;
        private System.Windows.Forms.Button BtRegistrarse;
    }
}

