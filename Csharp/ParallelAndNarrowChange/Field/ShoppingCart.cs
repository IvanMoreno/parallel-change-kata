namespace ParallelAndNarrowChange.Field
{
    // Divergent change (keep track of products and calculate discounts)
    public class ShoppingCart{
        // Data clump
        decimal price; // Primitive obsession
        int numberOfItems;

        public decimal CalculateTotalPrice(){
            return price;
        }

        public bool HasDiscount(){
            return price > 100; // Magic number
        }

        public void Add(int aPrice){ // Primitive obsession
            this.price += aPrice;
            numberOfItems++;
        }

        public int NumberOfProducts(){
            return numberOfItems;
        }
    }
}
