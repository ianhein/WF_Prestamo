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
        List<Equipo> equipos;
        List<Profesor> profesores;
        List<TipoEquipo> tipoEquipos;
        List<Ubicacion> ubicaciones;

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
            equipos = new List<Equipo>();
            profesores = new List<Profesor>();
            tipoEquipos = new List<TipoEquipo>();
            ubicaciones = new List<Ubicacion>();
        }

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public DateTime FechaCancelacion { get => fechaCancelacion; set => fechaCancelacion = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
        internal List<Equipo> Equipos { get => equipos; set => equipos = value; }
        internal List<Profesor> Profesores { get => profesores; set => profesores = value; }
        internal List<TipoEquipo> TipoEquipos { get => tipoEquipos; set => tipoEquipos = value; }
        internal List<Ubicacion> Ubicaciones { get => ubicaciones; set => ubicaciones = value; }
        
        
    }
}
