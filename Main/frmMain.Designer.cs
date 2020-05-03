namespace Main
{
    partial class frmMain
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
            this.btnAbrirServidor = new System.Windows.Forms.Button();
            this.btnAbrirCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirServidor
            // 
            this.btnAbrirServidor.Location = new System.Drawing.Point(39, 38);
            this.btnAbrirServidor.Name = "btnAbrirServidor";
            this.btnAbrirServidor.Size = new System.Drawing.Size(116, 23);
            this.btnAbrirServidor.TabIndex = 0;
            this.btnAbrirServidor.Text = "Abrir Servidor";
            this.btnAbrirServidor.UseVisualStyleBackColor = true;
            this.btnAbrirServidor.Click += new System.EventHandler(this.btnAbrirServidor_Click);
            // 
            // btnAbrirCliente
            // 
            this.btnAbrirCliente.Enabled = false;
            this.btnAbrirCliente.Location = new System.Drawing.Point(39, 67);
            this.btnAbrirCliente.Name = "btnAbrirCliente";
            this.btnAbrirCliente.Size = new System.Drawing.Size(116, 23);
            this.btnAbrirCliente.TabIndex = 1;
            this.btnAbrirCliente.Text = "Abrir Cliente";
            this.btnAbrirCliente.UseVisualStyleBackColor = true;
            this.btnAbrirCliente.Click += new System.EventHandler(this.btnAbrirCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(161, 49);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 130);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAbrirCliente);
            this.Controls.Add(this.btnAbrirServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirServidor;
        private System.Windows.Forms.Button btnAbrirCliente;
        private System.Windows.Forms.Button btnSalir;
    }
}

