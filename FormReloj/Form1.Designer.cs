namespace FormReloj
{
    partial class FrmPrincipalReloj
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
            this.btnAcutalizar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcutalizar
            // 
            this.btnAcutalizar.Location = new System.Drawing.Point(151, 175);
            this.btnAcutalizar.Name = "btnAcutalizar";
            this.btnAcutalizar.Size = new System.Drawing.Size(453, 102);
            this.btnAcutalizar.TabIndex = 0;
            this.btnAcutalizar.Text = "button1";
            this.btnAcutalizar.UseVisualStyleBackColor = true;
            this.btnAcutalizar.Click += new System.EventHandler(this.btnAcutalizar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(297, 86);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "label1";
            // 
            // FrmPrincipalReloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAcutalizar);
            this.Name = "FrmPrincipalReloj";
            this.Text = "Reloj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipalReloj_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipalReloj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcutalizar;
        private System.Windows.Forms.Label lbl;
    }
}
