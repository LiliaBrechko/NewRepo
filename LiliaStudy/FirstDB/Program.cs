using Microsoft.EntityFrameworkCore.Diagnostics;
using Repositories;
using System;
using System.Net;

namespace FirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> repositoryProduct = new Repository<Product>();
            Repository<Customer> repositoryCustomer = new Repository<Customer>();
            Repository<Order> repositoryOrder = new Repository<Order>();
            Repository<OrderDetails> repositoryOrderDetails = new Repository<OrderDetails>();
            /*
            Product Pizza = new Product()
            {
                Name = "Pizza",
                Price = 200

            };
            Product Doner = new Product()
            {
                Name = "Doner",
                Price = 100

            };
            Product HotDog = new Product()
            {
                Name = "Hot Dog",
                Price = 50

            };
            Product Salad = new Product()
            {
                Name = "Salad",
                Price = 90

            };
            Product Pasta = new Product()
            {
                Name = "Pasta",
                Price = 120

            };
            Product FrenchFrie = new Product()
            {
                Name = "French Frie",
                Price = 60

            };
            Product Nuggets = new Product()
            {
                Name = "Nuggets",
                Price = 80

            };
            Product Sushi = new Product()
            {
                Name = "Sushi",
                Price = 40

            };
            Product Burger = new Product()
            {
                Name = "Burger",
                Price = 95

            };


            var burgerid = repositoryProduct.Create(Burger);
            var pizzaid = repositoryProduct.Create(Pizza);
            var pastaid = repositoryProduct.Create(Pasta);
            var sushiid = repositoryProduct.Create(Sushi);
            var frenchfrieid = repositoryProduct.Create(FrenchFrie);
            var nuggetsid = repositoryProduct.Create(Nuggets);
            var saladid = repositoryProduct.Create(Salad);
            var donerid = repositoryProduct.Create(Doner);
            var hotdogid = repositoryProduct.Create(HotDog);






            //add customers
            Customer Oksana = new Customer()
            {
                Name = "Oksana",
                Phone = "0978542715",
                Adress = "Bershad"
            };
            Customer Dmytro = new Customer()
            {
                Name = "Dmytro",
                Phone = "0680126925",
                Adress = "Bershad"
            };

            var oksanaid = repositoryCustomer.Create(Oksana);
            var dmytroid = repositoryCustomer.Create(Dmytro);

            Order order1 = new Order()
            {
                CustomerId = oksanaid

            };

            Order order2 = new Order()
            {
                CustomerId = dmytroid

            };
            var order1id = repositoryOrder.Create(order1);
            var order2id = repositoryOrder.Create(order2);

            OrderDetails orderDetails1 = new OrderDetails()
            {
                ProductId = pizzaid,
                OrderId = order1id,
            };


            OrderDetails orderDetails2 = new OrderDetails()
            {
                ProductId = pastaid,
                OrderId = order2id,
            };


            var orderdetails1ID = repositoryOrderDetails.Create(orderDetails1);
            var orderdetails2ID = repositoryOrderDetails.Create(orderDetails2);


            */

            repositoryOrder.Delete(1);

        }
    }
}