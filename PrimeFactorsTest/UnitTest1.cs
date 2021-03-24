using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module_2;

namespace PrimeFactorsTest
{
    [TestClass]
    public class UnitTest1
    {
        //Prime factors of 4 are: "2  2 "

        

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange - repeat all test scenarios
            int number = 4;

            //Act - call method
            string expected = "2 x 2";
            string res = Program.PrimeFactors(number);

            //Assert
            Assert.AreEqual(res, expected);



        }

        //Prime factors of 4 are: "2  2 "



        [TestMethod]
        public void TestMethod2()
        {
            //Arrange - repeat all test scenarios
            int number = 7;

            //Act - call method
            string expected = "7";
            string res = Program.PrimeFactors(number);

            //Assert
            Assert.AreEqual(res, expected);



        }

        //Prime factors of 4 are: "2  2 "



        [TestMethod]
        public void TestMethod3()
        {
            //Arrange - repeat all test scenarios
            int number = 30;

            //Act - call method
            string expected = "2 x 3 x 5";
            string res = Program.PrimeFactors(number);

            //Assert
            Assert.AreEqual(res, expected);



        }

        //Prime factors of 4 are: "2  2 "



        [TestMethod]
        public void TestMethod4()
        {
            //Arrange - repeat all test scenarios
            int number = 40;

            //Act - call method
            string expected = "2 x 2 x 2 x 5";
            string res = Program.PrimeFactors(number);

            //Assert
            Assert.AreEqual(res, expected);



        }

        //Prime factors of 4 are: "2  2 "



        [TestMethod]
        public void TestMethod5()
        {
            //Arrange - repeat all test scenarios
            int number = 50;

            //Act - call method
            string expected = "2 x 5 x 5";
            string res = Program.PrimeFactors(number);

            //Assert
            Assert.AreEqual(res, expected);



        }
    }
}
