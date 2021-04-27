using EF_TablesDBO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TestTasks01_LichakRA
{

    public class ClinetSendData
    {
        const int PORT = 5006;
        const string ADDRESS = "127.0.0.1";
        
        ObservableCollection<Product> dbForSend = new ObservableCollection<Product>();
       
        ProductsList listProduct = new ProductsList();

        public void SenDataToSever()
        {
            TcpClient client = null;
            try
            {
                listProduct.LoadData(dbForSend);

                string message;
                client = new TcpClient(ADDRESS, PORT);
                NetworkStream stream = client.GetStream();

              
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(dbForSend.ToString());
                writer.Flush();
                
               
                StreamReader reader = new StreamReader(stream);
                message = reader.ReadLine();
                Console.WriteLine("Получен ответ: " + message);

                reader.Close();
                writer.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (client != null)
                    client.Close();
            }
        }
    }

    
}
