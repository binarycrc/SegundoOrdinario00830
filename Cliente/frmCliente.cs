/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmCliente : Form
    {
        //bool clienteConectado;
        IPAddress ipServidor = IPAddress.Parse("127.0.0.1");
        int intPort = 30000;

        TcpClient cliente;
        BinaryWriter escritor;
        BinaryReader lector;
        public frmCliente()
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

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmRegistrarAlumno registrarAlumno = new frmRegistrarAlumno();
                registrarAlumno.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream clienteStream = cliente.GetStream();
                escritor = new BinaryWriter(clienteStream);
                lector = new BinaryReader(clienteStream);
                clienteStream.Flush();
                escritor.Write("loginalumno");
                escritor.Write(txtDsc_user_name.Text.Trim());
                escritor.Write(txtDsc_password.Text.Trim());

                string respuesta = lector.ReadString();

                //MessageBox.Show(respuesta);

                switch (respuesta)
                {
                    case "OK":
                        
                        frmConsultarNotas consultarNotas = new frmConsultarNotas();
                        consultarNotas.CargaNotas(txtDsc_user_name.Text.Trim(), txtDsc_password.Text.Trim());
                        //txtDsc_user_name.Text.Trim(), txtDsc_password.Text.Trim()
                        this.Close();
                        consultarNotas.Show();
                        break;

                    case "Denegado":
                        MessageBox.Show("Acceso denegado o Usuario no existe!");
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
