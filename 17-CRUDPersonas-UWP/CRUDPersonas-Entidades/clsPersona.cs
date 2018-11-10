using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_CRUDPersonas_Entidades
{
    public class clsPersona
    {
        #region atributosYPropiedades

        public int idPersona { get; set; }

        public int idDepartamento { get; set; }

        public String nombre { get; set; }

        public String apellidos { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public String direccion { get; set; }

        public String telefono { get; set; }


        #endregion


        #region constructores

        public clsPersona(int idPersona, int idDepartamento, String nombre, String apellidos, DateTime fechaNacimiento, String direccion, String telefono) {

            this.idPersona = idPersona;
            this.idDepartamento = idDepartamento;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;

        }

        public clsPersona() {

            this.idPersona = 0;
            this.idDepartamento = 0;
            this.nombre = "";
            this.apellidos = "";
            this.fechaNacimiento = new DateTime();
            this.direccion = "";
            this.telefono = "";

        }

        #endregion


    }
}