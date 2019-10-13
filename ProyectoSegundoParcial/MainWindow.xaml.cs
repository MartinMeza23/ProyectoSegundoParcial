using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            btnGuardar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            grdAutos.Children.Clear();
            
            switch (cbMarca.SelectedIndex)
            {
                case 0:
                    grdAutos.Children.Add(new FORD());
                    break;
                case 1:
                    grdAutos.Children.Add(new CHEVROLET());
                    break;
                case 2:
                    grdAutos.Children.Add(new HONDA());
                    break;
                case 3:
                    grdAutos.Children.Add(new NISSAN());
                    break;
                case 4:
                    grdAutos.Children.Add(new MAZDA());
                    break;
                case 5:
                    grdAutos.Children.Add(new DODGE());
                    break;
                case 6:
                    grdAutos.Children.Add(new ACURA());
                    break;
                case 7:
                    grdAutos.Children.Add(new JEEP());
                    break;


            }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdAutos.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            txtLeyenda.Visibility = Visibility.Hidden;
            
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            grdAutos.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            txtLeyenda.Visibility = Visibility.Hidden;
           
        }
    }
}
