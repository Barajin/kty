using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAulasVisual
{
    public class Aula
    {
        
            private string ClaveAula;
            private string Descripcion;
            private char Edificio;
            private int Cupo;
        private bool Asignada;

            public Aula(string claveAula, string descripcion, char edificio, int cupo,bool asignada)
            {
                ClaveAula = claveAula;
                Cupo = cupo;
                Descripcion = descripcion;
                Edificio = edificio;
                Asignada = asignada;
            }
            public int pCupo
            {
                set
                {
                    Cupo = value;
                }
                get
                {
                    return Cupo;
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
            public string pDescripcion
            {
                set
                {
                    Descripcion = value;
                }
                get
                {
                    return Descripcion;
                }
            }
            public char pEdificio
            {
                set
                {
                    Edificio = value;
                }
                get
                {
                    return Edificio;
                }
            }
        public bool pAsignada
        {
            set
            {
                Asignada = value;
            }
            get
            {
                return Asignada;
            }

        }
    }
}
