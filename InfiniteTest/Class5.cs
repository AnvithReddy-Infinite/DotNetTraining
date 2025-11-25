using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteTest
{
    internal class Class5
    {
        [Test]
        public void Test1()
        {
            //  RealClass r = new RealClass();

            FakeClass f = new FakeClass();
            Client ob = new Client(f);
            var res = ob.AddClient(10, 20);//

            Assert.That(res, Is.EqualTo("the sum is 30"));


        }

        [Test]
        public void Test2()
        {
            FakeCls f = new FakeCls();// which is using the list
            Client1 ob = new Client1(f);
            var res = ob.AddClient("u");//

            Assert.That(res.Count, Is.GreaterThan(0));


        }
        [Test]  // stub version of moq
        public void Test3()
        {
            // how to use mock framework
            // readymade way to work with sub and fake

            var m = new Mock<IMath>();
            m.Setup(c => c.Add(10, 20)).Returns("the sum is 30");// stub         


            Client ob = new Client(m.Object);
            var res = ob.AddClient(10, 20);//

            Assert.That(res, Is.EqualTo("the sum is 30"));

        }

        [Test]// stub version of moq with data type support
        public void Test4()
        {
            // how to use mock framework
            // readymade way to work with sub and fake

            var m = new Mock<IMath>();
            m.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns("the sum is 30");


            Client ob = new Client(m.Object);
            var res = ob.AddClient(10, 20);//

            Assert.That(res, Is.EqualTo("the sum is 30"));

        }


        [Test] // // stub version of moq with verify 
        public void Test6()
        {
            // how to use mock framework
            // readymade way to work with sub and fake

            var m = new Mock<IMath>();
            m.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns("the sum is 30");


            Client ob = new Client(m.Object);
            var res = ob.AddClient(50, 5);//

            Assert.That(res, Is.EqualTo("the sum is 30"));


            // did u call the add method with parameter or not 
            // did u called the add method atleast once
            // its cross checking if mock is done properly or not
            m.Verify(x => x.Add(50, 5), Times.Once);


        }
        [Test]  // fake verion of MOQ
        public void Test5()
        {
            // how to use mock framework
            // readymade way to work with sub and fake

            var m = new Mock<DbInter>();
            m.Setup(c => c.GetData(It.IsAny<string>())).Returns((string d) => {
                List<string> st = new List<string>()
         {
             "India","canada","uk","us"
         };
                return st.Where(c => c.Contains(d)).ToList();

            });


            // "the sum is 30");
            //  m.Setup(c => c.multi(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);//fake


            Client1 ob = new Client1(m.Object);
            var res = ob.AddClient("u");//

            Assert.That(res.Count, Is.GreaterThan(0));

        }

    }
}
