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

namespace practica1ef
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CategoryWindow categoryWindow = new CategoryWindow();
            categoryWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productWindow = new ProductWindow();
            productWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WarehouseWindow warehouseWindow = new WarehouseWindow();
            warehouseWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AllWindow allWindow = new AllWindow();
            allWindow.Show();
        }
    }
}
