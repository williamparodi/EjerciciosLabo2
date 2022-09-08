namespace Vistas
{
    partial class FrmSaludar
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.cboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.Location = new System.Drawing.Point(0, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(100, 23);
            this.lblSaludo.TabIndex = 0;
            // 
            // cboBox
            // 
            this.cboBox.FormattingEnabled = true;
            this.cboBox.Location = new System.Drawing.Point(352, 146);
            this.cboBox.Name = "cboBox";
            this.cboBox.Size = new System.Drawing.Size(121, 23);
            this.cboBox.TabIndex = 0;
            // 
            // FrmSaludar
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 365);
            this.Controls.Add(this.cboBox);
            this.Name = "FrmSaludar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboBox;
    }
}