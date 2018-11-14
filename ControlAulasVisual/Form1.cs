using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAulasVisual
{
    public partial class Form1 : Form
    {
        List<Materia> ListaMaterias = new List<Materia>();
        List<Aula> ListaAulas = new List<Aula>();
        Dictionary<int, Maestro> Dicmaestros= new Dictionary<int, Maestro>();
        public Form1(List<Aula> ListaAulass, Dictionary<int, Maestro> Dicmaestross)
        {
            InitializeComponent();
           ListaAulas=ListaAulass;
        }

        private void impresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignarAulasAMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDeAula frmAltaAula = new AltaDeAula();
            frmAltaAula.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modificacionDeAsignaciónDeAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificaciones frmModi = new Modificaciones();
            frmModi.ShowDialog();
        }

        private void bajasDeAulasNoAsiganadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaAsignacion frmBaja = new BajaAsignacion();
            frmBaja.ShowDialog();
        }

        private void asignarAulasAMaestrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AsignarAula frmAsignarAula = new AsignarAula();
            frmAsignarAula.ShowDialog();
        }

        private void altaDeMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMaestro frmAltaMaestro = new AltaMaestro();
            frmAltaMaestro.ShowDialog();
        }

        private void consultaDeMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMaestros frmListaMaestros = new ListaMaestros();
            frmListaMaestros.ShowDialog();
        }

        private void consultaDeHorarioPorMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPorMaestro frmConsultaPorMaestro = new ConsultaPorMaestro();
            frmConsultaPorMaestro.ShowDialog();
        }

        private void consultaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaGeneralMaestro frmConsultaMaestro = new ConsultaGeneralMaestro();
            frmConsultaMaestro.ShowDialog();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe frmAcerca = new AcercaDe();
            frmAcerca.ShowDialog();
        }
    }
}
