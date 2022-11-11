using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    public class Ubicacion
    {
        int idUbicacion;
        string aula;
        string edificio;
        public string Aula { get => aula; set => aula = value; }
        public string Edificio {get => edificio; set => edificio = value; }
        public int IdUbicacion { get => idUbicacion; set => idUbicacion = value; }

        public Ubicacion(string aula, int idUbicacion, string edificio)
        {
            this.idUbicacion = idUbicacion;
            this.aula = aula;
            this.edificio = edificio;
        }
       
       
        public Ubicacion()
        {
        }
        
        public string NombreCompleto
        {
            get
            {
                return edificio + " - " + aula;
            }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }


    }
}
