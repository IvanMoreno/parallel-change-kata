namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart{
        private decimal price;
        int numberOfItems;

        public decimal CalculateTotalPrice(){
            return price;
        }

        public bool HasDiscount(){
            return price > 100;
        }

        public void Add(int aPrice){
            this.price = aPrice;
            numberOfItems++;
        }

        public int NumberOfProducts(){
            return numberOfItems;
        }
    }
}
