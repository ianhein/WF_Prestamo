using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    public class Usuario
    {
        int idUsuario;
        string user;
        string password;
        public Usuario() { }

        public Usuario(string user,string password )
        {
            this.user = user;
            this.password = password;
        }

        public string User { get => user; set => user = value; }

        public string Password { get => password; set => password = value; }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }


    }
}
