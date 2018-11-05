using _16_DataBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DataBinding.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        #region propiedades privadas

        private List<clsPersona> _ListadoDePersonas;
        private List<clsDepartamento> _ListadoDeDepartamentos;
        private clsPersona _PersonaSelecionada;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region propiedades publicas

        public List<clsPersona> ListadoDePersonas {

            get {

                return _ListadoDePersonas;
            }

            set {

                _ListadoDePersonas = value;
            }

        }

        public List<clsDepartamento> ListadoDeDepartamentos
        {

            get
            {

                return _ListadoDeDepartamentos;
            }

            set
            {

                _ListadoDeDepartamentos = value;
            }

        }

        public clsPersona PersonaSelecionada
        {

            get {

                return _PersonaSelecionada;
            }

            set {

                _PersonaSelecionada = value;
            }
        }

        #endregion


        #region constructores

        public MainPageViewModel() {

            //Cargar el listado de personas
            _ListadoDePersonas = clsListadoPersonas.listadoPersonas();
            _ListadoDeDepartamentos = clsListadoDepartamentos.crearListadoDepartamentos();

        }

        #endregion

    }
}
