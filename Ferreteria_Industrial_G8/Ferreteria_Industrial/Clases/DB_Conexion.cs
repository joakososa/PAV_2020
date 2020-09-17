using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ferreteria_Industrial.Clases
{
    class DB_Conexion
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd_Sql = new SqlCommand();

        private void Conectar()
        {
            Conexion.ConnectionString = "Data Source=DESARROLLO\\SQLEXPRESS;Initial Catalog=FerreteriaDB;Integrated Security=True";
            Conexion.Open();
            Cmd_Sql.Connection = Conexion;
            Cmd_Sql.CommandType = System.Data.CommandType.Text;
                       
        }

        private void Desconectar_BD()
        {
            Conexion.Close();
        }

        public DataTable Consulta_Sql (string Sql)
        {
            Conectar();
            Cmd_Sql.CommandText = Sql;
            DataTable Tabla = new DataTable();
            Tabla.Load(Cmd_Sql.ExecuteReader());
            Desconectar_BD();
            return Tabla;
                          
         }
     
    }
}
