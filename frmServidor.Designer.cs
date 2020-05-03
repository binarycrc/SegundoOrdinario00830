namespace SegundoOrdinario00830
{
    partial class frmServidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDsc_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDsc_user_name = new System.Windows.Forms.TextBox();
            this.cbDsc_rol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDsc_apellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDsc_apellido1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDsc_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_alumno = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCan_horas = new System.Windows.Forms.TextBox();
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDsc_grado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDsc_curso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId_curso = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.gvRegistroNotas = new System.Windows.Forms.DataGridView();
            this.btnConsultarNotas = new System.Windows.Forms.Button();
            this.btnRegistrarNota = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNotaproyecto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNotaId_curso = new System.Windows.Forms.TextBox();
            this.txtNotaordinario2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNotaordinario1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotaId_alumno = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnValidarDenegar = new System.Windows.Forms.Button();
            this.btnValidarValidar = new System.Windows.Forms.Button();
            this.gvValidarAlumnos = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.btnValidarConsultarTodos = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistroNotas)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvValidarAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRegistrarAlumno);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDsc_password);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtDsc_user_name);
            this.tabPage1.Controls.Add(this.cbDsc_rol);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDsc_apellido2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDsc_apellido1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDsc_nombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtId_alumno);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro Alumno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(234, 147);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(157, 60);
            this.btnRegistrarAlumno.TabIndex = 14;
            this.btnRegistrarAlumno.Text = "Registrar";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contraseña";
            // 
            // txtDsc_password
            // 
            this.txtDsc_password.Location = new System.Drawing.Point(231, 69);
            this.txtDsc_password.Name = "txtDsc_password";
            this.txtDsc_password.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_password.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Usuario";
            // 
            // txtDsc_user_name
            // 
            this.txtDsc_user_name.Location = new System.Drawing.Point(231, 30);
            this.txtDsc_user_name.Name = "txtDsc_user_name";
            this.txtDsc_user_name.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_user_name.TabIndex = 10;
            // 
            // cbDsc_rol
            // 
            this.cbDsc_rol.AutoCompleteCustomSource.AddRange(new string[] {
            "PENDIENTE",
            "ESTUDIANTE",
            "DENEGADO"});
            this.cbDsc_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDsc_rol.FormattingEnabled = true;
            this.cbDsc_rol.Items.AddRange(new object[] {
            "ESTUDIANTE",
            "PENDIENTE",
            "DENEGADO"});
            this.cbDsc_rol.Location = new System.Drawing.Point(6, 186);
            this.cbDsc_rol.Name = "cbDsc_rol";
            this.cbDsc_rol.Size = new System.Drawing.Size(160, 21);
            this.cbDsc_rol.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtDsc_apellido2
            // 
            this.txtDsc_apellido2.Location = new System.Drawing.Point(6, 147);
            this.txtDsc_apellido2.Name = "txtDsc_apellido2";
            this.txtDsc_apellido2.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_apellido2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer Apellido";
            // 
            // txtDsc_apellido1
            // 
            this.txtDsc_apellido1.Location = new System.Drawing.Point(6, 108);
            this.txtDsc_apellido1.Name = "txtDsc_apellido1";
            this.txtDsc_apellido1.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_apellido1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtDsc_nombre
            // 
            this.txtDsc_nombre.Location = new System.Drawing.Point(6, 69);
            this.txtDsc_nombre.Name = "txtDsc_nombre";
            this.txtDsc_nombre.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificación";
            // 
            // txtId_alumno
            // 
            this.txtId_alumno.Location = new System.Drawing.Point(6, 30);
            this.txtId_alumno.Name = "txtId_alumno";
            this.txtId_alumno.Size = new System.Drawing.Size(160, 20);
            this.txtId_alumno.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtCan_horas);
            this.tabPage2.Controls.Add(this.btnRegistrarCurso);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDsc_grado);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDsc_curso);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtId_curso);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Cursos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cantidad Horas";
            // 
            // txtCan_horas
            // 
            this.txtCan_horas.Location = new System.Drawing.Point(6, 145);
            this.txtCan_horas.Name = "txtCan_horas";
            this.txtCan_horas.Size = new System.Drawing.Size(160, 20);
            this.txtCan_horas.TabIndex = 22;
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.Location = new System.Drawing.Point(214, 106);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(157, 60);
            this.btnRegistrarCurso.TabIndex = 21;
            this.btnRegistrarCurso.Text = "Registrar";
            this.btnRegistrarCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nivel";
            // 
            // txtDsc_grado
            // 
            this.txtDsc_grado.Location = new System.Drawing.Point(6, 106);
            this.txtDsc_grado.Name = "txtDsc_grado";
            this.txtDsc_grado.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_grado.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre Curso";
            // 
            // txtDsc_curso
            // 
            this.txtDsc_curso.Location = new System.Drawing.Point(6, 67);
            this.txtDsc_curso.Name = "txtDsc_curso";
            this.txtDsc_curso.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_curso.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Número Curso";
            // 
            // txtId_curso
            // 
            this.txtId_curso.Location = new System.Drawing.Point(6, 28);
            this.txtId_curso.Name = "txtId_curso";
            this.txtId_curso.Size = new System.Drawing.Size(160, 20);
            this.txtId_curso.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.gvRegistroNotas);
            this.tabPage3.Controls.Add(this.btnConsultarNotas);
            this.tabPage3.Controls.Add(this.btnRegistrarNota);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtNotaproyecto);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtNotaId_curso);
            this.tabPage3.Controls.Add(this.txtNotaordinario2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtNotaordinario1);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtNotaId_alumno);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(710, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registro Notas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Notas";
            // 
            // gvRegistroNotas
            // 
            this.gvRegistroNotas.AllowUserToAddRows = false;
            this.gvRegistroNotas.AllowUserToDeleteRows = false;
            this.gvRegistroNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRegistroNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvRegistroNotas.Location = new System.Drawing.Point(6, 106);
            this.gvRegistroNotas.Name = "gvRegistroNotas";
            this.gvRegistroNotas.Size = new System.Drawing.Size(698, 148);
            this.gvRegistroNotas.TabIndex = 27;
            // 
            // btnConsultarNotas
            // 
            this.btnConsultarNotas.Location = new System.Drawing.Point(549, 54);
            this.btnConsultarNotas.Name = "btnConsultarNotas";
            this.btnConsultarNotas.Size = new System.Drawing.Size(157, 36);
            this.btnConsultarNotas.TabIndex = 26;
            this.btnConsultarNotas.Text = "Consultar Notas";
            this.btnConsultarNotas.UseVisualStyleBackColor = true;
            this.btnConsultarNotas.Click += new System.EventHandler(this.btnConsultarNotas_Click);
            // 
            // btnRegistrarNota
            // 
            this.btnRegistrarNota.Location = new System.Drawing.Point(549, 12);
            this.btnRegistrarNota.Name = "btnRegistrarNota";
            this.btnRegistrarNota.Size = new System.Drawing.Size(157, 36);
            this.btnRegistrarNota.TabIndex = 25;
            this.btnRegistrarNota.Text = "Registrar";
            this.btnRegistrarNota.UseVisualStyleBackColor = true;
            this.btnRegistrarNota.Click += new System.EventHandler(this.btnRegistrarNota_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Nota Proyecto";
            // 
            // txtNotaproyecto
            // 
            this.txtNotaproyecto.Location = new System.Drawing.Point(372, 67);
            this.txtNotaproyecto.Name = "txtNotaproyecto";
            this.txtNotaproyecto.Size = new System.Drawing.Size(160, 20);
            this.txtNotaproyecto.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nota Ordinario 2";
            // 
            // txtNotaId_curso
            // 
            this.txtNotaId_curso.Location = new System.Drawing.Point(189, 28);
            this.txtNotaId_curso.Name = "txtNotaId_curso";
            this.txtNotaId_curso.Size = new System.Drawing.Size(160, 20);
            this.txtNotaId_curso.TabIndex = 21;
            // 
            // txtNotaordinario2
            // 
            this.txtNotaordinario2.Location = new System.Drawing.Point(189, 67);
            this.txtNotaordinario2.Name = "txtNotaordinario2";
            this.txtNotaordinario2.Size = new System.Drawing.Size(160, 20);
            this.txtNotaordinario2.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Curso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Nota Ordinario 1";
            // 
            // txtNotaordinario1
            // 
            this.txtNotaordinario1.Location = new System.Drawing.Point(6, 67);
            this.txtNotaordinario1.Name = "txtNotaordinario1";
            this.txtNotaordinario1.Size = new System.Drawing.Size(160, 20);
            this.txtNotaordinario1.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Alumno";
            // 
            // txtNotaId_alumno
            // 
            this.txtNotaId_alumno.Location = new System.Drawing.Point(6, 28);
            this.txtNotaId_alumno.Name = "txtNotaId_alumno";
            this.txtNotaId_alumno.Size = new System.Drawing.Size(160, 20);
            this.txtNotaId_alumno.TabIndex = 14;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnValidarDenegar);
            this.tabPage4.Controls.Add(this.btnValidarValidar);
            this.tabPage4.Controls.Add(this.gvValidarAlumnos);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.btnValidarConsultarTodos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(710, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Validar Alumnos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnValidarDenegar
            // 
            this.btnValidarDenegar.Location = new System.Drawing.Point(545, 214);
            this.btnValidarDenegar.Name = "btnValidarDenegar";
            this.btnValidarDenegar.Size = new System.Drawing.Size(157, 36);
            this.btnValidarDenegar.TabIndex = 30;
            this.btnValidarDenegar.Text = "Denegar";
            this.btnValidarDenegar.UseVisualStyleBackColor = true;
            this.btnValidarDenegar.Click += new System.EventHandler(this.btnValidarDenegar_Click);
            // 
            // btnValidarValidar
            // 
            this.btnValidarValidar.Location = new System.Drawing.Point(382, 214);
            this.btnValidarValidar.Name = "btnValidarValidar";
            this.btnValidarValidar.Size = new System.Drawing.Size(157, 36);
            this.btnValidarValidar.TabIndex = 29;
            this.btnValidarValidar.Text = "Validar";
            this.btnValidarValidar.UseVisualStyleBackColor = true;
            this.btnValidarValidar.Click += new System.EventHandler(this.btnValidarValidar_Click);
            // 
            // gvValidarAlumnos
            // 
            this.gvValidarAlumnos.AllowUserToAddRows = false;
            this.gvValidarAlumnos.AllowUserToDeleteRows = false;
            this.gvValidarAlumnos.AllowUserToResizeRows = false;
            this.gvValidarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvValidarAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvValidarAlumnos.Location = new System.Drawing.Point(9, 47);
            this.gvValidarAlumnos.MultiSelect = false;
            this.gvValidarAlumnos.Name = "gvValidarAlumnos";
            this.gvValidarAlumnos.Size = new System.Drawing.Size(693, 150);
            this.gvValidarAlumnos.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Alumnos Pendientes de Validar";
            // 
            // btnValidarConsultarTodos
            // 
            this.btnValidarConsultarTodos.Location = new System.Drawing.Point(545, 6);
            this.btnValidarConsultarTodos.Name = "btnValidarConsultarTodos";
            this.btnValidarConsultarTodos.Size = new System.Drawing.Size(157, 36);
            this.btnValidarConsultarTodos.TabIndex = 26;
            this.btnValidarConsultarTodos.Text = "Consultar Todos";
            this.btnValidarConsultarTodos.UseVisualStyleBackColor = true;
            this.btnValidarConsultarTodos.Click += new System.EventHandler(this.btnValidarConsultarTodos_Click);
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 305);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Servidor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistroNotas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvValidarAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDsc_apellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDsc_apellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDsc_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId_alumno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDsc_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDsc_user_name;
        private System.Windows.Forms.ComboBox cbDsc_rol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCan_horas;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDsc_grado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDsc_curso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId_curso;
        private System.Windows.Forms.TextBox txtNotaId_curso;
        private System.Windows.Forms.TextBox txtNotaordinario2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNotaordinario1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNotaId_alumno;
        private System.Windows.Forms.Button btnConsultarNotas;
        private System.Windows.Forms.Button btnRegistrarNota;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNotaproyecto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gvValidarAlumnos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnValidarConsultarTodos;
        private System.Windows.Forms.Button btnValidarDenegar;
        private System.Windows.Forms.Button btnValidarValidar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView gvRegistroNotas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

