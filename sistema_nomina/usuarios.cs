using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_nomina
{
    public partial class usuarios : Form
    {
        UsuariosControlador usuariosControlador = new UsuariosControlador();

        public usuarios()
        {
            InitializeComponent();
        }

        public void usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        public void MostrarUsuarios()
        {
            UsuariosControlador usuariosControlador = new UsuariosControlador();
            dataGridViewUsers.DataSource = usuariosControlador.mostrarUsuarios();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.INSERTAR = true;
            form.Show();
            this.Hide();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridViewUsers.SelectedCells.Count > 1)
            {
                Form1 form = new Form1();
                form.EDITAR = true;
                form.textBoxID.Text = dataGridViewUsers.CurrentRow.Cells["id"].Value.ToString();
                form.textBoxNombre.Text = dataGridViewUsers.CurrentRow.Cells["nombre"].Value.ToString();
                form.textBoxApellidoP.Text = dataGridViewUsers.CurrentRow.Cells["apellido_paterno"].Value.ToString();
                form.textBoxApellidoM.Text = dataGridViewUsers.CurrentRow.Cells["apellido_materno"].Value.ToString();
                form.textBoxFechaInicio.Text = dataGridViewUsers.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                form.textBoxNSS.Text = dataGridViewUsers.CurrentRow.Cells["nss"].Value.ToString();
                form.textBoxCURP.Text = dataGridViewUsers.CurrentRow.Cells["curp"].Value.ToString();
                form.textBoxRFC.Text = dataGridViewUsers.CurrentRow.Cells["rfc"].Value.ToString();
                form.textBoxSalarioDiario.Text = dataGridViewUsers.CurrentRow.Cells["salarioDiario"].Value.ToString();
                form.COMBOBOX_JORNADA = int.Parse(dataGridViewUsers.CurrentRow.Cells["tipoJornada"].Value.ToString());
                form.COMBOBOX_PUESTO = int.Parse(dataGridViewUsers.CurrentRow.Cells["puesto"].Value.ToString());
                form.textBoxBanco.Text = dataGridViewUsers.CurrentRow.Cells["banco"].Value.ToString();
                form.textBoxCuentaBancaria.Text = dataGridViewUsers.CurrentRow.Cells["cuentaBancaria"].Value.ToString();
                form.textBoxEmail.Text = dataGridViewUsers.CurrentRow.Cells["email"].Value.ToString();
                form.COMBOBOX_NOMINA = int.Parse(dataGridViewUsers.CurrentRow.Cells["tipoNomina"].Value.ToString());
                form.COMBOBOX_CONTRATO = int.Parse(dataGridViewUsers.CurrentRow.Cells["tipoContrato"].Value.ToString());
                form.textBoxBonos.Text = dataGridViewUsers.CurrentRow.Cells["abonos"].Value.ToString();
                form.textBoxFechaInicio.Text = dataGridViewUsers.CurrentRow.Cells["fechaInicio"].Value.ToString();
                form.textBoxPassword.Text = dataGridViewUsers.CurrentRow.Cells["pass"].Value.ToString();
                form.setGenero(validarGenero(dataGridViewUsers.CurrentRow.Cells["genero"].Value.ToString()));
                form.textBoxFechaNacimiento.Text = dataGridViewUsers.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
                form.cambiarFormulario(true);
                form.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("No ha seleccionado una fila para editar");
            }

            
        }
        private int validarGenero(string genero) { return int.Parse(genero); }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if(dataGridViewUsers.SelectedCells.Count > 1 && MessageBox.Show("Estas Seguro de que desea eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuariosControlador.Borrar(int.Parse(dataGridViewUsers.CurrentRow.Cells["id"].Value.ToString()));
                MostrarUsuarios();
            } else if(dataGridViewUsers.SelectedCells.Count <= 1)
            {
                MessageBox.Show("Seleccione una fila");
            }

        }
    }
}
