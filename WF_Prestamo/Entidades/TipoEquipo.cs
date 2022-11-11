using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    public class TipoEquipo
    {
        int id;
        
        string nombre;

        public TipoEquipo(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string Estado { get => nombre; set => nombre = value; }

        public int Id { get => id; set => id = value; }


        public TipoEquipo()
        {
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
