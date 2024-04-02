using practica1.PetShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace practica1
{
    /// <summary>
    /// Логика взаимодействия для WarehouseWindow1.xaml
    /// </summary>
    public partial class WarehouseWindow1 : Window
    {
        WarehouseTableAdapter storehouse = new WarehouseTableAdapter();

        public WarehouseWindow1()
        {
            InitializeComponent();
            gridWarehouse.ItemsSource = storehouse.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }
    }
}
