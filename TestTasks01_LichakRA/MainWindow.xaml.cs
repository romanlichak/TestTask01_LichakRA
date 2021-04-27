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
using EF_TablesDBO;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace TestTasks01_LichakRA
{
   
    public partial class MainWindow : Window
    {
        ClinetSendData sendData = new ClinetSendData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductsList products = new ProductsList();
            products.Owner = this;
            products.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InputDataProduct inputData = new InputDataProduct();
            inputData.Owner = this;
            inputData.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выход в главное меню без отправки на сервер");
                
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {         
            try
            {
                sendData.SenDataToSever();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Данные отправлены на сервер");
            }
        }

       
    }
}
