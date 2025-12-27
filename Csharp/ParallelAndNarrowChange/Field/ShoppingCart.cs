using System.Collections.Generic;

namespace ParallelAndNarrowChange.Field {
    // Divergent change (keep track of products and calculate discounts)
    public class ShoppingCart {
        // Data clump
        decimal price;

        public decimal Price {
            get => price;
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
            numberOfItems++;
        }

        public int NumberOfProducts() {
            return numberOfItems;
        }
    }
}