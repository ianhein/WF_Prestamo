﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;
using System.Data.SQLite;

namespace WF_Prestamo.Persistencia
{
    internal class pEquipo
    {
        public static void Save(Equipo e)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Equipo (Nombre) Value(@Nombre)");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", e.NombreEquipo));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Equipo e)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Ubicacion  SET NombreEquipo= @Nombre, idEquipo= @idEquipo WHERE idEquipo= @idEquipo;");
            //Cargo parametros
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", e.NombreEquipo));
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", e.Id));
            //asigno conexion
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Delete(Equipo e)
        {
            //Creo script SQL a utilizar
            SQLiteCommand cmd = new SQLiteCommand("DELETE idEquipo FROM Equipo WHERE idEquipo = @idEquipo");

            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@idEquipo", e.Id));
         
            cmd.ExecuteNonQuery();
           
        }
        /*public static List<TipoEquipo> GetTypeEquipList()
        {
            List<TipoEquipo> TipoEquipo = new List
        }*/
        public static TipoEquipo GetById(int id)
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

        public static List<Equipo> GetAll()
        {
            List<Equipo> equipos = new List<Equipo>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idEquipo, idTipoEquipo, NombreEquipo FROM Equipo");
            // creo el detareader 
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader reader = cmd.ExecuteReader();
            // recorro el datareader 
            while (reader.Read())
            {
                Equipo e = new Equipo();
                e.Id = reader.GetInt32(0);
                e.TipoEquipo = GetById(reader.GetInt32(1));
                e.NombreEquipo = reader.GetString(2);
                equipos.Add(e);
                //e.TipoEquipos = ;
            }
            return equipos;

        }

    }
}
