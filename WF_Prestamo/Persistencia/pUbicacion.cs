using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;

namespace WF_Prestamo.Persistencia
{
    internal class pUbicacion
    {
        public static void Save(Ubicacion u)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Ubicacion (aula, edificio) VALUES (@aula, @edificio);");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@aula", u.Aula));
            cmd.Parameters.Add(new SQLiteParameter("@edificio", u.Edificio));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static void Update(Ubicacion u)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Ubicacion  SET Edificio=@edificio, Aula= @Aula, idUbicacion= @idUbicacion WHERE idUbicacion= @idUbicacion;");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@idUbicacion", u.IdUbicacion));
            cmd.Parameters.Add(new SQLiteParameter("@Aula", u.Aula));
            cmd.Parameters.Add(new SQLiteParameter("@edificio", u.Edificio));


            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



        public static void Delete(Ubicacion u)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Ubicacion WHERE idUbicacion= @idUbicacion;");

            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@idUbicacion", u.IdUbicacion));

            cmd.ExecuteNonQuery();

        }

     

        public static List<Ubicacion> GetAll()
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idUbicacion, Aula, Edificio  FROM Ubicacion");
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {
                Ubicacion u = new Ubicacion();
                u.IdUbicacion = reader.GetInt32(0);
                u.Aula = reader.GetString(1);
                u.Edificio = reader.GetString(2);
                ubicaciones.Add(u);
            }
            return ubicaciones;
        }
        
        public static Ubicacion GetById(int id)
        {
            Ubicacion u = new Ubicacion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idUbicacion, Aula, Edificio FROM Ubicacion WHERE idUbicacion = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            //creo el datareader
            SQLiteDataReader reader = cmd.ExecuteReader();
            //Recorro el datareader
            while (reader.Read())
            {

                u.IdUbicacion = reader.GetInt32(0);
                u.Edificio = reader.GetString(1);
                u.Aula = reader.GetString(2);


            }
            return u;
        }

    }
}
