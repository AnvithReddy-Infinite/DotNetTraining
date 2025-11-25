namespace InfiniteTest
{
    public class Tests
    {
        //Nunit test
        //this is where unit testing happens
        //what to test?
        //how to do unit testing steps are:
        [Test]
        //[TestCase(10,10,20)]//parameterized test
        //[TestCase(5, 7, 12)]
        //[TestCase(-10, 10, 0)]
        //[TestCase(-5, 1, -4)]
        [TestCaseSource(nameof(MyCombination))]
        public void Test1(int a, int b, int c)
        {//how  to test add method?
            //1)step-1 Arrange
            //keepimg obj and required parameters ready
            //what ever its requires to test Add keep all ready.
            MyMath ob = new MyMath();
            //int a = 5;
            //int b = 10;


            //2)step-2:Act
            //we will execute add method and retrive the result
            int result = ob.Add(a, b);


            //3)Assert
            //here unit testing happens
            //i am excepting output as 15(a=5,b=10)
            //whether program will return same output or not 
            //assert is a static class
            Assert.That(result, Is.EqualTo(c));//excepted and output


            //this test method is crated to test add method
        }
        private static object[] MyCombination =
            {
            new object[] { 1, 2, 3 },
            new object[] { 4, 5,9 },
            new object[] { 6, 7,13 },
            new object[] { 8, 9,17 }

        };

        [Test]
        public void Test2()
        {
            //thos test method is crated to test multiply method
            MyMath ob2 = new MyMath();
            int c = 5;
            int d = 10;
            int res = ob2.Multiply(c, d);
            Assert.That(res, Is.EqualTo(50));

        }
    }
}
