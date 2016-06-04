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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Solidaridapp.Org.Solidaridapp.Inicial.Vista
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PerfilBenefactor : Page
    {
        public PerfilBenefactor()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Inicio));
        }
        private void btnContribuirEspecie_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistroDonaciones));
        }

        private void btnContribuirTransporte_Click(object sender, RoutedEventArgs e)
        {
            //TODO: pantalla con lista de benefactores que necesitan transporte
        }

        private void btnDonacionesRealizadas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistroInstituciones));
        }
    }
}
