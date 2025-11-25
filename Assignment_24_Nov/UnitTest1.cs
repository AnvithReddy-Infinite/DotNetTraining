using static Assignment_24_Nov.Assignment;
using NUnit.Framework;


namespace Assignment_24_Nov
{
    //Exercise-1
    public class Tests
    {
        public class CalculatorTests
        {
            [Test]
            public void Square_ShouldReturnCorrectSum()
            {
                Calculator calc = new Calculator();
                int result = calc.Square(2);
                Assert.That(result, Is.EqualTo(4));
            }
        }
    }
    //Exercise-2
    public class StringHelperTests
    {
        [Test]
        public void ToUpper_ShouldReturnCorrectData()
        {
            StringHelper helper = new StringHelper();
            string result = helper.ToUpper("hello");

            Assert.That(result.Length, Is.EqualTo(5));
            Assert.That(result[0], Is.EqualTo('H'));
            Assert.That(result, Is.EqualTo("HELLO"));
        }
    }
    //Exercise-3
    public class MathHelperTests
    {
        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-1, 5, -5)]
        [TestCase(0, 19, 0)]
        public void Multiply_TestCases(int a, int b, int expected)
        {
            MathHelper helper = new MathHelper();
            int result = helper.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    //Exercise-4
    public class StudentServiceTests
    {
        [Test]
        public void ValidateAge_NegativeAge_ShouldThrow()
        {
            StudentService service = new StudentService();
            Assert.Throws<ArgumentException>(() => service.ValidateAge(-1));
        }
    }
    //Exercise-5
    public class SetupTeardownTests
    {
        [SetUp]
        public void Before()
        {
            Console.WriteLine("Before Test");
        }
        [TearDown]
        public void After()
        {
            Console.WriteLine("After Test");
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
    //Exercise-6
    public class NumberServiceTests
    {
        [Test]
        public void EvenNumbers_Test()
        {
            NumberService service = new NumberService();
            var list = service.GetEvenNumbers();
            Assert.That(list.Count, Is.EqualTo(4));
            Assert.That(list, Is.Ordered);
            Assert.That(list, Has.All.Matches<int>(x => x % 2 == 0));
        }
    }
    //Exercise-7
    public class StringConstraintTests
    {
        [Test]
        public void Test_String_Constraints()
        {
            string str = "NUnitFrameWork";
            Assert.That(str, Does.StartWith("NUnit"));
            Assert.That(str, Does.EndWith("Work"));
            Assert.That(str, Does.Contain("Frame"));
            Assert.That(str.Length, Is.EqualTo(14));
        }
    }
    //Exercise-8
    public class MarkServiceTests
    {
        [Test]
        public async Task GetMarksAsync_ShouldReturn90()
        {
            MarkService service = new MarkService();
            int result = await service.GetMarksAsync();
            Assert.That(result, Is.EqualTo(90));
        }
    }
    //Exercise-9
    public class MarksSourceTests
    {
        [Test]
        [TestCaseSource(typeof(MarksSource), nameof(MarksSource.Marks))]
        public void Marks_ShouldBeGreaterThan40(int mark)
        {
            Assert.That(mark, Is.GreaterThan(40));
        }
    }
    ////////////////////////////
    ///

    // Bank Account Tests




}