namespace ControlAulasVisual
{
    partial class BajaAsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaAsignacion));
            this.DGVBorrar = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.BTNBorrar = new System.Windows.Forms.Button();
            this.ClaveAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBorrar
            // 
            this.DGVBorrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBorrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveAula});
            this.DGVBorrar.Location = new System.Drawing.Point(12, 12);
            this.DGVBorrar.Name = "DGVBorrar";
            this.DGVBorrar.Size = new System.Drawing.Size(145, 150);
            this.DGVBorrar.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(128, 183);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 32;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // BTNBorrar
            // 
            this.BTNBorrar.Location = new System.Drawing.Point(36, 183);
            this.BTNBorrar.Name = "BTNBorrar";
            this.BTNBorrar.Size = new System.Drawing.Size(86, 53);
            this.BTNBorrar.TabIndex = 31;
            this.BTNBorrar.Text = "Borrar";
            this.BTNBorrar.UseVisualStyleBackColor = true;
            this.BTNBorrar.Click += new System.EventHandler(this.BTNBorrar_Click);
            // 
            // ClaveAula
            // 
            this.ClaveAula.HeaderText = "Clave Aula";
            this.ClaveAula.Name = "ClaveAula";
            // 
            // BajaAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(270, 260);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.BTNBorrar);
            this.Controls.Add(this.DGVBorrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BajaAsignacion";
            this.Text = "Baja de aulas no asignadas";
            this.Load += new System.EventHandler(this.BajaAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBorrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBorrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button BTNBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveAula;
    }
}