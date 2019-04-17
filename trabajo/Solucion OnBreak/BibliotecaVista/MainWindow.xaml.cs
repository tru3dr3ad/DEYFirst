using MahApps.Metro.Controls;
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

namespace BibliotecaVista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow :MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            AdministracionCliente admcli = new AdministracionCliente();
            admcli.Show();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            AdministracionContrato admicon = new AdministracionContrato();
            admicon.Show();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            ListadoCliente listcli = new ListadoCliente();
            listcli.Show();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
            ListadoContrato listcon = new ListadoContrato();
            listcon.Show();
        }
    }
}
