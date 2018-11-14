namespace ControlAulasVisual
{
    partial class ConsultaPorMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPorMaestro));
            this.DGVConsultaXMaestro = new System.Windows.Forms.DataGridView();
            this.NombreMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNombreMaestro = new System.Windows.Forms.ComboBox();
            this.lblNombreMaestro = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultaXMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVConsultaXMaestro
            // 
            this.DGVConsultaXMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsultaXMaestro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMaestro,
            this.Aula,
            this.Materia});
            this.DGVConsultaXMaestro.Location = new System.Drawing.Point(12, 59);
            this.DGVConsultaXMaestro.Name = "DGVConsultaXMaestro";
            this.DGVConsultaXMaestro.Size = new System.Drawing.Size(586, 173);
            this.DGVConsultaXMaestro.TabIndex = 0;
            // 
            // NombreMaestro
            // 
            this.NombreMaestro.HeaderText = "Nombre Del Maestro";
            this.NombreMaestro.Name = "NombreMaestro";
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // cmbNombreMaestro
            // 
            this.cmbNombreMaestro.FormattingEnabled = true;
            this.cmbNombreMaestro.Location = new System.Drawing.Point(12, 32);
            this.cmbNombreMaestro.Name = "cmbNombreMaestro";
            this.cmbNombreMaestro.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreMaestro.TabIndex = 1;
            this.cmbNombreMaestro.SelectedIndexChanged += new System.EventHandler(this.cmbNombreMaestro_SelectedIndexChanged);
            // 
            // lblNombreMaestro
            // 
            this.lblNombreMaestro.AutoSize = true;
            this.lblNombreMaestro.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreMaestro.Location = new System.Drawing.Point(12, 16);
            this.lblNombreMaestro.Name = "lblNombreMaestro";
            this.lblNombreMaestro.Size = new System.Drawing.Size(75, 13);
            this.lblNombreMaestro.TabIndex = 2;
            this.lblNombreMaestro.Text = "Clave Maestro";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(468, 244);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ConsultaPorMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(610, 309);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblNombreMaestro);
            this.Controls.Add(this.cmbNombreMaestro);
            this.Controls.Add(this.DGVConsultaXMaestro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaPorMaestro";
            this.Text = "ConsultaPorMaestro";
            this.Load += new System.EventHandler(this.ConsultaPorMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultaXMaestro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVConsultaXMaestro;
        private System.Windows.Forms.ComboBox cmbNombreMaestro;
        private System.Windows.Forms.Label lblNombreMaestro;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
    }
}