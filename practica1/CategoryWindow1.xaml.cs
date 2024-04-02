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
    /// Логика взаимодействия для CategoryWindow1.xaml
    /// </summary>
    public partial class CategoryWindow1 : Window
    {
        CategoriesTableAdapter category = new CategoriesTableAdapter();

        public CategoryWindow1()
        {
            InitializeComponent();
            gridCategories.ItemsSource = category.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            category.InsertQuery(NameTbx.Text);
            gridCategories.ItemsSource = category.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (gridCategories.SelectedItem != null)
            {
                object id = (gridCategories.SelectedItem as DataRowView).Row[0];
                category.UpdateQueryy(NameTbx.Text, Convert.ToInt32(id));
                gridCategories.ItemsSource = category.GetData();
                
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (gridCategories.SelectedItem != null)
            {
                DataRowView row = (DataRowView)gridCategories.SelectedItem;
                int categoryId = Convert.ToInt32(row.Row["CategoryID"]);
                string categoryName = row.Row["CategoryName"].ToString();
                category.DeleteQuery(categoryId, categoryName);
                gridCategories.ItemsSource = category.GetData();
            }

            

        }

    }
}

