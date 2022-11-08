using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;
using WF_Prestamo.Persistencia;

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
            cmd.Parameters.Add(new SQLiteParameter("@idUsuario", p.UsuarioPrestamo.IdUsuario));
            cmd.Parameters.Add(new SQLiteParameter("@idProfesor", p.EquipoPrestamo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@Duracion", p.duracion));
            cmd.Parameters.Add(new SQLiteParameter("@FechaPrestamo", p.FechaPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@EstadoPrestamo", p.EstadoPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@HoraInicio", p.HoraInicio));
            cmd.Parameters.Add(new SQLiteParameter("@HoraFin", p.HoraFin));
            
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }
        public static List<Prestamo> Getall()
        {
            List<Prestamo> lista = new List<Prestamo>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idPrestamo, idEquipo, idUbicacion, idUsuario, idProfesor,Duracion,FechaPrestamo, EstadoPrestamo,HoraInicio,HoraFin FROM Prestamo");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Prestamo p = new Prestamo();
                p.IdPrestamo = dr.GetInt32(0);
                p.EquipoPrestamo.Id = dr.GetInt32(1);
                p.UbicacionPrestamo.IdUbicacion = dr.GetInt32(2);
                p.UsuarioPrestamo.IdUsuario = dr.GetInt32(3);
                p.ProfesorPrestamo.Id = dr.GetInt32(4);
                p.duracion = dr.GetString(5);
                p.FechaPrestamo = dr.GetString(6);
                p.EstadoPrestamo = dr.GetString(7);
                p.HoraInicio = dr.GetDateTime(8);
                p.HoraFin = dr.GetDateTime(9);
                lista.Add(p);
            }
            return lista;
        }
    }
            

    }

