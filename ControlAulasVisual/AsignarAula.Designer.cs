namespace ControlAulasVisual
{
    partial class AsignarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarAula));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblClaveMaestro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClaveMaestro = new System.Windows.Forms.ComboBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUDHora = new System.Windows.Forms.NumericUpDown();
            this.CMBClaveAula = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(126, 216);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 30;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(34, 216);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(86, 53);
            this.btnAlta.TabIndex = 29;
            this.btnAlta.Text = "Asignar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblClaveMaestro
            // 
            this.lblClaveMaestro.AutoSize = true;
            this.lblClaveMaestro.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveMaestro.Location = new System.Drawing.Point(9, 109);
            this.lblClaveMaestro.Name = "lblClaveMaestro";
            this.lblClaveMaestro.Size = new System.Drawing.Size(118, 13);
            this.lblClaveMaestro.TabIndex = 27;
            this.lblClaveMaestro.Text = "Hora(Formato 24 horas)";
            this.lblClaveMaestro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Clave de Maestro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbClaveMaestro
            // 
            this.cmbClaveMaestro.FormattingEnabled = true;
            this.cmbClaveMaestro.Location = new System.Drawing.Point(12, 79);
            this.cmbClaveMaestro.Name = "cmbClaveMaestro";
            this.cmbClaveMaestro.Size = new System.Drawing.Size(131, 21);
            this.cmbClaveMaestro.TabIndex = 25;
            this.cmbClaveMaestro.SelectedIndexChanged += new System.EventHandler(this.cmbClaveMaestro_SelectedIndexChanged);
            // 
            // txtMateria
            // 
            this.txtMateria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMateria.Location = new System.Drawing.Point(12, 26);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(131, 20);
            this.txtMateria.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Materia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NUDHora
            // 
            this.NUDHora.Location = new System.Drawing.Point(12, 125);
            this.NUDHora.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDHora.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NUDHora.Name = "NUDHora";
            this.NUDHora.Size = new System.Drawing.Size(61, 20);
            this.NUDHora.TabIndex = 32;
            this.NUDHora.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // CMBClaveAula
            // 
            this.CMBClaveAula.FormattingEnabled = true;
            this.CMBClaveAula.Location = new System.Drawing.Point(12, 169);
            this.CMBClaveAula.Name = "CMBClaveAula";
            this.CMBClaveAula.Size = new System.Drawing.Size(131, 21);
            this.CMBClaveAula.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Clave del aula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AsignarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(245, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMBClaveAula);
            this.Controls.Add(this.NUDHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblClaveMaestro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClaveMaestro);
            this.Controls.Add(this.txtMateria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsignarAula";
            this.Text = "AsignarAula";
            this.Load += new System.EventHandler(this.AsignarAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label lblClaveMaestro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClaveMaestro;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDHora;
        private System.Windows.Forms.ComboBox CMBClaveAula;
        private System.Windows.Forms.Label label3;
    }
}