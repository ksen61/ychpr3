using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace practica1ef
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private PetShopEntities product = new PetShopEntities();
        public ProductWindow()
        {
            InitializeComponent();
            NameTbx2.ItemsSource = product.Categories.ToList();
            NameTbx2.SelectedIndex = 0;
            gridProduct.ItemsSource = product.Products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newProduct = new Products
            {
                ProductName = NameTbx1.Text,
                CategoryID = (int)NameTbx2.SelectedValue,
                Price = decimal.Parse(NameTbx3.Text)
            };
            product.Products.Add(newProduct);
            product.SaveChanges();
            gridProduct.ItemsSource = product.Products.ToList();

           
        }
    

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (gridProduct.SelectedItem != null)
            {
                var selectedProduct = gridProduct.SelectedItem as Products;
                selectedProduct.ProductName = NameTbx1.Text;
                selectedProduct.CategoryID = (int)NameTbx2.SelectedValue;
                selectedProduct.Price = decimal.Parse(NameTbx3.Text);

                product.SaveChanges();
                gridProduct.Items.Refresh();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gridProduct.SelectedItem != null)
            {
                var selectedProduct = gridProduct.SelectedItem as Products;
                product.Products.Remove(selectedProduct);
                product.SaveChanges();
                gridProduct.ItemsSource = product.Products.ToList();
            }
           

        }

        private void gridProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridProduct.SelectedItem != null)
            {
                var selectedProduct = gridProduct.SelectedItem as Products;
                NameTbx1.Text = selectedProduct.ProductName;
                NameTbx3.Text = selectedProduct.Price.ToString();

                // Находим соответствующую категорию продукта
                Categories selectedCategory = product.Categories.FirstOrDefault(c => c.CategoryID == selectedProduct.CategoryID);
                if (selectedCategory != null)
                {
                    // Устанавливаем выбранную категорию в ComboBox
                    NameTbx2.SelectedItem = selectedCategory;
                }

            }
        }
      

    }
}
