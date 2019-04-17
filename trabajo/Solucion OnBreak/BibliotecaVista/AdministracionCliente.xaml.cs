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
using System.Windows.Shapes;

namespace BibliotecaVista
{
    /// <summary>
    /// Lógica de interacción para AdministracionCliente.xaml
    /// </summary>
    public partial class AdministracionCliente : MetroWindow
    {
        public AdministracionCliente()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarCli creacli = new ActualizarCli();
            creacli.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            ActualizarCli nuevocli = new ActualizarCli();
            nuevocli.Show();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
