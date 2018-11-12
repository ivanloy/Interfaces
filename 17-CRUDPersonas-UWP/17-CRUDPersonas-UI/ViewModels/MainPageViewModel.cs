using _17_CRUDPersonas_BL.Listados;
using _17_CRUDPersonas_BL.Manejadoras;
using _17_CRUDPersonas_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace _17_CRUDPersonas_UI.ViewModels
{
    public class MainPageViewModel : clsVMBase  //Esto es para no implementar siempre lo mismo, por eso el resto esta comentado
    {

        #region propiedades privadas

        private List<clsPersona> _ListadoDePersonas;
        private List<clsDepartamento> _ListadoDeDepartamentos;
        private clsPersona _PersonaSelecionada;


        private DelegateCommand _eliminarCommand;
        private DelegateCommand _actualizarListadoCommand;



        #endregion

        #region propiedades publicas

        //public event PropertyChangedEventHandler PropertyChanged;

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
                NotifyPropertyChanged("PersonaSelecionada");
                //Llamamos a can execute para ver si habilitamos o no el boton
                _eliminarCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand eliminarCommand
        {

            get
            {
                _eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                return _eliminarCommand;
            }


        }public DelegateCommand actualizarListadoCommand
        {

            get
            {
                _actualizarListadoCommand = new DelegateCommand(ActualizarListado_Executed);
                return _actualizarListadoCommand;
            }
        }

        private void ActualizarListado_Executed()
        {

            clsListadoPersonas_BL oListados = new clsListadoPersonas_BL();

            _ListadoDePersonas = oListados.ListadoCompletoPersonas_BL();
            NotifyPropertyChanged("ListadoDePersonas");

        }




        private async void EliminarCommand_Executed()
        {
            clsManejadoraPersonas_BL gestora;
            int filasAfectadas;
            ContentDialog confirmarBorrado = new ContentDialog();

            confirmarBorrado.Title = "Eliminar";
            confirmarBorrado.Content = "¿Esta seguro de que quiere borrar?";
            confirmarBorrado.PrimaryButtonText = "Cancelar";
            confirmarBorrado.SecondaryButtonText = "Aceptar";

            ContentDialogResult resultado = await confirmarBorrado.ShowAsync();
            if (resultado == ContentDialogResult.Secondary) {

                try
                {
                    gestora = new clsManejadoraPersonas_BL();

                    filasAfectadas = gestora.BorrarPersonaPorID_BL(PersonaSelecionada.idPersona);

                    if (filasAfectadas == 1) {

                        clsListadoPersonas_BL oListados = new clsListadoPersonas_BL();

                        _ListadoDePersonas = oListados.ListadoCompletoPersonas_BL();
                        NotifyPropertyChanged("ListadoDePersonas");

                    }
                }
                catch (Exception e)
                {


                    //TODO lanzar dialogo con error
                }

            }

            
        }


        /// <summary>
        /// Funcion que devuelve un bool para habilitar o deshabilitar los controles bindeados al comando eliminar
        /// </summary>
        /// <returns></returns>
        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeEliminar = false;

            if (PersonaSelecionada != null)
            {

                sePuedeEliminar = true;
            }

            return sePuedeEliminar;
        }

        #endregion


        #region constructores

        public MainPageViewModel() {

            //clsListadoPersonas_BL gestoraListadosPersonas = new clsListadoPersonas_BL();
            
            clsListadoDepartamentos_BL gestoraListadosDepartamentos = new clsListadoDepartamentos_BL();

            //Cargar el listado de personas
            //_ListadoDePersonas = gestoraListadosPersonas.ListadoCompletoPersonas_BL();
            ActualizarListado_Executed();  //Al usar esto, descomentamos lo otro
            _ListadoDeDepartamentos = gestoraListadosDepartamentos.ListadoCompletoDepartamentos_BL();

        }

        #endregion



        //protected void OnPropertyChanged(string name)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;

        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(name));
        //    }
        //}

    }
}
