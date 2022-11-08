using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;

namespace WF_Prestamo.Persistencia
{
    internal class pPrestamo
    {
        public static void Save(Prestamo p)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Prestamo (idEquipo, idUbicacion, idUsuario, idProfesor,Duracion,FechaPrestamo, EstadoPrestamo,HoraInicio,HoraFin) VALUES (@idEquipo, @idUbicacion, @idUsuario, @idProfesor,@Duracion,@FechaPrestamo,@EstadoPrestamo,@HoraInicio,@HoraFin);");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", p.EquipoPrestamo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@idUbicacion", p.UbicacionPrestamo.IdUbicacion));
            cmd.Parameters.Add(new SQLiteParameter("@idUsuario", p.Usu));
            cmd.Parameters.Add(new SQLiteParameter("@idProfesor", p.IdProfesor));
            cmd.Parameters.Add(new SQLiteParameter("@Duracion", p.));
            cmd.Parameters.Add(new SQLiteParameter("@FechaPrestamo", p.FechaPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@EstadoPrestamo", p.EstadoPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@HoraInicio", p.HoraInicio));
            cmd.Parameters.Add(new SQLiteParameter("@HoraFin", p.HoraFin));
            
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }


    }
}
