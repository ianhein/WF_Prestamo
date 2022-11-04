using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    class Equipo
    {
        int idEquipo;
        string nombre;
        List<TipoEquipo> tipoEquipos;

        public Equipo(int idEquipo, string nombre, List<TipoEquipo> tipoEquipos)
        {
            this.idEquipo = idEquipo;
            this.nombre = nombre;
            this.tipoEquipos = tipoEquipos;
            
        }

        public Equipo()
        {
            
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public int Id { get => idEquipo; set => idEquipo = value; }

        internal List<TipoEquipo> TipoEquipos { get => tipoEquipos; set => tipoEquipos = value; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
