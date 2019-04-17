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
    /// Lógica de interacción para CrearContrato.xaml
    /// </summary>
    public partial class CrearContrato : MetroWindow
    {
        public CrearContrato()
        {
            InitializeComponent();
        }

        private void BtnCalcularValor_Click(object sender, RoutedEventArgs e)
        {
            CalcularValor calc = new CalcularValor();
            calc.Show();
        }

        private void TxtFechaCrea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
