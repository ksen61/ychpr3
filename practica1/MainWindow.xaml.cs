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
using practica1.PetShopDataSetTableAdapters;

namespace practica1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow1 categoryWindow1 = new CategoryWindow1();
            categoryWindow1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductWindow1 productWindow1 = new ProductWindow1();
            productWindow1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WarehouseWindow1 warehouseWindow1 = new WarehouseWindow1();
            warehouseWindow1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AllWindow1 allWindow1 = new AllWindow1();
            allWindow1.Show();
        }
    }
}
