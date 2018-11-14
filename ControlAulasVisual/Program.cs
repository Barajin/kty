using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAulasVisual
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Aula> ListaAulas = new List<Aula>();
            Dictionary<int, Maestro> Dicmaestros = new Dictionary<int, Maestro>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(ListaAulas,Dicmaestros));
        }
    }
}
