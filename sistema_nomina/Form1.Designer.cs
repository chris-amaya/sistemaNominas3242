namespace sistema_nomina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellidoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApellidoM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.textBoxNSS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCURP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRFC = new System.Windows.Forms.TextBox();
            this.textBoxSalarioDiario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBonos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxBanco = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxCuentaBancaria = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTipoNomina = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoContrato = new System.Windows.Forms.ComboBox();
            this.comboBoxJornada = new System.Windows.Forms.ComboBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.nominaDataSet = new sistema_nomina.nominaDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new sistema_nomina.nominaDataSetTableAdapters.usersTableAdapter();
            this.comboBoxTipoPuestos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nominaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(124, 34);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 0;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(430, 33);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(124, 60);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // textBoxApellidoP
            // 
            this.textBoxApellidoP.Location = new System.Drawing.Point(124, 86);
            this.textBoxApellidoP.Name = "textBoxApellidoP";
            this.textBoxApellidoP.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidoP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellido Paterno";
            // 
            // textBoxApellidoM
            // 
            this.textBoxApellidoM.Location = new System.Drawing.Point(124, 112);
            this.textBoxApellidoM.Name = "textBoxApellidoM";
            this.textBoxApellidoM.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidoM.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido Materno";
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(124, 138);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaNacimiento.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Género";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(124, 167);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 6;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(215, 167);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino.TabIndex = 7;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // textBoxNSS
            // 
            this.textBoxNSS.Location = new System.Drawing.Point(124, 190);
            this.textBoxNSS.Name = "textBoxNSS";
            this.textBoxNSS.Size = new System.Drawing.Size(100, 20);
            this.textBoxNSS.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "NSS";
            // 
            // textBoxCURP
            // 
            this.textBoxCURP.Location = new System.Drawing.Point(124, 216);
            this.textBoxCURP.Name = "textBoxCURP";
            this.textBoxCURP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCURP.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "CURP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "RFC empleado";
            // 
            // textBoxRFC
            // 
            this.textBoxRFC.Location = new System.Drawing.Point(124, 242);
            this.textBoxRFC.Name = "textBoxRFC";
            this.textBoxRFC.Size = new System.Drawing.Size(100, 20);
            this.textBoxRFC.TabIndex = 10;
            // 
            // textBoxSalarioDiario
            // 
            this.textBoxSalarioDiario.Location = new System.Drawing.Point(430, 60);
            this.textBoxSalarioDiario.Name = "textBoxSalarioDiario";
            this.textBoxSalarioDiario.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarioDiario.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Salario Diario integrado";
            // 
            // textBoxBonos
            // 
            this.textBoxBonos.Location = new System.Drawing.Point(737, 109);
            this.textBoxBonos.Name = "textBoxBonos";
            this.textBoxBonos.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonos.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(560, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Salario Base, cuotas y aportaciones";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tipo de jornada";
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(737, 138);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaInicio.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(592, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Fecha Inicio relacion laboral";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(737, 27);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(699, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(651, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tipo de nómina";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(651, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Tipo de contrato";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(385, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "puesto";
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.Location = new System.Drawing.Point(430, 164);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(100, 20);
            this.textBoxBanco.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(385, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Banco";
            // 
            // textBoxCuentaBancaria
            // 
            this.textBoxCuentaBancaria.Location = new System.Drawing.Point(430, 186);
            this.textBoxCuentaBancaria.Name = "textBoxCuentaBancaria";
            this.textBoxCuentaBancaria.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuentaBancaria.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(343, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Cuenta bancaria";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(472, 281);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(159, 34);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxTipoNomina
            // 
            this.comboBoxTipoNomina.FormattingEnabled = true;
            this.comboBoxTipoNomina.Location = new System.Drawing.Point(737, 52);
            this.comboBoxTipoNomina.Name = "comboBoxTipoNomina";
            this.comboBoxTipoNomina.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoNomina.TabIndex = 17;
            // 
            // comboBoxTipoContrato
            // 
            this.comboBoxTipoContrato.FormattingEnabled = true;
            this.comboBoxTipoContrato.Location = new System.Drawing.Point(737, 79);
            this.comboBoxTipoContrato.Name = "comboBoxTipoContrato";
            this.comboBoxTipoContrato.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoContrato.TabIndex = 18;
            // 
            // comboBoxJornada
            // 
            this.comboBoxJornada.FormattingEnabled = true;
            this.comboBoxJornada.Location = new System.Drawing.Point(430, 109);
            this.comboBoxJornada.Name = "comboBoxJornada";
            this.comboBoxJornada.Size = new System.Drawing.Size(100, 21);
            this.comboBoxJornada.TabIndex = 12;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(472, 281);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(159, 34);
            this.buttonActualizar.TabIndex = 5;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Visible = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // nominaDataSet
            // 
            this.nominaDataSet.DataSetName = "nominaDataSet";
            this.nominaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.nominaDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxTipoPuestos
            // 
            this.comboBoxTipoPuestos.FormattingEnabled = true;
            this.comboBoxTipoPuestos.Location = new System.Drawing.Point(430, 137);
            this.comboBoxTipoPuestos.Name = "comboBoxTipoPuestos";
            this.comboBoxTipoPuestos.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoPuestos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 327);
            this.Controls.Add(this.comboBoxTipoPuestos);
            this.Controls.Add(this.comboBoxJornada);
            this.Controls.Add(this.comboBoxTipoContrato);
            this.Controls.Add(this.comboBoxTipoNomina);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.textBoxCuentaBancaria);
            this.Controls.Add(this.textBoxBanco);
            this.Controls.Add(this.textBoxBonos);
            this.Controls.Add(this.textBoxSalarioDiario);
            this.Controls.Add(this.textBoxRFC);
            this.Controls.Add(this.radioButtonFemenino);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxCURP);
            this.Controls.Add(this.textBoxNSS);
            this.Controls.Add(this.textBoxFechaNacimiento);
            this.Controls.Add(this.textBoxApellidoM);
            this.Controls.Add(this.textBoxApellidoP);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonActualizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nominaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Button buttonActualizar;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxNombre;
        public System.Windows.Forms.TextBox textBoxApellidoP;
        public System.Windows.Forms.TextBox textBoxApellidoM;
        public System.Windows.Forms.TextBox textBoxFechaNacimiento;
        public System.Windows.Forms.RadioButton radioButtonMasculino;
        public System.Windows.Forms.RadioButton radioButtonFemenino;
        public System.Windows.Forms.TextBox textBoxNSS;
        public System.Windows.Forms.TextBox textBoxCURP;
        public System.Windows.Forms.TextBox textBoxRFC;
        public System.Windows.Forms.TextBox textBoxSalarioDiario;
        public System.Windows.Forms.TextBox textBoxBonos;
        public System.Windows.Forms.TextBox textBoxFechaInicio;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxBanco;
        public System.Windows.Forms.TextBox textBoxCuentaBancaria;
        public System.Windows.Forms.Button buttonGuardar;
        public System.Windows.Forms.ComboBox comboBoxTipoNomina;
        public System.Windows.Forms.ComboBox comboBoxTipoContrato;
        public System.Windows.Forms.ComboBox comboBoxJornada;
        private nominaDataSet nominaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private nominaDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        public System.Windows.Forms.ComboBox comboBoxTipoPuestos;
    }
}

