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
    /// Lógica de interacción para ListadoCliente.xaml
    /// </summary>
    public partial class ListadoCliente : MetroWindow
    {
        public ListadoCliente()
        {
            InitializeComponent();
        }

        private void BtnContrato_Click(object sender, RoutedEventArgs e)
        {
            AdministracionContrato adminicon = new AdministracionContrato();
            adminicon.Show();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
