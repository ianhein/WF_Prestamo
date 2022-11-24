using System.Collections.Generic;
using System.Data.SQLite;
using WF_Prestamo.Entidades;

namespace WF_Prestamo.Persistencia
{
    internal class pUsuario
    {
        public static void Save(Usuario us)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Usuario (user, password) VALUES (@user, @password);");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@user", us.User));
            cmd.Parameters.Add(new SQLiteParameter("@password", us.Password));

            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();

        }

        public static List<Usuario> GetByUser(string user, string password)
        {

            List<Usuario> usuarios = new List<Usuario>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Usuario where User = @user and Password=@password;");
            cmd.Parameters.Add(new SQLiteParameter("@user", user));
            cmd.Parameters.Add(new SQLiteParameter("@password", password));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                Usuario u = new Usuario();
                u.User = obdr.GetString(1);
                u.Password = obdr.GetString(2);
                
                usuarios.Add(u);
            }
            return usuarios;
        }

        public static Usuario GetById(int id)
        {
            Usuario u = new Usuario();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Usuario where idUser = @id;");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                u.User = obdr.GetString(1);
                u.Password = obdr.GetString(2);
            }
            return u;
        }
        public static Usuario GetByUser1(string user)
        {

            Usuario u = new Usuario();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Usuario where User = @user ");
            cmd.Parameters.Add(new SQLiteParameter("@user", user));
            //cmd.Parameters.Add(new SQLiteParameter("@password", password));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {                
                u.User = obdr.GetString(1);
                u.Password = obdr.GetString(2);                
            }
            return u;
        }

        public static List<Usuario> GetByUserList(string user)
        {

            List<Usuario> usuarios = new List<Usuario>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Usuario where User = @user ;");
            cmd.Parameters.Add(new SQLiteParameter("@user", user));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                Usuario u = new Usuario();
                u.User = obdr.GetString(1);

                usuarios.Add(u);
            }
            return usuarios;
        }

        public static Usuario GetByUserOnly(string user)
        {

            Usuario u = new Usuario();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Usuario where User = @user;");
            cmd.Parameters.Add(new SQLiteParameter("@user", user));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                u.User = obdr.GetString(1);
                u.Password = obdr.GetString(2);
            }
            return u;
        }
        public static void Update(Usuario us, int idUsuario)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Usuario SET user= @user, idUsuario= @idUsuario WHERE idUsuario= @idUsuario;");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@user", us.User));
            cmd.Parameters.Add(new SQLiteParameter("@idUsuario", idUsuario));
            
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Usuario");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Usuario u = new Usuario();
                u.IdUsuario = obdr.GetInt32(0);
                u.User = obdr.GetString(1);
                u.Password = obdr.GetString(2);
                usuarios.Add(u);
            }
            return usuarios;
        }
      
    }
}
