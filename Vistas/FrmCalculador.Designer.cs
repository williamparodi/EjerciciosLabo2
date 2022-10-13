namespace Vistas
{
    partial class FrmCalculador
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
            this.lbl_Kilometros = new System.Windows.Forms.Label();
            this.lbl_Litros = new System.Windows.Forms.Label();
            this.txt_Kilometros = new System.Windows.Forms.TextBox();
            this.txt_Litros = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rtx_Texto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_Kilometros
            // 
            this.lbl_Kilometros.AutoSize = true;
            this.lbl_Kilometros.Location = new System.Drawing.Point(79, 52);
            this.lbl_Kilometros.Name = "lbl_Kilometros";
            this.lbl_Kilometros.Size = new System.Drawing.Size(64, 15);
            this.lbl_Kilometros.TabIndex = 0;
            this.lbl_Kilometros.Text = "Kilometros";
            // 
            // lbl_Litros
            // 
            this.lbl_Litros.AutoSize = true;
            this.lbl_Litros.Location = new System.Drawing.Point(79, 135);
            this.lbl_Litros.Name = "lbl_Litros";
            this.lbl_Litros.Size = new System.Drawing.Size(39, 15);
            this.lbl_Litros.TabIndex = 1;
            this.lbl_Litros.Text = "Litros ";
            // 
            // txt_Kilometros
            // 
            this.txt_Kilometros.Location = new System.Drawing.Point(83, 75);
            this.txt_Kilometros.Name = "txt_Kilometros";
            this.txt_Kilometros.Size = new System.Drawing.Size(100, 23);
            this.txt_Kilometros.TabIndex = 2;
            // 
            // txt_Litros
            // 
            this.txt_Litros.Location = new System.Drawing.Point(83, 167);
            this.txt_Litros.Name = "txt_Litros";
            this.txt_Litros.Size = new System.Drawing.Size(100, 23);
            this.txt_Litros.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(79, 269);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(104, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rtx_Texto
            // 
            this.rtx_Texto.Location = new System.Drawing.Point(431, 52);
            this.rtx_Texto.Name = "rtx_Texto";
            this.rtx_Texto.Size = new System.Drawing.Size(270, 291);
            this.rtx_Texto.TabIndex = 5;
            this.rtx_Texto.Text = "";
            // 
            // FrmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtx_Texto);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Litros);
            this.Controls.Add(this.txt_Kilometros);
            this.Controls.Add(this.lbl_Litros);
            this.Controls.Add(this.lbl_Kilometros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kilometros;
        private System.Windows.Forms.Label lbl_Litros;
        private System.Windows.Forms.TextBox txt_Kilometros;
        private System.Windows.Forms.TextBox txt_Litros;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RichTextBox rtx_Texto;
    }
}