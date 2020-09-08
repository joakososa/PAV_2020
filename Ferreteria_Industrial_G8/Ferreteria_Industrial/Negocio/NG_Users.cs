using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_Industrial.Clases;
using System.Data;

namespace Ferreteria_Industrial.Negocio
{
    class NG_Users
    {
        DB_Conexion DataBase = new DB_Conexion();
        public enum Respuesta { Validacion_Correcta, Validacion_Incorrecta };
        public Respuesta Validar_Usuario (string Usr, string Pass)
        {
            string Sql = "";
            Sql = "SELECT * FROM users WHERE CUIT='"+Usr+"' AND password='"+ Pass+"'";
            DataTable Tabla = new DataTable();
            Tabla = DataBase.Consulta_Sql(Sql);

            if (Tabla.Rows.Count==0)
            {
                return Respuesta.Validacion_Incorrecta;
            }
            else
            {
                return Respuesta.Validacion_Correcta;
            }
        }
    }
}
