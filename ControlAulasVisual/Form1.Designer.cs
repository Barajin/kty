namespace ControlAulasVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAulasAMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasDeAulasNoAsiganadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAulasAMaestrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeMaestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeHorarioPorMaestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aulasToolStripMenuItem,
            this.maestrosToolStripMenuItem,
            this.impresiónToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarAulasAMaestrosToolStripMenuItem,
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem,
            this.bajasDeAulasNoAsiganadasToolStripMenuItem,
            this.asignarAulasAMaestrosToolStripMenuItem1});
            this.aulasToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.classroom;
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aulasToolStripMenuItem.Text = "Aulas";
            this.aulasToolStripMenuItem.Click += new System.EventHandler(this.aulasToolStripMenuItem_Click);
            // 
            // asignarAulasAMaestrosToolStripMenuItem
            // 
            this.asignarAulasAMaestrosToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.plus;
            this.asignarAulasAMaestrosToolStripMenuItem.Name = "asignarAulasAMaestrosToolStripMenuItem";
            this.asignarAulasAMaestrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.asignarAulasAMaestrosToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.asignarAulasAMaestrosToolStripMenuItem.Text = "Alta de Aulas";
            this.asignarAulasAMaestrosToolStripMenuItem.Click += new System.EventHandler(this.asignarAulasAMaestrosToolStripMenuItem_Click);
            // 
            // modificacionDeAsignaciónDeAulasToolStripMenuItem
            // 
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.edit;
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem.Name = "modificacionDeAsignaciónDeAulasToolStripMenuItem";
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem.Text = "Modificacion de asignación de aulas";
            this.modificacionDeAsignaciónDeAulasToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeAsignaciónDeAulasToolStripMenuItem_Click);
            // 
            // bajasDeAulasNoAsiganadasToolStripMenuItem
            // 
            this.bajasDeAulasNoAsiganadasToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.minus_symbol_inside_a_circle_1_;
            this.bajasDeAulasNoAsiganadasToolStripMenuItem.Name = "bajasDeAulasNoAsiganadasToolStripMenuItem";
            this.bajasDeAulasNoAsiganadasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bajasDeAulasNoAsiganadasToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.bajasDeAulasNoAsiganadasToolStripMenuItem.Text = "Bajas de aulas no asiganadas";
            this.bajasDeAulasNoAsiganadasToolStripMenuItem.Click += new System.EventHandler(this.bajasDeAulasNoAsiganadasToolStripMenuItem_Click);
            // 
            // asignarAulasAMaestrosToolStripMenuItem1
            // 
            this.asignarAulasAMaestrosToolStripMenuItem1.Image = global::ControlAulasVisual.Properties.Resources.teacher_at_the_blackboard;
            this.asignarAulasAMaestrosToolStripMenuItem1.Name = "asignarAulasAMaestrosToolStripMenuItem1";
            this.asignarAulasAMaestrosToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.asignarAulasAMaestrosToolStripMenuItem1.Size = new System.Drawing.Size(311, 22);
            this.asignarAulasAMaestrosToolStripMenuItem1.Text = "Asignar Aulas a Maestros";
            this.asignarAulasAMaestrosToolStripMenuItem1.Click += new System.EventHandler(this.asignarAulasAMaestrosToolStripMenuItem1_Click);
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeMaestrosToolStripMenuItem,
            this.consultaDeMaestrosToolStripMenuItem});
            this.maestrosToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.teacher_at_the_blackboard1;
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.maestrosToolStripMenuItem.Text = "Maestros";
            // 
            // altaDeMaestrosToolStripMenuItem
            // 
            this.altaDeMaestrosToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.plus;
            this.altaDeMaestrosToolStripMenuItem.Name = "altaDeMaestrosToolStripMenuItem";
            this.altaDeMaestrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.altaDeMaestrosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.altaDeMaestrosToolStripMenuItem.Text = "Alta de maestros";
            this.altaDeMaestrosToolStripMenuItem.Click += new System.EventHandler(this.altaDeMaestrosToolStripMenuItem_Click);
            // 
            // consultaDeMaestrosToolStripMenuItem
            // 
            this.consultaDeMaestrosToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.male_job_search_symbol;
            this.consultaDeMaestrosToolStripMenuItem.Name = "consultaDeMaestrosToolStripMenuItem";
            this.consultaDeMaestrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.consultaDeMaestrosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.consultaDeMaestrosToolStripMenuItem.Text = "Consulta de maestros";
            this.consultaDeMaestrosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeMaestrosToolStripMenuItem_Click);
            // 
            // impresiónToolStripMenuItem
            // 
            this.impresiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeHorarioPorMaestroToolStripMenuItem,
            this.consultaGeneralToolStripMenuItem});
            this.impresiónToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.male_job_search_symbol;
            this.impresiónToolStripMenuItem.Name = "impresiónToolStripMenuItem";
            this.impresiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.impresiónToolStripMenuItem.Text = "Consultas";
            this.impresiónToolStripMenuItem.Click += new System.EventHandler(this.impresiónToolStripMenuItem_Click);
            // 
            // consultaDeHorarioPorMaestroToolStripMenuItem
            // 
            this.consultaDeHorarioPorMaestroToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.teacher_at_the_blackboard;
            this.consultaDeHorarioPorMaestroToolStripMenuItem.Name = "consultaDeHorarioPorMaestroToolStripMenuItem";
            this.consultaDeHorarioPorMaestroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.consultaDeHorarioPorMaestroToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.consultaDeHorarioPorMaestroToolStripMenuItem.Text = "Consulta de horario por maestro";
            this.consultaDeHorarioPorMaestroToolStripMenuItem.Click += new System.EventHandler(this.consultaDeHorarioPorMaestroToolStripMenuItem_Click);
            // 
            // consultaGeneralToolStripMenuItem
            // 
            this.consultaGeneralToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.magnifier;
            this.consultaGeneralToolStripMenuItem.Name = "consultaGeneralToolStripMenuItem";
            this.consultaGeneralToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.consultaGeneralToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.consultaGeneralToolStripMenuItem.Text = "Consulta general";
            this.consultaGeneralToolStripMenuItem.Click += new System.EventHandler(this.consultaGeneralToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.information_button;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ControlAulasVisual.Properties.Resources.icon;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ControlAulasVisual.Properties.Resources.school;
            this.pictureBox1.Location = new System.Drawing.Point(37, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control de Aulas ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::ControlAulasVisual.Properties.Resources.AdminSchoolSoftwareEducativo;
            this.pictureBox2.Location = new System.Drawing.Point(272, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlAulasVisual.Properties.Resources._770x335_school_choice;
            this.ClientSize = new System.Drawing.Size(551, 375);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Control de aulas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAulasAMaestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeAsignaciónDeAulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasDeAulasNoAsiganadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeMaestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeMaestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeHorarioPorMaestroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAulasAMaestrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

