using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        //Promotion Services
            //Price calculation
        //Product selection and process

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Key in the Order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Please enter product type, eg: A | B | C | D");
                string productType = Console.ReadLine();
                Product product = new Product(productType);
                products.Add(product);
            }

            ProductService productService = new ProductService();
            int totalPrice = productService.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
