using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sistema_nomina
{
    public class UsuariosModelo
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM users";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, int genero, string nss, string curp, string rfc, int salarioDiario, int jornadaTipo, int puesto, string banco, string cuentaBancaria, string email, int tipoNomina, int tipoContrato, int abonos, string fechaInicio, string pass )
        {
            //PROCEDIMNIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "InsertarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido_paterno", apellido_paterno);
            comando.Parameters.AddWithValue("@apeliido_materno", apellido_materno);
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@nss", nss);
            comando.Parameters.AddWithValue("@curp", curp);
            comando.Parameters.AddWithValue("@rfc", rfc);
            comando.Parameters.AddWithValue("@salarioDiario", salarioDiario);
            comando.Parameters.AddWithValue("@jornadaTipo", jornadaTipo);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@banco", banco);
            comando.Parameters.AddWithValue("@cuentaBancaria", cuentaBancaria);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@tipoNonima", tipoNomina);
            comando.Parameters.AddWithValue("@tipoContrato", tipoContrato);
            comando.Parameters.AddWithValue("@abonos", abonos);
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void ActualizarUsuarios(int id, string nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, int genero, string nss, string curp, string rfc, int salarioDiario, int jornadaTipo, int puesto, string banco, string cuentaBancaria, string email, int tipoNomina, int tipoContrato, int abonos, string fechaInicio, string pass)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = "ActualizarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido_paterno", apellido_paterno);
            comando.Parameters.AddWithValue("@apeliido_materno", apellido_materno);
            comando.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@nss", nss);
            comando.Parameters.AddWithValue("@curp", curp);
            comando.Parameters.AddWithValue("@rfc", rfc);
            comando.Parameters.AddWithValue("@salarioDiario", salarioDiario);
            comando.Parameters.AddWithValue("@jornadaTipo", jornadaTipo);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@banco", banco);
            comando.Parameters.AddWithValue("@cuentaBancaria", cuentaBancaria);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@tipoNonima", tipoNomina);
            comando.Parameters.AddWithValue("@tipoContrato", tipoContrato);
            comando.Parameters.AddWithValue("@abonos", abonos);
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void BorrarUsuario(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = $"DELETE FROM users WHERE id = {id}";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public SqlDataReader loginUser(string user, string password)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando.CommandText = $"SELECT * FROM users WHERE id = {user} AND password = {password}";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            return leer;
        }
    }

}
