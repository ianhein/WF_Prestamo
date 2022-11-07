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
        string estadoPrestamo;
        Equipo Equipo;
        Profesor Profesor;
        Ubicacion Ubicacion;
        TipoEquipo TipoEquipo;
        

        public Prestamo(int idPrestamo, string fechaPrestamo, DateTime horaInicio, DateTime horaFin, string nombreProfesor, string estadoPrestamo, DateTime fechaCancelacion)
        {
            this.idPrestamo = idPrestamo;
            this.fechaPrestamo = fechaPrestamo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.estadoPrestamo = estadoPrestamo;
            this.fechaCancelacion = fechaCancelacion;
        }

        public Prestamo()
        {
            Equipo = new Equipo();
            Profesor = new Profesor();
            Ubicacion = new Ubicacion();
            TipoEquipo = new TipoEquipo();
        }

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public DateTime FechaCancelacion { get => fechaCancelacion; set => fechaCancelacion = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        internal Equipo EquipoPrestamo { get => Equipo; set => Equipo = value; }
        internal Profesor ProfesorPrestamo { get => Profesor; set => Profesor = value; }
        internal Ubicacion UbiacionPrestamo { get => Ubicacion; set => Ubicacion = value; }
        internal TipoEquipo TipoEquipoPrestamo { get => TipoEquipo; set => TipoEquipo = value; }
        


    }
}
