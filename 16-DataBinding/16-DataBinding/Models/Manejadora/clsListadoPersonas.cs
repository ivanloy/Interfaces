using System;
using System.Collections.Generic;
using System.Linq;


namespace _16_DataBinding.Models
{
    public class clsListadoPersonas
    {

        /// <summary>
        /// Metodo que devolvera una lista de objetos persona con datos predefinidos
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> listadoPersonas() {

             List<clsPersona> listado = new List<clsPersona>();

            listado.Add(new clsPersona(1, 1, "Jorge", "Obando Lopez", new DateTime(1998, 10, 9), "Calle patata", "1111111"));
            listado.Add(new clsPersona(2, 1, "Gorge", "Obandino Lopecio", new DateTime(1998, 10, 9), "Calle patata", "1111111"));
            listado.Add(new clsPersona(3, 2, "Jorgue", "Hovando Pezlo", new DateTime(1998, 10, 9), "Calle patata", "1111111"));

         

            return listado;


        }

    }
}