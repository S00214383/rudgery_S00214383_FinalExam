using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using rudgery_S00214383_FinalExam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //unit test
        [TestMethod]
        public void TestMethod1()
        {

            //ARRANGE
            RentalProperty h1 = new RentalProperty() { Location = "Sligo", Price = 1000 };
            decimal expectedResult = 100m;
            //ACT
            h1.IncreaseRent(0.1m);

            //ASSERT
            Assert.AreEqual(expectedResult, h1.Price);
        }
    }
}
