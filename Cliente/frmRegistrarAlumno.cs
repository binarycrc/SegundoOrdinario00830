using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Libreria;

namespace Cliente
{
    public partial class frmRegistrarAlumno : Form
    {
        //bool clienteConectado;
        IPAddress ipServidor = IPAddress.Parse("127.0.0.1");
        int intPort = 30000;

        TcpClient cliente;
        BinaryWriter escritor;
        BinaryReader lector;
        public frmRegistrarAlumno()
        {
            InitializeComponent();
            try
            {
                cliente = new TcpClient();
                IPEndPoint serverEndPoint = new IPEndPoint(ipServidor, intPort);

                cliente.Connect(serverEndPoint);
            }
            catch (Exception)
            {

                throw;
            }
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

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream clienteStream = cliente.GetStream();
                escritor = new BinaryWriter(clienteStream);
                lector = new BinaryReader(clienteStream);
                clienteStream.Flush();
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                Alumno alumno = new Alumno(
                                txtId_alumno.Text,
                                txtDsc_nombre.Text.Trim(),
                                txtDsc_apellido1.Text.Trim(),
                                txtDsc_apellido2.Text.Trim(),
                                txtDsc_user_name.Text.Trim(),
                                txtDsc_password.Text.Trim(),
                                cbDsc_rol.SelectedItem.ToString().Trim()
                            );

                escritor.Write("registraralumno");
                binaryFormatter.Serialize(clienteStream,alumno);
                String respuesta = lector.ReadString();

                switch (respuesta)
                {
                    case "OK":
                        MessageBox.Show("Alumno creado!");
                        break;

                    case "ExistenteAlumno":
                        MessageBox.Show("El alumno con la identificacion "+ txtId_alumno.Text + ", ya existe!");
                        break;

                    case "ExistenteUserName":
                        MessageBox.Show("El alumno con el Usuario " + txtDsc_user_name.Text + ", ya existe!");
                        break;

                    default:
                        MessageBox.Show(respuesta);
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
