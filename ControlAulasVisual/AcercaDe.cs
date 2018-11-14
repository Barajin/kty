using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ControlAulasVisual
{
    public partial class AcercaDe : Form
    {
        SoundPlayer sonido;
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            sonido = new SoundPlayer(Application.StartupPath+@"\son\take.wav");
            sonido.Play();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            sonido.Stop();
            this.Close();
        }
    }
}
