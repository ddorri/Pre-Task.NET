using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pre_Task;

namespace Pre_TaskTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Euclid_2parametrs()
        {
            //arrange
            int x1 = 12;
            int x2 = 30;
            int expected = 6;
            double leadTime;


            //act
            GCD_Program gcd_program = new GCD_Program();
            int actual = gcd_program.Euclid(x1, x2, out leadTime); 

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Euclid_3parametrs()
        {
            //arrange
            int x1 = 12;
            int x2 = 30;
            int x3 = 60;
            int expected = 6;


            //act
            GCD_Program gcd_program = new GCD_Program();
            int actual = gcd_program.Euclid(x1, x2, x3);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Euclid_4parametrs()
        {
            //arrange
            int x1 = 12;
            int x2 = 30;
            int x3 = 60;
            int x4 = 6;
            int expected = 6;


            //act
            GCD_Program gcd_program = new GCD_Program();
            int actual = gcd_program.Euclid(x1, x2, x3, x4);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Euclid_5parametrs()
        {
            //arrange
            int x1 = 12;
            int x2 = 30;
            int x3 = 60;
            int x4 = 122;
            int x5 = 22;
            int expected = 2;


            //act
            GCD_Program gcd_program = new GCD_Program();
            int actual = gcd_program.Euclid(x1, x2, x3, x4, x5);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stein_2parametrs()
        {
            //arrange
            int x1 = 12;
            int x2 = 36;
            int expected = 12;
            double leadTime;

            //act
            GCD_Program gcd_program = new GCD_Program();
            int actual = gcd_program.Euclid(x1, x2,out leadTime);

            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}
