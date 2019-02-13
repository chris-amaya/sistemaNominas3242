using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sistema_nomina
{
    class Conexion
    {
        private SqlConnection Connection = new SqlConnection("Server=DESKTOP-QCPDCI6\\SQLEXPRESS;DataBase=nomina;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
            return Connection;
        }

        public SqlConnection CerrarConexion()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
            return Connection;
        }
    }
}
