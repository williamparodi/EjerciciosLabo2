namespace Clase20Ejecicio101Avisame
{
    partial class FrmAvisador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_NombreCompleto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(370, 119);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(210, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(368, 203);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(212, 23);
            this.txt_Apellido.TabIndex = 1;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(228, 290);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(287, 48);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Crear";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(216, 119);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(217, 205);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(51, 15);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_NombreCompleto
            // 
            this.lbl_NombreCompleto.AutoSize = true;
            this.lbl_NombreCompleto.Location = new System.Drawing.Point(237, 389);
            this.lbl_NombreCompleto.Name = "lbl_NombreCompleto";
            this.lbl_NombreCompleto.Size = new System.Drawing.Size(38, 15);
            this.lbl_NombreCompleto.TabIndex = 5;
            this.lbl_NombreCompleto.Text = "label1";
            // 
            // FrmAvisador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_NombreCompleto);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_nombre);
            this.Name = "FrmAvisador";
            this.Text = "El Avisador ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_NombreCompleto;
    }
}
