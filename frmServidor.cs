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
    }
}
