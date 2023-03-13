using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace service
{
    public class Service1 : IService1
    {
        const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\Education\\SSTU\\Информационные технологии\\.net-classes\\prac4\\service\\service\\App_Data\\test.mdf\";Integrated Security=True";
        public List<Customer> GetCustomers()
        {
            var result = new List<Customer>();
            
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = "select * from customer";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Year = reader.GetInt32(3)
                    };

                    result.Add(customer);
                }

                connection.Close();
            }

            return result;
        }

        public List<Order> GetOrders(int customerId)
        {
            var result = new List<Order>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = $"select * from [order] where customer_id = {customerId}";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var order = new Order
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Price = reader.GetSqlMoney(2).ToDouble(),
                        Customer_id = customerId
                    };

                    result.Add(order);
                }

                connection.Close();
            }

            return result;
        }
    }
}
