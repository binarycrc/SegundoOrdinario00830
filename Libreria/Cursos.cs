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
    /// Clase para Cursos
    /// </summary>
    public class Cursos
    {
        /// <summary>
        /// Campos privados de la clase
        /// </summary>
        string _id_curso;
        string _dsc_curso;
        string _dsc_grado;
        string _can_horas;

        /// <summary>
        /// Constructor con todos los campos de la clase
        /// </summary>
        /// <param name="id_curso"></param>
        /// <param name="dsc_curso"></param>
        /// <param name="dsc_grado"></param>
        /// <param name="can_horas"></param>
        public Cursos(string id_curso, string dsc_curso, string dsc_grado, string can_horas)
        {
            ///Asignamos los valores del constructor de la clase
            ///a los campos mediante sets
            Id_curso = id_curso;
            Dsc_curso = dsc_curso;
            Dsc_grado = dsc_grado;
            Can_horas = can_horas;
        }

        /// <summary>
        /// Encapsulamos los campos de la clase
        /// </summary>
        public string Id_curso { get => _id_curso; set => _id_curso = value; }
        public string Dsc_curso { get => _dsc_curso; set => _dsc_curso = value; }
        public string Dsc_grado { get => _dsc_grado; set => _dsc_grado = value; }
        public string Can_horas { get => _can_horas; set => _can_horas = value; }
    }
}
