using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    public class Equipo
    {
        int idEquipo;
        string nombreEquipo;
        TipoEquipo tipoEquipo;

        public Equipo(int idEquipo,string nombreEquipo, TipoEquipo tipoEquipo)
        {
            this.idEquipo = idEquipo;
            this.nombreEquipo = nombreEquipo;
            this.tipoEquipo = tipoEquipo;
        }


        public Equipo()
        {
            
        }


        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }

        public int Id { get => idEquipo; set => idEquipo = value; }

        public TipoEquipo TipoEquipo { get => tipoEquipo; set => tipoEquipo = value; }


        public string NombreCompleto
        {
            get
            {
                return nombreEquipo;
            }
        }

        public string NombreTipoEquipo
        {
            get
            {
                return tipoEquipo.ToString();
            }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }


    }
}
