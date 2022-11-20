using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;

namespace WF_Prestamo.Persistencia
{
    internal class pProfesor
    {
        public static void Save(Profesor p)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Profesor (nombre, apellido) VALUES (@nombre, @apellido);");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", p.Apellido));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static List<Profesor> GetProfesors(string nombre, string apellido)
        {

            List<Profesor> profesores = new List<Profesor>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Profesor where Nombre = @nombre and Apellido=@apellido;");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", apellido));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                Profesor p = new Profesor();
                p.Nombre = obdr.GetString(1);
                p.Apellido = obdr.GetString(2);

                profesores.Add(p);
            }
            return profesores;
        }
        public static void Update(Profesor p)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Profesor SET Nombre = @nombre, Apellido=@apellido, idProfesor = @idProfesor WHERE idProfesor= @idProfesor;");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@nombre", p.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", p.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@idProfesor", p.Id));

            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Profesor p)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Profesor WHERE idProfesor = @idProfesor;");

            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@idProfesor", p.Id));

            cmd.ExecuteNonQuery();

        }

        public static List<Profesor> GetAll()
        {
            List<Profesor> profesores = new List<Profesor>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idProfesor, Nombre, Apellido FROM Profesor");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Profesor p = new Profesor();

                p.Id = obdr.GetInt32(0);
                p.Nombre = obdr.GetString(1);
                p.Apellido = obdr.GetString(2);
                profesores.Add(p);
            }
            return profesores;
        }

        public static Profesor GetById(int id)
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
    }
}
