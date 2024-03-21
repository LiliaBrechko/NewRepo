using System;

namespace FirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Config config = new Config())
            {

                Product milk = new Product()
                {
                    Name = "Milk",
                    Price = 40

                };
                Product bread = new Product()
                {
                    Name = "Bread",
                    Price = 25

                };
                Product apple = new Product()
                {
                    Name = "Apple",
                    Price = 30

                };

                List<Product> products = new List<Product> { milk, bread, apple };




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
                Customer Denys = new Customer()
                {
                    Name = "Denys",
                    Phone = "0938405093",
                    Adress = "Kyiv"
                };

                Customer Svitlana = new Customer()
                {
                    Name = "Svitlana",
                    Phone = "0673379165",
                    Adress = "Rivne"
                };

                Customer Pavlo = new Customer()
                {
                    Name = "Pavlo",
                    Phone = "0507563005",
                    Adress = "Rivne"
                };

                Customer Vitaliy = new Customer()
                {
                    Name = "Vitaliy",
                    Phone = "0638187970",
                    Adress = "Rivne"
                };
                Customer Kateryna = new Customer()
                {
                    Name = "Kateryna",
                    Phone = "0967445444",
                    Adress = "Rivne"
                };

                Customer Andriy = new Customer()
                {
                    Name = "Andriy",
                    Phone = "0688089639",
                    Adress = "Bershad"
                };

                List<Customer> customers = new List<Customer> {  Oksana, Denys, Dmytro, Pavlo, Svitlana, Vitaliy, Kateryna, Andriy };
                config.Customers.AddRange(customers);
                config.SaveChanges();   
             

            }
        }
    }
}