namespace ControlAulasVisual
{
    partial class Modificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modificaciones));
            this.lblClaveMaestro = new System.Windows.Forms.Label();
            this.lblClavedeAula = new System.Windows.Forms.Label();
            this.CMBClaveAula = new System.Windows.Forms.ComboBox();
            this.CMBClaveMaestro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveMaestro
            // 
            this.lblClaveMaestro.AutoSize = true;
            this.lblClaveMaestro.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveMaestro.Location = new System.Drawing.Point(12, 68);
            this.lblClaveMaestro.Name = "lblClaveMaestro";
            this.lblClaveMaestro.Size = new System.Drawing.Size(91, 13);
            this.lblClaveMaestro.TabIndex = 15;
            this.lblClaveMaestro.Text = "Clave del maestro";
            this.lblClaveMaestro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClaveMaestro.Click += new System.EventHandler(this.lblClaveMaestro_Click);
            // 
            // lblClavedeAula
            // 
            this.lblClavedeAula.AutoSize = true;
            this.lblClavedeAula.BackColor = System.Drawing.Color.Transparent;
            this.lblClavedeAula.Location = new System.Drawing.Point(12, 9);
            this.lblClavedeAula.Name = "lblClavedeAula";
            this.lblClavedeAula.Size = new System.Drawing.Size(73, 13);
            this.lblClavedeAula.TabIndex = 14;
            this.lblClavedeAula.Text = "Clave de Aula";
            this.lblClavedeAula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CMBClaveAula
            // 
            this.CMBClaveAula.FormattingEnabled = true;
            this.CMBClaveAula.Location = new System.Drawing.Point(12, 34);
            this.CMBClaveAula.Name = "CMBClaveAula";
            this.CMBClaveAula.Size = new System.Drawing.Size(131, 21);
            this.CMBClaveAula.TabIndex = 13;
            this.CMBClaveAula.SelectedIndexChanged += new System.EventHandler(this.CMBClaveAula_SelectedIndexChanged);
            // 
            // CMBClaveMaestro
            // 
            this.CMBClaveMaestro.FormattingEnabled = true;
            this.CMBClaveMaestro.Location = new System.Drawing.Point(15, 94);
            this.CMBClaveMaestro.Name = "CMBClaveMaestro";
            this.CMBClaveMaestro.Size = new System.Drawing.Size(131, 21);
            this.CMBClaveMaestro.TabIndex = 18;
            this.CMBClaveMaestro.SelectedIndexChanged += new System.EventHandler(this.CMBClaveMaestro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Horario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(34, 198);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 53);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(140, 198);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 158);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Modificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBClaveMaestro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblClaveMaestro);
            this.Controls.Add(this.lblClavedeAula);
            this.Controls.Add(this.CMBClaveAula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificaciones";
            this.Text = "Modificaciones";
            this.Load += new System.EventHandler(this.Modificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClaveMaestro;
        private System.Windows.Forms.Label lblClavedeAula;
        private System.Windows.Forms.ComboBox CMBClaveAula;
        private System.Windows.Forms.ComboBox CMBClaveMaestro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}