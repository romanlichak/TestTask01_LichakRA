using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EF_TablesDBO;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace TestTasks01_LichakRA
{
   
    public partial class ProductsList : Window
    {
        TestMobileSMARTContext db = new TestMobileSMARTContext();
      

        public ProductsList()
        {
            InitializeComponent();

             db.Products.Load();

            listProductsTable.ItemsSource = db.Products.Local.ToBindingList();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Product poduct = listProductsTable.SelectedItem as Product;

            db.Products.Remove(poduct);
            db.SaveChanges();
        }

        public void LoadData(ObservableCollection<Product> loadProduct)
        {
            db.Products.Load();
            var data = db.Products;
            foreach (var item in data)
            {
                loadProduct.Add(item);
            }
        }
    }
}
