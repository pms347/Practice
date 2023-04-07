using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class InterviewQuest
    {
    }
    

namespace ConsoleApp1
    {
        public class Program1
        {
            public static void Main1(string[] args)
            {
                OrderService orderService = new OrderService();
                var Customer = orderService.GetCustomerByName(args[5]);
                Console.WriteLine("Customer Phone Number is  " + Customer.PhoneNumber);
                var order = orderService.GetOrdersByProductName(args[6]);
                Console.WriteLine("Order Cost is  " + order.Cost);
            }
        }

        public class OrderService
        {
            public Customer GetCustomerByName(string name)
            {

                List<Customer> Customers = new List<Customer>()
            {
              new Customer{ Id=1 ,Name="ABC",Address="Test Address",PhoneNumber=88888888 },
              new Customer{ Id=2 ,Name="CDE",Address="Test Address",PhoneNumber=88888888 },
              new Customer{ Id=3 ,Name="EFG",Address="Test Address",PhoneNumber=88888888 },
              new Customer{ Id=4 ,Name="HIJ",Address="Test Address",PhoneNumber=88888888 },
              new Customer{ Id=5 ,Name="LMN",Address="Test Address",PhoneNumber=88888888 }
            };

                foreach (var Customer in Customers)
                {
                    if (Customer.Name == name)
                        return Customer;
                }
                return null;
            }

            public Order GetOrdersByProductName(string name)
            {
                List<Order> Customers = new List<Order>()
            {
              new Order{ Id=1 ,ProductName="ABC",ProductDescription="Test Address",Cost=9999 },
              new Order{ Id=2 ,ProductName="CDE",ProductDescription="Test Address",Cost=1111 },
              new Order{ Id=3 ,ProductName="EFG",ProductDescription="Test Address",Cost=7777 },
              new Order{ Id=4 ,ProductName="HIJ",ProductDescription="Test Address",Cost=6666 },
              new Order{ Id=5 ,ProductName="LMN",ProductDescription="Test Address",Cost=111.6 }
            };

                foreach (var Customer in Customers)
                {
                    if (Customer.ProductName == name)
                        return Customer;
                }
                return null;

            }

        }

        public class Customer
        {
            public int Id { get; set; }

            public string Name { get; set; }
            public string Address { get; set; }
            public int PhoneNumber { get; set; }
        }
        public class Order
        {
            public int Id { get; set; }

            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public double Cost { get; set; }
        }

    }

}
