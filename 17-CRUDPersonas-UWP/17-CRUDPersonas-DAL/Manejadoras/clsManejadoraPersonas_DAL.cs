using _17_CRUDPersonas_DAL.Conexion;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUDPersonas_DAL.Manejadoras
{
    public class clsManejadoraPersonas_DAL
    {
        /// <summary>
        /// Metodo que devuelve una persona segun su id
        /// </summary>
        /// <param name="IDPersona"></param>
        /// <returns></returns>
        public clsPersona personaPorID_DAL(int id)
        {

            clsPersona oPersona = new clsPersona();


            clsMyConnection gestoraConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;

            try
            { //try no obligatorio ya que lo controlamos en la clase clsMyConnection


                //Obtenemos una conexion abierta
                conexion = gestoraConexion.getConnection();

                //Definir los parametros del comando
                miComando.CommandText = "SELECT * FROM personas WHERE IDPersona = @id";

                //Añadir un parametro version larga

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = id;
                miComando.Parameters.Add(param);
                //*/

                //Añadir un parametro version corta
                //miComando.Parameters.Add("@IDPersona", System.Data.SqlDbType.Int).Value = oPersona.nombre;

                miComando.Connection = conexion;
                miLector = miComando.ExecuteReader();





                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    miLector.Read();

                    oPersona = new clsPersona();

                    //Definir los atributos
                    oPersona.idPersona = (int)miLector["IDPersona"];
                    oPersona.idDepartamento = (int)miLector["IDDepartamento"];
                    oPersona.nombre = (string)miLector["nombrePersona"];
                    oPersona.apellidos = (string)miLector["apellidosPersona"];
                    oPersona.fechaNacimiento = (DateTime)miLector["fechaNacimiento"];
                    oPersona.direccion = (string)miLector["direccion"];
                    oPersona.telefono = (string)miLector["telefono"];



                }

            }
            catch (SqlException exSql)
            {
                throw exSql;
            }
            finally
            {

                miLector.Close();
                gestoraConexion.closeConnection(ref conexion);
            }

            return oPersona;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int BorrarPersonaPorID_DAL(int id)
        {


            clsMyConnection gestoraConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand miComando = new SqlCommand();

            int filas;

            try
            { //try no obligatorio ya que lo controlamos en la clase clsMyConnection


                //Obtenemos una conexion abierta
                conexion = gestoraConexion.getConnection();

                //Definir los parametros del comando
                miComando.CommandText = "DELETE FROM personas WHERE IDPersona = @id";

                //Añadir un parametro version larga

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = id;
                miComando.Parameters.Add(param);
                //*/

                //Añadir un parametro version corta
                //miComando.Parameters.Add("@IDPersona", System.Data.SqlDbType.Int).Value = oPersona.nombre;

                miComando.Connection = conexion;
                filas = miComando.ExecuteNonQuery();



            }
            catch (SqlException exSql)
            {

                throw exSql;

            }
            finally
            {

                gestoraConexion.closeConnection(ref conexion);

            }

            return filas;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int insertarPersona_DAL(clsPersona oPersona)
        {
            
            int filas;

            clsMyConnection gestoraConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand miComando = new SqlCommand();

            

            try
            { //try no obligatorio ya que lo controlamos en la clase clsMyConnection


                //Obtenemos una conexion abierta
                conexion = gestoraConexion.getConnection();

                //Definir los parametros del comando
                miComando.CommandText = "INSERT INTO personas values (@nombre, @apellidos, @fechaNacimiento, @telefono, @direccion, @idDepartamento)";

                //Añadir un parametro version larga
                /*
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = id;
                miComando.Parameters.Add(param);
                //*/

                //Añadir un parametro version corta
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = oPersona.nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = oPersona.apellidos;
                miComando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.DateTime).Value = oPersona.fechaNacimiento;
                miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = oPersona.direccion;
                miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = oPersona.telefono;
                miComando.Parameters.Add("@idDepartamento", System.Data.SqlDbType.Int).Value = oPersona.idDepartamento;

                miComando.Connection = conexion;
                filas = miComando.ExecuteNonQuery();

            }
            catch (SqlException exSql)
            {

                throw exSql;

            }
            finally
            {

                gestoraConexion.closeConnection(ref conexion);

            }

            return filas;

        }



        public int actualizarPersona_DAL(clsPersona oPersona)
        {

            int filas;

            clsMyConnection gestoraConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand miComando = new SqlCommand();



            try
            { //try no obligatorio ya que lo controlamos en la clase clsMyConnection


                //Obtenemos una conexion abierta
                conexion = gestoraConexion.getConnection();

                //Definir los parametros del comando
                miComando.CommandText = "UPDATE personas SET nombrePersona = @nombre, apellidosPersona = @apellidos, fechaNacimiento = @fechaNacimiento, telefono = @telefono, direccion = @direccion, IDDepartamento = @idDepartamento WHERE IDPersona = @idPersona";

                //Añadir un parametro version larga
                /*
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.SqlDbType = System.Data.SqlDbType.Int;
                param.Value = id;
                miComando.Parameters.Add(param);
                //*/

                //Añadir un parametro version corta
                miComando.Parameters.Add("@idPersona", System.Data.SqlDbType.Int).Value = oPersona.idPersona;
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = oPersona.nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = oPersona.apellidos;
                miComando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.DateTime).Value = oPersona.fechaNacimiento;
                miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = oPersona.direccion;
                miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = oPersona.telefono;
                miComando.Parameters.Add("@idDepartamento", System.Data.SqlDbType.Int).Value = oPersona.idDepartamento;

                miComando.Connection = conexion;
                filas = miComando.ExecuteNonQuery();

            }
            catch (SqlException exSql)
            {

                throw exSql;

            }
            finally
            {

                gestoraConexion.closeConnection(ref conexion);

            }

            return filas;


        }
    }
}
