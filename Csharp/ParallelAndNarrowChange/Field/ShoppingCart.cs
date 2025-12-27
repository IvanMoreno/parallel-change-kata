using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field {
    // Divergent change (keep track of products and calculate discounts)
    public class ShoppingCart {
        // Data clump
        decimal price;
        readonly List<int> prices = new();

        public decimal Price {
            get => prices.Sum();
            private set => price = value;
        }

        int numberOfItems;

        public decimal CalculateTotalPrice() {
            return Price;
        }

        public bool HasDiscount() {
            return Price > 100; // Magic number
        }

        public void Add(int aPrice) {
            // Primitive obsession
            this.Price += aPrice;
            prices.Add(aPrice);
            numberOfItems++;
        }

        public int NumberOfProducts() {
            return numberOfItems;
        }
    }
}