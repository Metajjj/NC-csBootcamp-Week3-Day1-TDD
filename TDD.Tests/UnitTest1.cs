using FluentAssertions;
using TDD;

namespace TDD.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(TestName = "Rotate_NothToRight_ReturnsEast")]
        public void Rotate_NothToRight_ReturnsEast()
        {
            var compass = new Compass();

            //Setup vals
            var p = Compass.Points.North;
            var dir = Compass.Directions.Right;

            //Cal func
            var result = compass.Rotate(p, dir);

            //Check res
            //Assert.That(result==Compass.Points.East);
            result.Should().Be(Compass.Points.East);



            //Assert.Pass();
        }

        [Test]
        [TestCase(TestName = "WestToNorth_&_NorthToWest")] //Gives name in test-explorer!
        public void Test2()
        {
            var compass = new Compass();

            //Setup vals
            var p = Compass.Points.West;
            var dir = Compass.Directions.Right;

            //Cal func
            var result = compass.Rotate(p, dir);

            //Check res
            result.Should().Be(Compass.Points.North);

            compass.Rotate(Compass.Points.North, Compass.Directions.Left)
                .Should().Be(Compass.Points.West);
        }

        [Test]
        [TestCase(TestName = "Testing palindrome")]
        public void Test3()
        {
            //vals
            String input1 = "cat", input2 = "racecar";

            //Call func
            var res1 = StringManipulator.IsPalindrome(input1);
            var res2 = StringManipulator.IsPalindrome(input2);

            //Assert res
            res1.Should().BeFalse();
            res2.Should().BeTrue();
        }

        [Test]
        [TestCase(TestName = "Find longest word")]
        public void Test4()
        {

            //assert
            WordAnalyzer.FindLongestWord("apple banana pair").Should().Be("banana");
            WordAnalyzer.FindLongestWord("apple banana pair").Should().NotBe("apple");
        }

        [Test]
        [TestCase(TestName = "Calulate Letter Frequency")]
        public void Test5()
        {

            CalculateLetterFrequencyClass.CalculateLetterFrequency("hello").Should().Equal(new Dictionary<char, int> {
                { 'l', 2 },{'h',1},{'e', 1},{'o',1 }
                });

            return;
            //needs .Equal for arrays/collections!
            CalculateLetterFrequencyClass.CalculateLetterFrequency("hello").Should().Equal(new Dictionary<char, int> {

                    //Order doesnt matter with dict!
                { 'l', 2 },
                {'h',1},
                {'e', 1},
                {'o',1 }
                }
            );
        }

        [Test]
        [TestCase(TestName = "Add Item")]
        public void Test6()
        {
            var shopping = new ShoppingCart();
            shopping.AddItem("apples", 1.2m);
            shopping.AddItem("oranges", 1.80m);

            shopping.CalculatTotalPrice().Should().Be(3m);
        }

        [Test]
        [TestCase(TestName = " Apply Discount")]
        public void Test7()
        {
            var shopping = new ShoppingCart();
            shopping.AddItem("apples", 100.0m);
            // shopping.AddItem("oranges", 1.80m);

            shopping.ApplyDiscount(0.2m, "apples");
            shopping.CalculatTotalPrice().Should().Be(80m);

        }

        [Test]
        [TestCase(TestName = " Empty List")]

        public void Test8()
        {
            var shopping = new ShoppingCart();

            shopping.CalculatTotalPrice().Should().Be(0m);
        }

        [Test]
        [TestCase(TestName = "Exceeds MAX VALUE")]

        public void Test9()
        {
            var shopping = new ShoppingCart();
            string itemName = "ExpensiveItem";
            decimal price = decimal.MaxValue;

            Assert.Throws<OverflowException>(() => shopping.AddItem(itemName, price + 2));
        }

        [Test]
        [TestCase(TestName = "Negative Price")]

        public void Test10()
        {
            var shopping = new ShoppingCart();
            string itemName = "ExpensiveItem";
            decimal price = -1.00m;



            Assert.Throws<ArgumentOutOfRangeException>(() => shopping.AddItem(itemName, price));

        }

        [Test]
        [TestCase(TestName = "Manipulate warehouse locs")]
        public void Test11()
        {
            var warehouse = new WarehouseInventory();

            warehouse.AddLocationToWarehouse("loc1");

                //Check if warehouse locs update
            //Assert.Equals(warehouse.WarehouseLocations.Count, 1);
            warehouse.WarehouseLocations.Count().Should().Be(1);

            warehouse.EmptyWarehouse();
            warehouse.WarehouseLocations.Count().Should().Be(0);
        }
    }
}