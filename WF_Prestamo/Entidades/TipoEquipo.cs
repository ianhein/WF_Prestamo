using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    internal class TipoEquipo
    {
        int id;
        string estado;

        public TipoEquipo(string estado, int id)
        {
            this.estado = estado;
            this.id = id;
        }

        public string Estado { get => estado; set => estado = value; }

        public int Id { get => id; set => id = value; }


        public TipoEquipo()
        {
        }

    }
}
