namespace PantojaCajeroSqlC
{
    partial class InicioSesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioT = new System.Windows.Forms.TextBox();
            this.ContraseñaT = new System.Windows.Forms.TextBox();
            this.BtIngresar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // UsuarioT
            // 
            this.UsuarioT.Location = new System.Drawing.Point(343, 125);
            this.UsuarioT.Name = "UsuarioT";
            this.UsuarioT.Size = new System.Drawing.Size(210, 22);
            this.UsuarioT.TabIndex = 2;
            this.UsuarioT.TextChanged += new System.EventHandler(this.UsuarioT_TextChanged);
            // 
            // ContraseñaT
            // 
            this.ContraseñaT.Location = new System.Drawing.Point(343, 208);
            this.ContraseñaT.Name = "ContraseñaT";
            this.ContraseñaT.Size = new System.Drawing.Size(210, 22);
            this.ContraseñaT.TabIndex = 3;
            this.ContraseñaT.TextChanged += new System.EventHandler(this.ContraseñaT_TextChanged);
            // 
            // BtIngresar
            // 
            this.BtIngresar.Location = new System.Drawing.Point(149, 300);
            this.BtIngresar.Name = "BtIngresar";
            this.BtIngresar.Size = new System.Drawing.Size(155, 40);
            this.BtIngresar.TabIndex = 4;
            this.BtIngresar.Text = "Ingresar";
            this.BtIngresar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(438, 300);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(155, 40);
            this.BtCancelar.TabIndex = 5;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtIngresar);
            this.Controls.Add(this.ContraseñaT);
            this.Controls.Add(this.UsuarioT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioT;
        private System.Windows.Forms.TextBox ContraseñaT;
        private System.Windows.Forms.Button BtIngresar;
        private System.Windows.Forms.Button BtCancelar;
    }
}