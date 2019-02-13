using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;
using System.Collections;

namespace sistema_nomina
{
    public partial class Form1 : Form
    {
        public int COMBOBOX_JORNADA = 0;
        public int COMBOBOX_NOMINA = 0;
        public int COMBOBOX_CONTRATO = 0;
        public int COMBOBOX_PUESTO = 0;

        public bool INSERTAR = true;
        public bool EDITAR = false;

        private List<string> mensajesShowBox = new List<string>();

        UsuariosControlador usuariosControlador = new UsuariosControlador();
        usuarios usuarios = new usuarios();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var resultadoJornadas = new UsuariosControlador().mostrarJornadas();
            comboBoxJornada.DataSource = resultadoJornadas.Item1;
            comboBoxJornada.ValueMember = resultadoJornadas.Item2;
            comboBoxJornada.DisplayMember = resultadoJornadas.Item3;
            comboBoxJornada.SelectedIndex = COMBOBOX_JORNADA;

            var resultadoNomina = new UsuariosControlador().mostrarNomina();
            comboBoxTipoNomina.DataSource = resultadoNomina.Item1;
            comboBoxTipoNomina.ValueMember = resultadoNomina.Item2;
            comboBoxTipoNomina.DisplayMember = resultadoNomina.Item3;
            comboBoxTipoNomina.SelectedIndex = COMBOBOX_NOMINA;

            var resultadoContrato = new UsuariosControlador().mostrarContrato();
            comboBoxTipoContrato.ValueMember = resultadoContrato.Item2;
            comboBoxTipoContrato.DisplayMember = resultadoContrato.Item3;
            comboBoxTipoContrato.DataSource = resultadoContrato.Item1;
            comboBoxTipoContrato.SelectedIndex = COMBOBOX_CONTRATO;

            var resultadoPuestos = new UsuariosControlador().mostrarPuestos();
            comboBoxTipoPuestos.ValueMember = resultadoPuestos.Item2;
            comboBoxTipoPuestos.DisplayMember = resultadoPuestos.Item3;
            comboBoxTipoPuestos.DataSource = resultadoPuestos.Item1;
            comboBoxTipoPuestos.SelectedIndex = COMBOBOX_PUESTO;
        }
        int genero = 0;
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            if (radioButtonFemenino.Checked == true) { genero = 0; }
            else if (radioButtonMasculino.Checked == true) { genero = 1; }
            else { mensajesShowBox.Add("falta selecionar genero"); }

            try
            {
                usuariosControlador.Insertar(textBoxNombre.Text.ToString(), textBoxApellidoP.Text.ToString(), textBoxApellidoM.Text.ToString(), textBoxFechaNacimiento.Text.ToString(), genero, textBoxNSS.Text.ToString(), textBoxCURP.Text.ToString(), textBoxRFC.Text.ToString(), int.Parse(textBoxSalarioDiario.Text.ToString()), comboBoxJornada.SelectedIndex, comboBoxTipoPuestos.SelectedIndex, textBoxBanco.Text.ToString(), textBoxCuentaBancaria.Text.ToString(), textBoxEmail.Text.ToString(), comboBoxTipoNomina.SelectedIndex, int.Parse(comboBoxTipoContrato.SelectedIndex.ToString()), int.Parse(textBoxBonos.Text.ToString()), textBoxFechaInicio.Text.ToString(), textBoxPassword.Text.ToString());
                MessageBox.Show("Se insertó correctamente");
                usuarios.MostrarUsuarios();
                this.Hide();
                usuarios.Show();
            } catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (radioButtonFemenino.Checked == true) { genero = 0; }
            else if (radioButtonMasculino.Checked == true) { genero = 1; }
            else { mensajesShowBox.Add("falta selecionar genero"); }

            try
            {
                usuariosControlador.Actualizar(int.Parse(textBoxID.Text.ToString()), textBoxNombre.Text.ToString(), textBoxApellidoP.Text.ToString(), textBoxApellidoM.Text.ToString(), textBoxFechaNacimiento.Text.ToString(), genero, textBoxNSS.Text.ToString(), textBoxCURP.Text.ToString(), textBoxRFC.Text.ToString(), int.Parse(textBoxSalarioDiario.Text.ToString()), comboBoxJornada.SelectedIndex, comboBoxTipoPuestos.SelectedIndex, textBoxBanco.Text.ToString(), textBoxCuentaBancaria.Text.ToString(), textBoxEmail.Text.ToString(), comboBoxTipoNomina.SelectedIndex, int.Parse(comboBoxTipoContrato.SelectedIndex.ToString()), int.Parse(textBoxBonos.Text.ToString()), textBoxFechaInicio.Text.ToString(), textBoxPassword.Text.ToString());
                MessageBox.Show("Se actualizó correctamente");
                usuarios.MostrarUsuarios();
                this.Hide();
                usuarios.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        // FUNCIONES PERSONALES
        public void cambiarFormulario(bool actualizar)
        {
            if (!actualizar)
            {
                buttonGuardar.Visible = true;
                buttonActualizar.Visible = false;
            }
            else if (actualizar == true)
            {
                buttonActualizar.Visible = true;
                buttonGuardar.Visible = false;
            }
        }

        public void setGenero(int genero)
        {
            // int genero = 0;
            if(genero == 0) { radioButtonFemenino.Checked = true; }
            else { radioButtonMasculino.Checked = true; }
        }

        private void limpiarForm()
        {
            textBoxNombre.Clear();
            textBoxApellidoP.Clear();
            textBoxApellidoM.Clear();
            textBoxFechaNacimiento.Clear();
            textBoxNSS.Clear();
            textBoxCURP.Clear();
            textBoxRFC.Clear();
            textBoxSalarioDiario.Clear();  
            textBoxBanco.Clear();
            textBoxCuentaBancaria.Clear();
            textBoxEmail.Clear();
            textBoxBonos.Clear();
            textBoxFechaInicio.Clear(); 
            textBoxPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
