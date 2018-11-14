namespace ControlAulasVisual
{
    partial class AltaDeAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDeAula));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblClaveMaestro = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtClaveAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroAula = new System.Windows.Forms.Label();
            this.NUDNumeroAula = new System.Windows.Forms.NumericUpDown();
            this.CMBEdificio = new System.Windows.Forms.ComboBox();
            this.NUDCupo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumeroAula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(132, 153);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(86, 53);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(18, 153);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(86, 53);
            this.btnAlta.TabIndex = 30;
            this.btnAlta.Text = "Dar De Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(24, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(131, 20);
            this.txtDescripcion.TabIndex = 29;
            // 
            // lblClaveMaestro
            // 
            this.lblClaveMaestro.AutoSize = true;
            this.lblClaveMaestro.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveMaestro.Location = new System.Drawing.Point(21, 85);
            this.lblClaveMaestro.Name = "lblClaveMaestro";
            this.lblClaveMaestro.Size = new System.Drawing.Size(63, 13);
            this.lblClaveMaestro.TabIndex = 28;
            this.lblClaveMaestro.Text = "Descripción";
            this.lblClaveMaestro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Location = new System.Drawing.Point(21, 46);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(41, 13);
            this.lblDomicilio.TabIndex = 24;
            this.lblDomicilio.Text = "Edificio";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClaveAula
            // 
            this.txtClaveAula.Enabled = false;
            this.txtClaveAula.Location = new System.Drawing.Point(24, 23);
            this.txtClaveAula.Name = "txtClaveAula";
            this.txtClaveAula.Size = new System.Drawing.Size(55, 20);
            this.txtClaveAula.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Clave Aula";
            // 
            // NumeroAula
            // 
            this.NumeroAula.AutoSize = true;
            this.NumeroAula.BackColor = System.Drawing.Color.Transparent;
            this.NumeroAula.Location = new System.Drawing.Point(176, 46);
            this.NumeroAula.Name = "NumeroAula";
            this.NumeroAula.Size = new System.Drawing.Size(65, 13);
            this.NumeroAula.TabIndex = 32;
            this.NumeroAula.Text = "NumeroAula";
            this.NumeroAula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUDNumeroAula
            // 
            this.NUDNumeroAula.Location = new System.Drawing.Point(201, 61);
            this.NUDNumeroAula.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUDNumeroAula.Name = "NUDNumeroAula";
            this.NUDNumeroAula.Size = new System.Drawing.Size(17, 20);
            this.NUDNumeroAula.TabIndex = 34;
            this.NUDNumeroAula.ValueChanged += new System.EventHandler(this.NUDNumeroAula_ValueChanged);
            // 
            // CMBEdificio
            // 
            this.CMBEdificio.FormattingEnabled = true;
            this.CMBEdificio.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CMBEdificio.Location = new System.Drawing.Point(24, 61);
            this.CMBEdificio.Name = "CMBEdificio";
            this.CMBEdificio.Size = new System.Drawing.Size(121, 21);
            this.CMBEdificio.TabIndex = 35;
            this.CMBEdificio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.CMBEdificio.Click += new System.EventHandler(this.CMBEdificio_Click);
            // 
            // NUDCupo
            // 
            this.NUDCupo.Location = new System.Drawing.Point(180, 101);
            this.NUDCupo.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDCupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCupo.Name = "NUDCupo";
            this.NUDCupo.Size = new System.Drawing.Size(57, 20);
            this.NUDCupo.TabIndex = 36;
            this.NUDCupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(177, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cupo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(243, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 53);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // AltaDeAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(347, 221);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDCupo);
            this.Controls.Add(this.CMBEdificio);
            this.Controls.Add(this.NUDNumeroAula);
            this.Controls.Add(this.NumeroAula);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblClaveMaestro);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtClaveAula);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaDeAula";
            this.Text = "AltaDeAula";
            this.Load += new System.EventHandler(this.AltaDeAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumeroAula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblClaveMaestro;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtClaveAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumeroAula;
        private System.Windows.Forms.NumericUpDown NUDNumeroAula;
        private System.Windows.Forms.ComboBox CMBEdificio;
        private System.Windows.Forms.NumericUpDown NUDCupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}