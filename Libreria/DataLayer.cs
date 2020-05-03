/*********************************************************************
 * Copyright 2020 Pablo Ugalde
 * Universidad Estatal A Distancia
 * PRIMER CUATRI-2020 00830 PROGRAMACION AVANZADA
 * 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class DataLayer
    {
        #region "Definicion de variables"
        public static SqlConnection sqlConnData = new SqlConnection(); //connector a la base de datos
        public string _LatestError = ""; //campo publico para mostrar mensajes de la clase
        public static string _ServerDataSource = "BINARYCRCD2"; //campo para el datasourse usado en la coneccion a la base de datos
        public static string _ServerInitialCatalog = "Notas"; //campo para el catalogo/base de datos usado en la coneccion
        //String de coneccion a la base de datos con los valores por defecto
        public static string _DBConnectionString = "Data Source=" + _ServerDataSource + ";Initial Catalog=" + _ServerInitialCatalog + ";Trusted_Connection=yes;";
        #endregion //Definicion de variables

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public DataLayer() { }
        /// <summary>
        /// Constructor de la clase con los valores de datasourse y catalogo
        /// </summary>
        /// <param name="ServerDataSource"></param>
        /// <param name="ServerInitialCatalog"></param>
        public DataLayer(string ServerDataSource, string ServerInitialCatalog)
        {
            //Asignamos los valores a los campos
            _ServerDataSource = ServerDataSource;
            _ServerInitialCatalog = ServerInitialCatalog;
            _DBConnectionString = "Data Source=" + _ServerDataSource + ";Initial Catalog=" + _ServerInitialCatalog + ";Trusted_Connection=yes;";
        }

        #region "Connection open and close"
        /// <summary>
        /// Metodo para abrir la coneccion a la base de datos
        /// </summary>
        /// <param name="strType"></param>
        /// <returns></returns>
        public bool OpenData(string strType)
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                //si el tipo de comando es un store procedure
                if (strType == "sp") { commandData.CommandType = CommandType.StoredProcedure; }
                //sino es un query
                else { commandData.CommandType = CommandType.Text; }
                //asignamos el string de coneccion al comando de coneccion
                sqlConnData.ConnectionString = _DBConnectionString;
                commandData.Connection = sqlConnData;
                //si la coneccion no esta abierta entonces la abrimos
                if (sqlConnData.State != ConnectionState.Open) { sqlConnData.Open(); }
                // si la coneccion esta abierta entonces retornamos el valor de true
                if (sqlConnData.State == ConnectionState.Open) { return true; }
                // si no se pudo abrir o no esta abierta retornamos el valor de false
                else { return false; }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
                return false; //retornamos el valor de false
            }
        }
        /// <summary>
        /// Metodo para cerrar la coneccion a la base de datos
        /// </summary>
        public void CloseData()
        {
            try
            {
                sqlConnData.Close();
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
            }
        }
        /// <summary>
        /// Metodo para probar la coneccion a la base de datos
        /// </summary>
        /// <returns></returns>
        public bool testData()
        {
            //por defecto el valor retornado seria false
            bool result = false;
            try
            {
                CloseData(); //cerramos la coneccion
                if (OpenData("query")) //tratatomos de abrir la coneccion
                {
                    CloseData(); // si se logro abrir entonces la cerramos
                    result = true; //retornamos el valor de true
                }
                else
                    result = false; //si no se logro abrir retornamos el valor false
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
                result = false; // retornamos el valor de false
            }
            return result;
        }
        #endregion //"Connection open and close"

        #region "Alumno"
        
        public string LoginAlumno(string dsc_user_name, string dsc_password)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query"); //abrimos la coneccion a la base de datos
                commandData = new System.Data.SqlClient.SqlCommand("select * from Alumno with(nolock) " +
                    "where Dsc_rol = 'ESTUDIANTE' and Dsc_user_name = @Dsc_user_name and Dsc_password = @Dsc_password", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos el parametro al query con el valor requerido
                commandData.Parameters.Add("@Dsc_user_name", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Dsc_user_name"].Value = dsc_user_name.Trim();
                commandData.Parameters.Add("@Dsc_password", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Dsc_password"].Value = dsc_password.Trim();
                reader = commandData.ExecuteReader(); //cargamos el resultado del query al reader
                if (reader.HasRows) //si existen registros
                {
                    reader.Close(); //cerramos el reader
                    CloseData();// si se logro abrir entonces la cerramos
                    return "OK"; // retornamos el valor de true
                }
                else
                {
                    reader.Close(); //cerramos el reader
                    CloseData(); //cerramos la coneccion a la base de datos
                    return "Denegado"; // retornamos el valor de false
                }
            }
            catch (Exception ex)
            {
                CloseData(); //cerramos la base de datos
                return "Error -"+ ex.Message; //retornamos el valor false
            }
        }

        public string RegistrarAlumno(Alumno alumno)
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                //query para insertar condutor
                commandData = new System.Data.SqlClient.SqlCommand("INSERT INTO [dbo].[Alumno]" +
                    "([Id_alumno],[Dsc_nombre],[Dsc_apellido1],[Dsc_apellido2],[Dsc_user_name],[Dsc_password],[Dsc_rol])" +
                    "VALUES(@Id_alumno, @Dsc_nombre, @Dsc_apellido1, @Dsc_apellido2, @Dsc_user_name, @Dsc_password, @Dsc_rol)", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos los parametros al query con el valor requerido
                commandData.Parameters.Add("@Id_alumno", System.Data.SqlDbType.VarChar,10);
                commandData.Parameters["@Id_alumno"].Value = alumno.Id_alumno;
                commandData.Parameters.Add("@Dsc_nombre", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_nombre"].Value = alumno.Dsc_nombre.Trim();
                commandData.Parameters.Add("@Dsc_apellido1", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_apellido1"].Value = alumno.Dsc_apellido1.Trim();
                commandData.Parameters.Add("@Dsc_apellido2", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_apellido2"].Value = alumno.Dsc_apellido2.Trim();
                commandData.Parameters.Add("@Dsc_user_name", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_user_name"].Value = alumno.Dsc_user_name.Trim();
                commandData.Parameters.Add("@Dsc_password", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_password"].Value = alumno.Dsc_password.Trim();
                commandData.Parameters.Add("@Dsc_rol", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_rol"].Value = alumno.Dsc_rol.Trim();

                if (ExisteAlumno(alumno.Id_alumno) == false) //buscamos si existe el alumno
                {
                    if (ExisteUserName(alumno.Dsc_user_name) == false) //buscamos si existe el alumno
                    {
                        OpenData("query"); //abrimos la base de datos
                        commandData.ExecuteNonQuery(); //ejecutamos el query en la base de datos con todos los parametros
                        CloseData();// cerramos la coneccion a la base de datos
                        return "OK"; //retornamos el valor de true si todo salio bien
                    }
                    else
                    {
                        return "ExistenteUserName"; //retornamos el valor de false si el conductor ya existe
                    }
                }
                else
                {
                    return "ExistenteAlumno"; //retornamos el valor de false si el conductor ya existe
                }
            }
            catch (Exception ex)
            {
                CloseData(); //cerramos la coneccion a la base de datos
                return "Error - "+ ex.Message;  // retornamos el valor de false si hay algun error
            }
        }

        public bool ExisteAlumno(string Id_alumno)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query"); //abrimos la coneccion a la base de datos
                commandData = new System.Data.SqlClient.SqlCommand("select * from Alumno with(nolock) where Id_alumno = @Id_alumno", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos el parametro al query con el valor requerido
                commandData.Parameters.Add("@Id_alumno", System.Data.SqlDbType.VarChar,10);
                commandData.Parameters["@Id_alumno"].Value = Id_alumno;
                reader = commandData.ExecuteReader(); //cargamos el resultado del query al reader
                if (reader.HasRows) //si existen registros
                {
                    reader.Close(); //cerramos el reader
                    CloseData();// si se logro abrir entonces la cerramos
                    return true; // retornamos el valor de true
                }
                else
                {
                    reader.Close(); //cerramos el reader
                    CloseData(); //cerramos la coneccion a la base de datos
                    return false; // retornamos el valor de false
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
                CloseData(); //cerramos la base de datos
                return false; //retornamos el valor false
            }

        }

        public bool ExisteUserName(string Dsc_user_name)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query"); //abrimos la coneccion a la base de datos
                commandData = new System.Data.SqlClient.SqlCommand("select * from Alumno with(nolock) where Dsc_user_name = @Dsc_user_name", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos el parametro al query con el valor requerido
                commandData.Parameters.Add("@Dsc_user_name", System.Data.SqlDbType.VarChar,50);
                commandData.Parameters["@Dsc_user_name"].Value = Dsc_user_name;
                reader = commandData.ExecuteReader(); //cargamos el resultado del query al reader
                if (reader.HasRows) //si existen registros
                {
                    reader.Close(); //cerramos el reader
                    CloseData();// si se logro abrir entonces la cerramos
                    return true; // retornamos el valor de true
                }
                else
                {
                    reader.Close(); //cerramos el reader
                    CloseData(); //cerramos la coneccion a la base de datos
                    return false; // retornamos el valor de false
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
                CloseData(); //cerramos la base de datos
                return false; //retornamos el valor false
            }

        }
        public Alumno GetAlumno(string dsc_user_name, string dsc_password)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            Alumno retorno= null;
            try
            {
                OpenData("query"); //abrimos la coneccion a la base de datos
                commandData = new System.Data.SqlClient.SqlCommand("select " +
                    "[Id_alumno],[Dsc_nombre],[Dsc_apellido1],[Dsc_apellido2],[Dsc_user_name],[Dsc_password],[Dsc_rol]" +
                    "from Alumno with(nolock) " +
                    "where Dsc_user_name = @Dsc_user_name and Dsc_password = @Dsc_password", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos el parametro al query con el valor requerido
                commandData.Parameters.Add("@Dsc_user_name", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_user_name"].Value = dsc_user_name.Trim();
                commandData.Parameters.Add("@Dsc_password", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_password"].Value = dsc_password.Trim();
                reader = commandData.ExecuteReader(); //cargamos el resultado del query al reader
                if (reader.HasRows) //si existen registros
                {
                    while (reader.Read())//leemos cada registro
                    {
                        // Creamos la instancia para la clase Conductor
                        // con los datos del query
                        Alumno alumno = new Alumno(reader["Id_alumno"].ToString()
                            , reader["Dsc_nombre"].ToString()
                            , reader["Dsc_apellido1"].ToString()
                            , reader["Dsc_apellido2"].ToString()
                            , reader["Dsc_user_name"].ToString()
                            , reader["Dsc_password"].ToString()
                            , reader["Dsc_rol"].ToString()
                            );
                        retorno = alumno;
                    }
                    reader.Close(); //cerramos el reader
                    CloseData();// si se logro abrir entonces la cerramos
                    return retorno; // retornamos el valor de true
                }
                else
                {
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                CloseData(); //cerramos la base de datos
                return retorno;
            }
        }
        #endregion //"Alumno"

        #region "Cursos"
        public string RegistrarCursos(Cursos cursos)
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                //query para insertar condutor
                commandData = new System.Data.SqlClient.SqlCommand("INSERT INTO [dbo].[Cursos]" +
                    "([Id_curso],[Dsc_curso],[Dsc_Grado],[Can_Horas])" +
                    "VALUES(@Id_curso, @Dsc_curso, @Dsc_grado, @Can_horas)", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos los parametros al query con el valor requerido
                commandData.Parameters.Add("@Id_curso", System.Data.SqlDbType.VarChar,10);
                commandData.Parameters["@Id_curso"].Value = cursos.Id_curso;
                commandData.Parameters.Add("@Dsc_curso", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_curso"].Value = cursos.Dsc_curso.Trim();
                commandData.Parameters.Add("@Dsc_Grado", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_Grado"].Value = cursos.Dsc_grado.Trim();
                commandData.Parameters.Add("@Can_horas", System.Data.SqlDbType.VarChar,2);
                commandData.Parameters["@Can_horas"].Value = cursos.Can_horas;

                if (ExisteCursos(cursos.Id_curso) == false) //buscamos si existe el alumno
                {
                        OpenData("query"); //abrimos la base de datos
                        commandData.ExecuteNonQuery(); //ejecutamos el query en la base de datos con todos los parametros
                        CloseData();// cerramos la coneccion a la base de datos
                        return "OK"; //retornamos el valor de true si todo salio bien
                }
                else
                {
                    return "ExistenteCursos"; //retornamos el valor de false si el conductor ya existe
                }
            }
            catch (Exception ex)
            {
                CloseData(); //cerramos la coneccion a la base de datos
                return "Error - " + ex.Message;  // retornamos el valor de false si hay algun error
            }
        }
        public bool ExisteCursos(string Id_curso)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query"); //abrimos la coneccion a la base de datos
                commandData = new System.Data.SqlClient.SqlCommand("select * from Cursos with(nolock) where Id_curso = @Id_curso", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos el parametro al query con el valor requerido
                commandData.Parameters.Add("@Id_curso", System.Data.SqlDbType.VarChar,10);
                commandData.Parameters["@Id_curso"].Value = Id_curso;
                reader = commandData.ExecuteReader(); //cargamos el resultado del query al reader
                if (reader.HasRows) //si existen registros
                {
                    reader.Close(); //cerramos el reader
                    CloseData();// si se logro abrir entonces la cerramos
                    return true; // retornamos el valor de true
                }
                else
                {
                    reader.Close(); //cerramos el reader
                    CloseData(); //cerramos la coneccion a la base de datos
                    return false; // retornamos el valor de false
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
                CloseData(); //cerramos la base de datos
                return false; //retornamos el valor false
            }

        }
        #endregion //"Cursos"

        #region "CursosAlumno"
        public string RegistrarCursosAlumno(CursosAlumno cursosAlumno)
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                //query para insertar condutor
                commandData = new System.Data.SqlClient.SqlCommand("INSERT INTO [dbo].[CursosAlumno]" +
                    "([Id_curso],[Id_alumno],[NotaOrdinario1],[NotaOrdinario2],[NotaProyecto])" +
                    "VALUES(@Id_curso, @Id_alumno, @NotaOrdinario1, @NotaOrdinario2, @NotaProyecto)", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos los parametros al query con el valor requerido
                commandData.Parameters.Add("@Id_curso", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Id_curso"].Value = cursosAlumno.Id_curso;
                commandData.Parameters.Add("@Id_alumno", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Id_alumno"].Value = cursosAlumno.Id_alumno.Trim();
                commandData.Parameters.Add("@NotaOrdinario1", System.Data.SqlDbType.VarChar, 6);
                commandData.Parameters["@NotaOrdinario1"].Value = cursosAlumno.Notaordinario1.Trim();
                commandData.Parameters.Add("@NotaOrdinario2", System.Data.SqlDbType.VarChar, 6);
                commandData.Parameters["@NotaOrdinario2"].Value = cursosAlumno.Notaordinario2;
                commandData.Parameters.Add("@NotaProyecto", System.Data.SqlDbType.VarChar, 6);
                commandData.Parameters["@NotaProyecto"].Value = cursosAlumno.Notaproyecto;

                if (ExisteCursosAlumno(cursosAlumno.Id_curso, cursosAlumno.Id_alumno) == false) //buscamos si existe el alumno
                {
                    OpenData("query"); //abrimos la base de datos
                    commandData.ExecuteNonQuery(); //ejecutamos el query en la base de datos con todos los parametros
                    CloseData();// cerramos la coneccion a la base de datos
                    return "OK"; //retornamos el valor de true si todo salio bien
                }
                else
                {
                    return "ExistenteCursosAlumno"; //retornamos el valor de false si el conductor ya existe
                }
            }
            catch (Exception ex)
            {
                CloseData(); //cerramos la coneccion a la base de datos
                return "Error - " + ex.Message;  // retornamos el valor de false si hay algun error
            }
        }

        public bool ExisteCursosAlumno(string Id_curso, string Id_alumno)
        {
            SqlCommand commandData = new SqlCommand();
            SqlDataReader reader;
            try
            {
                OpenData("query"); //abrimos la coneccion a la base de datos
                commandData = new System.Data.SqlClient.SqlCommand("select * from CursosAlumno with(nolock) " +
                    "where Id_curso = @Id_curso and Id_alumno = @Id_alumno", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos el parametro al query con el valor requerido
                commandData.Parameters.Add("@Id_curso", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Id_curso"].Value = Id_curso;
                commandData.Parameters.Add("@Id_curso", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Id_curso"].Value = Id_alumno;
                reader = commandData.ExecuteReader(); //cargamos el resultado del query al reader
                if (reader.HasRows) //si existen registros
                {
                    reader.Close(); //cerramos el reader
                    CloseData();// si se logro abrir entonces la cerramos
                    return true; // retornamos el valor de true
                }
                else
                {
                    reader.Close(); //cerramos el reader
                    CloseData(); //cerramos la coneccion a la base de datos
                    return false; // retornamos el valor de false
                }
            }
            catch (Exception ex)
            {
                _LatestError = ex.Message;//si existe algun error se muestra un mensaje
                CloseData(); //cerramos la base de datos
                return false; //retornamos el valor false
            }

        }

        public DataTable ConsultarCursosAlumno(string Id_curso, string Id_alumno)
        {
            SqlCommand commandData = new SqlCommand();
            System.Data.DataSet ds = new System.Data.DataSet();
            DataTable dt = new DataTable();
            OpenData("query");
            string sqlconsulta = " select a.Dsc_nombre as nombre, a.Dsc_apellido1 as apellido1, " +
                " a.Dsc_apellido2 as apellido2, c.Dsc_curso as curso, ca.NotaOrdinario1 as NotaOrdinario1, " +
                " ca.NotaOrdinario2 as NotaOrdinario2, ca.NotaProyecto as NotaProyecto " +
                " from CursosAlumno ca with(nolock), Alumno a with(nolock), Cursos c with(nolock) " +
                " where ca.Id_alumno = a.Id_alumno and ca.Id_curso = c.Id_curso ";

            
            if (!String.IsNullOrEmpty(Id_curso))
            { 
                sqlconsulta += " and ca.Id_curso = '" + Id_curso+"'";
            }
            if (!String.IsNullOrEmpty(Id_alumno)) 
            { 
                sqlconsulta += " and ca.Id_alumno = '"+ Id_alumno+"'";
            }


            commandData = new System.Data.SqlClient.SqlCommand(sqlconsulta, sqlConnData);
            commandData.CommandType = CommandType.Text;
            //agregamos el parametro al query con el valor requerido
            
            SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(commandData);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                da.Dispose();
            }
            CloseData();
            return dt;
        }
        public DataTable ConsultarAlumnos()
        {
            SqlCommand commandData = new SqlCommand();
            System.Data.DataSet ds = new System.Data.DataSet();
            DataTable dt = new DataTable();
            OpenData("query");
            string sqlconsulta = " SELECT [Id_alumno],[Dsc_nombre],[Dsc_apellido1],[Dsc_apellido2] " +
                " ,[Dsc_user_name],[Dsc_password],[Dsc_rol] " +
                " FROM[dbo].[Alumno] with(nolock) ";

            commandData = new System.Data.SqlClient.SqlCommand(sqlconsulta, sqlConnData);
            commandData.CommandType = CommandType.Text;
            //agregamos el parametro al query con el valor requerido

            SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(commandData);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                da.Dispose();
            }
            CloseData();
            return dt;
        }

        public string ValidarAlumno(string Id_alumno, string Dsc_rol)
        {
            SqlCommand commandData = new SqlCommand();
            try
            {
                //query para insertar condutor
                commandData = new System.Data.SqlClient.SqlCommand("UPDATE [dbo].[Alumno]" +
                    "SET[Dsc_rol] = @Dsc_rol  WHERE Id_alumno = @Id_alumno", sqlConnData);
                commandData.CommandType = CommandType.Text;
                //agregamos los parametros al query con el valor requerido
                commandData.Parameters.Add("@Id_alumno", System.Data.SqlDbType.VarChar, 10);
                commandData.Parameters["@Id_alumno"].Value = Id_alumno;
                commandData.Parameters.Add("@Dsc_rol", System.Data.SqlDbType.VarChar, 50);
                commandData.Parameters["@Dsc_rol"].Value = Dsc_rol;

                if (ExisteAlumno(Id_alumno)) //buscamos si existe el alumno
                {
                    OpenData("query"); //abrimos la base de datos
                    commandData.ExecuteNonQuery(); //ejecutamos el query en la base de datos con todos los parametros
                    CloseData();// cerramos la coneccion a la base de datos
                    return "OK"; //retornamos el valor de true si todo salio bien
                }
                else
                {
                    return "ExistenteAlumno"; //retornamos el valor de false si el conductor ya existe
                }
            }
            catch (Exception ex)
            {
                CloseData(); //cerramos la coneccion a la base de datos
                return "Error - " + ex.Message;  // retornamos el valor de false si hay algun error
            }
        }
        #endregion //"CursosAlumno"
    }
}
