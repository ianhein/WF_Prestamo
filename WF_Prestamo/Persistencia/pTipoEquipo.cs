using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Prestamo.Entidades;
using System.Data.SQLite;

namespace WF_Prestamo.Persistencia
{
    internal class pTipoEquipo
    {
        public static List<TipoEquipo> GetAll()
        {
            List<TipoEquipo> tipoEquipos = new List<TipoEquipo>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idTipoEquipo, Estado FROM TipoEquipo");
            // creo el detareader 
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TipoEquipo tipoEquipo = new TipoEquipo();
                tipoEquipo.Id = reader.GetInt32(0);
                tipoEquipo.Estado = reader.GetString(1);
                tipoEquipos.Add(tipoEquipo);
            }
            return tipoEquipos;
        }

        public static TipoEquipo GetById(int id)
        {
            TipoEquipo tipoEquipo = new TipoEquipo();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idTipoEquipo, Estado FROM TipoEquipo WHERE idTipoEquipo = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tipoEquipo.Id = reader.GetInt32(0);
                tipoEquipo.Estado = reader.GetString(1);
            }
            return tipoEquipo;
        }
    }
}
