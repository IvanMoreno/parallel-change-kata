using FluentAssertions;
using NUnit.Framework;
using ParallelAndNarrowChange.Field;

namespace ParallelAndNarrowChange{
    [TestFixture]
    public class ShoppingCartShould{
        private ShoppingCart cart;

        [SetUp]
        public void SetUp(){
            cart = new ShoppingCart();
        }

        [Test]
        public void final_price_is_zero_with_empty_cart()
        {
            cart.CalculateTotalPrice().Should().Be(0);
        }

        [Test]
        public void calculate_the_final_price_with_one_item(){
            cart.Add(10);

            cart.CalculateTotalPrice().Should().Be(10);
        }

        [Test]
        public void calculate_the_final_price_with_two_items()
        {
            cart.Add(10);
            cart.Add(5);
            
            cart.CalculateTotalPrice().Should().Be(10 + 5);
        }

        [Test]
        public void knows_the_number_of_items_with_just_one(){
            cart.Add(10);

            cart.NumberOfProducts().Should().Be(1);
        }

        [Test]
        public void knows_the_number_of_two_items() {
            cart.Add(10);
            cart.Add(10);
            
            cart.NumberOfProducts().Should().Be(2);
        }

        [Test]
        public void may_offer_discounts_when_there_at_least_one_expensive_product(){
            cart.Add(120);

            cart.HasDiscount().Should().BeTrue();
        }

        [TestCase(10)]
        [TestCase(100)]
        public void does_not_offer_discount_for_cheap_products(int aPrice){
            cart.Add(aPrice);

            cart.HasDiscount().Should().BeFalse();
        }
    }
}
