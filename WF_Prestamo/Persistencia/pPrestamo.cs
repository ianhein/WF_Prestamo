using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;
using WF_Prestamo.Forms.Equipos;
using WF_Prestamo.Forms.Ubicaciones;
using WF_Prestamo.Forms;
using WF_Prestamo.Persistencia;

namespace WF_Prestamo.Persistencia
{
    internal class pPrestamo
    {
        public static void Save(Prestamo p, int idEquipo, int idUbicacion, int idUsuario, int idProfesor, int idTipoEquipo)
        {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Prestamo (idEquipo, idUbicacion, idUsuario, idProfesor, idTipoEquipo, FechaPrestamo, EstadoPrestamo,HoraInicio,HoraFin) VALUES (@idEquipo, @idUbicacion, @idUsuario, @idProfesor, @idTipoEquipo, @FechaPrestamo,@EstadoPrestamo,@HoraInicio,@HoraFin);");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", idEquipo));
            cmd.Parameters.Add(new SQLiteParameter("@idUbicacion", idUbicacion));
            cmd.Parameters.Add(new SQLiteParameter("@idUsuario", idUsuario));
            cmd.Parameters.Add(new SQLiteParameter("@idProfesor", idProfesor));
            cmd.Parameters.Add(new SQLiteParameter("@idTipoEquipo", idTipoEquipo));
            cmd.Parameters.Add(new SQLiteParameter("@FechaPrestamo", p.FechaPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@EstadoPrestamo", p.EstadoPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@HoraInicio", p.HoraInicio));
            cmd.Parameters.Add(new SQLiteParameter("@HoraFin", p.HoraFin));
            
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        //update prestamos
        public static void Update(Prestamo p, int idProfesor, int idUbicacion, int idEquipo,  int idUsuario, int idTipoEquipo)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Prestamo SET idEquipo = @idEquipo, idUbicacion = @idUbicacion, idUsuario = @idUsuario, idProfesor = @idProfesor, idTipoEquipo = @idTipoEquipo, FechaPrestamo = @FechaPrestamo, EstadoPrestamo = @EstadoPrestamo, HoraInicio = @HoraInicio, HoraFin = @HoraFin WHERE idPrestamo = @idPrestamo;");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", idEquipo));
            cmd.Parameters.Add(new SQLiteParameter("@idUbicacion", idUbicacion));
            cmd.Parameters.Add(new SQLiteParameter("@idUsuario", idUsuario));
            cmd.Parameters.Add(new SQLiteParameter("@idProfesor", idProfesor));
            cmd.Parameters.Add(new SQLiteParameter("@idTipoEquipo", idTipoEquipo));
            cmd.Parameters.Add(new SQLiteParameter("@FechaPrestamo", p.FechaPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@EstadoPrestamo", p.EstadoPrestamo));
            cmd.Parameters.Add(new SQLiteParameter("@HoraInicio", p.HoraInicio));
            cmd.Parameters.Add(new SQLiteParameter("@HoraFin", p.HoraFin));
            cmd.Parameters.Add(new SQLiteParameter("@idPrestamo", p.IdPrestamo));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Prestamo> GetAll()
        {
            List<Prestamo> lista = new List<Prestamo>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idPrestamo, idEquipo, idUbicacion, idUsuario, idProfesor, idTipoEquipo, FechaPrestamo, EstadoPrestamo,HoraInicio,HoraFin FROM Prestamo");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Prestamo p = new Prestamo
                {
                    IdPrestamo = dr.GetInt32(0),
                    EquipoPrestamo = GetEquipoById(dr.GetInt32(1)),
                    UbicacionPrestamo = GetUbicacionById(dr.GetInt32(2)),
                    UsuarioPrestamo = GetUsuarioById(dr.GetInt32(3)),
                    ProfesorPrestamo = GetProfesorById(dr.GetInt32(4)),
                    TipoEquipoPrestamo = GetTipoEquipoById(dr.GetInt32(5)),
                    FechaPrestamo = dr.GetString(6),
                    EstadoPrestamo = dr.GetString(7),
                    HoraInicio = dr.GetString(8),
                    HoraFin = dr.GetString(9)
                };
                lista.Add(p);
            }
            return lista;
        }

        public static Profesor GetProfesorById(int id)
        {
            Profesor p = new Profesor();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idProfesor, Nombre, Apellido FROM Profesor WHERE idProfesor = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {
                p.Id = reader.GetInt32(0);
                p.Nombre = reader.GetString(1);
                p.Apellido = reader.GetString(2);

            }
            return p;
        }

        public static Ubicacion GetUbicacionById(int id)
        {

            Ubicacion p = new Ubicacion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idUbicacion, Aula, Edificio FROM Ubicacion WHERE idUbicacion = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {
                p.IdUbicacion = reader.GetInt32(0);
                p.Aula = reader.GetString(1);
                p.Edificio = reader.GetString(2);
            }
            return p;
        }

        public static Usuario GetUsuarioById(int id)
        {
            Usuario p = new Usuario();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idUser, User FROM Usuario WHERE idUser = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {
                p.IdUsuario = reader.GetInt32(0);
                p.User = reader.GetString(1);
            }
            return p;
        }

        public static Equipo GetEquipoById(int id)
        {

            Equipo e = new Equipo();
            TipoEquipo tp = new TipoEquipo();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idEquipo, idTipoEquipo, NombreEquipo FROM Equipo WHERE idEquipo = @id ");
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {
                e.Id = reader.GetInt32(0);
                e.TipoEquipo = GetTipoEquipoById(reader.GetInt32(1));
                e.NombreEquipo = reader.GetString(2);
            }

            return e;

        }
        public static List<Prestamo> GetAllAct()
        {
            List<Prestamo> lista = new List<Prestamo>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idPrestamo, idEquipo, idUbicacion, idUsuario, idProfesor, idTipoEquipo, FechaPrestamo, EstadoPrestamo,HoraInicio,HoraFin FROM Prestamo WHERE EstadoPrestamo = 'Aceptado' OR 'Pendiente'");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Prestamo p = new Prestamo();
                p.IdPrestamo = dr.GetInt32(0);
                p.EquipoPrestamo = GetEquipoById(dr.GetInt32(1));
                p.UbicacionPrestamo = GetUbicacionById(dr.GetInt32(2));
                p.UsuarioPrestamo = GetUsuarioById(dr.GetInt32(3));
                p.ProfesorPrestamo = GetProfesorById(dr.GetInt32(4));
                p.TipoEquipoPrestamo = GetTipoEquipoById(dr.GetInt32(5));
                p.FechaPrestamo = dr.GetString(6);
                p.EstadoPrestamo = dr.GetString(7);
                p.HoraInicio = dr.GetString(8);
                p.HoraFin = dr.GetString(9);
                lista.Add(p);
            }
            return lista;
        }

        public static TipoEquipo GetTipoEquipoById(int id)
        {

            TipoEquipo p = new TipoEquipo();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idTipoEquipo,  Estado FROM TipoEquipo WHERE idTipoEquipo = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {

                p.Id = reader.GetInt32(0);
                p.Estado = reader.GetString(1);


            }
            return p;
        }

        public static Prestamo GetById (int id )
        {
            Prestamo p = new Prestamo();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idPrestamo, idEquipo, idUbicacion, idUsuario, idProfesor,FechaPrestamo, EstadoPrestamo,HoraInicio,HoraFin FROM Prestamo WHERE idPrestamo = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {
                p.IdPrestamo = reader.GetInt32(0);
                p.EquipoPrestamo = GetEquipoById(reader.GetInt32(1));
                p.UbicacionPrestamo = GetUbicacionById(reader.GetInt32(2));
                p.UsuarioPrestamo = GetUsuarioById(reader.GetInt32(3));
                p.ProfesorPrestamo = GetProfesorById(reader.GetInt32(4));
                p.FechaPrestamo = reader.GetString(5);
                p.EstadoPrestamo = reader.GetString(6);
                p.HoraInicio = reader.GetString(7);
                p.HoraFin = reader.GetString(8);
                p.TipoEquipoPrestamo = p.EquipoPrestamo.TipoEquipo;
            }
            return p;
        }
     
        public static void FinalizarPrestamo(Prestamo p)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE idPrestamo FROM Prestamo WHERE idPrestamo = @idPrestamo");

            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@idPrestamo", p.IdPrestamo));
            SQLiteDataReader reader = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            
            while (reader.Read())
            {

                p.EstadoPrestamo = "Cancelado";

            }


        }
    }
            

    }

