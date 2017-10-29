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
using WpfLaboratorio.ViewModel;

namespace WpfLaboratorio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MantenimientoDeMuestras mantenimiento = new MantenimientoDeMuestras();
        public MainWindow()
        {
            InitializeComponent();
            mantenimiento.CargarMuestra();
            this.DataContext = mantenimiento;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            this.mantenimiento.RegistrarMuestra();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            this.mantenimiento.ActualizarMuestra();
            MuestrasDataGrid.Items.Refresh();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.mantenimiento.EliminarMuestra();
        }
    }
}
