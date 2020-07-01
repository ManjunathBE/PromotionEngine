using System;

namespace PromotionEngine
{
    public class Product
    {
        public string Id { get; set; }
        public decimal Price { get; set; }

        public Product(string id)
        {
            this.Id = id;
            switch (Id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 2015m;
                    break;
            }
        }
    }
}
