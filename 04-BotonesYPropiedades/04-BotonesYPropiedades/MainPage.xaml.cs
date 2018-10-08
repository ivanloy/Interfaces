using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace _04_BotonesYPropiedades
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


            //Creacion del objeto boton
            Button boton = new Button();


            //Asignacion de propiedades al boton
<<<<<<< Updated upstream
            boton.Height = 70;
            boton.Width = 200;
            boton.Font = 
=======
<<<<<<< HEAD
            boton.Content = "Boton 3";
            boton.Height = 70;
            boton.Width = 200;
            boton.FontSize = 16;
            boton.VerticalAlignment = VerticalAlignment.Center;
            boton.HorizontalAlignment = HorizontalAlignment.Center;
            boton.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            boton.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Yellow);
            boton.FontFamily = new FontFamily("verdana");
            boton.FontWeight = Windows.UI.Text.FontWeights.Bold;

            sp_panel.Children.Add(boton);

            //Añadimos un metodo al boton
            boton.Click += boton_Click;


        }

        /// <summary>
        /// Evento asociado al boton que mostrara un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void boton_Click(object sender, RoutedEventArgs e) {

            MessageDialog mensage = new MessageDialog("Hola");

            await mensage.ShowAsync();
=======
            boton.Height = 70;
            boton.Width = 200;
            boton.Font = 
>>>>>>> parent of 9ba2865... Peta, solucionar mañana
>>>>>>> Stashed changes

        }

      
    }
}
