using System;

namespace checkout_kata
{
    public class ProductItem
    {
        public ProductItem(int price)
        {
            Price = price;
        }

        public String Sku { get; set; }
        public int Price { get; set; }
    }
}