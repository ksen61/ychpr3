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

namespace practica1ef
{
    /// <summary>
    /// Логика взаимодействия для WarehouseWindow.xaml
    /// </summary>
    public partial class WarehouseWindow : Window
    {
        private PetShopEntities storehouse = new PetShopEntities();
        public WarehouseWindow()
        {
            InitializeComponent();
            NameTbx4.ItemsSource = storehouse.Products.ToList();
            NameTbx4.SelectedIndex = 0;
            gridStorehouse.ItemsSource = storehouse.Warehouse.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                var newWarehouse = new Warehouse
                {
                    ProductID = (int)NameTbx4.SelectedValue,
                    Quantity = int.Parse(NameTbx5.Text),
                    
                };

                storehouse.Warehouse.Add(newWarehouse);
                storehouse.SaveChanges();
                gridStorehouse.ItemsSource = storehouse.Warehouse.ToList();
            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (gridStorehouse.SelectedItem != null)
            {
                var selectedWarehouse = gridStorehouse.SelectedItem as Warehouse;
                selectedWarehouse.ProductID = (int)NameTbx4.SelectedValue;
                selectedWarehouse.Quantity = int.Parse(NameTbx5.Text);

                storehouse.SaveChanges();
                gridStorehouse.Items.Refresh();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gridStorehouse.SelectedItem != null)
            {
                var selectedWarehouse = gridStorehouse.SelectedItem as Warehouse;
                storehouse.Warehouse.Remove(selectedWarehouse);
                storehouse.SaveChanges();
                gridStorehouse.ItemsSource = storehouse.Warehouse.ToList();
            }
            
        }

        private void gridStorehouse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridStorehouse.SelectedItem != null)
            {
                var selectedWarehouse = gridStorehouse.SelectedItem as Warehouse;
                NameTbx5.Text = selectedWarehouse.Quantity.ToString();

                Products selectedProduct = storehouse.Products.FirstOrDefault(p => p.ProductID == selectedWarehouse.ProductID);
                if (selectedProduct != null)
                {
                    NameTbx4.SelectedItem = selectedProduct;
                }
            }


        }

    }
}
