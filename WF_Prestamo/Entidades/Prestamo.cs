using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Prestamo.Entidades
{
    internal class Prestamo
    {
        int idPrestamo;
        string fechaPrestamo;
        DateTime fechaCancelacion;
        DateTime horaInicio;
        DateTime horaFin;
        string Duracion;
        string estadoPrestamo;
        Equipo Equipo;
        Profesor Profesor;
        Ubicacion Ubicacion;
        TipoEquipo TipoEquipo;
        Usuario Usuario;



        public Prestamo()
        {
            Equipo = new Equipo();
            Profesor = new Profesor();
            Ubicacion = new Ubicacion();
            TipoEquipo = new TipoEquipo();
            Usuario = new Usuario();
        }

        public Prestamo(int idPrestamo, string fechaPrestamo, DateTime fechaCancelacion, DateTime horaInicio, DateTime horaFin, string Duracion, string estadoPrestamo, Equipo equipo, Profesor profesor, Ubicacion ubicacion, TipoEquipo tipoEquipo, Usuario usuario)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaCancelacion = fechaCancelacion;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.Duracion = Duracion;
            this.estadoPrestamo = estadoPrestamo;
            Equipo = equipo;
            Profesor = profesor;
            Ubicacion = ubicacion;
            TipoEquipo = tipoEquipo;
            Usuario = usuario;
        }

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public DateTime FechaCancelacion { get => fechaCancelacion; set => fechaCancelacion = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        internal Equipo EquipoPrestamo { get => Equipo; set => Equipo = value; }
        internal Profesor ProfesorPrestamo { get => Profesor; set => Profesor = value; }
        internal Ubicacion UbicacionPrestamo { get => Ubicacion; set => Ubicacion = value; }
        internal TipoEquipo TipoEquipoPrestamo { get => TipoEquipo; set => TipoEquipo = value; }
        internal Usuario UsuarioPrestamo { get => Usuario; set => Usuario = value; }
        internal string duracion { get => Duracion; set => Duracion = value; }


    }
}
