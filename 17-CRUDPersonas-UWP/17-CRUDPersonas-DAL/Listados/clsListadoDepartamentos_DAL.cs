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
    public class clsListadoDepartamentos_DAL
    {

        public List<clsDepartamento> listadoCompletoDepartamentos_DAL()
        {


            List<clsDepartamento> listado = new List<clsDepartamento>();
            clsDepartamento oDepartamento;

            clsMyConnection gestoraConexion = new clsMyConnection();
            SqlConnection conexion = null;

            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;

            try
            { //try no obligatorio ya que lo controlamos en la clase clsMyConnection


                //Obtenemos una conexion abierta
                conexion = gestoraConexion.getConnection();

                //Definir los parametros del comando
                miComando.CommandText = "SELECT * FROM departamentos";
                miComando.Connection = conexion;
                miLector = miComando.ExecuteReader();

                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oDepartamento = new clsDepartamento();

                        //Definir los atributos
                        oDepartamento.ID = (int)miLector["IDDepartamento"];
                        oDepartamento.nombre = (String)miLector["nombreDepartamento"];

                        //Annanir a la lista
                        listado.Add(oDepartamento);
                    }
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






            return listado;
        }

    }
}
