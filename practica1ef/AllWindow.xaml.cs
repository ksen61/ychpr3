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
    /// Логика взаимодействия для AllWindow.xaml
    /// </summary>
    
    public partial class AllWindow : Window
    {
        public class ViewModel
        {
            public string ProductsName { get; set; }
            public string CategoriesName { get; set; }
            public decimal Cost { get; set; }
            public int Amount { get; set; }
        }



        private PetShopEntities alltable = new PetShopEntities();
        public AllWindow()
        {
            InitializeComponent();

            var jointData = from product in alltable.Products
                            join category in alltable.Categories on product.CategoryID equals category.CategoryID
                            join warehouse in alltable.Warehouse on product.ProductID equals warehouse.ProductID
                            select new ViewModel
                            {
                                ProductsName = product.ProductName,
                                CategoriesName = category.CategoryName,
                                Cost = (decimal)product.Price,
                                Amount = (int)warehouse.Quantity
                            };

            AllTable.ItemsSource = jointData.ToList();
        }



    }
}
