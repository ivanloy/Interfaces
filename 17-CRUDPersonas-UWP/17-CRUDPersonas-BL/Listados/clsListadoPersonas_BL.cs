using _17_CRUDPersonas_DAL.Listados;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUDPersonas_BL.Listados
{
    public class clsListadoPersonas_BL
    {
        /// <summary>
        /// Funcion que devolvera un listado de personas, obtendra el listado de personas de la capa DAL
        /// Devolvera una lista vacia si ha habido algun error
        /// </summary>
        /// <returns>Una lista de clsPersona</returns>
        public List<clsPersona> ListadoCompletoPersonas_BL() {

            clsListadoPersonas_DAL listadoDAL = new clsListadoPersonas_DAL();
            List<clsPersona> listado = new List<clsPersona>();

            listado = listadoDAL.listadoCompletoPersonas_DAL();

            return listado;

        }
    

    }
}
