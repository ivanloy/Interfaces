using _14_SplitViewPractice.Views;
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

namespace _14_SplitViewPractice
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

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void HomeListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.frame.Navigate(typeof(home));
            Titulo.Text = "Inicio";

            if (MySplitView.IsPaneOpen) {

                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            }

           
        }

        private void MensaggesListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.frame.Navigate(typeof(messages));
            Titulo.Text = "Mensajes";

            if (MySplitView.IsPaneOpen)
            {

                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            }
        }

        private void CatalogoListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {

            this.frame.Navigate(typeof(catalogo));
            Titulo.Text = "Catalogo";

            if (MySplitView.IsPaneOpen)
            {

                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            }

        }
    }
}
