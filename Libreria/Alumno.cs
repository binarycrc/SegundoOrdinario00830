/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    /// <summary>
    /// Clase para Alumno
    /// </summary>
    [Serializable]
    public class Alumno
    {
        /// <summary>
        /// Campos privados de la clase
        /// </summary>
        string _id_alumno;
        string _dsc_nombre;
        string _dsc_apellido1;
        string _dsc_apellido2;
        string _dsc_user_name;
        string _dsc_password;
        string _dsc_rol;

        /// <summary>
        /// Constructor con todos los campos de la clase
        /// </summary>
        /// <param name="id_alumno"></param>
        /// <param name="dsc_nombre"></param>
        /// <param name="dsc_apellido1"></param>
        /// <param name="dsc_apellido2"></param>
        /// <param name="dsc_user_name"></param>
        /// <param name="dsc_password"></param>
        /// <param name="dsc_rol"></param>
        public Alumno(string id_alumno, string dsc_nombre, string dsc_apellido1, string dsc_apellido2, string dsc_user_name, string dsc_password, string dsc_rol)
        {
            ///Asignamos los valores del constructor de la clase
            ///a los campos mediante sets
            Id_alumno = id_alumno;
            Dsc_nombre = dsc_nombre;
            Dsc_apellido1 = dsc_apellido1;
            Dsc_apellido2 = dsc_apellido2;
            Dsc_user_name = dsc_user_name;
            Dsc_password = dsc_password;
            Dsc_rol = dsc_rol;
        }

        /// <summary>
        /// Encapsulamos los campos de la clase
        /// </summary>
        public string Id_alumno { get => _id_alumno; set => _id_alumno = value; }
        public string Dsc_nombre { get => _dsc_nombre; set => _dsc_nombre = value; }
        public string Dsc_apellido1 { get => _dsc_apellido1; set => _dsc_apellido1 = value; }
        public string Dsc_apellido2 { get => _dsc_apellido2; set => _dsc_apellido2 = value; }
        public string Dsc_user_name { get => _dsc_user_name; set => _dsc_user_name = value; }
        public string Dsc_password { get => _dsc_password; set => _dsc_password = value; }
        public string Dsc_rol { get => _dsc_rol; set => _dsc_rol = value; }
    }
}
