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
    /// Lógica de interacción para AdministracionContrato.xaml
    /// </summary>
    public partial class AdministracionContrato : MetroWindow
    {
        public AdministracionContrato()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            CrearContrato creacontrato = new CrearContrato();
            creacontrato.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            CrearContrato creacontr = new CrearContrato();
            creacontr.Show();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
