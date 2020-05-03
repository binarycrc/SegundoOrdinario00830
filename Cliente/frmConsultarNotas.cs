using Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmConsultarNotas : Form
    {
        Alumno alumno;
        DataLayer datalayer = new DataLayer();
        public frmConsultarNotas()
        {
            InitializeComponent();
        }
        public void CargaNotas(string Dsc_user_name, string Dsc_password) 
        {
            alumno = datalayer.GetAlumno(Dsc_user_name, Dsc_password);
            //MessageBox.Show("adentro " + alumno.Dsc_nombre);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
