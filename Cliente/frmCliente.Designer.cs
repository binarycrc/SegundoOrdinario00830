namespace Cliente
{
    partial class frmCliente
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
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDsc_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDsc_user_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkRegistrarse);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnIngresarCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDsc_password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDsc_user_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.Location = new System.Drawing.Point(57, 139);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(60, 13);
            this.linkRegistrarse.TabIndex = 21;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "Registrarse";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrarse_LinkClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(91, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Location = new System.Drawing.Point(9, 97);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarCliente.TabIndex = 19;
            this.btnIngresarCliente.Text = "Ingresar";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contraseña";
            // 
            // txtDsc_password
            // 
            this.txtDsc_password.Location = new System.Drawing.Point(6, 71);
            this.txtDsc_password.Name = "txtDsc_password";
            this.txtDsc_password.PasswordChar = '*';
            this.txtDsc_password.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_password.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario";
            // 
            // txtDsc_user_name
            // 
            this.txtDsc_user_name.Location = new System.Drawing.Point(6, 32);
            this.txtDsc_user_name.Name = "txtDsc_user_name";
            this.txtDsc_user_name.Size = new System.Drawing.Size(160, 20);
            this.txtDsc_user_name.TabIndex = 15;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 223);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cliente - Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDsc_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDsc_user_name;
    }
}

