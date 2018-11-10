using _17_CRUDPersonas_DAL.Listados;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUDPersonas_BL.Listados
{
    public class clsListadoDepartamentos_BL
    {

        public List<clsDepartamento> ListadoCompletoDepartamentos_BL()
        {

            clsListadoDepartamentos_DAL listadoDAL = new clsListadoDepartamentos_DAL();
            List<clsDepartamento> listado = new List<clsDepartamento>();

            listado = listadoDAL.listadoCompletoDepartamentos_DAL();

            return listado;

        }

    }
}
