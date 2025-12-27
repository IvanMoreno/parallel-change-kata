using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field {
    // Divergent change (keep track of products and calculate discounts)
    public class ShoppingCart {
        const decimal ItemPriceThresholdForDiscount = 100;
        
        readonly List<int> prices = new();

        public decimal CalculateTotalPrice() {
            return prices.Sum();
        }

        public bool HasDiscount() {
            return prices.Any(price => price > ItemPriceThresholdForDiscount);
        }

        public void Add(int aPrice) {
            // Primitive obsession
            prices.Add(aPrice);
        }

        public int NumberOfProducts() {
            return prices.Count;
        }
    }
}