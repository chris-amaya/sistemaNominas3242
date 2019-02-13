using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using System.Collections;

namespace sistema_nomina
{
    public class UsuariosControlador
    {
        private UsuariosModelo Obj_usuarios = new UsuariosModelo();
        ArrayList listaJornadas = new ArrayList();
        ArrayList listaNomina = new ArrayList();
        ArrayList listaContrato = new ArrayList();
        ArrayList listaPuestos = new ArrayList();

        dynamic json = JsonConvert.DeserializeObject(File.ReadAllText("C:\\Users\\chris\\OneDrive\\Escritorio\\jsonOpciones.txt"));

        public DataTable mostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = Obj_usuarios.Mostrar();
            return tabla;
        }

        public void Insertar(string nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, int genero, string nss, string curp, string rfc, int salarioDiario, int jornadaTipo, int puesto, string banco, string cuentaBancaria, string email, int tipoNomina, int tipoContrato, int abonos, string fechaInicio, string pass)
        {
            Obj_usuarios.Insertar(nombre, apellido_paterno, apellido_materno, fecha_nacimiento, genero, nss, curp, rfc, salarioDiario, jornadaTipo, puesto, banco, cuentaBancaria, email, tipoNomina, tipoContrato, abonos, fechaInicio, pass);
        }

        public void Actualizar(int id, string nombre, string apellido_paterno, string apellido_materno, string fecha_nacimiento, int genero, string nss, string curp, string rfc, int salarioDiario, int jornadaTipo, int puesto, string banco, string cuentaBancaria, string email, int tipoNomina, int tipoContrato, int abonos, string fechaInicio, string pass)
        {
            Obj_usuarios.ActualizarUsuarios(id, nombre,  apellido_paterno, apellido_materno, fecha_nacimiento, genero, nss, curp, rfc, salarioDiario, jornadaTipo, puesto, banco, cuentaBancaria, email, tipoNomina, tipoContrato, abonos, fechaInicio, pass);
        }

        public void Borrar(int id)
        {
            Obj_usuarios.BorrarUsuario(id);
        }

        public void loginUser(string user, string password)
        {
            Obj_usuarios.loginUser(user, password);
        }


        public Tuple<ArrayList, string, string> mostrarJornadas()
        {
            const string VALUE_MEMBER = "idJornada";
            const string DISPLAYMEMBER = "JornadaTipo";
            int indexJornada = 1;
            foreach (dynamic Tipojornada in json.jornadaTipo)
            {
                listaJornadas.Add(new jornada(Tipojornada.ToString(), indexJornada));
                indexJornada++;
            }
            return Tuple.Create(listaJornadas, VALUE_MEMBER, DISPLAYMEMBER);
        }

        public Tuple<ArrayList, string, string> mostrarNomina()
        {
            const string VALUE_MEMBER = "idNomina";
            const string DISPLAYMEMBER = "nominaTipo";
            int indexNomina = 1;
            foreach (dynamic tipoNomina in json.tipoNomina)
            {
                listaNomina.Add(new nomina(tipoNomina.ToString(), indexNomina));
                indexNomina++;
            }
            return Tuple.Create(listaNomina, VALUE_MEMBER, DISPLAYMEMBER);
        }

        public Tuple<ArrayList, string, string> mostrarContrato()
        {
            const string VALUE_MEMBER = "idContrato";
            const string DISPLAYMEMBER = "ContratoTipo";
            int indexContrato = 1;
            foreach (dynamic tipoContrato in json.tipoContrato)
            {
                listaContrato.Add(new contrato(tipoContrato.ToString(), indexContrato));
                indexContrato++;
            }
            return Tuple.Create(listaContrato, VALUE_MEMBER, DISPLAYMEMBER);
        }

        public Tuple<ArrayList, string, string> mostrarPuestos()
        {
            const string VALUE_MEMBER = "idPuesto";
            const string DISPLAYMEMBER = "PuestoTipo";
            int indexPuesto = 1;
            foreach (dynamic tipoPuesto in json.puestos)
            {
                listaPuestos.Add(new puesto(tipoPuesto.ToString(), indexPuesto));
                indexPuesto++;
            }
            return Tuple.Create(listaPuestos, VALUE_MEMBER, DISPLAYMEMBER);
        }
    }

    public class puesto
    {
        private string idPuesto;
        private string puestoTipo;

        public puesto(string puestoTipo, int PuestoTipo)
        {
            this.puestoTipo = puestoTipo;
        }

        public string PuestoTipo
        {
            get
            {
                return puestoTipo;
            }
        }
        public string IdPuesto
        {
            get
            {
                return idPuesto;
            }
        }

    }

    public class jornada
    {
        private string idJornada;
        private string jornadaTipo;

        public jornada(string jornadaTipo, int idJornada)
        {
            this.jornadaTipo = jornadaTipo;
        }

        public string JornadaTipo
        {
            get
            {
                return jornadaTipo;
            }
        }
        public string IdJornada
        {
            get
            {
                return idJornada;
            }
        }

    }

    public class nomina
    {
        private string idNomina;
        private string nominaTipo;

        public nomina(string nominaTipo, int idNomina)
        {
            this.nominaTipo = nominaTipo;
        }

        public string NominaTipo
        {
            get
            {
                return nominaTipo;
            }
        }
        public string IdNomina
        {
            get
            {
                return idNomina;
            }
        }

    }

    public class contrato
    {
        private string idContrato;
        private string contratoTipo;

        public contrato(string contratoTipo, int idNomina)
        {
            this.contratoTipo = contratoTipo;
        }

        public string ContratoTipo
        {
            get
            {
                return contratoTipo;
            }
        }
        public string IdContrato
        {
            get
            {
                return idContrato;
            }
        }

    }
}
