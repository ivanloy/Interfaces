using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld_Windows_Forms_C

    /*
    clsPersona
    
    Atributos:
        
        nombre String CyM
        apellido String CyM

    Metodos:
 
    */
{
    public class clsPersona
    {
        #region "Atributos"
        private String _nombre;
        //private String _apellidos; //no necesario si se hace con la forma cortita
        #endregion

        #region Propiedades publicas
        public string nombre
        {

            get { return _nombre; }

            set { _nombre = value; }

        }

        //Cuando no queremos validar ni hacer nada en el set

        public string apellidos { get; set; }

        #endregion











    }
}
