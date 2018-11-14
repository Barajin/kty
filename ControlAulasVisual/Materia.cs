using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAulasVisual
{
    public class Materia
    {
        private string NombreMateria;
        private int ClvMaestro;
        private string ClaveAula;
        private int Horario;
     

        public Materia(string nombreMateria, int clvMaestro, string clvAula, int horario)
        {
            NombreMateria = nombreMateria;
            ClvMaestro = clvMaestro;
            ClaveAula = clvAula;
            Horario = horario;
            

        }
        public int pHorario
        {
            set
            {
                Horario = value;
            }
            get
            {
                return Horario;
            }

        }
        public string pNombreMateria
        {
            set
            {
                NombreMateria = value;
            }
            get
            {
                return NombreMateria;
            }
        }

        public int pClvMaestro
        {
            set
            {
                ClvMaestro = value;
            }
            get
            {
                return ClvMaestro;
            }
        }

        public string pClaveAula
        {
            set
            {
                ClaveAula = value;
            }
            get
            {
                return ClaveAula;
            }
        }
     
    }
}
