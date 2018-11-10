using _17_CRUDPersonas_DAL.Manejadoras;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUDPersonas_BL.Manejadoras
{
    public class clsManejadoraPersonas_BL
    {
        /// <summary>
        /// Devuelve una persona segun su id
        /// </summary>
        /// <param name="IDPersona"></param>
        /// <returns></returns>
        public clsPersona personaPorID_BL(int IDPersona) {

            clsManejadoraPersonas_DAL gestora = new clsManejadoraPersonas_DAL();

            clsPersona oPersona = new clsPersona();

            oPersona = gestora.personaPorID_DAL(IDPersona);


            return oPersona;

        }

        /// <summary>
        /// Borra una persona segun su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int BorrarPersonaPorID_BL(int id)
        {
            int filasAfectadas;

            clsManejadoraPersonas_DAL gestora = new clsManejadoraPersonas_DAL();

            filasAfectadas = gestora.BorrarPersonaPorID_DAL(id);


            return filasAfectadas;

        }

        public int insertarPersona_BL(clsPersona oPersona)
        {
            int filas;

            clsManejadoraPersonas_DAL gestora = new clsManejadoraPersonas_DAL();

            filas = gestora.insertarPersona_DAL(oPersona);


            return filas;

        }

        public int actualizarPersona_BL(clsPersona oPersona)
        {
            int filas;

            clsManejadoraPersonas_DAL gestora = new clsManejadoraPersonas_DAL();

            filas = gestora.actualizarPersona_DAL(oPersona);


            return filas;
        }


    }
}
