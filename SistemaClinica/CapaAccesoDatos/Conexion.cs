using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion() { }
        public static Conexion GetConexion()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion
        
        public MySqlConnection ConexionDB()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "";
            return conexion;
        }
    }
}
