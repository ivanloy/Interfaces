using _17_CRUDPersonas_DAL.Conexion;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUDPersonas_DAL.Listados
{
    public class clsListadoPersonas_DAL
    {
        /// <summary>
        /// Funcion que devuelve un listado (List) de personas, obtenido de la base de datos
        /// La lista estara vacia si no hay datos en la BBDD o no se ha podido acceder
        /// </summary>
        /// <returns>List de clsPersona</returns>
        public List<clsPersona> listadoCompletoPersonas_DAL() {


            List<clsPersona> listado = new List<clsPersona>();
            clsPersona oPersona;

            clsMyConnection gestoraConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;

            try
            { //try no obligatorio ya que lo controlamos en la clase clsMyConnection


                //Obtenemos una conexion abierta
                conexion = gestoraConexion.getConnection();

                //Definir los parametros del comando
                miComando.CommandText = "SELECT * FROM personas";
                miComando.Connection = conexion;
                miLector = miComando.ExecuteReader();

                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();

                        //Definir los atributos
                        oPersona.idPersona = (int)miLector["IDPersona"];
                        oPersona.idDepartamento = (int)miLector["IDDepartamento"];
                        oPersona.nombre = (string)miLector["nombrePersona"];
                        oPersona.apellidos = (string)miLector["apellidosPersona"];
                        oPersona.fechaNacimiento = (DateTime)miLector["fechaNacimiento"];
                        oPersona.direccion = (string)miLector["direccion"];
                        oPersona.telefono = (string)miLector["telefono"];

                        //Annanir a la lista
                        listado.Add(oPersona);
                    }
                }
                                         
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }
            finally {

                miLector.Close();
                gestoraConexion.closeConnection(ref conexion);
            }
            
            return listado;
        }

        

    }
}
