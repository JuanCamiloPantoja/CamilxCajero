namespace PantojaCajeroSqlC
{
    partial class Registrar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreT = new System.Windows.Forms.TextBox();
            this.ApellidpT = new System.Windows.Forms.TextBox();
            this.EdadT = new System.Windows.Forms.TextBox();
            this.NumDocuT = new System.Windows.Forms.TextBox();
            this.ClaveT = new System.Windows.Forms.TextBox();
            this.TipDocu = new System.Windows.Forms.ComboBox();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo  de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de Documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Registrar PIN";
            // 
            // NombreT
            // 
            this.NombreT.Location = new System.Drawing.Point(339, 50);
            this.NombreT.Name = "NombreT";
            this.NombreT.Size = new System.Drawing.Size(204, 22);
            this.NombreT.TabIndex = 7;
            // 
            // ApellidpT
            // 
            this.ApellidpT.Location = new System.Drawing.Point(340, 97);
            this.ApellidpT.Name = "ApellidpT";
            this.ApellidpT.Size = new System.Drawing.Size(203, 22);
            this.ApellidpT.TabIndex = 8;
            // 
            // EdadT
            // 
            this.EdadT.Location = new System.Drawing.Point(340, 151);
            this.EdadT.Name = "EdadT";
            this.EdadT.Size = new System.Drawing.Size(203, 22);
            this.EdadT.TabIndex = 9;
            this.EdadT.TextChanged += new System.EventHandler(this.EdadT_TextChanged);
            // 
            // NumDocuT
            // 
            this.NumDocuT.Location = new System.Drawing.Point(341, 265);
            this.NumDocuT.Name = "NumDocuT";
            this.NumDocuT.Size = new System.Drawing.Size(202, 22);
            this.NumDocuT.TabIndex = 11;
            this.NumDocuT.TextChanged += new System.EventHandler(this.NumDocuT_TextChanged);
            // 
            // ClaveT
            // 
            this.ClaveT.Location = new System.Drawing.Point(340, 327);
            this.ClaveT.Name = "ClaveT";
            this.ClaveT.Size = new System.Drawing.Size(203, 22);
            this.ClaveT.TabIndex = 12;
            this.ClaveT.TextChanged += new System.EventHandler(this.ClaveT_TextChanged);
            // 
            // TipDocu
            // 
            this.TipDocu.FormattingEnabled = true;
            this.TipDocu.Items.AddRange(new object[] {
            "T.I",
            "C.C",
            "P.P",
            "C.E"});
            this.TipDocu.Location = new System.Drawing.Point(339, 211);
            this.TipDocu.Name = "TipDocu";
            this.TipDocu.Size = new System.Drawing.Size(200, 24);
            this.TipDocu.TabIndex = 13;
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(192, 371);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(148, 36);
            this.BtGuardar.TabIndex = 14;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(466, 371);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(148, 36);
            this.BtCancelar.TabIndex = 15;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.TipDocu);
            this.Controls.Add(this.ClaveT);
            this.Controls.Add(this.NumDocuT);
            this.Controls.Add(this.EdadT);
            this.Controls.Add(this.ApellidpT);
            this.Controls.Add(this.NombreT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreT;
        private System.Windows.Forms.TextBox ApellidpT;
        private System.Windows.Forms.TextBox EdadT;
        private System.Windows.Forms.TextBox NumDocuT;
        private System.Windows.Forms.TextBox ClaveT;
        private System.Windows.Forms.ComboBox TipDocu;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Button BtCancelar;
    }
}