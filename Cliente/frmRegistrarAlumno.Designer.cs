namespace Cliente
{
    partial class frmRegistrarAlumno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDsc_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDsc_user_name);
            this.groupBox1.Controls.Add(this.cbDsc_rol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDsc_apellido2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDsc_apellido1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDsc_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId_alumno);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Alumno";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(234, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 36);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(234, 110);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(157, 36);
            this.btnRegistrarAlumno.TabIndex = 29;
            this.btnRegistrarAlumno.Text = "Registrar";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Contraseña";
            // 
            // txtDsc_password
            // 
            this.txtDsc_password.Location = new System.Drawing.Point(231, 71);
            this.txtDsc_password.Name = "txtDsc_password";
            this.txtDsc_password.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_password.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Usuario";
            // 
            // txtDsc_user_name
            // 
            this.txtDsc_user_name.Location = new System.Drawing.Point(231, 32);
            this.txtDsc_user_name.Name = "txtDsc_user_name";
            this.txtDsc_user_name.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_user_name.TabIndex = 25;
            // 
            // cbDsc_rol
            // 
            this.cbDsc_rol.AutoCompleteCustomSource.AddRange(new string[] {
            "PENDIENTE",
            "ESTUDIANTE",
            "DENEGADO"});
            this.cbDsc_rol.FormattingEnabled = true;
            this.cbDsc_rol.Items.AddRange(new object[] {
            "PENDIENTE",
            "ESTUDIANTE",
            "DENEGADO"});
            this.cbDsc_rol.Location = new System.Drawing.Point(6, 188);
            this.cbDsc_rol.Name = "cbDsc_rol";
            this.cbDsc_rol.Size = new System.Drawing.Size(160, 21);
            this.cbDsc_rol.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtDsc_apellido2
            // 
            this.txtDsc_apellido2.Location = new System.Drawing.Point(6, 149);
            this.txtDsc_apellido2.Name = "txtDsc_apellido2";
            this.txtDsc_apellido2.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_apellido2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Primer Apellido";
            // 
            // txtDsc_apellido1
            // 
            this.txtDsc_apellido1.Location = new System.Drawing.Point(6, 110);
            this.txtDsc_apellido1.Name = "txtDsc_apellido1";
            this.txtDsc_apellido1.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_apellido1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // txtDsc_nombre
            // 
            this.txtDsc_nombre.Location = new System.Drawing.Point(6, 71);
            this.txtDsc_nombre.Name = "txtDsc_nombre";
            this.txtDsc_nombre.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_nombre.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Identificación";
            // 
            // txtId_alumno
            // 
            this.txtId_alumno.Location = new System.Drawing.Point(6, 32);
            this.txtId_alumno.Name = "txtId_alumno";
            this.txtId_alumno.Size = new System.Drawing.Size(160, 20);
            this.txtId_alumno.TabIndex = 15;
            // 
            // frmRegistrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarAlumno";
            this.Text = "Cliente - Registra Alumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDsc_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDsc_user_name;
        private System.Windows.Forms.ComboBox cbDsc_rol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDsc_apellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDsc_apellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDsc_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId_alumno;
    }
}