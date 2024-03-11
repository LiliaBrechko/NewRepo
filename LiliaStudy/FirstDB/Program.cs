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


                Customer Lilia = new Customer()
                {
                    Name = "Lilia",
                    Phone = "0987801428",
                    Adress = "Kyiv"
                };
                Customer Pasha = new Customer()
                {
                    Name = "Pasha",
                    Phone = "0737801428",
                    Adress = "Kyiv"
                };
                List<Customer> customers = new List<Customer> { Lilia, Pasha };

             

            }
        }
    }
}