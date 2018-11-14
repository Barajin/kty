using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAulasVisual
{
    public class Maestro
    {
        private string NombreMaestro;
        private string FormacionAcademica;
        private string Domicilio;

        public Maestro(string nombreMaestro, string formacionAcademica, string domicilio)
        {
            NombreMaestro = nombreMaestro;
            FormacionAcademica = formacionAcademica;
            Domicilio = domicilio;
        }

        public string pNombreMaestro
        {
            set
            {
                NombreMaestro = value;
            }
            get
            {
                return NombreMaestro;
            }
        }

        public string pFormacionAcademica
        {
            set
            {
                FormacionAcademica = value;
            }
            get
            {
                return FormacionAcademica;
            }
        }

        public string pDomicilio
        {
            set
            {
                Domicilio = value;
            }
            get
            {
                return Domicilio;
            }
        }
    }
}

