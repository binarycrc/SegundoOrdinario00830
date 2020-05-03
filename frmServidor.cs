/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/
using Libreria;
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
using System.Threading;
using System.Windows.Forms;

namespace SegundoOrdinario00830
{
    public partial class frmServidor : Form
    {
        TcpListener tcpListener;
        Thread subprocesoEscuchaClientes;
        bool servidorIniciado;
        IPAddress local = IPAddress.Parse("127.0.0.1");
        int intPort = 30000;
        DataLayer datalayer = new DataLayer();

        public frmServidor()
        {
            InitializeComponent();
            try
            {
                if (tcpListener == null)
                {
                    tcpListener = new TcpListener(local, intPort);
                    Thread.Sleep(500);
                }

                subprocesoEscuchaClientes = new Thread(new ThreadStart(EscuchaClientes));
                subprocesoEscuchaClientes.IsBackground = true;
                subprocesoEscuchaClientes.Start();

                servidorIniciado = true;
                cbDsc_rol.SelectedIndex = cbDsc_rol.FindStringExact("ESTUDIANTE");
            }
            catch (ThreadAbortException) { }
            catch (Exception) { }
        }

        private void EscuchaClientes()
        {
            try
            {
                tcpListener.Start();
                while (servidorIniciado)
                {
                    TcpClient cliente = tcpListener.AcceptTcpClient();
                    Thread clienteThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                    clienteThread.Start(cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComunicacionCliente(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            NetworkStream clienteStream = tcpClient.GetStream();
            BinaryWriter escritor = new BinaryWriter(clienteStream);
            BinaryReader lector = new BinaryReader(clienteStream);
            BinaryFormatter bf = new BinaryFormatter();
            clienteStream.Flush();

            String accion;
            while (servidorIniciado)
            {
                try
                {
                    accion = lector.ReadString();
                    switch (accion)
                    {
                        case "loginalumno":
                            String Dsc_user_name = lector.ReadString();
                            String Dsc_password = lector.ReadString();
                            string resultadoLogin = datalayer.LoginAlumno(Dsc_user_name, Dsc_password);
                            escritor.Write(resultadoLogin);
                            break;

                        case "registraralumno":
                            Alumno alumno = (Alumno)(bf.Deserialize(clienteStream));
                            string resultadoRegistrarAlumno = datalayer.RegistrarAlumno(alumno);
                            escritor.Write(resultadoRegistrarAlumno);
                            break;

                        default:
                            Console.WriteLine("Nothing");
                            break;
                    }
                }
                catch (Exception)
                {
                    break;
                }
                //lastMessage = textoleido; // encoder.GetString(message, 0, byteleidos);
                //MessageBox.Show(string.Format("el cliente {0} se ha conectado", mensaje, "Cliente conectado", MessageBoxButtons.OK, MessageBoxIcon.Information));
                //listClientesConectados.Invoke(modificarListBoxClientes, new object[] { lastMessage });
            }
            tcpClient.Close();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno(
                                txtId_alumno.Text,
                                txtDsc_nombre.Text.Trim(),
                                txtDsc_apellido1.Text.Trim(),
                                txtDsc_apellido2.Text.Trim(),
                                txtDsc_user_name.Text.Trim(),
                                txtDsc_password.Text.Trim(),
                                cbDsc_rol.SelectedItem.ToString().Trim()
                            );
                string respuesta = datalayer.RegistrarAlumno(alumno);

                switch (respuesta)
                {
                    case "OK":
                        MessageBox.Show("Alumno creado!");
                        break;

                    case "ExistenteAlumno":
                        MessageBox.Show("El alumno con la identificacion " + txtId_alumno.Text + ", ya existe!");
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

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Cursos cursos = new Cursos(
                    txtId_curso.Text.Trim(), txtDsc_curso.Text.Trim(),
                    txtDsc_grado.Text.Trim(), txtCan_horas.Text.Trim()
                    );
                string respuesta = datalayer.RegistrarCursos(cursos);

                switch (respuesta)
                {
                    case "OK":
                        MessageBox.Show("Curso creado!");
                        break;

                    case "ExistenteCursos":
                        MessageBox.Show("El curso con el número " + txtId_curso.Text + ", ya existe!");
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

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            try
            {
                CursosAlumno cursosAlumno = new CursosAlumno(
                    txtNotaId_curso.Text.Trim(),
                    txtNotaId_alumno.Text.Trim(),
                    txtNotaordinario1.Text.Trim(),
                    txtNotaordinario2.Text.Trim(),
                    txtNotaproyecto.Text.Trim()
                    );

                string respuesta = datalayer.RegistrarCursosAlumno(cursosAlumno);

                switch (respuesta)
                {
                    case "OK":
                        MessageBox.Show("Nota Ingresada!");
                        break;

                    case "ExistenteCursosAlumno":
                        MessageBox.Show("La Nota para ese Alumno ya existe!");
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

        private void btnConsultarNotas_Click(object sender, EventArgs e)
        {
            try
            {
                gvRegistroNotas.DataSource = datalayer.ConsultarCursosAlumno(txtNotaId_curso.Text.Trim(),txtNotaId_alumno.Text.Trim());
                gvRegistroNotas.Update();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnValidarConsultarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                gvValidarAlumnos.DataSource = datalayer.ConsultarAlumnos();
                gvRegistroNotas.Update();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnValidarValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedId_alumno;
                if (gvValidarAlumnos.SelectedCells.Count > 0)
                {
                    int selectedrowindex = gvValidarAlumnos.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gvValidarAlumnos.Rows[selectedrowindex];
                    selectedId_alumno = Convert.ToString(selectedRow.Cells["Id_alumno"].Value);

                    datalayer.ValidarAlumno(selectedId_alumno, "ESTUDIANTE");
                    btnValidarConsultarTodos_Click(sender, e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnValidarDenegar_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedId_alumno;
                if (gvValidarAlumnos.SelectedCells.Count > 0)
                {
                    int selectedrowindex = gvValidarAlumnos.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gvValidarAlumnos.Rows[selectedrowindex];
                    selectedId_alumno = Convert.ToString(selectedRow.Cells["Id_alumno"].Value);

                    datalayer.ValidarAlumno(selectedId_alumno, "DENEGADO");
                    btnValidarConsultarTodos_Click(sender, e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
