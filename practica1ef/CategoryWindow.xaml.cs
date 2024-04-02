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
    /// Логика взаимодействия для CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        private PetShopEntities category = new PetShopEntities();
        public CategoryWindow()
        {
            InitializeComponent();
            gridCategory.ItemsSource = category.Categories.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Categories c = new Categories();
            c.CategoryName = NameTbx.Text;
            category.Categories.Add(c);
            category.SaveChanges();
            gridCategory.ItemsSource = category.Categories.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(gridCategory.SelectedItem != null)
            {
                category.Categories.Remove(gridCategory.SelectedItem as Categories);
                category.SaveChanges();
                gridCategory.ItemsSource = category.Categories.ToList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (gridCategory.SelectedItem != null)
            {
                var selected = gridCategory.SelectedItem as Categories;
                selected.CategoryName = NameTbx.Text;
                category.SaveChanges();
                gridCategory.ItemsSource = category.Categories.ToList();
            }
        }

        private void gridCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridCategory.SelectedItem != null)
            {
                var selected = gridCategory.SelectedItem as Categories;
                NameTbx.Text = selected.CategoryName;
            }
        }
    }
}
