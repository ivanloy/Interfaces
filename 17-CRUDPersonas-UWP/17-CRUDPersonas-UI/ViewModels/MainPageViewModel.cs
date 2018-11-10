using _17_CRUDPersonas_BL.Listados;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_CRUDPersonas_UI.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        #region propiedades privadas

        private List<clsPersona> _ListadoDePersonas;
        private List<clsDepartamento> _ListadoDeDepartamentos;
        private clsPersona _PersonaSelecionada;



        #endregion

        #region propiedades publicas

        public event PropertyChangedEventHandler PropertyChanged;

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
                OnPropertyChanged("PersonaSelecionada");
            }
        }

        #endregion


        #region constructores

        public MainPageViewModel() {

            clsListadoPersonas_BL gestoraListadosPersonas = new clsListadoPersonas_BL();
            clsListadoDepartamentos_BL gestoraListadosDepartamentos = new clsListadoDepartamentos_BL();

            //Cargar el listado de personas
            _ListadoDePersonas = gestoraListadosPersonas.ListadoCompletoPersonas_BL();
            _ListadoDeDepartamentos = gestoraListadosDepartamentos.ListadoCompletoDepartamentos_BL();

        }

        #endregion



        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
