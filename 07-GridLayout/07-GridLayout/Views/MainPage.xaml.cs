using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _07_GridLayout
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al click del boton Enviar, que valida los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {

            //Declaracion de variables
            String nombre, apellidos, email, fechaNacimiento;

            nombre = txtNombre.Text;
            apellidos = txtApellido.Text;
            email = txtEmail.Text;
            fechaNacimiento = txtErrorNacimiento.Text;

            //Valida que el nombre no este en blanco
            if (String.IsNullOrEmpty(nombre))
            {

                txtErrorNombre.Visibility = Visibility.Visible;    

            }
            else {

                txtErrorNombre.Visibility = Visibility.Collapsed;
            }


            //Valida que los apellidos no esten en blanco
            if (String.IsNullOrEmpty(apellidos))
            {

                txtErrorApellido.Visibility = Visibility.Visible;

            }
            else
            {
                

                txtErrorApellido.Visibility = Visibility.Collapsed;
            }

            //Valida que tenga formato de email
            if (String.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {

                txtErrorEmail.Visibility = Visibility.Visible;

            }
            else
            {
                txtErrorEmail.Visibility = Visibility.Collapsed;
                  
            }


            //Validamos la fecha (pero ahora lo miras con regex Jorge :c)
            if (cdpFechaNacimiento.Date > DateTime.Now)
            {

                txtErrorNacimiento.Visibility = Visibility.Visible;

            }
            else
            {

                txtErrorNacimiento.Visibility = Visibility.Collapsed;
            }






        }
    }
}
