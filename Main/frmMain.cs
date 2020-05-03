using Cliente;
using SegundoOrdinario00830;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo para abrir una unica ventana de servidor 
        /// desde el form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirServidor_Click(object sender, EventArgs e)
        {
            try
            {
                ///si ya existe un form de servidor
                if (Application.OpenForms.OfType<frmServidor>().Count() == 1)
                {
                    ///ubicamos el form abierto activo
                    var form = Application.OpenForms.OfType<frmServidor>().FirstOrDefault();
                    form.Activate();
                    //Application.OpenForms.OfType<frmServidor>().First().Close();
                    btnAbrirCliente.Enabled = true;
                }
                else
                {
                    ///sino abrimos un form de servidor nuevo
                    frmServidor frmservidor = new frmServidor();
                    frmservidor.StartPosition = FormStartPosition.Manual;
                    frmservidor.Location = new Point(
                        0, 0
                        );
                    frmservidor.Show();
                    btnAbrirCliente.Enabled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para abrir una ventada de cliente
        /// desde el form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente frmclient = new frmCliente();
                frmclient.Show();
                frmclient.StartPosition = FormStartPosition.Manual;
                frmclient.Location = new Point(
                    Screen.PrimaryScreen.WorkingArea.Width - frmclient.Width,
                    Screen.PrimaryScreen.WorkingArea.Height - frmclient.Height);
                frmclient.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para cerrar la aplicacion completamente
        /// desde el boton SALIR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {

                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Metodo para cerrar la aplicacion completamente
        /// desde la X del form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            Environment.Exit(0);
        }

        
    }
}
