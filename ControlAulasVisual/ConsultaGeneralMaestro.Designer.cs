namespace ControlAulasVisual
{
    partial class ConsultaGeneralMaestro
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaGeneralMaestro));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetConjunto = new ControlAulasVisual.DataSetConjunto();
            this.dataSetConjuntoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConjunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConjuntoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(591, 195);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataSetConjuntoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControlAulasVisual.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(560, 288);
            this.reportViewer1.TabIndex = 32;
            // 
            // dataSetConjunto
            // 
            this.dataSetConjunto.DataSetName = "DataSetConjunto";
            this.dataSetConjunto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetConjuntoBindingSource
            // 
            this.dataSetConjuntoBindingSource.DataSource = this.dataSetConjunto;
            this.dataSetConjuntoBindingSource.Position = 0;
            // 
            // ConsultaGeneralMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(689, 334);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnRegresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaGeneralMaestro";
            this.Text = "ConsultaGeneralMaestro";
            this.Load += new System.EventHandler(this.ConsultaGeneralMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConjunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConjuntoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetConjuntoBindingSource;
        private DataSetConjunto dataSetConjunto;
    }
}