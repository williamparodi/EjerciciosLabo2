namespace Vistas
{
    partial class FrmRegistro
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
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonNoBinario = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.grpBoxCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxJs = new System.Windows.Forms.CheckBox();
            this.checkBoxCPlus = new System.Windows.Forms.CheckBox();
            this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.grpBoxGenero.SuspendLayout();
            this.grpBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.numericUpDownEdad);
            this.grpBox.Controls.Add(this.lblEdad);
            this.grpBox.Controls.Add(this.lblDireccion);
            this.grpBox.Controls.Add(this.lblNombre);
            this.grpBox.Controls.Add(this.txtDireccion);
            this.grpBox.Controls.Add(this.txtNombre);
            this.grpBox.Location = new System.Drawing.Point(38, 30);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(240, 182);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Detalles del usuario";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(99, 131);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(102, 23);
            this.numericUpDownEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(28, 131);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(28, 82);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(101, 80);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // grpBoxGenero
            // 
            this.grpBoxGenero.Controls.Add(this.radioButtonNoBinario);
            this.grpBoxGenero.Controls.Add(this.radioButtonFemenino);
            this.grpBoxGenero.Controls.Add(this.radioButtonMasculino);
            this.grpBoxGenero.Location = new System.Drawing.Point(463, 33);
            this.grpBoxGenero.Name = "grpBoxGenero";
            this.grpBoxGenero.Size = new System.Drawing.Size(200, 143);
            this.grpBoxGenero.TabIndex = 1;
            this.grpBoxGenero.TabStop = false;
            this.grpBoxGenero.Text = "Género";
            // 
            // radioButtonNoBinario
            // 
            this.radioButtonNoBinario.AutoSize = true;
            this.radioButtonNoBinario.Location = new System.Drawing.Point(21, 104);
            this.radioButtonNoBinario.Name = "radioButtonNoBinario";
            this.radioButtonNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radioButtonNoBinario.TabIndex = 2;
            this.radioButtonNoBinario.TabStop = true;
            this.radioButtonNoBinario.Text = "No Binario";
            this.radioButtonNoBinario.UseVisualStyleBackColor = true;
            this.radioButtonNoBinario.CheckedChanged += new System.EventHandler(this.radioButtonNoBinario_CheckedChanged);
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(21, 63);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(78, 19);
            this.radioButtonFemenino.TabIndex = 1;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            this.radioButtonFemenino.CheckedChanged += new System.EventHandler(this.radioButtonFemenino_CheckedChanged);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(21, 26);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButtonMasculino_CheckedChanged);
            // 
            // grpBoxCursos
            // 
            this.grpBoxCursos.Controls.Add(this.checkBoxJs);
            this.grpBoxCursos.Controls.Add(this.checkBoxCPlus);
            this.grpBoxCursos.Controls.Add(this.checkBoxCSharp);
            this.grpBoxCursos.Location = new System.Drawing.Point(464, 241);
            this.grpBoxCursos.Name = "grpBoxCursos";
            this.grpBoxCursos.Size = new System.Drawing.Size(200, 100);
            this.grpBoxCursos.TabIndex = 2;
            this.grpBoxCursos.TabStop = false;
            this.grpBoxCursos.Text = "Cursos";
            // 
            // checkBoxJs
            // 
            this.checkBoxJs.AutoSize = true;
            this.checkBoxJs.Location = new System.Drawing.Point(10, 77);
            this.checkBoxJs.Name = "checkBoxJs";
            this.checkBoxJs.Size = new System.Drawing.Size(78, 19);
            this.checkBoxJs.TabIndex = 2;
            this.checkBoxJs.Text = "JavaScript";
            this.checkBoxJs.UseVisualStyleBackColor = true;
            this.checkBoxJs.CheckedChanged += new System.EventHandler(this.checkBoxJs_CheckedChanged);
            // 
            // checkBoxCPlus
            // 
            this.checkBoxCPlus.AutoSize = true;
            this.checkBoxCPlus.Location = new System.Drawing.Point(10, 49);
            this.checkBoxCPlus.Name = "checkBoxCPlus";
            this.checkBoxCPlus.Size = new System.Drawing.Size(50, 19);
            this.checkBoxCPlus.TabIndex = 1;
            this.checkBoxCPlus.Text = "C++";
            this.checkBoxCPlus.UseVisualStyleBackColor = true;
            this.checkBoxCPlus.CheckedChanged += new System.EventHandler(this.checkBoxCPlus_CheckedChanged);
            // 
            // checkBoxCSharp
            // 
            this.checkBoxCSharp.AutoSize = true;
            this.checkBoxCSharp.Location = new System.Drawing.Point(10, 24);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(41, 19);
            this.checkBoxCSharp.TabIndex = 0;
            this.checkBoxCSharp.Text = "C#";
            this.checkBoxCSharp.UseVisualStyleBackColor = true;
            this.checkBoxCSharp.CheckedChanged += new System.EventHandler(this.checkBoxCSharp_CheckedChanged);
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 15;
            this.listBoxPaises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPaises.Location = new System.Drawing.Point(38, 252);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(240, 124);
            this.listBoxPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(38, 225);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(548, 380);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listBoxPaises);
            this.Controls.Add(this.grpBoxCursos);
            this.Controls.Add(this.grpBoxGenero);
            this.Controls.Add(this.grpBox);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.grpBoxGenero.ResumeLayout(false);
            this.grpBoxGenero.PerformLayout();
            this.grpBoxCursos.ResumeLayout(false);
            this.grpBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpBoxGenero;
        private System.Windows.Forms.RadioButton radioButtonNoBinario;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.GroupBox grpBoxCursos;
        private System.Windows.Forms.CheckBox checkBoxJs;
        private System.Windows.Forms.CheckBox checkBoxCPlus;
        private System.Windows.Forms.CheckBox checkBoxCSharp;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}