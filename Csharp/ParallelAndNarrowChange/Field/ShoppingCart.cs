using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field {
    // Divergent change (keep track of products and calculate discounts)
    public class ShoppingCart {
        readonly List<int> prices = new();

        public decimal CalculateTotalPrice() {
            return prices.Sum();
        }

        public bool HasDiscount() {
            return CalculateTotalPrice() > 100; // Magic number
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