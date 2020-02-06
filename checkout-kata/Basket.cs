using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace checkout_kata
{
    public class Basket
    {
        
        public List<ProductItem> Items = new List<ProductItem>();
        
        private List<ProductItem> DiscountCandidates = new List<ProductItem>();
        
        public void Scan(ProductItem productItem) {
            Items.Add(productItem);
            
        }

        private int CheckIfSpecialOfferApplies(SpecialOffer specialOffer)
        {
            DiscountCandidates =Items.Where(T => T.Sku.Equals(specialOffer.SKU)).ToList();

            if (DiscountCandidates.Count >= specialOffer.Quantity)
            {
                var discount =
                    Convert.ToInt32(Math.Floor(d: (double) (DiscountCandidates.Count / specialOffer.Quantity)));
                
                return discount;
            }
            else
            {
                
            }
        }
        public void Total()
        {
            throw new NotImplementedException("TODO");
        }
    }

}
