using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    public class Profesor
    {
        int id;
        string nombre;
        string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public int Id { get => id; set => id = value; }

        public Profesor(int id, string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        public Profesor()
        {
        }

        //get name + lastname as attribute
        public string NombreCompleto
        {
            get
            {
                return apellido + ", " + nombre;
            }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}
