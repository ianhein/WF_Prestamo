using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    public class Prestamo
    {
        int idPrestamo;
        string fechaPrestamo;
        string horaInicio;
        string horaFin;
        string estadoPrestamo;
        Equipo Equipo;
        Profesor Profesor;
        Ubicacion Ubicacion;
        Usuario Usuario;
        TipoEquipo TipoEquipo;


        public Prestamo()
        {
            Equipo = new Equipo();
            Profesor = new Profesor();
            Ubicacion = new Ubicacion();
            Usuario = new Usuario();
            TipoEquipo = new TipoEquipo();
        }

        public Prestamo(int idPrestamo, string fechaPrestamo, string horaInicio, string horaFin, string estadoPrestamo, Equipo equipo, Profesor profesor, Ubicacion ubicacion, Usuario usuario, TipoEquipo tipoEquipo)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.estadoPrestamo = estadoPrestamo;
            Equipo = equipo;
            Profesor = profesor;
            Ubicacion = ubicacion;
            Usuario = usuario;
            TipoEquipo = tipoEquipo;
        }
       
        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFin { get => horaFin; set => horaFin = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        public Equipo EquipoPrestamo { get => Equipo; set => Equipo = value; }
        public Profesor ProfesorPrestamo { get => Profesor; set => Profesor = value; }
        public Ubicacion UbicacionPrestamo { get => Ubicacion; set => Ubicacion = value; }
        public Usuario UsuarioPrestamo { get => Usuario; set => Usuario = value; }
        public TipoEquipo TipoEquipoPrestamo { get => TipoEquipo; set => TipoEquipo = value; }



        public override string ToString()
        {
            return IdPrestamo.ToString();
        }

    }
}
