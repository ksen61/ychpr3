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
using practica1.PetShopDataSetTableAdapters;
namespace practica1
{
    /// <summary>
    /// Логика взаимодействия для AllWindow1.xaml
    /// </summary>
    public partial class AllWindow1 : Window
    {
        ProductsTableAdapter all = new ProductsTableAdapter();
        public AllWindow1()
        {
            InitializeComponent();

            AllTable.ItemsSource = all.GetDataBy3();
           

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AllTable.Columns[0].Visibility = Visibility.Collapsed;
            AllTable.Columns[2].Visibility = Visibility.Collapsed;
            AllTable.Columns[4].Visibility = Visibility.Collapsed;
            AllTable.Columns[6].Visibility = Visibility.Collapsed;
            AllTable.Columns[7].Visibility = Visibility.Collapsed;
            AllTable.Columns[1].Header = "Название товара";
            AllTable.Columns[3].Header = "Цена товара";
            AllTable.Columns[5].Header = "Категория товара";
            AllTable.Columns[8].Header = "Количество товара";
        }
    }
}
