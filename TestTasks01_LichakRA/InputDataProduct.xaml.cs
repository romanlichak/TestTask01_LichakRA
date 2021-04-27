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

namespace TestTasks01_LichakRA
{
   
    public partial class InputDataProduct : Window
    {
        public InputDataProduct()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestMobileSMARTContext db = new TestMobileSMARTContext();
            Product product = new Product() { 
                 Barcode = barCodeItemInput.Text,
                Name = nameProductItemInput.Text, 
                Unit = quantityProductItemInput.Text,
             Describe = describeProductItemInput.Text,};

            db.Products.Add(product);

            db.SaveChanges();

            barCodeItemInput.Clear();
            nameProductItemInput.Clear();
            quantityProductItemInput.Clear();
            describeProductItemInput.Clear();
                
        }
    }
}
