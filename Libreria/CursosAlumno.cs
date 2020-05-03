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
    /// Clase para CursosAlumno
    /// </summary>
    public class CursosAlumno
    {
        /// <summary>
        /// Campos privados de la clase
        /// </summary>
        string _id_curso;
        string _id_alumno;
        string _notaordinario1;
        string _notaordinario2;
        string _notaproyecto;

        /// <summary>
        /// Constructor con todos los campos de la clase
        /// </summary>
        /// <param name="id_curso"></param>
        /// <param name="id_alumno"></param>
        /// <param name="notaordinario1"></param>
        /// <param name="notaordinario2"></param>
        /// <param name="notaproyecto"></param>
        public CursosAlumno(string id_curso, string id_alumno, string notaordinario1, string notaordinario2, string notaproyecto)
        {
            ///Asignamos los valores del constructor de la clase
            ///a los campos mediante sets
            Id_curso = id_curso;
            Id_alumno = id_alumno;
            Notaordinario1 = notaordinario1;
            Notaordinario2 = notaordinario2;
            Notaproyecto = notaproyecto;
        }

        /// <summary>
        /// Encapsulamos los campos de la clase
        /// </summary>
        public string Id_curso { get => _id_curso; set => _id_curso = value; }
        public string Id_alumno { get => _id_alumno; set => _id_alumno = value; }
        public string Notaordinario1 { get => _notaordinario1; set => _notaordinario1 = value; }
        public string Notaordinario2 { get => _notaordinario2; set => _notaordinario2 = value; }
        public string Notaproyecto { get => _notaproyecto; set => _notaproyecto = value; }
    }
}
