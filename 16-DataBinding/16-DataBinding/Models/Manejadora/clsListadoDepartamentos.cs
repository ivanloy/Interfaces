using System;
using System.Collections.Generic;
using System.Linq;


namespace _16_DataBinding.Models
{
    public class clsListadoDepartamentos
    {

        public static List<clsDepartamento> crearListadoDepartamentos() {

            List<clsDepartamento> listado = new List<clsDepartamento>();


            listado.Add(new clsDepartamento("Administracion del cafe", 1));
            listado.Add(new clsDepartamento("Gestion de capsulas", 2));
            listado.Add(new clsDepartamento("Departamento de compras", 3));

            return listado;
        }

    }
}