using MathLogic;

namespace MatchLogicTests
{
    [TestClass]
    public class RekenenTest
    {
        [TestMethod]
        public void som_test()
        {
            Rekenen calc = new Rekenen();
            int a = 5;
            int b = 1;
            int result = 0;
            int expectedResult = 6;
            result = calc.som(a, b);

            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void delen_doorNul_Throw_exeption()
        {
            Rekenen calc = new Rekenen();
            int a = 5;
            int b = 0;

            Exception result = new Exception();

            Assert.ThrowsException <ArgumentException>(() => calc.delen(a, b), "Delen door nul moet fout geven");
        }

        [TestMethod]
        public void delen_test()
        {
            // ARRANGE
            int a = 10;
            int b = 2;
            int result = 0;
            int expectedResult = 5;
            Rekenen calc = new Rekenen();
            // ACT
            result = calc.delen(a, b);
            //ASSERT 
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void delen_test_met_fout()
        {
            // ARRANGE
            int a = 5;
            int b = 2;
            double result = 0;
            double expectedResult = 2.5;
            Rekenen calc = new Rekenen();
            // ACT
            result = calc.delen(a, b);
            //ASSERT 
            Assert.AreEqual(expectedResult, result);
        }


    }
}