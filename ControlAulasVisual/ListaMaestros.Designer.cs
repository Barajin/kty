namespace ControlAulasVisual
{
    partial class ListaMaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaMaestros));
            this.DGVvistaMaestros = new System.Windows.Forms.DataGridView();
            this.NombreMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormacionAcademica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVvistaMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVvistaMaestros
            // 
            this.DGVvistaMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVvistaMaestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMaestro,
            this.DomicilioMaestro,
            this.FormacionAcademica});
            this.DGVvistaMaestros.Location = new System.Drawing.Point(21, 29);
            this.DGVvistaMaestros.Name = "DGVvistaMaestros";
            this.DGVvistaMaestros.Size = new System.Drawing.Size(497, 150);
            this.DGVvistaMaestros.TabIndex = 0;
            this.DGVvistaMaestros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NombreMaestro
            // 
            this.NombreMaestro.HeaderText = "Nombre Maestro";
            this.NombreMaestro.Name = "NombreMaestro";
            // 
            // DomicilioMaestro
            // 
            this.DomicilioMaestro.HeaderText = "Domicilio Maestro";
            this.DomicilioMaestro.Name = "DomicilioMaestro";
            // 
            // FormacionAcademica
            // 
            this.FormacionAcademica.HeaderText = "Formación Académica";
            this.FormacionAcademica.Name = "FormacionAcademica";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(432, 196);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ListaMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(680, 377);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.DGVvistaMaestros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaMaestros";
            this.Text = "ListaMaestros";
            this.Load += new System.EventHandler(this.ListaMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVvistaMaestros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVvistaMaestros;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioMaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormacionAcademica;
    }
}